using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem019
    {
        public int Run()
        {
            DateTime startDate = new DateTime(1901, 1, 1).AddMonths(-1);
            DateTime endDate = new DateTime(2000, 12, 31);

            DateTime firstDay = startDate;

            int numSundays = 0;
            do
            {
                firstDay = firstDay.AddMonths(1);

                if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                    numSundays++;

            } while (firstDay < endDate);


            return numSundays;
        }
    }
}
