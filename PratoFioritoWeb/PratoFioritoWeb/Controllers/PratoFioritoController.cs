using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PratoFioritoWeb.Models;

namespace PratoFioritoWeb.Controllers
{
    public class PratoFioritoController : Controller
    {
        public IActionResult Index(int difficulty)
        {
            Difficulty diff = new Difficulty();
            if (difficulty == 0)
            {
                diff.height = 5;
                diff.width = 7;
            }
            return View(diff);
        }
    }
}
