using DinkToPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfDownloadPackage.Model
{
  public  class PdfGlobalSettings
    {

        public string DocTitle { get; set; }
        public string Body { get; set; }

        public bool? PagesCount { get; set; } = true;
        public Orientation Orientation { get; set; }
        public ColorMode ColorMode { get; set; }
        public MarginSetting MarginSetting { get; set; }
        public string Page { get; set; }
        public bool? UseExternalLinks { get; set; }

        public bool? UseLocalLinks { get; set; }
 
        public bool? ProduceForms { get; set; }

        public bool? IncludeInOutline { get; set; }

        public WebPageSettings WebSettings { get; set; }
        public HeadSettings? HeaderSettings { get; set; }
        public FootSettings? FooterSettings { get; set; }
    
    }
}
