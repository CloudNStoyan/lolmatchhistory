using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LoLMatchHistory.FormModels;
using Microsoft.AspNetCore.Mvc;

namespace LoLMatchHistory.Controllers
{
    public class ApiController : Controller
    {
        [HttpPost]
        public IActionResult Add(InputMatchup matchup)
        {
            Console.WriteLine(matchup.Win + "\n\n");
            return this.RedirectToAction("Index","Home");
        }
    }
}