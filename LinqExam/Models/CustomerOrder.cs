using LinqExam.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LinqExam.Models
{
    public class CustomerOrder
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int ProductCount { get; set; }

        public DateTime Date { get; set; }
    }
}
