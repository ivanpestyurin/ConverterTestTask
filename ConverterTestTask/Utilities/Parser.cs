using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net;

namespace ConverterTestTask.Utilities
{
    public class Parser
    {
        const string url = "https://www.cbr-xml-daily.ru/daily_json.js";

        WebClient wc;
        string webData;

        public List<string> name { get; private set; }
        public List<string> charCode { get; private set; }
        public List<double> rate { get; private set; }
        public List<int> nominal { get; private set; }

        public int Length { get; private set; } = 0;

        public Parser()
        {
            LoadPage();
            FillArraysWithParameters();
        }
        private void LoadPage()
        {
            wc = new WebClient();
            webData = wc.DownloadString(url);
        }

        private void FillArraysWithParameters()
        {

            charCode = Regex.Matches(webData, @"(?<=CharCode"": "")(.*)(?="")")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();

            name = Regex.Matches(webData, @"(?<=Name"": "")(.*)(?="")")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();

            rate = Regex.Matches(webData, @"(?<=Value"": )(.*)(?=,)")
                .Cast<Match>()
                .Select(m => double.Parse(m.Value))
                .ToList();

            nominal = Regex.Matches(webData, @"(?<=Nominal"": )(.*)(?=,)")
                .Cast<Match>()
                .Select(m => int.Parse(m.Value))
                .ToList();

            Length = nominal.Count();
        }
    }
}
