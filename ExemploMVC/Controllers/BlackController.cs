using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace ExemploMVC.Controllers
{
    [ApiController]

    public class BlackController : Controller
    {
        string name = "";
        [Route("api/[controller]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("api/[controller]/vitoria/{Ponto1}/{Ponto2}")]
        public int Vitoria(int Ponto1, int Ponto2)
        {
            var p1 = Ponto1;
            var p2 = Ponto2;

            if(p1 > p2 && p1 < 22)
            {

                return 1;


            }else if(p2 > p1 && p2 < 22)
            {

                return 2;
                
            }else if(p1 == p2)
            {
                return 3;

            }else if(p1 > 22)
            {

                return 4;

            }else if(p2 > 22)
            {

                return 5;

            }
            else
            {
                return 6;
            }
        }


[Route("api/[controller]/jogada/{jogador}/{pontos}")]
public JsonResult Jogada(int jogador, int pontos)
{
    int x, total_pontos = 0;
    Random sorteio = new Random();
    x = sorteio.Next(1, 14);


    switch (x)
    {
        case 1: name = "1"; total_pontos = 1; break;
        case 2: name = "2"; total_pontos = 2; break;
        case 3: name = "3"; total_pontos = 3; break;
        case 4: name = "4"; total_pontos = 4; break;
        case 5: name = "5"; total_pontos = 5; break;
        case 6: name = "6"; total_pontos = 6; break;
        case 7: name = "7"; total_pontos = 7; break;
        case 8: name = "8"; total_pontos = 8; break;
        case 9: name = "9"; total_pontos = 9; break;
        case 10: name = "10"; total_pontos = 10; break;
        case 11: name = "11"; total_pontos = 11; break;
        case 12: name = "12"; total_pontos = 12; break;
        case 13: name = "13"; total_pontos = 13; break;
    }

    if (jogador == 1)
    {
        var Resultado_1 = pontos + total_pontos;
        var res = new
        {
            carta = name,
            pontos = Resultado_1,
            id = jogador
        };
        return Json(res);
    }

    else if (jogador == 2)
    {
        var Resultado_2 = pontos + total_pontos;
        var res = new
        {
            carta = name,
            pontos = Resultado_2,
            id = jogador
        };
        return Json(res);
    }
    else
    {
        var Resultado_3 = pontos + total_pontos;
        var res = new
        {
            carta = name,
            pontos = Resultado_3,
            id = jogador
        };
        return Json(res);
    }


}
    }
}
 