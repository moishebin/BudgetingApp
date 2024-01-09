using Microsoft.AspNetCore.Mvc;
using System;

namespace BudgetingApp.Controllers
{
    public class BudgetController : Controller
    {
        public IActionResult Index()
        {
            //get from database
            return View();
        }

        public IActionResult CreateBudget()
        {
            return View();
        }
    }
}
