using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank3MonthsPrepration.Week3
{
    internal class Maximum_Perimeter_Triangle
    {
        public static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            List<int> sticksInOrder = sticks.OrderBy(x => x).ToList();
            List<int> resultSticks = new List<int>();
            for (int i = 0; i < sticksInOrder.Count() - 1; i++)
            {
                if (i + 2 < sticksInOrder.Count())
                {
                    int firstStick = sticksInOrder.ElementAt(i);
                    int secondStick = sticksInOrder.ElementAt(i + 1);
                    int thirdStick = sticksInOrder.ElementAt(i + 2);

                    if ((firstStick + secondStick) > thirdStick)
                    {
                        resultSticks.Clear();
                        resultSticks = new List<int>() { firstStick, secondStick, thirdStick };
                    }
                }
            }
            if (resultSticks.Count > 0)
            {
                return resultSticks;
            }
            else
            {
                return new List<int>() { -1 };
            }

        }
    }
}
