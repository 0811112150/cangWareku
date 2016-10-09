using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Linq.Expressions;

namespace Warehouse.Common.Extension
{
	public static class QueryableExtension
	{
		#region 动态排序
		/// <summary>
		/// 动态排序
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="propertyName">属性名称，支持根据导航属性实体内属性排序(只支持一级)</param>
		/// <param name="ascending">是否为升序</param>
		/// <returns></returns>
		public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string propertyName, bool ascending) where T : class
		{
			string[] propertyPath = propertyName.Split(new char[] { '.' });
			if (propertyPath.Length <= 1) {
				Type type = typeof(T);

				PropertyInfo property = type.GetProperty(propertyName);
				if (property == null)
					throw new ArgumentException("propertyName", "Not Exist");

				ParameterExpression param = Expression.Parameter(type, "p");
				Expression propertyAccessExpression = Expression.MakeMemberAccess(param, property);
				LambdaExpression orderByExpression = Expression.Lambda(propertyAccessExpression, param);

				string methodName = ascending ? "OrderBy" : "OrderByDescending";

				MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExpression));

				return source.Provider.CreateQuery<T>(resultExp);
			} else {
				Type type = typeof(T);
				PropertyInfo include = type.GetProperty(propertyPath[0]);

				if (include == null)
					throw new ArgumentException("propertyIncludeName", "Not Exist");

				Type typeInclude = include.PropertyType;
				PropertyInfo propertyInclude = typeInclude.GetProperty(propertyPath[1]);

				if (typeInclude == null)
					throw new ArgumentException("propertyIncludesName", "Not Exist");

				ParameterExpression param = Expression.Parameter(type);

				Expression propertyAccessExpression = Expression.MakeMemberAccess(param, include);
				Expression propertyAccessExpressionInclude = Expression.MakeMemberAccess(propertyAccessExpression, propertyInclude);

				LambdaExpression orderByExpression = Expression.Lambda(propertyAccessExpressionInclude, param);

				string methodName = ascending ? "OrderBy" : "OrderByDescending";

				MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { type, propertyInclude.PropertyType }, source.Expression, Expression.Quote(orderByExpression));

				return source.Provider.CreateQuery<T>(resultExp);
			}

		}
		#endregion

		#region 分页
		/// <summary>
		/// 分页
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="totalRecord"></param>
		/// <param name="orderbyFieldName">属性名称，支持根据导航属性实体内属性排序(只支持一级)。注意：一次查询只能有一个OrderBy，如有多个OrderBy，最后的OrderBy生效</param>
		/// <param name="ascending">是否为升序</param>
		/// <param name="pageIndex"></param>
		/// <param name="pageSize"></param>
		/// <param name="addOrderByEmpty">orderbyFieldName为NULL时，是否添加OrderBy。若在Page外进行排序则orderByFieldName必须为NULL，且addOrderByEmpty必须为false</param>
		/// <returns></returns>
		public static IQueryable<T> Page<T>(this IQueryable<T> source, out int totalRecord, string orderbyFieldName = null,
			bool ascending = true, int pageIndex = 1, int pageSize = -1, bool addOrderByEmpty = true) where T : class
		{
			totalRecord = source.Count();

			if (!string.IsNullOrWhiteSpace(orderbyFieldName)) {
				source = source.OrderBy(orderbyFieldName, ascending);
			} else if (addOrderByEmpty) {
				source = source.OrderBy(p => "");
			}

			if (pageSize > 0) {
				//页码小于1，直接返回Count为零的List
				if (pageIndex < 1) {
					return new List<T>().AsQueryable();
				}
				//页码大于最大页数，直接返回Count为零的List
				if ((pageIndex - 1) * pageSize >= totalRecord) {
					return new List<T>().AsQueryable();
				}

				return source.Skip((pageIndex - 1) * pageSize).Take(pageSize);
			} else {
				return source;
			}
		}
		#endregion
	}
}
