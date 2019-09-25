using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace IBLL
{
    public interface IBLL<T> where T:class
    {
        int StudentAdd(T t);
        int StudentUpd(T t);
        int StudentDel(T t);
        List<T> StudentSelect();
        List<T> StudentSelectWhere(Expression<Func<T, bool>> where);
        List<T> FenYe<K>(Expression<Func<T, K>> order, Expression<Func<T, bool>> where, int currentPage, int PageSize, out int rows);
    
    }
}
