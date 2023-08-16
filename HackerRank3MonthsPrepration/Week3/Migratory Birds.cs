using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank3MonthsPrepration.Week3
{
    internal class Migratory_Birds
    {
        public static int migratoryBirds()
        {
            var arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            var lowerSightedBird = arr.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).ToList().FirstOrDefault();

            return lowerSightedBird;
        }
    }
}
