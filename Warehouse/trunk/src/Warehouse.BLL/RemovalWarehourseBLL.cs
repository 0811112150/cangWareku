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

namespace Warehouse.BLL
{
    public class RemovalWarehouseBLL
    {
        /// <summary>
        /// 保存出库订单表
        /// </summary>
        /// <param name="webOrder"></param>
        /// <returns></returns>
        public static CResult<int> SaveRemalWarehouseOrder(WebRemovalWarehouseOrder webOrder)
        {
            if (string.IsNullOrWhiteSpace(webOrder.SpeedChangeBoxName) || webOrder.Count <= 0)
            {
                return new CResult<int>(-1, ErrorCode.ParameterError);
            }
            using (var db = new WarehouseContext())
            {
                var order = new RemovalWarehouseOrder();
                order.DispathPlace = webOrder.DispathPlace;
                order.DispathTime = DateTime.Now;
                order.SpeedChangeBoxName = webOrder.SpeedChangeBoxName;
                order.Staff = webOrder.Staff;
                order.StateID = (int)RecordState.Show;
                order.PlanCount = webOrder.PlanCount;

                RepositoryIoc.GetRemovalWarehouseOrderRepository(db).Insert(order);
                if (db.SaveChanges() > 0)
                {
                    return new CResult<int>(order.OrderID);
                }
                else
                {
                    return new CResult<int>(-1, ErrorCode.SaveDbChangesFailed);
                }
            }
        }

        /// <summary>
        /// 保存出库记录表
        /// </summary>
        /// <param name="currentArrayCount"></param>
        /// <param name="twoDimensionCode"></param>
        /// <param name="orderID"></param>
        /// <param name="speedChangeBoxID"></param>
        /// <param name="planTotoalCount"></param>
        /// <param name="totalCount"></param>
        /// <param name="isForceRemoval"></param>
        /// <returns></returns>
        public static RemovalResultEnum SaveRemalWarehouseInfo(out List<WebPutInWarehouseRecord> barCodeList, out int currentArrayCount, string twoDimensionCode, int orderID, int speedChangeBoxID, int planTotoalCount, int totalCount, bool isForceRemoval = false)
        {
            currentArrayCount = 0;
            barCodeList = new List<WebPutInWarehouseRecord>();
            if (string.IsNullOrWhiteSpace(twoDimensionCode))
            {
                return RemovalResultEnum.参数错误;
            }
            using (var db = new WarehouseContext())
            {
                var twoDimensionCodeList = RepositoryIoc.GetTwoDimensioncodeRepository(db).FirstOrDefault(r => r.TwoDimensionCodeNum == twoDimensionCode && r.StateID == (int)RecordState.Show, string.Format("{0},{1}", CommonHelper.GetPropName<TwoDimensioncode>(r => r.WarehouseMs), CommonHelper.GetPropName<TwoDimensioncode>(r => r.SpeedChangeBoxType)));
                if (twoDimensionCodeList == null)
                {
                    return RemovalResultEnum.此二维码信息不存在;
                }

                if (twoDimensionCodeList.SpeedChangeBoxType.SpeedChangeBoxTypeID != speedChangeBoxID)
                {
                    return RemovalResultEnum.变速箱型号不一致;
                }

                var warehouseList = twoDimensionCodeList.WarehouseMs;
                var removalWarehouseRepository = RepositoryIoc.GetRemovalWarehourseRecordRepository(db);
                var order = RepositoryIoc.GetRemovalWarehouseOrderRepository(db).FirstOrDefault(r => r.OrderID == orderID);
                if (order == null)
                {
                    return RemovalResultEnum.出库订单信息不存在;
                }

                currentArrayCount = warehouseList.Count();

                foreach (var item in warehouseList)
                {
                    var removalWarehouse = new RemovalWarehouseRecord();
                    if (removalWarehouse.StateID == (int)RecordState.Delete)
                    {
                        return RemovalResultEnum.当前二维码已经出库;
                    }

                    removalWarehouse.StateID = (int)RecordState.Show;
                    removalWarehouse.WarehouseID = item.WarehouseID;
                    removalWarehouse.RemovalWarehouseTime = DateTime.Now;
                    removalWarehouse.OrderID = order.OrderID;
                    removalWarehouseRepository.Insert(removalWarehouse);
                    removalWarehouse.RemovalWarehouseTime = DateTime.Now;
                    item.StateID = (int)RecordState.Delete;

                    barCodeList.Add(new WebPutInWarehouseRecord()
                    {
                        BarCode = item.BarCode,
                        Place = item.Place,
                        PutInUserName = item.PutInUserName,
                        PutInTime = item.WarehouseTime,
                    });
                }

                if (!isForceRemoval)
                {
                    if (currentArrayCount + totalCount > planTotoalCount)
                    {
                        return RemovalResultEnum.当前出库数量已经大于设置的出库数量;
                    }
                }

                twoDimensionCodeList.StateID = (int)RecordState.Delete;
                if (db.SaveChanges() > 0)
                {
                    return RemovalResultEnum.执行成功;
                }
                barCodeList.Clear();
                return RemovalResultEnum.保存失败;
            }
        }

        public CResult<string> TwoDimensionCodeByBarCode(string barCode)
        {
            barCode = barCode.Trim();
            if (string.IsNullOrWhiteSpace(barCode))
            {
                return new CResult<string>(string.Empty, ErrorCode.ParameterError);
            }
            using (var db = new WarehouseContext())
            {
                var warehouse = RepositoryIoc.GetWarehouseMRepository(db).FirstOrDefault(r => r.BarCode == barCode && r.StateID == (int)RecordState.Show, CommonHelper.GetPropName<WarehouseM>(r => r.TwoDimensioncode));
                if (warehouse == null)
                {
                    return new CResult<string>(string.Empty, ErrorCode.BarCodeNotExist);
                }
                var twoDimensioncode = warehouse.TwoDimensioncode;
                return new CResult<string>(twoDimensioncode.TwoDimensionCodeNum);
            }

        }

        public CResult<string> TwoDimensionCodeByBarID(int barCodeID)
        {
            using (var db = new WarehouseContext())
            {
                var warehouse = RepositoryIoc.GetWarehouseMRepository(db).FirstOrDefault(r => r.WarehouseID == barCodeID && r.StateID == (int)RecordState.Show, CommonHelper.GetPropName<WarehouseM>(r => r.TwoDimensioncode));
                if (warehouse == null)
                {
                    return new CResult<string>(string.Empty, ErrorCode.BarCodeNotExist);
                }
                var twoDimensioncode = warehouse.TwoDimensioncode;
                var codeType = warehouse.TwoDimensioncode.SpeedChangeBoxType.SpeedChangeBoxName;
                return new CResult<string>(codeType + "~" + twoDimensioncode.TwoDimensionCodeNum);
            }

        }

        /// <summary>
        /// 获得出库信息表
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="searchName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderEnum"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public CResult<List<WebRemovalWarehouse>> GetRemovalWarehouseInfoList(out int totalCount, string searchName = "", int pageIndex = -1, int pageSize = 100, RemovalListOrderEnum orderEnum = RemovalListOrderEnum.DispathTime, bool ascending = false)
        {
            totalCount = 0;
            using (var db = new WarehouseContext())
            {
                Expression<Func<RemovalWarehouseRecord, bool>> filter = r => r.StateID == (int)RecordState.Show;
                if (!string.IsNullOrWhiteSpace(searchName))
                {
                    filter = filter.And(r => r.RemovalWarehouseOrder.Staff.Contains(searchName)
                        || r.WarehouseM.BarCode.Contains(searchName)
                        || r.RemovalWarehouseOrder.DispathPlace.Contains(searchName));
                }
                var removalWareIQueary = RepositoryIoc.GetRemovalWarehourseRecordRepository(db).LazyGet(out totalCount, filter, CommonHelper.GetPropName<RemovalWarehouseRecord>(r => r.WarehouseM));
                switch (orderEnum)
                {
                    case RemovalListOrderEnum.BarCode:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.WarehouseM.BarCode);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.WarehouseM.BarCode);
                        }
                        break;
                    case RemovalListOrderEnum.DispathPlace:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.RemovalWarehouseOrder.DispathPlace);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.RemovalWarehouseOrder.DispathPlace);
                        }
                        break;
                    case RemovalListOrderEnum.DispathTime:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.RemovalWarehouseTime);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.RemovalWarehouseTime);
                        }
                        break;
                    case RemovalListOrderEnum.Staff:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.RemovalWarehouseOrder.Staff);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.RemovalWarehouseOrder.Staff);
                        }
                        break;
                }
                removalWareIQueary = removalWareIQueary.Page(out totalCount, null, true, pageIndex, pageSize);
                var result = (from f in removalWareIQueary
                              select new WebRemovalWarehouse()
                              {
                                  BarCode = f.WarehouseM.BarCode,
                                  RemovalWarehouseTime = f.RemovalWarehouseTime,
                                  SpeedChangeBoxName = f.WarehouseM.TwoDimensioncode.SpeedChangeBoxType.SpeedChangeBoxName,
                                  Staff = f.RemovalWarehouseOrder.Staff,
                                  DispathPlace = f.RemovalWarehouseOrder.DispathPlace,
                              }).ToList();
                return new CResult<List<WebRemovalWarehouse>>(result);
            }
        }

        /// <summary>
        /// 获得出库订单表
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="searchName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderEnum"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public CResult<List<WebRemovalWarehouseOrder>> GetRemovalWarehouseOrderList(out int totalCount, string searchName = "", int pageIndex = -1, int pageSize = 100,
            WarehouseOrderOrderEnum orderEnum = WarehouseOrderOrderEnum.DispathTime, bool ascending = false, DateTime? searchStarttime = null,
            DateTime? searchEndTime = null)
        {
            totalCount = 0;
            using (var db = new WarehouseContext())
            {
                Expression<Func<RemovalWarehouseOrder, bool>> filter = r => r.StateID == (int)RecordState.Show
                    && r.RemovalWarehouseRecords.Count > 0;
                if (!string.IsNullOrWhiteSpace(searchName))
                {
                    filter = filter.And(r => r.Staff.Contains(searchName)
                        || r.SpeedChangeBoxName.Contains(searchName)
                        || r.DispathPlace.Contains(searchName));
                }
                if (searchStarttime.HasValue)
                {
                    filter = filter.And(r => r.DispathTime >= searchStarttime);
                }
                if (searchEndTime.HasValue)
                {
                    searchEndTime = searchEndTime.Value.AddDays(1);
                    filter = filter.And(r => r.DispathTime <= searchEndTime);
                }

                var removalWareOrderIQueary = RepositoryIoc.GetRemovalWarehouseOrderRepository(db).LazyGet(out totalCount, filter);
                switch (orderEnum)
                {
                    case WarehouseOrderOrderEnum.Count:
                        if (ascending)
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderBy(r => r.RemovalWarehouseRecords.Count());
                        }
                        else
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderByDescending(r => r.RemovalWarehouseRecords.Count());
                        }
                        break;
                    case WarehouseOrderOrderEnum.DispathTime:
                        if (ascending)
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderBy(r => r.DispathTime);
                        }
                        else
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderByDescending(r => r.DispathTime);
                        }
                        break;
                    case WarehouseOrderOrderEnum.DispathPlace:
                        if (ascending)
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderBy(r => r.DispathPlace);
                        }
                        else
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderByDescending(r => r.DispathPlace);
                        }
                        break;
                    case WarehouseOrderOrderEnum.Staff:
                        if (ascending)
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderBy(r => r.Staff);
                        }
                        else
                        {
                            removalWareOrderIQueary = removalWareOrderIQueary.OrderByDescending(r => r.Staff);
                        }
                        break;
                }
                removalWareOrderIQueary = removalWareOrderIQueary.Page(out totalCount, null, true, pageIndex, pageSize);
                var result = (from f in removalWareOrderIQueary
                              select new WebRemovalWarehouseOrder()
                              {
                                  OrderID = f.OrderID,
                                  SpeedChangeBoxName = f.SpeedChangeBoxName,
                                  Count = f.RemovalWarehouseRecords.Count(),
                                  Staff = f.Staff,
                                  DispathPlace = f.DispathPlace,
                                  DispathTime = f.DispathTime,
                                  PlanCount = f.PlanCount,
                              }).ToList();
                return new CResult<List<WebRemovalWarehouseOrder>>(result);
            }
        }

        /// <summary>
        /// 根据订单ID获得出库记录表
        /// </summary>
        /// <param name="orderID"></param>
        /// <param name="totalCount"></param>
        /// <param name="searchName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="orderEnum"></param>
        /// <param name="ascending"></param>
        /// <returns></returns>
        public CResult<List<WebRemovalWarehouse>> GetRemovalWarehouseInfoListByOrderID(int orderID, out int totalCount, string searchName = "", int pageIndex = -1, int pageSize = 100, RemovalListOrderEnum orderEnum = RemovalListOrderEnum.DispathTime, bool ascending = false)
        {
            totalCount = 0;
            using (var db = new WarehouseContext())
            {
                Expression<Func<RemovalWarehouseRecord, bool>> filter = r => r.StateID == (int)RecordState.Show;
                filter = filter.And(r => r.OrderID == orderID);
                if (!string.IsNullOrWhiteSpace(searchName))
                {
                    filter = filter.And(r => r.RemovalWarehouseOrder.Staff.Contains(searchName)
                        || r.WarehouseM.BarCode.Contains(searchName)
                        || r.RemovalWarehouseOrder.DispathPlace.Contains(searchName));
                }
                var removalWareIQueary = RepositoryIoc.GetRemovalWarehourseRecordRepository(db).LazyGet(out totalCount, filter, CommonHelper.GetPropName<RemovalWarehouseRecord>(r => r.WarehouseM));
                switch (orderEnum)
                {
                    case RemovalListOrderEnum.BarCode:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.WarehouseM.BarCode);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.WarehouseM.BarCode);
                        }
                        break;
                    case RemovalListOrderEnum.DispathPlace:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.RemovalWarehouseOrder.DispathPlace);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.RemovalWarehouseOrder.DispathPlace);
                        }
                        break;
                    case RemovalListOrderEnum.DispathTime:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.RemovalWarehouseTime);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.RemovalWarehouseTime);
                        }
                        break;
                    case RemovalListOrderEnum.Staff:
                        if (ascending)
                        {
                            removalWareIQueary = removalWareIQueary.OrderBy(r => r.RemovalWarehouseOrder.Staff);
                        }
                        else
                        {
                            removalWareIQueary = removalWareIQueary.OrderByDescending(r => r.RemovalWarehouseOrder.Staff);
                        }
                        break;
                }
                removalWareIQueary = removalWareIQueary.Page(out totalCount, null, true, pageIndex, pageSize);
                var result = (from f in removalWareIQueary
                              select new WebRemovalWarehouse()
                              {
                                  BarCode = f.WarehouseM.BarCode,
                                  RemovalWarehouseTime = f.RemovalWarehouseTime,
                                  SpeedChangeBoxName = f.WarehouseM.TwoDimensioncode.SpeedChangeBoxType.SpeedChangeBoxName,
                                  Staff = f.RemovalWarehouseOrder.Staff,
                                  DispathPlace = f.RemovalWarehouseOrder.DispathPlace,
                              }).ToList();
                return new CResult<List<WebRemovalWarehouse>>(result);
            }
        }
    }
}
