using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EF;
using System.Linq.Expressions;
namespace DAO
{
    public class StudentDAO : DaoBase<Student>, IStudentDAO<StudentModel>
    {

        public int StudentAdd(StudentModel t)
        {
            Student st = new Student()
            {
                SName = t.SName
            };
            return Insert(st);
        }


        public int StudentUpd(StudentModel t)
        {
            Student st = new Student()
            {
                SID = t.SID,
                SName = t.SName
            };
            return Update(st);
        }

        public int StudentDel(StudentModel t)
        {
            Student st = new Student()
            {
                SID = t.SID,
            };
            return Delete(st);
        }

        public List<StudentModel> StudentSelect()
        {
            List<Student> list = Select();
            List<StudentModel> list2 = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel sm = new StudentModel()
                {
                    SID = item.SID,
                    SName = item.SName
                };
                list2.Add(sm);
            }
            return list2;
        }

        public List<StudentModel> StudentSelectWhere(Expression<Func<StudentModel, bool>> where)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> FenYe<K>(Expression<Func<StudentModel, K>> order, Expression<Func<StudentModel, bool>> where, int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }
    }
}
