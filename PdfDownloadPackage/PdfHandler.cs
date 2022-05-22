using DinkToPdf;
using DinkToPdf.Contracts;
using EscanGetDocApi.Helpers;
using PdfDownloadPackage.Helpers;
using PdfDownloadPackage.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace PdfDownloadPackage
{
  public  class PdfHandler
    {

        public static byte[] createPdf(string html, PdfSettings pdfSettings , DocumentSettings documentSettings)
        {
            var _converter = new BasicConverter(new PdfTools());
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = pdfSettings,
                Objects = { documentSettings }
            };
            var file = _converter.Convert(pdf);

            return file;
        }

        private static HtmlToPdfDocument BuildPdfSettings(PdfGlobalSettings _)
        {
            var _pdfSettings = new PdfSettings
            {
                ColorMode = (DinkToPdf.ColorMode?)_.ColorMode,
                Orientation = (DinkToPdf.Orientation?)_.Orientation,
                PaperSize = PaperKind.A4,
                Margins = _.MarginSetting,
                DocumentTitle = _.DocTitle
            };

            WebSettings _webSettings = UtilMapper.MapFromWebPage(_.WebSettings);
            HeaderSettings _headerSettings = UtilMapper.MapFromHeader(_.HeaderSettings);
            FooterSettings _footerSettings = UtilMapper.MapFromFooter(_.FooterSettings);
            var objectSettings = new DocumentSettings
            {
                PagesCount = _.PagesCount,
                HtmlContent = _.Body,
                WebSettings = _webSettings,
                HeaderSettings = _headerSettings,
                FooterSettings = _footerSettings
            };
            return new HtmlToPdfDocument()
            {
                GlobalSettings = _pdfSettings,
                Objects = { objectSettings }
            };
        }
        public static byte[] createPdfSync(PdfGlobalSettings _pdfGlobalSettings)
        {
            try
            {


                var context = new CustomAssemblyLoadContext();
                context.LoadUnmanagedLibrary(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "libwkhtmltox.dll"));
                var _converter = new SynchronizedConverter(new PdfTools());
                var pdf = BuildPdfSettings(_pdfGlobalSettings);
                var file = _converter.Convert(pdf);

                return file;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        
        }
    }
}
