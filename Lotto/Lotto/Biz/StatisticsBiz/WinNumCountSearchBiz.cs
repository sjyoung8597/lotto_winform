using Lotto.Facade;
using Lotto.Model;
using Lotto.Model.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Biz.StatisticsBiz
{
    public class WinNumCountSearchBiz : BaseBiz
    {
        public List<WinNumBinding> getWinNumCountSearch(string sortBy, string sortAscending)
        {
            //로또번호별 카운트
            int[] lottoNoCount = new int[LOTTO_END_NO + 1];
            //보너스번호별 카운트
            int[] bnusNoCount = new int[LOTTO_END_NO + 1];
            //마지막 출현 라운드 정보
            int[] latestRound = new int[LOTTO_END_NO + 1];
            //마지막 출현 라운드 정보
            int[] bnuslatestRound = new int[LOTTO_END_NO + 1];
            //전체번호별 카운트
            int[] allCount = new int[LOTTO_END_NO + 1];

            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            List<Win> winList = lottoWinFacade.getLottoWinList();
            List<WinNumBinding> result = new List<WinNumBinding>();
            for (int index = 0; index < winList.Count; index++)
            {
                Win win = winList[index];
                List<int> winNums = lottoWinBiz.getLottoWinNums(win);
                foreach (int num in winNums)
                {
                    lottoNoCount[num] = lottoNoCount[num] + 1;
                    latestRound[num] = win.round;
                    allCount[num] = allCount[num] + 1;
                }
                bnusNoCount[win.bnusNo] = bnusNoCount[win.bnusNo] + 1;
                bnuslatestRound[win.bnusNo] = win.round;
                allCount[win.bnusNo] = allCount[win.bnusNo] + 1;
            }

            for(int index = 1; index <= LOTTO_END_NO; index++)
            {
                WinNumBinding winNumBinding = new WinNumBinding();
                winNumBinding.allCount = allCount[index];
                winNumBinding.bnusCount = bnusNoCount[index];
                winNumBinding.bnusRound = bnuslatestRound[index];
                winNumBinding.drwtNo = index;
                winNumBinding.lottoCount = lottoNoCount[index];
                winNumBinding.lottoRound = latestRound[index];
                result.Add(winNumBinding);
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
