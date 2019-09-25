using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IBLL;
using System.Web.Mvc;
using BLL;
using Model;
namespace WebApplication1.Controllers
{
    public class StudentController:Controller
    {
        IStudentBLL<StudentModel> isb = new StudentBLL();
        public ActionResult Index()
        {
            List<StudentModel> list = isb.StudentSelect();
            return View(list);
        }
    }
}