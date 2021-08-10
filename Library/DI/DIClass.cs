using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DI
{
    public class DIClass
    {
        private static ITestDataService _testDataService;

        public DIClass(ITestDataService testDataService)
        {
            if (_testDataService == null)
            {
                _testDataService = testDataService;
            }
        }

        public static string ExecuteStatic()
        {
            Console.WriteLine(_testDataService.Execute());
            return (_testDataService.Execute());
        }

        public string Execute()
        {
            Console.WriteLine(_testDataService.Execute());
            return (_testDataService.Execute());
        }
    }
}
