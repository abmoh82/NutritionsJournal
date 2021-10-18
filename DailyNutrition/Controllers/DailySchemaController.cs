using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DailyNutrition.Controllers
{
    public class DailySchemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
