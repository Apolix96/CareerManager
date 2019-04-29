using SoriNotSori.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;


namespace SoriNotSori.DAL
{
    public class DataChanges
    {
        CareerContext context = new CareerContext();
        DataFind CairFind = new DataFind();
        public string Edit(CareerModels career)
        {
            context.Entry(career).State = EntityState.Modified;
            context.SaveChanges();
            return "ok";
        }
        public string Delete(int? ID)
        {
            CareerModels career = context.Career.Find(ID);
            context.Career.Remove(career);
            context.SaveChanges();
            return "Ok";
        }
        public string DeleteConfirmed(int? ID)
        {
            CareerModels cuier = context.Career.Find(ID);
            context.Career.Remove(cuier);
            context.SaveChanges();
            return "ok";
        }
    }
}