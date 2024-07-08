using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QrCode_API.Models;

namespace QrCode_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QrCodeGeneratorController : ControllerBase
    {
        [HttpGet("Gerar/{{texto}}&{{tamanho}}/")]
        public IActionResult Gerar(string texto, int tamanho)
        {
            QrCodeGenerator generator = new QrCodeGenerator(); // instanciando a classe
            var PageHtml = generator.GeradorComSvg(texto, tamanho); // passando parametro para gerar o qrcode
            return Content(PageHtml, "text/html"); // retornando a pagina
        }
    }
}