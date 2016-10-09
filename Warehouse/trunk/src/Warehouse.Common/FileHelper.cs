using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;

namespace Warehouse.Common
{
	public class FileHelper
	{
		#region 拷贝文件
		public static bool Copy(string sourceFileName, string destFileName, bool overwrite = false)
		{
			if (string.IsNullOrWhiteSpace(sourceFileName) ||
				string.IsNullOrWhiteSpace(destFileName)) {
				return false;
			}

			sourceFileName = Path.Combine(SystemInfo.SystemBaseDir, sourceFileName);
			destFileName = Path.Combine(SystemInfo.SystemBaseDir, destFileName);
			var destDirectory = Path.GetDirectoryName(destFileName);
			if (!Directory.Exists(destDirectory)) {
				Directory.CreateDirectory(destDirectory);
			}
			File.Copy(sourceFileName, destFileName, overwrite);

			if (File.Exists(destFileName)) {
				return true;
			}
			return false;
		}
		#endregion

		#region 删除多个文件
		public static void DelFile(IEnumerable<string> relativeFullPathList)
		{
			foreach (var item in relativeFullPathList) {
				DelFile(item);
			}
		}
		#endregion

		#region 删除单个文件
		public static void DelFile(string relativeFullPath)
		{
			if (string.IsNullOrWhiteSpace(relativeFullPath)) {
				return;
			}

			try {
				var absoluteFullPath = Path.Combine(SystemInfo.SystemBaseDir, relativeFullPath);
				if (File.Exists(absoluteFullPath)) {
					File.Delete(absoluteFullPath);
				}
			} catch (Exception ex) {
				//Logger.Write(ex);
			}
		}
		#endregion

		#region 删除文件所在目录
		/// <summary>
		/// 删除文件所在目录
		/// </summary>
		/// <param name="relativeFullPath"></param>
		public static void DelFileDirectory(string relativeFullPath)
		{
			if (string.IsNullOrWhiteSpace(relativeFullPath)) {
				return;
			}

			try {
				string oldFilePath = Path.GetDirectoryName(Path.Combine(SystemInfo.SystemBaseDir, relativeFullPath));
				if (Directory.Exists(oldFilePath)) {
					Directory.Delete(oldFilePath, true);
				}
			} catch (Exception ex) {
				//Logger.Write(ex);
			}
		}

		public static void DelFileDirectory(IEnumerable<string> relativeFullPathList)
		{
			foreach (var item in relativeFullPathList) {
				DelFileDirectory(item);
			}
		}
		#endregion

		#region 创建目录
		public static bool CreateDirectory(string relativeDestDirectory)
		{
			if (string.IsNullOrWhiteSpace(relativeDestDirectory)) {
				return false;
			}

			try {
				relativeDestDirectory = Path.Combine(SystemInfo.SystemBaseDir, relativeDestDirectory);
				var fullDestDirectory = Path.GetDirectoryName(relativeDestDirectory);
				if (!Directory.Exists(fullDestDirectory)) {
					Directory.CreateDirectory(fullDestDirectory);
				}
				return true;
			} catch (Exception) {
				return false;
			}
		}
		#endregion

		public static string MakeSureFileExist(string releativeFilePath)
		{
			var fullPath = Path.Combine(SystemInfo.SystemBaseDir, releativeFilePath);
			if (!File.Exists(fullPath)) {
				try {
					if (!Directory.Exists(fullPath)) {
						Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
					}
					File.Create(releativeFilePath).Close();
				} catch (System.Exception ex) {
					LogHelper.Error("创建文件失败"+ex);
				}
			}
			return fullPath;
		}
	}
}
