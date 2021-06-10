using HtmlAgilityPack;
using Lotto.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;

namespace Lotto.Repository
{
    public class WebServiceRepository
    {
        private string apiUrl = Properties.Settings.Default.LottoApiUrl;
        private string apiUrl2 = Properties.Settings.Default.LottoApiUrl2;

        private string parsingUrl = Properties.Settings.Default.LottoPasingUrl;

        public Win getLottoParsing(int drwNo)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(parsingUrl + Convert.ToString(drwNo));

            return new Win(
                "success",
                Convert.ToInt32(Regex.Replace(doc.DocumentNode.SelectSingleNode("//div[contains(@class, 'win_result')]").ChildNodes[1].ChildNodes[0].InnerText, @"\D", "")),
                DateTime.ParseExact(Regex.Replace(doc.DocumentNode.SelectSingleNode("//p[contains(@class, 'desc')]").InnerText, @"\D", ""), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None),
                Convert.ToInt32(doc.DocumentNode.SelectNodes("//span[contains(@class, 'ball_645')]")[0].InnerText),
                Convert.ToInt32(doc.DocumentNode.SelectNodes("//span[contains(@class, 'ball_645')]")[1].InnerText),
                Convert.ToInt32(doc.DocumentNode.SelectNodes("//span[contains(@class, 'ball_645')]")[2].InnerText),
                Convert.ToInt32(doc.DocumentNode.SelectNodes("//span[contains(@class, 'ball_645')]")[3].InnerText),
                Convert.ToInt32(doc.DocumentNode.SelectNodes("//span[contains(@class, 'ball_645')]")[4].InnerText),
                Convert.ToInt32(doc.DocumentNode.SelectNodes("//span[contains(@class, 'ball_645')]")[5].InnerText),
                Convert.ToInt32(doc.DocumentNode.SelectNodes("//span[contains(@class, 'ball_645')]")[6].InnerText),
                Convert.ToInt64(Regex.Replace(doc.DocumentNode.SelectNodes("//ul[contains(@class, 'list_text_common')]")[0].ChildNodes[3].InnerText, @"\D", "")),
                Convert.ToInt64(Regex.Replace(doc.DocumentNode.SelectNodes("//strong[contains(@class, 'color_key1')]")[0].InnerText, @"\D", "")),
                Convert.ToInt32(doc.DocumentNode.SelectSingleNode("//table[contains(@class, 'tbl_data tbl_data_col')]").ChildNodes[7].ChildNodes[1].ChildNodes[5].InnerText),
                Convert.ToInt64(Regex.Replace(doc.DocumentNode.SelectSingleNode("//table[contains(@class, 'tbl_data tbl_data_col')]").ChildNodes[7].ChildNodes[1].ChildNodes[7].InnerText, @"\D", ""))); ;
        }

        public Win getLottoWinApi(int drwNo)
        {
            Win result = new Win();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl + Convert.ToString(drwNo));

                request.Method = "GET";
                request.Timeout = 1000;
                
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                
                Stream st = response.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("utf-8"));

                var restResult = sr.ReadToEnd();

                sr.Close();
                response.Close();

                result = JsonConvert.DeserializeObject<Win>(restResult);

            }
            catch
            {
                result = null;
            }
            return result;
        }

        public Win getLottoWinApi2(int drwNo)
        {
            Win result = new Win();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl2 + Convert.ToString(drwNo));

                request.Method = "GET";
                request.Timeout = 1000;
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36";
                request.CookieContainer = new CookieContainer();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream st = response.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("utf-8"));

                var restResult = sr.ReadToEnd();

                sr.Close();
                response.Close();

                result = JsonConvert.DeserializeObject<Win>(restResult);

            }
            catch
            {
                result = null;
            }
            return result;
        }
    }
}
