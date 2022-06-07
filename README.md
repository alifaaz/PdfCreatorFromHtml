   # صناعه ملف بي دي اف من ملف  html 

 لقد تم صناعه رابر لمكتبه [DinkToPdf](https://github.com/rdvojmoc/DinkToPdf)  من اجل تسهيل عمليه صناعه ملفات البي دي اف 
## كيفيه الاستعمال


المكتبه لطيفه خفيفه مجرد تصنع اعداداتك وتشمرهم هيه تحير بالعمليه المتبقيه

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
