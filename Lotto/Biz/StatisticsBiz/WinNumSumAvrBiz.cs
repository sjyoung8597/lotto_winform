using Lotto.Model;
using Lotto.Model.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Biz.StatisticsBiz
{
    public class WinNumSumAvrBiz
    {
        public List<WinSumAvgBinding> getTotalSumAvr(string sortBy, string sortAscending)
        {
            List<WinSumAvgBinding> result = new List<WinSumAvgBinding>();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            List<Win> winList = lottoWinBiz.getLottoWinList();
            foreach (Win win in winList)
            {
                WinSumAvgBinding winSumAvgBinding = new WinSumAvgBinding();
                winSumAvgBinding.roundNo = win.round;
                winSumAvgBinding.totalSum = lottoWinBiz.getLottoWinTotalSum(lottoWinBiz.getLottoWinNums(win));
                result.Add(winSumAvgBinding);
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
