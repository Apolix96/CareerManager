using SoriNotSori.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;
using SoriNotSori.DAL;


namespace SoriNotSori.Controllers
{

    public class HomeController : Controller
    {
        CareerContext context = new CareerContext();
        Data CaierData = new Data();
        DatabaseSet CaierSet = new DatabaseSet();
        DataFind CaierFind = new DataFind();
        DataChanges CaierChange = new DataChanges();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Career =CaierData.DataUse();
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CareerModels cuir)
        {
            CaierSet.DataSet(cuir);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? ID)
        {
            if (ID == null)
            {
                return HttpNotFound();
            }
            return View(CaierFind.ID(ID));
            
       
        }
        [HttpPost]
        public ActionResult Edit(CareerModels career)
        {
            CaierChange.Edit(career);
           
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Del(int? ID)
        {
            CaierChange.Delete(ID);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Del (int ID)
        {
            
            if (CaierFind.ID(ID) == null)
            {
                return HttpNotFound();
            }
            return View(CaierFind.ID(ID));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int ID)
        {
            
            if (CaierFind.ID(ID) == null)
            {
                return HttpNotFound();
            }
            CaierChange.DeleteConfirmed(ID);
            return RedirectToAction("Index");
        }





    }
}
