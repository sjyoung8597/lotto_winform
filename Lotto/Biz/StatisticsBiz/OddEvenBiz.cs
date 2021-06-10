using Lotto.Facade;
using Lotto.Model.Statistics;
using Lotto.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Biz.StatisticsBiz
{
    public class OddEvenBiz
    {
        public List<OddEvenBinding> getOddEvenStatistics(OddEvenType oddEvenType, int count)
        {
            List<OddEvenWin> oddEvenWinList = getOddEventList();
            List<OddEvenBinding> result = new List<OddEvenBinding>();

            foreach (OddEvenWin oddEvenWin in oddEvenWinList)
            {
                if((int)oddEvenType == 1 && oddEvenWin.oddCount == count)
                {
                    result.Add(new OddEvenBinding()
                    {
                        drwtNo = StringHelperBiz.getWinNums(oddEvenWin.drwtNo),
                        round = oddEvenWin.round,
                        count = oddEvenWin.oddCount,
                        oddEven = StringHelperBiz.statisticsOddEven((int) oddEvenType)
                    });
                }
                else if((int)oddEvenType == 2 && oddEvenWin.eventCount == count)
                {
                    result.Add(new OddEvenBinding()
                    {
                        drwtNo = StringHelperBiz.getWinNums(oddEvenWin.drwtNo),
                        round = oddEvenWin.round,
                        count = oddEvenWin.eventCount,
                        oddEven = StringHelperBiz.statisticsOddEven((int)oddEvenType)
                    });
                }
                #region 전체로직
                //else if(oddEvenWin.oddCount == count && oddEvenWin.eventCount == count)
                //{
                //    result.Add(new OddEvenBinding()
                //    {
                //        idx = idx++,
                //        drwtNo = StringHelperBiz.getWinNums(oddEvenWin.drwtNo),
                //        round = oddEvenWin.round,
                //        count = oddEvenWin.eventCount == count ? oddEvenWin.eventCount : oddEvenWin.oddCount,
                //        oddEven = StringHelperBiz.statisticsOddEven(oddEvenWin.oddCount == count ? 1:2)
                //    });
                //}
                #endregion
            }
            result.Reverse();
            return result;
        }

        public List<OddEvenWin> getOddEventList()
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            List<OddEvenWin> result = new List<OddEvenWin>();
            for (int round = 1; round <= lottoWinFacade.getLottoWinLast().round; round++)
            {
                result.Add(checkGetOddEvenWin(round));
            }
            return result;
        }

        public OddEvenWin checkGetOddEvenWin(int roundNo)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            List<int> winNums = lottoWinBiz.getLottoWinNums(roundNo);
            OddEvenWin result = new OddEvenWin(winNums);
            int odd = 0;
            int even = 0;
            foreach (int win in winNums)
            {
                if (win % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            result.oddCount = odd;
            result.eventCount = even;
            result.round = roundNo;

            return result;
        }
    }
}
