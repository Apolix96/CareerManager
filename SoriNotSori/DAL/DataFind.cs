using SoriNotSori.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;

namespace SoriNotSori.DAL
{
    public class DataFind
    {
        CareerContext context = new CareerContext();
        public CareerModels ID(int? ID)
        {
            CareerModels career = context.Career.Find(ID);
            return career;
        }
    }
}