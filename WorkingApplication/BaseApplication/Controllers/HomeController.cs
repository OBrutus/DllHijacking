using BaseApplication.Models;
using BaseApplication.Models.Internals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository, ILogger<HomeController> logger)
        {
            _employeeRepository = employeeRepository;
            _logger = logger;
        }

        public IActionResult Index(string name = "milind")
        {
            var targetEmployee = _employeeRepository.GetEmployee(name);
            if (targetEmployee == null)
                throw new NullReferenceException();
            return View(targetEmployee);
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
