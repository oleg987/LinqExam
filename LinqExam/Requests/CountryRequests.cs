using LinqExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LinqExam.Requests
{
    public class CountryRequests
    {
        private static readonly IEnumerable<CountryInfo> _countryInfos;
        private const string _filePath = "countries.json";

        static CountryRequests()
        {
            using var file = new FileStream(_filePath, FileMode.Open);
            using var stream = new StreamReader(file);

            var json = stream.ReadToEnd();

            _countryInfos = JsonSerializer.Deserialize<IEnumerable<CountryInfo>>(json)!;
        }

        public int CountOfCountries()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, IEnumerable<string>> CountriesWithCities()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Top3CountriesByPopulation()
        {
            throw new NotImplementedException();
        }

        public string Top1CountryByWomenCount()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Dictionary<string, int>> CountriesWithPopulationSeparetedByMenAndWomen()
        {
            throw new NotImplementedException();
        }

        public int CountOfCitiesWhereWomenPopulationLessThenMen()
        {
            throw new NotImplementedException();
        }

        public int WomenCountInCityWithLongestTitle()
        {
            throw new NotImplementedException();
        }

        public int CountOfCitiesWithNamesFrom2Words()
        {
            throw new NotImplementedException();
        }

        public int TotalPopulation()
        {
            throw new NotImplementedException();
        }

        public int TotalPersentOfMen()
        {
            throw new NotImplementedException();
        }
    }
}