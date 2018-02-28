using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAutofac.Services
{
    public class TestService : ITestService
    {
        public string GetTest()
        {
            return "It's working";
        }
    }
}
