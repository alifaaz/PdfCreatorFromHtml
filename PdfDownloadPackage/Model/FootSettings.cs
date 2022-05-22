using DinkToPdf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfDownloadPackage.Model
{
    public class FootSettings: ISettings
    {
    
        public int? FontSize { get; set; }
     
        public string FontName { get; set; }

        public string Left { get; set; }
    
        public string Center { get; set; }
     
        public string Right { get; set; }
    
        public bool? Line { get; set; }
    
        public double? Spacing { get; set; }
 
        public string HtmUrl { get; set; }
    }
}
