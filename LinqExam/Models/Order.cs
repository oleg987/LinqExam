using LinqExam.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LinqExam.Models
{
    public class Order
    {
        [JsonPropertyName("customer_id")]
        public int CustomerId { get; set; }

        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [JsonPropertyName("product_count")]
        public int ProductCount { get; set; }

        [JsonPropertyName("date")]
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime Date { get; set; }
    }
}
