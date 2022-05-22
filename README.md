# PdfCreatorFromHtml

This library is a wrapper for DinkToPdf with easy configuration

``` 
       var globalSettings = new PdfGlobalSettings()
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                MarginSetting = new MarginSetting { Top = 10 },
                DocTitle = "my report",
                PagesCount = true,
                Body = HtmlHelper.htmlGen("<h1>hello this is me</h1>"),
                WebSettings = new WebPageSettings() { DefaultEncoding = "utf-8", LoadImages = true },
                HeaderSettings = new HeadSettings(){ FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = new FootSettings() { FontName = "Arial", FontSize = 9, Line = true, Center = "الذيل غي اسفل الصفحه" }
            };
            byte[] pdf = PdfHandler.createPdfSync(globalSettings);

```
