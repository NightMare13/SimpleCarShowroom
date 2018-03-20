using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagersAssistant.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }

    }
}