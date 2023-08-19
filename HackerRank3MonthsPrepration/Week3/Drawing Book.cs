using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank3MonthsPrepration.Week3
{
    internal class Drawing_Book
    {
        public static int pageCount(int n, int p)
        {
            if (p <= n)
            {
                int fromLastPage = 0;
                int fromFirstPage= 0;
                if (n % 2 == 0&&n/p!=2)
                {
                    fromLastPage = (int)Math.Ceiling((double)(n - p) / 2);
                    fromFirstPage = (int)(Math.Ceiling((double)(p) / 2));
                }
                else
                {
                    fromLastPage = (int)Math.Ceiling((double)(n - p - 1) / 2);
                    fromFirstPage = (int)(Math.Ceiling((double)(p-1) / 2));
                    }
               

                if (fromLastPage > fromFirstPage)
                    return fromFirstPage;
                else if (fromFirstPage > fromLastPage)
                    return fromLastPage;
                else
                    return fromFirstPage;

            }
            return -1;
        }
    }
}
