using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.IO;

namespace Warehouse.Common
{
    public class CommonHelper
    {
        public static readonly Dictionary<string, string> FileMimeDic;

        #region 构造函数
        static CommonHelper()
        {
            FileMimeDic = new Dictionary<string, string>();
            FileMimeDic.Add(".pdf", "application/pdf");
            FileMimeDic.Add(".dwg", "application/x-autocad");
            FileMimeDic.Add(".dwf", "dwf drawing/x-dwf");
            FileMimeDic.Add(".zip", "application/zip");
        }
        #endregion

        #region 获得一个类中指定的属性的名称
        /// <summary>
        /// 获得一个类中指定的属性的名称
        /// </summary>
        /// <typeparam name="T">类</typeparam>
        /// <param name="expr">表达式</param>
        /// <returns>返回属性的名称</returns>
        public static string GetPropName<T>(Expression<Func<T, object>> expr)
        {
            switch (expr.Body.NodeType)
            {
                case ExpressionType.MemberAccess:
                    Regex regex = new Regex(@"^[^\.]+\.(?<value>.+$)");
                    var bodyStr = ((MemberExpression)expr.Body).ToString();
                    return regex.Match(bodyStr).Groups["value"].Value;
                case ExpressionType.Convert:
                    return ((MemberExpression)((UnaryExpression)expr.Body).Operand).Member.Name;
                default:
                    return null;
            }
        }
        #endregion

        #region 根据一个属性和要比较的值，返回一个比较的Expression
        /// <summary>
        /// 根据一个属性和要比较的值，返回一个比较的Expression
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propName"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetPropertyEqualsFunc<T>(string propName, int condition)
        {
            var para1 = Expression.Parameter(typeof(T), "x");
            var para2 = Expression.Constant(condition);
            var propExpression = Expression.Property(para1, propName);
            var equalExpression = Expression.Equal(propExpression, para2);
            return Expression.Lambda<Func<T, bool>>(equalExpression, para1);
            //return lambda.Compile();
        }
        #endregion

        #region GetFileContent
        public static byte[] GetFileContent(string path)
        {
            var appPath = AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(Path.Combine(appPath, path)))
            {
                //var memoryStream = new MemoryStream();
                using (var stream = new FileStream(Path.Combine(appPath, path), FileMode.Open, FileAccess.Read))
                {
                    byte[] bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, (int)stream.Length);
                    return bytes;
                }
            }
            return null;
        }
        #endregion

        #region GetMimeByFileExtensionOrDefault
        public static string GetMimeByFileExtensionOrDefault(string fileExtension, string defaultMime = "application")
        {
            fileExtension = fileExtension.ToLower();
            if (FileMimeDic.ContainsKey(fileExtension))
            {
                return FileMimeDic[fileExtension];
            }
            else
            {
                return defaultMime;
            }
        }
        #endregion

        #region 返回枚举上DescriptionAttribute内容列表
        /// <summary>
        /// 返回枚举上DescriptionAttribute内容列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<T, string> GetEnumAllDescription<T>() where T : struct
        {
            var result = new Dictionary<T, string>();
            var enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                return result;
            }

            var allFields = enumType.GetFields();
            foreach (var item in allFields)
            {
                var attributes = (DescriptionAttribute[])item.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Count() > 0)
                {
                    result.Add((T)Enum.Parse(enumType, item.Name), attributes[0].Description);
                }
            }
			
            return result;
        }
        #endregion
    }
}
