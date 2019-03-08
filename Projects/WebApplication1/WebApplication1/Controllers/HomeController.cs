using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.IO;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        marksheetEntities1 db = new marksheetEntities1();
        student st = new student();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult checkRoll(int roll)
        {
            return Json(!db.students.Any(x => x.rollno == roll), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Index(student pr)
        {
            pr.total = 300;
            pr.obtain = pr.math + pr.urdu + pr.english;
            pr.percentage = (pr.obtain * 100) / pr.total;
            if (pr.math < 33 || pr.urdu < 33 || pr.english < 33)
            {
                pr.remarks = "Fail";
                pr.grade = "F";
            }
            else
            {
                if (pr.percentage > 90)
                {
                    pr.remarks = "Marvellous";
                    pr.grade = "A1";
                }
                else if (pr.percentage >= 80 && pr.percentage < 90)
                {
                    pr.remarks = "Excellent";
                    pr.grade = "A";
                }
                else if (pr.percentage >= 70 && pr.percentage < 80)
                {
                    pr.remarks = "Supper";
                    pr.grade = "B+";
                }
                else if (pr.percentage >= 60 && pr.percentage < 70)
                {
                    pr.remarks = "Good";
                    pr.grade = "B";
                }
                else if (pr.percentage >= 50 && pr.percentage < 60)
                {
                    pr.remarks = "Fair";
                    pr.grade = "C";
                }
                else
                {
                    pr.remarks = "Fail";
                    pr.grade = "F";
                }
            }
            db.students.Add(pr);
            db.SaveChanges();
            ViewBag.msg = "Data is inserted";
            return View();
        }
    }
}