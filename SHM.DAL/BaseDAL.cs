using SHM.IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SHM.DAL
{
    public abstract class BaseDAL<T> : IBaseDAL<T> where T : class,new()
    {
        //EF上下文
        DbContext db = new DBContextFactory().GetDbContext();

        #region 新增
        public int Add(T model)
        {
            db.Set<T>().Add(model);
            return db.SaveChanges();
        }

        #endregion

        #region 根据Id删除
        public int Del(T model)
        {
            //把实体标记为onchanged
            db.Set<T>().Attach(model);
            //把实体标记为delete
            db.Set<T>().Remove(model);
            return db.SaveChanges();
        }
        #endregion

        #region 根据条件删除
        public int DelBy(Expression<Func<T, bool>> delWhere)
        {
            List<T> listDels = db.Set<T>().Where(delWhere).ToList();
            listDels.ForEach(d =>
            {
                db.Set<T>().Attach(d);
                db.Set<T>().Remove(d);
            });
            return db.SaveChanges();
        }
        #endregion

        #region 修改
        public int Modify(T model, params string[] proNames)
        {
            DbEntityEntry entry = db.Entry<T>(model);
            entry.State = EntityState.Unchanged;
            foreach (string proName in proNames)
            {
                entry.Property(proName).IsModified = true;
            }
            return db.SaveChanges();
        }
        #endregion

        #region 批量修改
        public int ModifyBy(T model, Expression<Func<T, bool>> whereLambda, params string[] proNames)
        {
            //查询要修改的 数据（实体集合）
            List<T> listModifes = db.Set<T>().Where(whereLambda).ToList();
            //获取实体类型对象
            Type t = typeof(T);
            //获取实体公共属性集合（反射）
            List<PropertyInfo> proInfos = t.GetProperties(BindingFlags.Instance | BindingFlags.Public).ToList();
            //创建实体属性的字典集合
            Dictionary<string, PropertyInfo> dicPros = new Dictionary<string, PropertyInfo>();
            proInfos.ForEach(p =>
            {
                if (proNames.Contains(p.Name))
                {
                    dicPros.Add(p.Name, p);
                }
            });

            foreach (string proName in proNames)
            {
                if (dicPros.ContainsKey(proName))
                {
                    PropertyInfo proInfo = dicPros[proName];
                    object newValue = proInfo.GetValue(model, null);
                    foreach (T modify in listModifes)
                    {
                        proInfo.SetValue(modify, newValue, null);
                    }
                }
            }
            return db.SaveChanges();
        }
        #endregion

        #region 根据条件查询
        public List<T> GetListBy(Expression<Func<T, bool>> whereLambda)
        {
            return db.Set<T>().Where(whereLambda).ToList();
        }
        #endregion

        #region 根据条件排序和查询
        /// <summary>
        /// 根据条件排序和查询
        /// </summary>
        /// <typeparam name="TKey">排序字段类型</typeparam>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        public List<T> GetListBy<TKey>(Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda)
        {
            return db.Set<T>().Where(whereLambda).OrderBy(orderLambda).ToList();
        }
        #endregion

        #region 分页查询
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TKey">排序字段类型</typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageize">页容量</param>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        public List<T> GetPageList<TKey>(int pageIndex, int pageize, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda)
        {
            return db.Set<T>().Where(whereLambda).OrderBy(orderLambda).Skip((pageIndex - 1) * pageize).Take(pageize).ToList();
        }
        #endregion

        #region 分页查询输出总行数
        /// <summary>
        /// 分页查询输出总行数
        /// </summary>
        /// <typeparam name="TKey">排序字段类型</typeparam>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageize">页容量</param>
        /// <param name="rowCount">总行数</param>
        /// <param name="isAsc">是否升序</param>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <returns></returns>
        public List<T> GetPageList<TKey>(int pageIndex, int pageize, ref int rowCount, Expression<Func<T, bool>> whereLambda, Expression<Func<T, TKey>> orderLambda, bool isAsc = true)
        {
            rowCount = db.Set<T>().Where(whereLambda).Count();
            if (isAsc)
            {
                //升序
                return db.Set<T>().Where(whereLambda).OrderBy(orderLambda).Skip((pageIndex - 1) * pageize).Take(pageize).ToList();
            }
            else
            {
                //降序
                return db.Set<T>().Where(whereLambda).OrderByDescending(orderLambda).Skip((pageIndex - 1) * pageize).Take(pageize).ToList();
            }
        }
        #endregion
    }
}
