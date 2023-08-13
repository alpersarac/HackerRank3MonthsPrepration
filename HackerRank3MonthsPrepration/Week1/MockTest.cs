using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank3MonthsPrepration.Week1
{
    public static class MockTest
    {
        public static int findMedian(List<int> arr)
        {
            var sortedList = arr.Select(x => x).OrderByDescending(x => x).ToList();
            int medianNumber = sortedList.ElementAt(sortedList.Count / 2);

            return medianNumber;
        }
    }
}
