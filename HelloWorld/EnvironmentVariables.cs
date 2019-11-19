using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class EnvironmentVariables : IEnvironmentVariable
    {
        public string getUserName()
        {
            return Environment.UserName.Replace(".", " ");
        }
    }
}
