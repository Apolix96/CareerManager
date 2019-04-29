using SoriNotSori.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;

namespace SoriNotSori.DAL
{
    public class Data
    {
        CareerContext context = new CareerContext();
        public IEnumerable<CareerModels> DataUse()
        {
            IEnumerable<CareerModels> Careers = context.Career;
            return Careers;
        }


    }
}