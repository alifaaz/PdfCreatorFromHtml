using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfDownloadPackage.Helpers
{
    public class ImageHelper
    {
        public static string ConvertBytyteArrayToBase64Image(byte[] source)
        {

            var ret = Convert.ToBase64String(source);

            return $"data:image/png;base64,{ret}";
        }
    }
}
