using Lotto.Biz.StatisticsBiz;
using Lotto.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lotto.Biz
{
    public class StringHelperBiz
    {
        //object -> json string convert
        public static string jsonConvert(List<Win> winList)
        {
            return JsonConvert.SerializeObject(winList); ;
        }

        public static string jsonConvert(List<LoginInfo> idList)
        {
            return JsonConvert.SerializeObject(idList); ;
        }

        public static string jsonConvert(List<MyNum> myNumList)
        {
            return JsonConvert.SerializeObject(myNumList); ;
        }

        public static string getInputFalse()
        {
            return "입력값이 잘못되었습니다.";
        }

        public static string getWinGrade(int grade, List<int> winNums)
        {
            StringBuilder sb = new StringBuilder();
            if (grade == -1)
            {
                sb.Append("발표 전");
            }
            else if(grade == 0)
            {
                sb.Append("미 당첨");
                sb.Append(getWinNums(winNums));
            }
            else
            {
                sb.Append(grade);
                sb.Append("등 당첨");
                sb.Append(getWinNums(winNums));
            }
            return sb.ToString();
        }

        public static string getWinNums(List<int> winNums)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("(");
            for (int index = 0; index < winNums.Count; index++)
            {
                sb.Append(winNums[index]);
                if (index+1 != winNums.Count)
                {
                    sb.Append(",");
                }
            }
            sb.Append(")");
            return sb.ToString();
        }

        public static string myNumInsertComplete(bool success)
        {
            return success ? "저장 되었습니다." : "올바른 입력값이 아닙니다.";
        }

        public static string endStatisticsOddEven(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(message);
            sb.Append("홀짝 1등 여부는 이 이상 없습니다.\n\r\n\r ");
            return sb.ToString();
        }

        public static string statisticsOddEven(int check)
        {
            string roundMessage = String.Empty;
            StringBuilder sb = new StringBuilder();
            if (check == 1)
            {
                sb.Append("홀수");
            }
            else if (check == 2)
            {
                sb.Append("짝수");
            }
            return sb.ToString();
        }

        public static string endStatisticsTen(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(message);
            sb.Append("10단위 1등 여부는 이 이상 없습니다.\n\r\n\r ");
            return sb.ToString();
        }

        public static string statisticsTen(int numUnit, int round, int count)
        {
            string roundMessage = String.Empty;
            if (numUnit == 1)
                roundMessage = "회 1~9사이 ";
            else if (numUnit == 2)
                roundMessage = "회 10~19사이 ";
            else if (numUnit == 3)
                roundMessage = "회 20~29사이 ";
            else if (numUnit == 4)
                roundMessage = "회 30~39사이 ";
            else if (numUnit == 5)
                roundMessage = "회 40~45사이 ";

            StringBuilder sb = new StringBuilder();
            sb.Append(round);
            sb.Append(roundMessage);
            sb.Append(count);
            sb.Append("개로 당첨입니다.\n\r\n\r");
            return sb.ToString();
        }

        public static string gameResult(List<List<int>> result)
        {
            StringBuilder sb = new StringBuilder();
            foreach (List<int> winNumList in result)
            {
                foreach(int num in winNumList)
                {
                    sb.Append(num);
                    sb.Append(" ");
                }
                sb.Append("\n\r\n\r");
            }
            return sb.ToString();
        }

        public static string updateText()
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            StringBuilder sb = new StringBuilder();
            Win fileLastWin = lottoWinBiz.getLottoWinLast();
            if (lottoWinBiz.isExpireLottoWin())
            {
                sb.Append("마지막업데이트: ");
                sb.Append(fileLastWin.drwNoDate.ToShortDateString());
                sb.Append(" ");
                sb.Append(fileLastWin.round);
                sb.Append("회");
            }
            return sb.ToString();
        }

        public static string allWinText(Win win)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(win.round);
            sb.Append("회 당첨번호 ");
            sb.Append(win.drwtNo1);
            sb.Append(",");
            sb.Append(win.drwtNo2);
            sb.Append(",");
            sb.Append(win.drwtNo3);
            sb.Append(",");
            sb.Append(win.drwtNo4);
            sb.Append(",");
            sb.Append(win.drwtNo5);
            sb.Append(",");
            sb.Append(win.drwtNo6);
            sb.Append(" 보너스 ");
            sb.Append(win.bnusNo);
            sb.Append("\r\n");
            sb.Append("총 판매액 ");
            sb.Append(String.Format("{0:#,###}", Convert.ToInt64(win.totSellamnt)));
            sb.Append("원,  1등 당첨 총 금액");
            sb.Append(String.Format("{0:#,###}", Convert.ToInt64(win.firstAccumamnt)));
            sb.Append("원\r\n당첨자수 ");
            sb.Append(win.firstPrzwnerCo);
            sb.Append("명 1인 당첨금액 ");
            sb.Append(String.Format("{0:#,###}", Convert.ToInt64(win.firstWinamnt)));
            sb.Append("원\r\n\r\n");

            return sb.ToString();
        }

        public static string getWinNums(Win win)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(win.drwtNo1);
            sb.Append(",");
            sb.Append(win.drwtNo2);
            sb.Append(",");
            sb.Append(win.drwtNo3);
            sb.Append(",");
            sb.Append(win.drwtNo4);
            sb.Append(",");
            sb.Append(win.drwtNo5);
            sb.Append(",");
            sb.Append(win.drwtNo6);
            return sb.ToString();
        }

        public static string getWinNums(MyNum win)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(win.drwtNo1);
            sb.Append(",");
            sb.Append(win.drwtNo2);
            sb.Append(",");
            sb.Append(win.drwtNo3);
            sb.Append(",");
            sb.Append(win.drwtNo4);
            sb.Append(",");
            sb.Append(win.drwtNo5);
            sb.Append(",");
            sb.Append(win.drwtNo6);
            return sb.ToString();
        }

        public static BindingWin bindingWin(Win win)
        {
            BindingWin result = new BindingWin();
            StatisticsBaseBiz statisticsBiz = new StatisticsBaseBiz();
            result.round = win.round;
            result.drwtNo = StringHelperBiz.getWinNums(win);
            result.bnusNo = win.bnusNo;
            result.firstWinTexamnt = stringWON(win.firstWinTexamnt);
            result.firstAccumamnt = stringWON(win.firstAccumamnt);
            result.firstPrzwnerCo = win.firstPrzwnerCo;
            result.totSellamnt = stringWON(win.totSellamnt);
            result.firstWinamnt = stringWON(win.firstWinamnt);
            result.drwNoDate = win.drwNoDate.ToString("yy-MM-dd");
            return result;
        }

        public static BindingMyNum bindingMyNum(MyNum myNum)
        {
            BindingMyNum result = new BindingMyNum();
            result.idx = myNum.idx;
            result.round = myNum.round;
            result.drwtNo = StringHelperBiz.getWinNums(myNum);
            result.drwNoDate = myNum.drwNoDate;
            return result;
        }

        public static string stringWON(long num)
        {
            return num > 0 ? String.Format("{0:#,###}", Convert.ToInt64(num)) + "원" : "";
        }

        public static string searchUrl(object round)
        {
            //네이버 검색 url
            string searchUrl = Properties.Settings.Default.SearchLottoWinUrl;
            StringBuilder sb = new StringBuilder();
            sb.Append(searchUrl);
            sb.Append(getRoundString(round));
            sb.Append("lotto");

            return sb.ToString();
        }

        public static string getRoundString(object round)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(round);
            return sb.ToString();
        }

        public static string limitCheckBox(int count)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("최대 ");
            sb.Append(count);
            sb.Append("개 까지 설정 가능합니다.");
            return sb.ToString();
        }

        public static int regexOnlyNum(string str)
        {
            return Convert.ToInt32(Regex.Replace(str, @"\D", ""));
        }
    }
}
