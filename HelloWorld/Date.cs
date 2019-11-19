using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Date : IDate
    {
        public int getHour()
        {
            return DateTime.Now.Hour;

        }

        public int getDayOfWeek()
    {
            return (int)DateTime.Now.DayOfWeek;
        }
    }
}
