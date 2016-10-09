using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.Common
{
	public enum AlarmReasonEnum
	{
		入库时型号不一致,
		出库时型号不一致,
		出库时数量不一致,
		出库时条形码重复扫描,
	}
}
