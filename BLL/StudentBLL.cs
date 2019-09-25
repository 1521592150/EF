using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAO;
using DAO;
namespace BLL
{
    public class StudentBLL:IStudentBLL<StudentModel>
    {
        IStudentDAO<StudentModel> isd=new StudentDAO();
        public int StudentAdd(StudentModel t)
        {
            return isd.StudentAdd(t);
        }

        public int StudentUpd(StudentModel t)
        {
            return isd.StudentUpd(t);
        }

        public int StudentDel(StudentModel t)
        {
            return isd.StudentDel(t);
        }

        public List<StudentModel> StudentSelect()
        {
            return isd.StudentSelect();
        }

        public List<StudentModel> StudentSelectWhere(System.Linq.Expressions.Expression<Func<StudentModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> FenYe<K>(System.Linq.Expressions.Expression<Func<StudentModel, K>> order, System.Linq.Expressions.Expression<Func<StudentModel, bool>> where, int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }
    }
}
