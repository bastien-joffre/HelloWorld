using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        private IEnvironmentVariable _environmentVariable;
        private IDate _date;

        private int morningTime;
        private int middayTime;
        private int eveningTime;

        public Message(int morningTime, int middayTime, int eveningTime)
            : this(new EnvironmentVariables(), new Date(), morningTime, middayTime, eveningTime)
        {
        }

        internal Message(IEnvironmentVariable environmentVariable, IDate date, int morningTime, int middayTime, int eveningTime)
        {
            _environmentVariable = environmentVariable;
            _date = date;

            this.morningTime = morningTime;
            this.middayTime = middayTime;
            this.eveningTime = eveningTime;
        }

        public string getHelloMessage()
        {
            string me = _environmentVariable.getUserName();
            int hour = _date.getHour();
            int dayOfWeek = _date.getDayOfWeek();

            if ((dayOfWeek == 1 ? hour >= this.morningTime : dayOfWeek > 0) &&
                (dayOfWeek == 5 ? hour < this.eveningTime : dayOfWeek < 5))
                if (hour >= morningTime && hour < this.middayTime)
                    return $"Bonjour {me}";
                else if (hour >= this.middayTime && hour < this.eveningTime)
                    return $"Bon après-midi {me}";
                else
                    return $"Bonsoir {me}";
            else
                return $"Bon week-end {me}";
        }
    }
}
