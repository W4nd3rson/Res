using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://www.valor.com.br/valor-data");
            var node = document.DocumentNode.SelectNodes("//strong[@class='name']").Where(x => x.InnerText == "Dólar Comercial").First().SelectSingleNode("following-sibling::*[1][self::span]").InnerText;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DolarValue.txt");
            File.WriteAllText(path, node);
        }
    }
}
