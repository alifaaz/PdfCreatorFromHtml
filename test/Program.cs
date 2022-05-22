using DinkToPdf;
using PdfDownloadPackage;
using PdfDownloadPackage.Helpers;
using PdfDownloadPackage.Model;
using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var globalSettings = new PdfSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSetting { Top = 10 },
                DocumentTitle = "PDF Report"
            };
            var objectSettings = new DocumentSettings
            {
                PagesCount = true,
                HtmlContent = HtmlHelper.htmlGen("hello this is me"),
                WebSettings = { DefaultEncoding = "utf-8", LoadImages = true },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "الذيل غي اسفل الصفحه" }
            };
            var pdf = PdfHandler.createPdfSync(globalSettings, objectSettings);

            System.IO.File.WriteAllBytes("helloيسيس.pdf", pdf);
            Console.WriteLine("Hello World!",ImageHelper.ConvertBytyteArrayToBase64Image(pdf));
        }
    }
}
