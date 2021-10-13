using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerAPI.Controllers
{
    public class Modelo
    {
        public int a { get; set; }
        public int b { get; set; }

    }

    public class Respuesta
    {
        public int c { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {
        [HttpGet]
        public int Addition(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        [Route("Suma")]
        public Respuesta Suma([FromBody] Modelo modelo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.c = modelo.a + modelo.b;
            return respuesta;
        }
        [HttpPost]
        [Route("Multiplicacion")]
        public Respuesta Multiplicacion([FromBody] Modelo modelo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.c = modelo.a * modelo.b;
            return respuesta;
        }
  
    }
}