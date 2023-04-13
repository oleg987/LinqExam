using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExam.Requests
{
    public class StringRequests
    {
        private static readonly string[] _randomStrings;

        static StringRequests()
        {
            using var file = new FileStream("random_strings.txt", FileMode.Open);

            using var sr = new StreamReader(file);

            var result = sr.ReadToEnd();

            _randomStrings = result.Split(Environment.NewLine);
        }

        /// <summary>
        /// Sort arrayToSort using Array.Sort()
        /// Format of elements {RandomNum}.{RandomString}
        /// Sort logic: sort by {RandomString} then by {RandomNum}
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string[] Sort()
        {
            var arrayToSort = new string[_randomStrings.Length];
            _randomStrings.CopyTo(arrayToSort, 0);

            return arrayToSort;
        }
    }
}
