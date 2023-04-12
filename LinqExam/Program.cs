using LinqExam.Requests;

namespace LinqExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var req = new CountryRequests();

            var res = req.Top3LargestCitiesAndTop3SmallestCities();
        }
    }
}