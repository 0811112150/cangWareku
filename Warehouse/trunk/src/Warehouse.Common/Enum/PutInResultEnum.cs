using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.Common
{
	public enum PutInResultEnum
	{
		第一次入库,
		重复入库,
		仓库已经存在此货物,
	}
}
