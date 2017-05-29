using System.Linq;
using System.Web.Mvc;
using MVC_Print_PDF.Models;
using Rotativa;

namespace MVC_Print_PDF.Controllers
{
    public class EmployeeInfoController : Controller
    {
        AppEntities ctx;
        public EmployeeInfoController()
        {
            ctx = new Models.AppEntities(); 
        }
        public ActionResult Index()
        {
            var emps = ctx.EmployeeInfoes.ToList();
            return View(emps);
        }
        public ActionResult PrintAllReport()
        {
            var report = new ActionAsPdf("Index");
            return report;
        }
        public ActionResult IndexById(int id)
        {
            var emp = ctx.EmployeeInfoes.Where(e=>e.EmpNo==id).First();
            return View(emp);
        }
        public ActionResult PrintSalarySlip(int id)
        {
            var report = new ActionAsPdf("IndexById",new  {id=id});
            return report;
        }
       }
}