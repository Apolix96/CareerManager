using SoriNotSori.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;

namespace SoriNotSori.Controllers
{

    public class HomeController : Controller
    {
        CareerContext context = new CareerContext();
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<CareerModels> Carer = context.Career;
            ViewBag.Career = Carer;
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
            context.Career.Add(cuir);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public string Craft(CareerModels career)
        {
            career.ID = career.ID;
            career.Name = career.Name;
            career.NameSub = career.NameSub;
            context.Career.Add(career);
            context.SaveChanges();
            return "Измененено "+career.Name+" "+career.NameSub+" Конец";
               
        }

        
        [HttpGet]
        public ActionResult Edit(int? ID)
        {
            if (ID == null)
            {
                return HttpNotFound();
            }
            CareerModels career = context.Career.Find(ID);
            if (career!= null)
            {
                return View(career);
            }
            return HttpNotFound();
        }
        [HttpPost]
        public ActionResult Edit(CareerModels career)
        {
            context.Entry(career).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Del(int? ID)
        {
            
                CareerModels Caier = context.Career.Find(ID);
                context.Career.Remove(Caier);
                context.SaveChanges();
           
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Del (int ID)
        {
            CareerModels cuier = context.Career.Find(ID);
            if (cuier == null)
            {
                return HttpNotFound();
            }
            return View(cuier);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int ID)
        {
            CareerModels cuier = context.Career.Find(ID);
            if (cuier == null)
            {
                return HttpNotFound();
            }
            context.Career.Remove(cuier);
            context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}
