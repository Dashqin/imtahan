using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Controllers
{
    public class EmployesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
