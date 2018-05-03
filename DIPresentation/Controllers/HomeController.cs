using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DIPresentation.Models;
using DIBusiness.Logic;
using DICommon.Logic.Model;

namespace DIPresentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDiBLService _dataService;

        public HomeController(IDiBLService dataService)
        {
            _dataService = dataService;
        }

        public IActionResult Index()
        {
            List<Student> students = _dataService.GetAll();
            return View(students);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
