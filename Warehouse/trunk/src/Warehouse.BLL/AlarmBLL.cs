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
using System.Web.Security;
using System.Data;
using System.Collections;

namespace Warehouse.BLL
{
	public class AlarmBLL
	{
		/// <summary>
		/// 添加报警
		/// </summary>
		/// <param name="webAlarm"></param>
		/// <returns></returns>
		public CResult<bool> AddAlarm(WebAlarm webAlarm)
		{
			using (var db = new WarehouseContext()) {
				var alarm = new Alarm();
				alarm.AlarmContent = webAlarm.AlarmContent;
				alarm.AlarmTime = DateTime.Now;
				alarm.AlarmTypeInt = webAlarm.AlarmTypeInt;
				alarm.Operator = webAlarm.Operator;
				RepositoryIoc.GetAlarmRepository(db).Insert(alarm);
				if (db.SaveChanges() > 0) {
					return new CResult<bool>(true);
				} else {
					return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
				}
			}
		}

		/// <summary>
		/// 获取报警记录
		/// </summary>
		/// <param name="totalCount">总的数量</param>
		/// <param name="searchName">查找字段</param>
		/// <param name="pageIndex">页码</param>
		/// <param name="pageSize">每一页显示多少条</param>
		/// <param name="orderEnum">排序枚举</param>
		/// <param name="ascending">标示正反排序的字段</param>
		/// <param name="searchStartTime">搜索开始时间</param>
		/// <param name="searchEndTime">搜索结束时间</param>
		/// <returns></returns>
		public CResult<List<WebAlarm>> GetAllAlarm(out int totalCount, string searchName = "", int pageIndex = 1, int pageSize = 100, AlarmOrderEnum orderEnum = AlarmOrderEnum.AlarmTime, bool ascending = false, DateTime? searchStartTime = null, DateTime? searchEndTime = null)
		{
			totalCount = 0;
			using (var db = new WarehouseContext()) {
				Expression<Func<Alarm, bool>> filter = r => true;
				if (searchStartTime.HasValue) {
					filter = filter.And(r => r.AlarmTime >= searchStartTime);
				}
				if (searchEndTime.HasValue) {
					var endTime = searchEndTime.Value.AddDays(1);
					filter = filter.And(r => r.AlarmTime < endTime);
				}

				var alarmIQuery = RepositoryIoc.GetAlarmRepository(db).Get(out totalCount, filter, null, orderEnum.ToString(), ascending, pageIndex, pageSize);
				var result = new List<WebAlarm>();
				foreach (var item in alarmIQuery) {
					result.Add(new WebAlarm() {
						AlarmTypeInt = item.AlarmTypeInt,
						AlarmContent = item.AlarmContent,
						AlarmTime = item.AlarmTime,
						Operator = item.Operator,
						AlarmTypeName = ((AlarmType)item.AlarmTypeInt).ToString(),
					});
				}
				return new CResult<List<WebAlarm>>(result);
			}

		}
	}
}
