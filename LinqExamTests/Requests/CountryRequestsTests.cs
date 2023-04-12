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
            string c = "Costa Rica";
            string s = "Slovenia";
            string t = "Tunisia";

            var actual = req.Top3CountriesByPopulation();

            Assert.AreEqual(expectedCount, actual.Count());
            Assert.IsTrue(actual.Contains(c));
            Assert.IsTrue(actual.Contains(s));
            Assert.IsTrue(actual.Contains(t));
        }

        [TestMethod()]
        public void Top1CountryByWomenCountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CountriesWithPopulationSeparetedByMenAndWomenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CountOfCitiesWhereWomenPopulationLessThenMenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void WomenCountInCityWithLongestTitleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CountOfCitiesWithNamesFrom2WordsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TotalPopulationTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TotalPersentOfMenTest()
        {
            Assert.Fail();
        }
    }
}