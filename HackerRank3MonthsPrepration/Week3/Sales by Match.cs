using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank3MonthsPrepration.Week3
{
    public class Sales_by_Match
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int totalPairCount = 0;
            var coloursDistincted = ar.Distinct().ToList();

            foreach (var colour in coloursDistincted)
            {
                var ww= ar.Where(x => x == colour).Count() / 2;
            }
            return totalPairCount;
        }
    }
}
