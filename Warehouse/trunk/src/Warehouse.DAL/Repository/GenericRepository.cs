using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using Warehouse.Common.Extension;

namespace Warehouse.DAL
{
	public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected WarehouseContext _context;
		protected DbSet<TEntity> _dbSet;

		public GenericRepository(WarehouseContext context)
		{
			this._context = context;
			this._dbSet = context.Set<TEntity>();
		}

		#region 查询数据
		/// <summary>
		/// 获取IEnumerable TEntity 数据
		/// </summary>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="orderBy">排序lambda表达式</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <returns></returns>
		public virtual IList<TEntity> Get(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = null)
		{
			return LazyGet(filter, orderBy, includeProperties).ToList();
		}

		/// <summary>
		/// 获取IEnumerable TEntity 数据（延时查询）
		/// </summary>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="orderBy">排序lambda表达式</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <returns></returns>
		public IQueryable<TEntity> LazyGet(
			Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = null)
		{
			IQueryable<TEntity> query = IncludeProperties(includeProperties, _dbSet);

			if (filter != null) {
				query = query.Where(filter);
			}

			if (orderBy != null) {
				return orderBy(query);
			} else {
				return query;
			}
		}

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
		public virtual IList<TEntity> Get(
			out int totalRecord,
			Expression<Func<TEntity, bool>> filter = null,
			string includeProperties = null,
			string orderbyFieldName = null,
			bool ascending = true,
			int pageIndex = 1, int pageSize = -1)
		{
			return LazyGet(out totalRecord, filter, includeProperties, orderbyFieldName, ascending, pageIndex, pageSize).ToList();
		}

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
		/// <returns></returns>
		public IQueryable<TEntity> LazyGet(
			out int totalRecord,
			Expression<Func<TEntity, bool>> filter = null,
			string includeProperties = null,
			string orderbyFieldName = null,
			bool ascending = true,
			int pageIndex = 1, int pageSize = -1,
			bool addOrderByEmpty = true)
		{
			IQueryable<TEntity> query = IncludeProperties(includeProperties, _dbSet);

			if (filter != null) {
				query = query.Where(filter);
			}

			return query.Page(out totalRecord, orderbyFieldName, ascending, pageIndex, pageSize, addOrderByEmpty);
		}

		/// <summary>
		/// 据条件查询满足条件的第一个或默认实体
		/// </summary>
		/// <param name="filter">过滤表达式树</param>
		/// <param name="includeProperties">各导航属性之间使用逗号(,)隔开</param>
		/// <returns></returns>
		public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "")
		{
			IQueryable<TEntity> query = IncludeProperties(includeProperties, _dbSet);

			if (filter != null) {
				return query.FirstOrDefault(filter);
			} else {
				return query.FirstOrDefault();
			}
		}

		/// <summary>
		/// 根据条件查询一列数据
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="selector"></param>
		/// <param name="filter"></param>
		/// <param name="isDistinct">是否去掉重复项</param>
		/// <returns></returns>
		public IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, bool>> filter = null, bool isDistinct = true)
		{
			var query = _dbSet.AsQueryable();
			if (filter != null) {
				query = query.Where(filter);
			}

			var result = query.Select(selector);
			if (isDistinct) {
				result = result.Distinct();
			}
			return result.ToList();
		}
		#endregion

		#region Count
		/// <summary>
		/// 根据条件查询数据Count
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		public virtual int Count(Expression<Func<TEntity, bool>> filter = null)
		{
			if (filter == null) {
				return _dbSet.Count();
			}
			return _dbSet.Count(filter);
		}
		#endregion

		#region 求和
		/// <summary>
		/// 根据条件，求某一列的和
		/// </summary>
		/// <param name="sum"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		public double? Sum(Expression<Func<TEntity, double?>> sum, Expression<Func<TEntity, bool>> filter = null)
		{
			var query = _dbSet.AsQueryable();
			if (filter != null) {
				query = query.Where(filter);
			}
			var result = query.Sum(sum);
			return result;
		}

		public decimal? Sum(Expression<Func<TEntity, decimal?>> sum, Expression<Func<TEntity, bool>> filter = null)
		{
			var query = _dbSet.AsQueryable();
			if (filter != null) {
				query = query.Where(filter);
			}
			var result = query.Sum(sum);
			return result;
		}
		#endregion

		#region Max
		public int? Max(Expression<Func<TEntity, int?>> max, Expression<Func<TEntity, bool>> filter = null)
		{
			var query = _dbSet.AsQueryable();
			if (filter != null) {
				query = query.Where(filter);
			}
			var result = query.Max(max);
			return result;
		}
		#endregion

		#region 插入数据
		/// <summary>
		/// 插入一条数据
		/// </summary>
		/// <param name="entity">数据实体</param>
		public virtual void Insert(TEntity entity)
		{
			_dbSet.Add(entity);
		}

		/// <summary>
		/// 插入多条数据
		/// </summary>
		/// <param name="entityList"></param>
		public virtual void Insert(IEnumerable<TEntity> entityList)
		{
			foreach (var item in entityList) {
				_dbSet.Add(item);
			}
		}
		#endregion

		#region 删除数据
		/// <summary>
		/// 根据主键删除一条数据
		/// </summary>
		/// <param name="id">主键</param>
		public virtual void Delete(object id)
		{
			TEntity entityToDelete = _dbSet.Find(id);
			Delete(entityToDelete);
		}

		/// <summary>
		/// 删除该实体
		/// </summary>
		/// <param name="entityToDelete">实体</param>
		public virtual void Delete(TEntity entityToDelete)
		{
			if (entityToDelete != null) {
				if (_context.Entry(entityToDelete).State == EntityState.Detached) {
					_dbSet.Attach(entityToDelete);
				}
				_dbSet.Remove(entityToDelete);
			}
		}

		/// <summary>
		/// 删除实体List
		/// </summary>
		/// <param name="entityList"></param>
		public virtual void Delete(IEnumerable<TEntity> entityList)
		{
			foreach (var item in entityList) {
				Delete(item);
			}
		}
		#endregion

		#region 更新数据
		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name="entityToUpdate">要更新的数据实体</param>
		/// <param name="setEntityState">是否设置该实体的更新状态，如果设置则生成的SQL语句会更新所有属性</param>
		/// <returns>该实体更新状态</returns>
		public virtual EntityState Update(TEntity entityToUpdate, bool setEntityState = false)
		{
			if (setEntityState) {
				_context.Entry(entityToUpdate).State = EntityState.Modified;
			}

			return _context.Entry(entityToUpdate).State;
		}
		#endregion

		#region 执行一条SQL语句
		/// <summary>
		/// 执行一条SQL语句
		/// </summary>
		/// <param name="query">SQL格式化字符串</param>
		/// <param name="parameters">如果有参数，则传参数列表</param>
		/// <returns></returns>
		public virtual IEnumerable<TEntity> GetWithRawSql(string query, params object[] parameters)
		{
			return _dbSet.SqlQuery(query, parameters).ToList();
		}
		#endregion

		#region 私有方法
		private static DbQuery<TEntity> IncludeProperties(string includeProperties, DbSet<TEntity> dbSet)
		{
			DbQuery<TEntity> query = dbSet;

			if (!string.IsNullOrEmpty(includeProperties)) {
				var properties = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (var includeProperty in properties) {
					query = query.Include(includeProperty);
				}
			}

			return query;
		}
		#endregion

		#region 暂时不用的方法
		///// <summary>
		///// 根据主键查询实体
		///// </summary>
		///// <param name="id">主键参数（例如Guid）</param>
		///// <returns></returns>
		//public virtual TEntity GetByID(object id)
		//{
		//    return _dbSet.Find(id);
		//}
		#endregion

		#region Dispose
		private bool disposed = false;

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed) {
				if (disposing && _context != null) {
					_context.Dispose();
				}
			}
			this.disposed = true;
		}

		~GenericRepository()
		{
			Dispose(false);
		}

		#endregion

		#region SaveChanges
		public bool SaveUpdateChanges(EntityState entityState)
		{
			var result = false;
			if (entityState != EntityState.Unchanged) {
				result = SaveChanges() > 0;
			} else {
				result = true;
			}
			return result;
		}

		public int SaveChanges()
		{
			if (_context != null) {
				return _context.SaveChanges();
			}
			return 0;
		}
		#endregion
	}
}
