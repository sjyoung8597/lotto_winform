using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.IO;
using Lotto.Model;

namespace Lotto.Biz
{
    public class Util
    {
        public static string stringLine(Win win)
        {
            string line = win.round + "," + win.drwtNo1.ToString() + "," + win.drwtNo2.ToString() + "," + win.drwtNo3.ToString() + ","
                    + win.drwtNo4.ToString() + "," + win.drwtNo5.ToString() + "," + win.drwtNo6.ToString() + "," + win.bnusNo + "," + win.drwNoDate.ToString("yyyy-MM-dd") + ","
                    + win.firstAccumamnt + "," + win.firstPrzwnerCo + "," + win.firstWinamnt + "," + win.totSellamnt;
            return line;
        }

        public static List<int> convertToIntList(string[] dataList)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < dataList.Length; i++)
            {
                if (i == 1 || i == 2 || i == 3 || i == 4 || i == 5 || i == 6)
                {
                    intList.Add(int.Parse(dataList[i]));
                }
            }
            intList.Sort();
            return intList;
        }

        public static bool checkUpdate()
        {
            FileBiz fileBiz = new FileBiz();
            DateBiz dateBiz = new DateBiz();
            string[] lines = fileBiz.readText();
            if (lines != null)
            {
                int lastIndex = lines.Length;
                string[] line = lines[lastIndex - 1].Split(',');
                if (line.Length > 8)
                {
                    DateTime datetime = DateTime.Parse(line[8]);
                    return dateBiz.updateLastWeek(datetime);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        public List<Win> ignoreNum()
        {

            return new List<Win>();
        }
    }
}
