using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserFunctions
{
    class WriteHTML
    {
        public const string links = "Links.html";
        public const string head = @"
<head>
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0""
    <title>History</title>
</head>
";
        public static bool CreateHtmlFile(List<string> urls)
        {
            if (File.Exists(links))
            {
                File.Delete(links);
                saveToFile(urls);
                return true;
            }
            else
            {
                saveToFile(urls);
                return true;
            }
        }
        private static bool saveToFile(List<string> urls)
        {
            using (StreamWriter ws = new StreamWriter(links))
            {
                ws.WriteLine("<!DOCTYPE html>");
                ws.WriteLine("<html>");
                ws.WriteLine(head);
                ws.WriteLine("<body>");
                urls.ForEach(url => {
                    ws.WriteLine($"<a href=\"{url}\">{url}</a>");
                });
                ws.WriteLine("</body>");
                ws.WriteLine("</html>");
            }
            return true;
        }
    }
}
