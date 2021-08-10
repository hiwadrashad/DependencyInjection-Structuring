using Dependency_injection_MVC.Models;
using Library.DataServices;
using Library.DI;
using Library.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_injection_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestDataService _testDataService;
        public HomeController(ILogger<HomeController> logger,ITestDataService testDataService)
        {
            _logger = logger;
            _testDataService = testDataService;
        }
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            ModelDTO DTO = new ModelDTO();
            DIClass DItestdataservice = new DIClass(_testDataService);
            DTO.text = DItestdataservice.Execute();
            DTO.statictext = DIClass.ExecuteStatic();
            return View(DTO);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
