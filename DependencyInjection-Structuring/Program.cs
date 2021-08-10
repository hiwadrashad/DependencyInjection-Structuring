using Library.DataServices;
using Library.DI;
using Library.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DependencyInjection_Structuring
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RegisterServices();
            TestDataService testdataservice = new TestDataService();
            DIClass DItestdataservice = new DIClass(testdataservice);
            DItestdataservice.Execute();
            DIClass.ExecuteStatic();
        }


        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<ITestDataService, TestDataService>();
            services.BuildServiceProvider(true);
        }
    }

}
