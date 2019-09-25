using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using System.Linq.Expressions;
using System.Data.Entity;
namespace DAO
{
    public class DaoBase<T> where T :class
    {
        MyDbContext db = new MyDbContext();
        public int Insert(T t)
        {
            db.Set<T>().Add(t);
            return db.SaveChanges();
        }
        public int Update(T t)
        {
            db.Set<T>().Attach(t);
            db.Entry<T>(t).State = EntityState.Modified;
            return db.SaveChanges();
        }
        public int Delete(T t)
        {
            db.Set<T>().Attach(t);
            db.Entry<T>(t).State = EntityState.Deleted;
            return db.SaveChanges();
        }
        public List<T> Select()
        {
            return db.Set<T>()
                .AsNoTracking()
                .Select(e => e)
                .ToList();
        }
        public List<T> SelectWhere(Expression<Func<T, bool>> where)
        {
            return db.Set<T>()
                .AsNoTracking()
                .Where(where)
                .Select(e => e)
                .ToList();
        }
        public List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where,int currentPage,int PageSize,out int rows)
        {
            var result = db.Set<T>()
                .AsNoTracking()
                .OrderBy(order);
            rows = result.Count();
            var data = result.Where(where)
                .Skip((currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();
            return data;
        }
    }
}
