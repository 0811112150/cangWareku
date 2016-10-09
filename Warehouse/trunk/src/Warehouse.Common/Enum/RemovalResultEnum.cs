using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.Common
{
	public enum RemovalResultEnum
	{
		参数错误,
		出库订单信息不存在,
		此二维码信息不存在,
		变速箱型号不一致,
		执行成功,
		保存失败,
		当前出库数量已经大于设置的出库数量,
		当前二维码已经出库,

	}
}
