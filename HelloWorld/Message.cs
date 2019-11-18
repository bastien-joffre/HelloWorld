using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Message
    {
        int morningTime;
        int middayTime;
        int eveningTime;

        public Message(int morningTime = 9, int middayTime = 13, int eveningTime = 18)
        {
            this.morningTime = morningTime;
            this.middayTime = middayTime;
            this.eveningTime = eveningTime;
        }

        public string getHelloMessage()
        {
            string me = Environment.UserName;
            me = me.Replace(".", " ");

            DateTime now = DateTime.Now;
            int dayOfWeekIndex = (int)now.DayOfWeek;

            if ((dayOfWeekIndex == 1 ? now.Hour >= this.morningTime : dayOfWeekIndex > 0) &&
                (dayOfWeekIndex == 5 ? now.Hour < this.eveningTime : dayOfWeekIndex < 5))
                if (now.Hour >= morningTime && now.Hour < this.middayTime)
                    return $"Bonjour {me}";
                else if (now.Hour >= this.middayTime && now.Hour < this.eveningTime)
                    return $"Bon après-midi {me}";
                else
                    return $"Bonsoir {me}";
            else
                return $"Bon week-end {me}";
        }
    }
}
