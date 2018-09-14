using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoLMatchHistory.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Matchup()
        {
            return this.View();
        }
    }
}