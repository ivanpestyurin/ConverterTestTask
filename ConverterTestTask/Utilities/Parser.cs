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

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        public void GetParametersForCurrentCurrency(int i)
        {
            //GetNextParameters();
            //name = this.name;
            //charCode = this.charCode;
            //value = this.value;
        }
        private void FillArraysWithParameters()
        {


        }
    }
}
