using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PiechartandBargraph.Controllers
{
    public class PiechartController : Controller
    {
        jayaEntities db= new jayaEntities();
        // GET: Piechart
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PieChart()
        {
            jayaEntities entities = new jayaEntities();
            return Json(entities.Countries.ToList(), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult CountryData()
     
        {
            List<object> data = new List<object>();
            List<string> lablesData = db.Countries.Select(a => a.CountryNAme).Distinct().ToList();
            data.Add(lablesData);
            List<string> Populationdata = db.Countries.Select(a => a.CountryPopulation).ToList();
            data.Add(Populationdata);
            return Json(data,JsonRequestBehavior.AllowGet);
           
        }
    }
}