using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld;

namespace UnitTestProject
{
    public class FakeDate : IDate
    {
        int _hour;
        int _dayOfWeek;

        public FakeDate(int hour, int dayOfWeek)
        {
            _hour = hour;
            _dayOfWeek = dayOfWeek;
        }

        public int getHour()
        {
            return _hour;
        }

        public int getDayOfWeek()
        {
            return _dayOfWeek;
        }
    }
}
