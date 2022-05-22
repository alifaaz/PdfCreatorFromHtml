using System;

namespace PdfDownloadPackage.Helpers
{
    public class HtmlHelper
    {

        public static string htmlGen(string body, string title = "document")
        {
            return $"<html>  <head><title>{title}</title></head><body>   <div class='root-pdf-converter'>{body} </div></body></html>";
        }



    }
}
