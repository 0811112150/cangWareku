using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data;

namespace Warehouse.DAL
{
	public interface IRepository<TEntity> where TEntity : class
	{
		#region 查询数据
		/// <summary>
		/// 获取IEnumerable TEntity 数据
		/// </summary>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="orderBy">排序lambda表达式</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <returns></returns>
		IList<TEntity> Get(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = null);

		/// <summary>
		/// 获取IEnumerable TEntity 数据（延时查询）
		/// </summary>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="orderBy">排序lambda表达式</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <returns></returns>
		IQueryable<TEntity> LazyGet(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = null);

		/// <summary>
		/// 获取IEnumerable TEntity 数据，分页查询
		/// </summary>
		/// <param name="totalRecord">总记录数</param>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <param name="orderbyFieldName">排序字段</param>
		/// <param name="ascending">是否正序排序</param>
		/// <param name="pageIndex">页码</param>
		/// <param name="pageSize">一页显示的数量,数值小于1则返回全部</param>
		/// <returns></returns>
		IList<TEntity> Get(
			out int totalRecord,
			Expression<Func<TEntity, bool>> filter = null,
			string includeProperties = null,
			string orderbyFieldName = null,
			bool ascending = true,
			int pageIndex = 1, int pageSize = -1);

		/// <summary>
		/// 获取IEnumerable TEntity 数据，分页查询（延时查询）
		/// </summary>
		/// <param name="totalRecord">总记录数</param>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <param name="orderbyFieldName">排序字段</param>
		/// <param name="ascending">是否正序排序</param>
		/// <param name="pageIndex">页码</param>
		/// <param name="pageSize">一页显示的数量,数值小于1则返回全部</param>
		/// <param name="addOrderByEmpty">orderbyFieldName为NULL时，是否添加OrderBy。若在Page外进行排序则orderByFieldName必须为NULL，且addOrderByEmpty必须为false</param>
		/// <returns></returns>
		IQueryable<TEntity> LazyGet(
			out int totalRecord,
			Expression<Func<TEntity, bool>> filter = null,
			string includeProperties = null,
			string orderbyFieldName = null,
			bool ascending = true,
			int pageIndex = 1, int pageSize = -1,
			bool addOrderByEmpty = true);

		/// <summary>
		/// 据条件查询满足条件的第一个或默认实体
		/// </summary>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <returns></returns>
		TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "");

		/// <summary>
		/// 根据条件查询一列数据
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="selector"></param>
		/// <param name="filter"></param>
		/// <param name="isDistinct">是否去掉重复项</param>
		/// <returns></returns>
		IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> filter = null, bool isDistinct = true);
		#endregion

		#region Count
		/// <summary>
		/// 根据条件查询数据Count
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		int Count(Expression<Func<TEntity, bool>> filter = null);
		#endregion

		#region 求和
		/// <summary>
		/// 根据条件，求某一列的和
		/// </summary>
		/// <param name="sum"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		double? Sum(Expression<Func<TEntity, double?>> sum, Expression<Func<TEntity, bool>> filter = null);

		decimal? Sum(Expression<Func<TEntity, decimal?>> sum, Expression<Func<TEntity, bool>> filter = null);
		#endregion

		#region 求最大值
		int? Max(Expression<Func<TEntity, int?>> max, Expression<Func<TEntity, bool>> filter = null);
		#endregion

		#region 插入数据
		/// <summary>
		/// 插入一条数据
		/// </summary>
		/// <param name="entity">数据实体</param>
		void Insert(TEntity entity);

		/// <summary>
		/// 插入多条数据
		/// </summary>
		/// <param name="entityList"></param>
		void Insert(IEnumerable<TEntity> entityList);
		#endregion

		#region 删除数据
		/// <summary>
		/// 根据主键删除一条数据
		/// </summary>
		/// <param name="id">主键</param>
		void Delete(object id);

		/// <summary>
		/// 删除该实体
		/// </summary>
		/// <param name="entityToDelete">实体</param>
		void Delete(TEntity entityToDelete);

		/// <summary>
		/// 删除实体List
		/// </summary>
		/// <param name="entityList"></param>
		void Delete(IEnumerable<TEntity> entityList);
		#endregion

		#region 更新数据
		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name="entityToUpdate">要更新的数据实体</param>
		/// <param name="setEntityState">是否设置该实体的更新状态，如果设置则生成的SQL语句会更新所有属性</param>
		/// <returns>该实体更新状态</returns>
		EntityState Update(TEntity entityToUpdate, bool setEntityState = false);
		#endregion

		#region 执行一条SQL语句
		/// <summary>
		/// 执行一条SQL语句
		/// </summary>
		/// <param name="query">SQL格式化字符串</param>
		/// <param name="parameters">如果有参数，则传参数列表</param>
		/// <returns></returns>
		IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters);
		#endregion

		#region SaveChanges
		bool SaveUpdateChanges(EntityState entityState);
		int SaveChanges();
		#endregion

	}
}
