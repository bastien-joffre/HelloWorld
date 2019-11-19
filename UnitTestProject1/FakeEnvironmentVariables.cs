using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelloWorld;

namespace UnitTestProject
{
    public class FakeEnvironmentVariables : IEnvironmentVariable
    {
        string _userName;

        public FakeEnvironmentVariables(string userName)
        {
            _userName = userName;
        }

        public string getUserName()
        {
            return _userName;
        }
    }
}
