using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SoriNotSori.Models
{
    public class Intit : System.Data.Entity.DropCreateDatabaseIfModelChanges<CareerContext>
    {

        protected override void Seed(CareerContext context)
        {
            context.Career.Add(new CareerModels { ID=0 ,Name="Свердловский карьер",NameSub="Свердловская область"});
            context.Career.Add(new CareerModels { ID=1 ,Name="Нижнетагильский карьер",NameSub= "Свердловская область" });
            context.Career.Add(new CareerModels { ID=2,Name="Ползунова",NameSub= "Свердловская область" });
            base.Seed(context);
        }
    }
}