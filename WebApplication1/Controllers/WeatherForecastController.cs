using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PdfDownloadPackage;
using PdfDownloadPackage.Helpers;
using PdfDownloadPackage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        { 
            var globalSettings = new PdfGlobalSettings()
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                MarginSetting = new MarginSetting { Top = 10 },
                DocTitle = "my report",
                PagesCount = true,
                Body = HtmlHelper.htmlGen("hello this is me"),
                WebSettings = new WebPageSettings() { DefaultEncoding = "utf-8", LoadImages = true },
                HeaderSettings = new HeadSettings(){ FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = new FootSettings() { FontName = "Arial", FontSize = 9, Line = true, Center = "الذيل غي اسفل الصفحه" }
            };
            var pdf = PdfHandler.createPdfSync(globalSettings);

            return File(pdf, "application/pdf", "IDs.pdf");
        }
    }
}
