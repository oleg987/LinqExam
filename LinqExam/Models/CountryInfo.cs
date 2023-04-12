using LinqExam.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LinqExam.Models
{
    public class CountryInfo
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("population")]
        public int Population { get; set; }

        [JsonPropertyName("population_dispersion")]
        [JsonConverter(typeof(PopulationDispersionJsonConverter))]
        public string PopulationDispersion { get; set; }
    }
}
