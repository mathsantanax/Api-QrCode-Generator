using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QRCoder;

namespace QrCode_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QrCodeGeneratorController : ControllerBase
    {
        [HttpGet("GerarComPNG/{{texto}}&{{tamanho}}/")]
        public IActionResult GerarComPNG(string texto, int tamanho)
        {
            // instanciando a classe
            QRCodeGenerator qR = new QRCodeGenerator();

            // criando o qrcode
            QRCodeData qRCodeData = qR.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);

            //convertendo para byte de png
            PngByteQRCode pngByte = new PngByteQRCode(qRCodeData);
            byte[] bytePNG = pngByte.GetGraphic(tamanho); // imagem em byte

            return File( bytePNG, "image/png"); // retornando a imagem       
        }
    }
}