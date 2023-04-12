using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqExam.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExam.Requests.Tests
{
    [TestClass()]
    public class CountryRequestsTests
    {
        [TestMethod()]
        public void CountOfCountriesTest()
        {
            var req = new CountryRequests();

            int expected = 42;

            int actual = req.CountOfCountries();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountriesWithCitiesTest()
        {
            var req = new CountryRequests();

            int expectedCount = 42;
            int indonesiaCitiesCount = 17;
            string unitedStatesContains = "Nashville";

            var actual = req.CountriesWithCities();

            Assert.AreEqual(expectedCount, actual.Count);
            Assert.AreEqual(indonesiaCitiesCount, actual["Indonesia"].Count());
            Assert.IsTrue(actual["United States"].Contains(unitedStatesContains));
        }

        [TestMethod()]
        public void Top3CountriesByPopulationTest()
        {
            var req = new CountryRequests();
            int expectedCount = 3;
            string c = "Indonesia";
            string s = "China";
            string t = "Philippines";

            var actual = req.Top3CountriesByPopulation();

            Assert.AreEqual(expectedCount, actual.Count());
            Assert.IsTrue(actual.Contains(c));
            Assert.IsTrue(actual.Contains(s));
            Assert.IsTrue(actual.Contains(t));
        }

        [TestMethod()]
        public void Top1CountryByWomenCountTest()
        {
            var req = new CountryRequests();

            var exp = "Indonesia";

            var act = req.Top1CountryByWomenCount();

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void CountriesWithPopulationSeparetedByMenAndWomenTest()
        {
            var req = new CountryRequests();

            var act = req.CountriesWithPopulationSeparetedByMenAndWomen();

            Assert.AreEqual(2658787, act["Poland"]["Men"]);
            Assert.AreEqual(4079045, act["Poland"]["Women"]);
        }

        [TestMethod()]
        public void CountOfCitiesWhereWomenPopulationLessThenMenTest()
        {
            var req = new CountryRequests();

            var exp = 43;

            var act = req.CountOfCitiesWhereWomenPopulationLessThenMen();

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void WomenCountInCityWithLongestTitleTest()
        {
            var req = new CountryRequests();

            var exp = 129917;

            var act = req.WomenCountInCityWithLongestTitle();

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void CountOfCitiesWithNamesFrom2WordsTest()
        {
            var req = new CountryRequests();

            var exp = 16;

            var act = req.CountOfCitiesWithNamesFrom2Words();

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void TotalPopulationTest()
        {
            var req = new CountryRequests();

            var exp = 277465052;

            var act = req.TotalPopulation();

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void TotalPersentOfMenTest()
        {
            var req = new CountryRequests();

            var exp = 48;

            var act = req.TotalPersentOfMen();

            Assert.AreEqual(exp, act);
        }

        [TestMethod()]
        public void Top3LargestCitiesAndTop3SmallestCitiesTest()
        {
            var req = new CountryRequests();

            var act = req.Top3LargestCitiesAndTop3SmallestCities();

            Assert.IsTrue(act.Contains("Penisihan"));
            Assert.IsTrue(act.Contains("Pilchowice"));
            Assert.IsTrue(act.Contains("Cork"));
            Assert.IsTrue(act.Contains("Lendan"));
            Assert.IsTrue(act.Contains("Quesada"));
            Assert.IsTrue(act.Contains("Baisha"));
        }
    }
}