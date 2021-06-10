using Lotto.Biz;
using Lotto.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Lotto.Repository
{
    public class LottoJsonRepository
    {
        private string fileName = @"\LOTTO_WIN.json";
        private string mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void createLottoJson(List<Win> input)
        {
            using (StreamWriter writeFile = new StreamWriter(mydoc + fileName))
            {
                writeFile.WriteLine(StringHelperBiz.jsonConvert(input));
                writeFile.Close();
            }
        }

        public List<Win> selectLottoJson()
        {
            List<Win> result = new List<Win>();
            if (File.Exists(mydoc + fileName))
            {
                string json = File.ReadAllText(mydoc + fileName);
                result = JsonConvert.DeserializeObject<List<Win>>(json);
            }
            return result;
        }
    }
}
