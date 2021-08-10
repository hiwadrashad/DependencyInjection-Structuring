using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataServices
{
    public class TestDataService : ITestDataService
    {
        public string Execute()
        {
            return "Test this";
        }
    }
}
