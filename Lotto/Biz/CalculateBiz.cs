using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lotto.Model;
using System.Collections;

namespace Lotto.Biz
{
    public class CalculateBiz
    {
        private const int WIN_NUM_CNT = 6;
        private const int LOTTO_END_NO = 45;

        public List<int> randomWinNum()
        {
            List<int> winNum = new List<int>();

            Random random = new Random();

            for (int i = 0; i < WIN_NUM_CNT; i++)
            {
                winNum.Add(random.Next(1, LOTTO_END_NO + 1));
                for (int j = 0; j < i; j++)
                {
                    if (winNum[i] == winNum[j])
                    {
                        i--;
                        winNum.Remove(winNum[j]);
                    }
                }

            }
            winNum.Sort();

            return winNum;
        }

        public bool firstWinner(List<int> randomWinNum) 
        {
            FileBiz fileBiz = new FileBiz();
            string[] lines = fileBiz.readText();
            if (lines != null)
            {
                foreach(string line in lines)
                {
                    string[] convertLine = line.Split(',');

                    if (randomWinNum[0] == Convert.ToInt32(convertLine[1]) && randomWinNum[1] == Convert.ToInt32(convertLine[2]) &&
                        randomWinNum[2] == Convert.ToInt32(convertLine[3]) && randomWinNum[3] == Convert.ToInt32(convertLine[4]) &&
                        randomWinNum[4] == Convert.ToInt32(convertLine[5]) && randomWinNum[5] == Convert.ToInt32(convertLine[6]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Win> getAllThirdWin(int roundNo)
        {
            List<Win> result = new List<Win>();
            FileBiz fileBiz = new FileBiz();
            
            string line = fileBiz.readText()[roundNo-1];
            string[] convertLine = line.Split(',');

            for (int lottoNo = 1; lottoNo <= LOTTO_END_NO; lottoNo++ )
            {
                for (int winCount = 1; winCount <= WIN_NUM_CNT; winCount++)
                {
                    string[] checkLine = { convertLine[0], convertLine[1], convertLine[2], convertLine[3], convertLine[4], convertLine[5], convertLine[6]};
                    checkLine[winCount] = Convert.ToString(lottoNo);
                    if (checkDuplicationWinNo(checkLine))
                    {
                        List<int> winNums = Util.convertToIntList(checkLine);
                        Win win = new Win(roundNo, winNums, 3);
                        result.Add(win);
                    }
                }
            }
            return result;
        }

        public List<Win> getAllSecondWin(int roundNo)
        {
            List<Win> result = new List<Win>();
            FileBiz fileBiz = new FileBiz();

            string line = fileBiz.readText()[roundNo - 1];
            string[] convertLine = line.Split(',');

            for (int winCount = 1; winCount <= WIN_NUM_CNT; winCount++)
            {
                string[] checkLine = { convertLine[0], convertLine[1], convertLine[2], convertLine[3], convertLine[4], convertLine[5], convertLine[6] };
                checkLine[winCount] = convertLine[7];
                List<int> winNums = Util.convertToIntList(checkLine);
                Win win = new Win(roundNo, winNums, 2);
                result.Add(win);
            }
            
            return result;
        }



        public bool checkDuplicationWinNo(string[] lines)
        {
            ArrayList ar = new ArrayList();
            foreach (string line in lines) 
            {
                if (!ar.Contains(line)) 
                {
                    ar.Add(line);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
