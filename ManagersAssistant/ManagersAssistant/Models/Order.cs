using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagersAssistant.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime Date { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }

    }
}