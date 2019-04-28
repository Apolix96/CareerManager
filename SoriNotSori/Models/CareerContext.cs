using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SoriNotSori.Models;

namespace SoriNotSori.Models
{
    public class CareerContext : DbContext
    {
        public CareerContext() : base("CareerContext")
        {
        }
        public DbSet<CareerModels> Career { get; set; }
        
    }
}