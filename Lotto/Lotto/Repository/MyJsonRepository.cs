using Lotto.Biz;
using Lotto.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Lotto.Repository
{
    public class MyJsonRepository
    {
        private string fileName = @"\MY_LOTTO_INFO_";
        private string loginFileName = @"\LOTTO_LOGIN_INFO.json";
        private string mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void createJson(List<MyNum> input)
        {
            LoginInfo id = selectIdJson().Find(x => x.selected == 1);
            using (StreamWriter writeFile = new StreamWriter(mydoc + fileName + id.id + ".json"))
            {
                writeFile.WriteLine(StringHelperBiz.jsonConvert(input));
                writeFile.Close();
            }
        }

        public List<MyNum> selectJson()
        {
            LoginInfo id = selectIdJson().Find(x => x.selected == 1);
            List<MyNum> result = new List<MyNum>();
            if (File.Exists(mydoc + fileName + id.id + ".json"))
            {
                string json = File.ReadAllText(mydoc + fileName + id.id + ".json");
                result = JsonConvert.DeserializeObject<List<MyNum>>(json);
            }
            return result;
        }

        public void createIdJson(List<LoginInfo> input)
        {
            using (StreamWriter writeFile = new StreamWriter(mydoc + loginFileName))
            {
                writeFile.WriteLine(StringHelperBiz.jsonConvert(input));
                writeFile.Close();
            }
        }

        public List<LoginInfo> selectIdJson()
        {
            List<LoginInfo> result = new List<LoginInfo>();
            if (File.Exists(mydoc + loginFileName))
            {
                string json = File.ReadAllText(mydoc + loginFileName);
                result = JsonConvert.DeserializeObject<List<LoginInfo>>(json);
            }
            return result;
        }
    }
}
