using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using Lotto.Model;

namespace Lotto.Biz
{
    public class FileBiz
    {
        private static string DEFAULT_DATA_FILE_NAME = @"\lotto_win_Info.txt";
        //파일 쓰기
        public void writeText(List<Win> winList)
        {
            string mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using(StreamWriter writeFile = new StreamWriter(mydoc + DEFAULT_DATA_FILE_NAME))
            {
                foreach (var line in winList)
                {
                    writeFile.WriteLine(Util.stringLine(line));
                    //writeFile.WriteLine(StringHelperBiz.jsonConvert(winList));

                }
                writeFile.Close();
            }
        }

        public void writeText()
        {
            string mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(mydoc + DEFAULT_DATA_FILE_NAME))
            {
                outputFile.WriteLine(String.Empty);
                outputFile.Close();
            }
        }

        //파일 전체 읽기
        public string[] readText()
        {
            
            string mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] lines = null;
            if (File.Exists(mydoc + DEFAULT_DATA_FILE_NAME))
            {
                lines = File.ReadAllLines(mydoc + DEFAULT_DATA_FILE_NAME);
            }
            return lines;
        }


    }
}
