using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QrCode_API.assets;

namespace QrCode_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QrCodeGeneratorController : ControllerBase
    {
        [HttpGet("Gerar/{texto}")]
        public IActionResult Gerar(string texto)
        {
            QrCodeGenerator generator = new QrCodeGenerator(); // instanciando a classe
            var PageHtml = generator.GeradorComSvg(texto); // passando parametro para gerar o qrcode
            return Content(PageHtml, "text/html"); // retornando a pagina
        }
    }
}