using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace ConverterTestTask.Utilities
{
    public class Parser
    {
        const string url = "https://www.cbr-xml-daily.ru/daily_json.js";
        HtmlWeb web;
        HtmlDocument doc;

        //public string[] name { get; private set; }
        public List<string> name { get; private set; }
        public string[] charCode { get; private set; }
        public double[] value { get; private set; }

        public int Length { get; private set; } = 0;

        public Parser()
        {
            FillArraysWithParameters();
        }
        private void LoadPage()
        {

            //WebClient wc = new WebClient();
            //string webData = wc.DownloadString("https://coinmarketcap.com/currencies/bitcoin/");
            //string price = getBetween(webData, "<div class=\"priceValue___11gHJ\">$", "</div>");

            web = new HtmlWeb();
            doc = web.Load(url);
        }

        public void GetParametersForCurrentCurrency(int i)
        {

        }
        private void FillArraysWithParameters()
        {


        }
    }
}
