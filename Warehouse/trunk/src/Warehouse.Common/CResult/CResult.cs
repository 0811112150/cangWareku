﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.Common.CResult
{
	public class CResult<T>
	{
		public CResult(T data, int code = 0, string msg = "")
		{
			this.Data = data;
			this.Msg = msg;
			this.Code = code;
		}

        public CResult(T data, ErrorCode errorCode, params object[] arg0)
        {
            this.Data = data;
            this.Code = (int)errorCode;
            var msg = ErrorCodeExtension.GetErrorCodeDescription(errorCode).Description;
            if (arg0.Length == 0)
            {
                this.Msg = msg;
            }
            else
            {
                this.Msg = string.Format(msg, arg0);
            }
        }

		private string _msg = string.Empty;
		public int Code { get; set; }
		public string Msg { get { return _msg; } set { _msg = value; } }
		public T Data { get; private set; }
	}
}
