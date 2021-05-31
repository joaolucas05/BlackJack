using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploMVC.Controllers
{
    public class BlackJackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Teste()
        {
            return View();
        }
        public string result(string cartas1)
        {
            String nome = "Katiuska";
            return nome;

        }
    }
    
}
