using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Warehouse.Common;
using Warehouse.DAL;
using Warehouse.DomainModel;
using Warehouse.ViewModel;
using Warehouse.Common.CResult;
using System.Linq.Expressions;
using Warehouse.Common.Extension;
using System.Data;

namespace Warehouse.BLL
{
    public class PutInWarehouseBLL
    {
        /// <summary>
        /// 保存入库信息
        /// </summary>
        /// <param name="barCodeList">条形码</param>
        /// <param name="twoDimensioncodeNum">二维码型号</param>
        /// <param name="speedChangeTypeID">产品类型ID</param>
        /// <param name="putInUserName">UserName</param>
        /// <param name="place">地点</param>
        /// <returns></returns>
        public static CResult<bool> SavePutInWarehouseInfo(List<string> barCodeList, string twoDimensioncodeNum, int speedChangeTypeID, string putInUserName, string place)
        {
            if (barCodeList == null)
            {
                return new CResult<bool>(false, ErrorCode.ParameterError);
            }

            if (string.IsNullOrWhiteSpace(twoDimensioncodeNum))
            {
                return new CResult<bool>(false, ErrorCode.ParameterError);
            }

            using (var db = new WarehouseContext())
            {
                var twoDimensioncodeRepository = RepositoryIoc.GetTwoDimensioncodeRepository(db);
                var twoDimensionCode = twoDimensioncodeRepository.FirstOrDefault(r => r.TwoDimensionCodeNum == twoDimensioncodeNum);
                if (twoDimensionCode == null)
                {
                    twoDimensionCode = new TwoDimensioncode();
                    twoDimensionCode.TwoDimensionCodeNum = twoDimensioncodeNum;
                    twoDimensionCode.Count = barCodeList.Count();
                    twoDimensionCode.StateID = (int)RecordState.Show;
                    twoDimensionCode.SpeedChangeBoxTypeID = speedChangeTypeID;
                    twoDimensioncodeRepository.Insert(twoDimensionCode);
                }
                else
                {
                    return new CResult<bool>(false, ErrorCode.TwoDimensioncodeHasExist);
                }
                if (db.SaveChanges() <= 0)
                {
                    return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
                }
                var warehouseRepository = RepositoryIoc.GetWarehouseMRepository(db);
                foreach (var item in barCodeList)
                {
                    var warehouse = warehouseRepository.FirstOrDefault(r => r.BarCode == item);
                    if (warehouse == null)
                    {
                        warehouse = new WarehouseM();
                        warehouse.BarCode = item;
                        warehouse.StateID = (int)RecordState.Show;
                        warehouse.WarehouseTime = DateTime.Now;
                        warehouse.PutInUserName = putInUserName;
                        warehouse.Place = place;
                        warehouse.TwoDimensioncodeID = twoDimensionCode.TwoDimensioncodeID;

                        var putInWare = new PutInWarehouseRecord();
                        putInWare.PutInTime = DateTime.Now;
                        putInWare.Place = place;
                        putInWare.PutInUserName = putInUserName;
                        putInWare.StateID = (int)RecordState.Show;
                        putInWare.WarehouseID = warehouse.WarehouseID;
                        warehouse.PutInWarehouseRecords.Add(putInWare);

                        warehouseRepository.Insert(warehouse);
                    }
                    else
                    {
                        if (warehouse.StateID == (int)RecordState.Show)
                        {
                            return new CResult<bool>(false, ErrorCode.PutInInfoHasExist);
                        }
                        else
                        {
                            warehouse.WarehouseTime = DateTime.Now;
                            warehouse.PutInUserName = putInUserName;
                            warehouse.Place = place;
                            warehouse.StateID = (int)RecordState.Show;
                            warehouse.TwoDimensioncodeID = twoDimensionCode.TwoDimensioncodeID;
                            var putInWare = new PutInWarehouseRecord();
                            putInWare.PutInTime = DateTime.Now;
                            putInWare.Place = place;
                            putInWare.PutInUserName = putInUserName;
                            putInWare.StateID = (int)RecordState.Show;
                            putInWare.WarehouseID = warehouse.WarehouseID;
                            warehouse.PutInWarehouseRecords.Add(putInWare);
                        }
                    }
                }
                if (db.SaveChanges() > 0)
                {
                    return new CResult<bool>(true);
                }
                else
                {
                    twoDimensioncodeRepository.Delete(twoDimensionCode);
                    db.SaveChanges();
                    return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
                }
            }
        }

        /// <summary>
        /// 判断当前的扫描的产品是第一次入库还是重复入库
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public static PutInResultEnum IsCurrentPutInInfoRight(string barCode)
        {
            using (var db = new WarehouseContext())
            {
                var warehouse = RepositoryIoc.GetWarehouseMRepository(db).FirstOrDefault(r => r.BarCode == barCode);
                if (warehouse == null)
                {
                    return PutInResultEnum.第一次入库;
                }
                if (warehouse.StateID == (int)RecordState.Delete)
                {
                    return PutInResultEnum.重复入库;
                }
                else
                {
                    return PutInResultEnum.仓库已经存在此货物;
                }
            }
        }

        /// <summary>
        /// 获得入库信息表
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="searchName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderEnum"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public CResult<List<WebPutInWarehouseRecord>> GetPutInWarehouseInfo(out int totalCount, string searchName = "", int pageIndex = 1, int pageSize = 100, PutInListOrderEnum orderEnum = PutInListOrderEnum.PutInTime, bool ascending = false, DateTime? searchStartTime = null,
            DateTime? searchEndTime = null)
        {
            totalCount = 0;
            using (var db = new WarehouseContext())
            {
                Expression<Func<PutInWarehouseRecord, bool>> filter = r => r.StateID == (int)RecordState.Show;
                if (!string.IsNullOrWhiteSpace(searchName))
                {
                    filter = filter.And(r => r.PutInUserName.Contains(searchName)
                        || r.WarehouseM.BarCode.Contains(searchName)
                        || r.Place.Contains(searchName));
                }
                if (searchStartTime.HasValue)
                {
                    filter = filter.And(r => r.PutInTime >= searchStartTime.Value);
                }
                if (searchEndTime.HasValue)
                {
                    searchEndTime = searchEndTime.Value.AddDays(1);
                    filter = filter.And(r => r.PutInTime <= searchEndTime);
                }

                var putInWareIQueary = RepositoryIoc.GetPutInWarehouseRecordRepository(db).LazyGet(out totalCount, filter, CommonHelper.GetPropName<PutInWarehouseRecord>(r => r.WarehouseM));
                switch (orderEnum)
                {
                    case PutInListOrderEnum.BarCode:
                        if (ascending)
                        {
                            putInWareIQueary = putInWareIQueary.OrderBy(r => r.WarehouseM.BarCode);
                        }
                        else
                        {
                            putInWareIQueary = putInWareIQueary.OrderByDescending(r => r.WarehouseM.BarCode);
                        }
                        break;
                    case PutInListOrderEnum.Place:
                        if (ascending)
                        {
                            putInWareIQueary = putInWareIQueary.OrderBy(r => r.Place);
                        }
                        else
                        {
                            putInWareIQueary = putInWareIQueary.OrderByDescending(r => r.Place);
                        }
                        break;
                    case PutInListOrderEnum.PutInTime:
                        if (ascending)
                        {
                            putInWareIQueary = putInWareIQueary.OrderBy(r => r.PutInTime);
                        }
                        else
                        {
                            putInWareIQueary = putInWareIQueary.OrderByDescending(r => r.PutInTime);
                        }
                        break;
                    case PutInListOrderEnum.PutInUserName:
                        if (ascending)
                        {
                            putInWareIQueary = putInWareIQueary.OrderBy(r => r.PutInUserName);
                        }
                        else
                        {
                            putInWareIQueary = putInWareIQueary.OrderByDescending(r => r.PutInUserName);
                        }
                        break;
                }
                putInWareIQueary = putInWareIQueary.Page(out totalCount, null, true, pageIndex, pageSize);
                var result = (from f in putInWareIQueary
                              select new WebPutInWarehouseRecord()
                              {
                                  BarCode = f.WarehouseM.BarCode,
                                  PutInTime = f.PutInTime,
                                  PutInUserName = f.PutInUserName,
                                  Place = f.Place,
                              }).ToList();
                return new CResult<List<WebPutInWarehouseRecord>>(result);
            }
        }

        /// <summary>
        /// 保存二维码信息
        /// </summary>
        /// <param name="twoDimensioncodeNum"></param>
        /// <param name="warehouseIDs"></param>
        /// <param name="speedChangeTypeID"></param>
        /// <returns></returns>
        public static CResult<bool> SaveTwoDimensioncode(string twoDimensioncodeNum, IEnumerable<int> warehouseIDs, int speedChangeTypeID)
        {
            if (string.IsNullOrWhiteSpace(twoDimensioncodeNum))
            {
                return new CResult<bool>(false, ErrorCode.ParameterError);
            }

            using (var db = new WarehouseContext())
            {
                var twoDimensioncodeRepository = RepositoryIoc.GetTwoDimensioncodeRepository(db);
                var twoDimensionCode = twoDimensioncodeRepository.FirstOrDefault(r => r.TwoDimensionCodeNum == twoDimensioncodeNum);
                if (twoDimensionCode == null)
                {
                    twoDimensionCode = new TwoDimensioncode();
                    twoDimensionCode.TwoDimensionCodeNum = twoDimensioncodeNum;
                    twoDimensionCode.Count = warehouseIDs.Count();
                    twoDimensionCode.SpeedChangeBoxTypeID = speedChangeTypeID;
                }
                else
                {
                    return new CResult<bool>(false, ErrorCode.TwoDimensioncodeHasExist);
                }
                if (db.SaveChanges() > 0)
                {
                    var warehouseRepository = RepositoryIoc.GetWarehouseMRepository(db);
                    var warehouseList = warehouseRepository.Get(r => warehouseIDs.Contains(r.WarehouseID));
                    foreach (var item in warehouseList)
                    {
                        item.TwoDimensioncodeID = twoDimensionCode.TwoDimensioncodeID;
                    }
                    return new CResult<bool>(db.SaveChanges() > 0);
                }
                else
                {
                    return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
                }
            }
        }

        /// <summary>
        /// 获得变速箱型号
        /// </summary>
        /// <returns></returns>
        public CResult<List<WebSpeedChangeBoxType>> GetSpeedChangeBoxType()
        {
            using (var db = new WarehouseContext())
            {
                var speedChangeBox = RepositoryIoc.GetSpeedChangeBoxTypeRepository(db).Get();
                var result = new List<WebSpeedChangeBoxType>();
                foreach (var item in speedChangeBox)
                {
                    result.Add(new WebSpeedChangeBoxType()
                    {
                        SpeedChangeBoxTypeID = item.SpeedChangeBoxTypeID,
                        SpeedChangeBoxName = item.SpeedChangeBoxName,
                    });
                }

                result = result.OrderBy(t => t.SpeedChangeBoxName).ToList();
                return new CResult<List<WebSpeedChangeBoxType>>(result);
            }
        }

        /// <summary>
        /// 判断当前型号是否符合设置的型号
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="speedChangeTypeNum"></param>
        /// <returns></returns>
        public static bool IsSpeedChangeTypeNumRight(string barCode, string speedChangeTypeNum)
        {
            var typeNumLength = speedChangeTypeNum.Length;
            if (barCode.Length < typeNumLength)
            {
                return false;
            }
            if (barCode.Substring(0, typeNumLength) == speedChangeTypeNum)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获得库存信息
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="searchName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderEnum"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public CResult<List<WebPutInWarehouseRecord>> GetWarehouseInfoList(out int totalCount, string searchName = "", int pageIndex = 1, int pageSize = 100, PutInListOrderEnum orderEnum = PutInListOrderEnum.PutInTime, bool ascending = false, DateTime? searchStartTime = null,
            DateTime? searchEndTime = null)
        {
            totalCount = 0;
            using (var db = new WarehouseContext())
            {
                Expression<Func<WarehouseM, bool>> filter = r => r.StateID == (int)RecordState.Show;
                if (!string.IsNullOrWhiteSpace(searchName))
                {
                    filter = filter.And(r => r.PutInUserName.Contains(searchName)
                        || r.BarCode.Contains(searchName)
                        || r.Place.Contains(searchName));
                }
                if (searchStartTime.HasValue)
                {
                    filter = filter.And(r => r.WarehouseTime >= searchStartTime.Value);
                }
                if (searchEndTime.HasValue)
                {
                    searchEndTime = searchEndTime.Value.AddDays(1);
                    filter = filter.And(r => r.WarehouseTime <= searchEndTime);
                }

                var warehouseIQueary = RepositoryIoc.GetWarehouseMRepository(db).LazyGet(out totalCount, filter, CommonHelper.GetPropName<PutInWarehouseRecord>(r => r.WarehouseM));
                switch (orderEnum)
                {
                    case PutInListOrderEnum.BarCode:
                        if (ascending)
                        {
                            warehouseIQueary = warehouseIQueary.OrderBy(r => r.BarCode);
                        }
                        else
                        {
                            warehouseIQueary = warehouseIQueary.OrderByDescending(r => r.BarCode);
                        }
                        break;
                    case PutInListOrderEnum.Place:
                        if (ascending)
                        {
                            warehouseIQueary = warehouseIQueary.OrderBy(r => r.Place);
                        }
                        else
                        {
                            warehouseIQueary = warehouseIQueary.OrderByDescending(r => r.Place);
                        }
                        break;
                    case PutInListOrderEnum.PutInTime:
                        if (ascending)
                        {
                            warehouseIQueary = warehouseIQueary.OrderBy(r => r.WarehouseTime);
                        }
                        else
                        {
                            warehouseIQueary = warehouseIQueary.OrderByDescending(r => r.WarehouseTime);
                        }
                        break;
                    case PutInListOrderEnum.PutInUserName:
                        if (ascending)
                        {
                            warehouseIQueary = warehouseIQueary.OrderBy(r => r.PutInUserName);
                        }
                        else
                        {
                            warehouseIQueary = warehouseIQueary.OrderByDescending(r => r.PutInUserName);
                        }
                        break;
                }
                warehouseIQueary = warehouseIQueary.Page(out totalCount, null, true, pageIndex, pageSize);
                var result = (from f in warehouseIQueary
                              select new WebPutInWarehouseRecord()
                              {
                                  BarCode = f.BarCode,
                                  PutInTime = f.WarehouseTime,
                                  PutInUserName = f.PutInUserName,
                                  Place = f.Place,
                                  WarehouseID = f.WarehouseID,
                              }).ToList();
                return new CResult<List<WebPutInWarehouseRecord>>(result);
            }
        }
    }
}
