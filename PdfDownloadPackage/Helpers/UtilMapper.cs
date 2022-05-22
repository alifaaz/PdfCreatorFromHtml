using DinkToPdf;
using PdfDownloadPackage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfDownloadPackage.Helpers
{
   internal  class UtilMapper 
    {
        internal static WebSettings MapFromWebPage(WebPageSettings _)
        {
            return new WebSettings()
            {
                LoadImages= _.LoadImages,
                Background= _.Background,
                DefaultEncoding = _.DefaultEncoding,
                EnableJavascript =_.EnableJavascript,
                EnableIntelligentShrinking = _.EnableIntelligentShrinking,
                MinimumFontSize = _.MinimumFontSize,
                PrintMediaType = _.PrintMediaType,
                UserStyleSheet = _.UserStyleSheet,
                enablePlugins = _.enablePlugins

            };
        }




        internal static HeaderSettings MapFromHeader(HeadSettings _)
        {
            return new HeaderSettings()
            {
                FontSize = _.FontSize,

                FontName = _.FontName,

                Left = _.Left,

                Center = _.Center,

                Right = _.Right,

                Line = _.Line,

                Spacing = _.Spacing,

                HtmUrl= _.HtmUrl
            };
        }

        internal static FooterSettings MapFromFooter(FootSettings _)
        {
            return new FooterSettings()
            {
                FontSize = _.FontSize,

                FontName = _.FontName,

                Left = _.Left,

                Center = _.Center,

                Right = _.Right,

                Line = _.Line,

                Spacing = _.Spacing,

                HtmUrl = _.HtmUrl
            };
        }
    }
}
