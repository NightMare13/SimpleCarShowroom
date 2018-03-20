using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ManagersAssistant.Models
{
    public class DataBasesContext : DbContext
    {
        public DataBasesContext() : base("DataBaseConnection")
        {
            
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}