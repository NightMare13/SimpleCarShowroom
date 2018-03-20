using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManagersAssistant.Models
{
    public class ProductsDBInitializer :DropCreateDatabaseAlways<DataBasesContext>
    {
        protected override void Seed(DataBasesContext context)
        {
            context.Cars.Add(new Car());
            context.Customers.Add(new Customer());
            context.Orders.Add(new Order());

            base.Seed(context);
        }
    }
}