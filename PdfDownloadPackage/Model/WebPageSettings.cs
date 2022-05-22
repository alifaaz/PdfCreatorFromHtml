using DinkToPdf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfDownloadPackage.Model
{
    public class WebPageSettings: ISettings
    {

   
        public bool? Background { get; set; }
 
        public bool? LoadImages { get; set; }
        public bool? EnableJavascript { get; set; }

        public bool? EnableIntelligentShrinking { get; set; }
   
        public int? MinimumFontSize { get; set; }

        public bool? PrintMediaType { get; set; }

        public string DefaultEncoding { get; set; } = "utf-8";


        public string? UserStyleSheet { get; set; }
  
        public bool? enablePlugins { get; set; }
    }
}
