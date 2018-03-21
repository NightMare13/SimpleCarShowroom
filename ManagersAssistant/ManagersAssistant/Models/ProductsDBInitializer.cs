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
            var car = context.Cars.Add(new Car() {CarId = 1, Brand = "BMW", Cost = new decimal(999.99)});
            var cust = context.Customers.Add(new Customer(){Name = "Pavel",CustomerId = 1,Orders = new List<Order>(),PhoneNumber = 999});
            context.Orders.Add(new Order(){Car = car, CustomerId = 1,CarId = 1,Customer = cust,Date = DateTime.Now,OrderId = 1});

            base.Seed(context);
        }
    }
}