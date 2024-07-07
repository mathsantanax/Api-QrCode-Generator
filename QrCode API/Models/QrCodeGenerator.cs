using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QRCoder;


namespace QrCode_API.Models
{
    internal class QrCodeGenerator
    {
        public string GeradorComSvg(string texto)
        {
            // inicializando o qrcode Generator
            QRCodeGenerator qR = new QRCodeGenerator();

            // criando o qrcode com o texto
            QRCodeData qRCodeData = qR.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);

            // Gerando QrCode como SVG
            SvgQRCode qrCode = new SvgQRCode(qRCodeData);
            string qrCodeAsSvg = qrCode.GetGraphic(20);


            // criando string para pagina html com o svg
            string htmlTemplate = $@"
                <!DOCTYPE html>
                <html lang='en'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <title>QR Code</title>
                </head>
                <body>
                    <div>{qrCodeAsSvg}</div>
                </body>
                </html>";

            //retona a pagina
            return htmlTemplate;
        }
    }
}