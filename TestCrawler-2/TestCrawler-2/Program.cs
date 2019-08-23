using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestCrawler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Os Arquivos estão em ~bin/Debug**//
            string fullText = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FullText.txt"));
            var indexes = new Regex(@"\D+").Split(fullText).Where(x => x != String.Empty);
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ResourceIT.txt");
            TextWriter textWriter = new StreamWriter(path, true);
            string extractedText = "";

            foreach (string index in indexes)
            {
                if (int.Parse(index) % 2 == 0)
                {
                    extractedText = Regex.Match(fullText, $@"(?i){int.Parse(index) - 1} RESOURCE IT SOLUTIONS\s+(.+?)\s+{index} RESOURCE IT SOLUTIONS").Groups[1].Value;
                    textWriter.WriteLine(extractedText);
                }
            }

            textWriter.Close();
        }
    }
}
