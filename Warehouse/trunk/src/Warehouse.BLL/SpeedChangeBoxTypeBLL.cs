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

namespace Warehouse.BLL
{
	public class SpeedChangeBoxTypeBLL
	{
		public CResult<bool> AddSpeedChangeBoxType(string speedChangeBoxName)
		{
			if (string.IsNullOrWhiteSpace(speedChangeBoxName)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {
				var repository = RepositoryIoc.GetSpeedChangeBoxTypeRepository(db);
				if (repository.Count(r => r.SpeedChangeBoxName == speedChangeBoxName) > 0) {
					return new CResult<bool>(false, ErrorCode.SpeedChangeBoxHasExist);
				}

				var speedChangeBox = new SpeedChangeBoxType();
				speedChangeBox.SpeedChangeBoxName = speedChangeBoxName;
				repository.Insert(speedChangeBox);
				if (db.SaveChanges() > 0) {
					return new CResult<bool>(true);
				} else {
					return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
				}
			}
		}

		public CResult<List<WebSpeedChangeBoxType>> GetSpeedChangeBoxList()
		{
			using (var db = new WarehouseContext()) {
				var speedChangeList = RepositoryIoc.GetSpeedChangeBoxTypeRepository(db).Get();
				var result = new List<WebSpeedChangeBoxType>();
				foreach (var item in speedChangeList) {
					result.Add(new WebSpeedChangeBoxType() {
						SpeedChangeBoxTypeID = item.SpeedChangeBoxTypeID,
						SpeedChangeBoxName = item.SpeedChangeBoxName,
					});
				}
				return new CResult<List<WebSpeedChangeBoxType>>(result);
			}
		}

		public CResult<bool> DelSpeedChangeBox(int speedChangeID)
		{
			if (speedChangeID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {
				var repository = RepositoryIoc.GetSpeedChangeBoxTypeRepository(db);

				var speedChange = repository.FirstOrDefault(r => r.SpeedChangeBoxTypeID == speedChangeID, CommonHelper.GetPropName<SpeedChangeBoxType>(r => r.TwoDimensioncodes));
				if (speedChange.TwoDimensioncodes.Count() > 0) {
					return new CResult<bool>(false, ErrorCode.SpeedChangeHasTwoDimensioncodes);
				}
				repository.Delete(speedChange);
				if (db.SaveChanges() > 0) {
					return new CResult<bool>(true);
				} else {
					return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
				}

			}
		}
	}
}
