using firstLevel2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace firstLevel2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        public HomeController(ILogger<HomeController> logger , IConfiguration config)
        {
            _logger = logger;
            configuration = config;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult regster()
        {
            return View();
        }
        [ValidateAntiForgeryToken()]
        public IActionResult rbt(UserrInfo obj)
        {
             ViewBag.userName = obj.UserName;
             ViewBag.password = obj.Password;
            var connection = configuration.GetConnectionString("BbrDB");
            UserrInfo.Insert(obj, connection);
            return View();
        }
        public IActionResult loginbt(UserrInfo obj)
        {
           var connection = configuration.GetConnectionString("BbrDB");
           bool auth = UserrInfo.Login(obj, connection);
            if (auth)
                ViewBag.Msg = "ok";
            else
                ViewBag.Msg = "not ok";
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Display()
        {
            var connection = configuration.GetConnectionString("BbrDB");
            List<Emp_Info> emps = Emp_Info.reEmpInfo(connection);
            return View(emps);
        }
        public IActionResult Update(int id)
        {
            var connection = configuration.GetConnectionString("BbrDB");
            Emp_Info emp = Emp_Info.reEmpInfoByID(id,connection);
            return View(emp);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
