using SoriNotSori.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;

namespace SoriNotSori.DAL
{
    public class DataDel
    {
        CareerContext context = new CareerContext();
        DataFind CairFind = new DataFind();
        public void Delete(int? ID)
        {
            CareerModels career = context.Career.Find(ID);
            context.Career.Remove(career);
            context.SaveChanges();

        }
    }
}