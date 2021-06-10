using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Lotto.Model;
using Newtonsoft.Json;

namespace Lotto.Service
{
    public class WebService
    {
        public string url = "http://www.nlotto.co.kr/common.do?method=getLottoNumber&drwNo=";

        public Win lottoAllWinNum(int drwNo) 
        {
            Win result = new Win();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + Convert.ToString(drwNo));

                request.Method = "GET";
                request.Timeout = 1000;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream st = response.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("utf-8"));
                //JavaScriptSerializer js = new JavaScriptSerializer();
                var restResult = sr.ReadToEnd();

                sr.Close();
                response.Close();
               // result = (Win)js.Deserialize(restResult, typeof(Win));
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
