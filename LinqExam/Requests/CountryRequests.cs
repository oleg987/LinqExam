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

        /*
         * Правила:
         * 
         * 1) Все запросы выполняются в одну строчку.
         * 2) Да, в одну длинную и ужастную строчку. 
         * 3) Да, это можно сделать.
         * 4) Дополнительные классы объявлять нельзя.
         * 5) При вычислениях мужского.женского населения полученное зачение округлять по математическим
         *    правилам и приводить к типу int.
         * 6) В методе CountriesWithPopulationSeparetedByMenAndWomen словарь который содержит кол-во
         *    мужского/женского населения в качестве ключей использовать значения "Men"/"Women" соответственно.
         * 7) Изменять класс CountryInfo нельзя.
         * 8) Изменять датасет (файл countries.json) нельзя.
         * 9) Изменять тесты нельзя.
         * 
         * Train your brain!
         */

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

        public IEnumerable<string> Top3LargestCitiesAndTop3SmallestCities()
        {
            throw new NotImplementedException();
        }
    }
}