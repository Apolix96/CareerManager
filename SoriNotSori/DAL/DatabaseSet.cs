using SoriNotSori.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.Entity;

namespace SoriNotSori.DAL
{   
    
    public class DatabaseSet
    {
        CareerContext context = new CareerContext();
        public void DataSet(CareerModels cuir)
        {
            context.Career.Add(cuir);
            context.SaveChanges();
            
        }
    }
}