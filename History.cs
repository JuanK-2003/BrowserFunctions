using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserFunctions
{
    class History
    {
        public const string historyURL = "historyURL'S.txt";
        public List<string> visitedURL { get; set; }
        public History()
        {
            visitedURL = new List<string>();
            if (File.Exists(historyURL))
            {
                using (StreamReader sr = File.OpenText(historyURL))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        visitedURL.Add(s);
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(historyURL))
                {
                    Console.WriteLine("File created");
                }
            }
        }
        public bool AddUrl(string url)
        {
            this.visitedURL.Add(url);
            //
            SaveUrls();
            return true;
        }

        public bool SaveUrls()
        {
            if (File.Exists(historyURL))
            {
                File.Delete(historyURL);
            }
            using (StreamWriter sw = new StreamWriter(historyURL))
            {
                visitedURL.ForEach(sw.WriteLine);
            }
            WriteHTML.CreateHtmlFile(this.visitedURL);
            return true;
        }
    }
}
