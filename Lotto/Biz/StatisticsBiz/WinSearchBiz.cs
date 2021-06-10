using Lotto.Model;
using Lotto.Model.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Biz.StatisticsBiz
{
    public class WinSearchBiz : BaseBiz
    {
        public List<WinGradeBinding> getWinSearch(string win1, string win2, string win3, string win4, string win5, string win6, string sortBy, string sortAscending)
        {
            List<WinGradeBinding> result = new List<WinGradeBinding>();
            if (win1 != "" && win2 != "" && win3 != "" && win4 != "" && win5 != "" && win6 != "")
            {
                MyNumBiz myNumBiz = new MyNumBiz();
                List<int> input = myNumBiz.getMyNums(Convert.ToInt32(win1), Convert.ToInt32(win2), Convert.ToInt32(win3), Convert.ToInt32(win4), Convert.ToInt32(win5), Convert.ToInt32(win6));
                result = getWinSearch(input, sortBy, sortAscending);
            }
            return result;
        }

    

        public List<WinGradeBinding> getWinSearch(List<int> input, string sortBy, string sortAscending)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            MyNumBiz myNumBiz = new MyNumBiz();

            List<Win> winList = lottoWinBiz.getLottoWinList();
            List<WinGradeBinding> result = new List<WinGradeBinding>();

            foreach(Win win in winList)
            {
                int grade = myNumBiz.getWinGrade(win, input);
                if (grade > 0)
                {
                    WinGradeBinding winGrade = new WinGradeBinding();
                    winGrade.round = win.round;
                    winGrade.grade = grade;
                    winGrade.drwtNo = StringHelperBiz.getWinNums(win);
                    winGrade.bnusNo = win.bnusNo;

                    result.Add(winGrade);
                }
            }
            if (sortBy != "")
            {
                result = sortAscending == "ASC" ?
                    result.OrderBy(r => r.GetType().GetProperty(sortBy).GetValue(r, null)).ToList() :
                    result.OrderByDescending(r => r.GetType().GetProperty(sortBy).GetValue(r, null)).ToList();
            }
            return result;
        }
    }
}
