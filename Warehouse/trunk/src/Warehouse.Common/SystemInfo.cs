using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.Common
{
	public class SystemInfo
	{
		public static string SystemBaseDir { get { return System.Windows.Forms.Application.StartupPath; } }

		public static string LogFolderPath { get { return "SystemFile/LogFolder/"; } }

		/// <summary>
		/// SystemFile/LogFolder/RemenberUserNames.txt
		/// </summary>
		public static string RemenberUserNamesFile { get { return string.Format("{0}RemenberUserNames.txt", LogFolderPath); } }

		/// <summary>
		/// 入库设置的保存文件
		/// </summary>
		public static string PutinConfigFile { get { return string.Format("{0}PutinConfig.txt", LogFolderPath); } }

		/// <summary>
		/// 出库设置的保存文件
		/// </summary>
		public static string RemovalConfigFile { get { return string.Format("{0}RemovalConfig.txt", LogFolderPath); } }

		/// <summary>
		/// SystemFile/LogFolder/RemenberUserNames.txt
		/// </summary>
		public static string DispatchPlaceFile { get { return string.Format("{0}DispatchPlace.txt", LogFolderPath); } }


	}
}
