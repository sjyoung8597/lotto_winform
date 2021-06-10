using Lotto.Facade;
using Lotto.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Biz.StatisticsBiz
{
    public class StatisticsBaseBiz : BaseBiz
    {
        private const int TEX_PERCENT = 33;

        public string getTenNumStatistics(int selectCount)
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();    
            string message = "";
            int count = 0;
            for (int round = 1; round <= lottoWinFacade.getLottoWinLast().round; round++)
            {
                int numUnit = checkTenNum(round, selectCount, out count);
                if (numUnit != 0)
                {
                    message += StringHelperBiz.statisticsTen(numUnit, round, count);
                }
            }
            return StringHelperBiz.endStatisticsTen(message);
        }

        

        public int checkTenNum(int roundNo, int selectCount, out int count)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();

            List<int> winNums = lottoWinBiz.getLottoWinNums(roundNo);

            int check10No = 0;
            int check20No = 0;
            int check30No = 0;
            int check40No = 0;
            int check50No = 0;

            foreach (int win in winNums)
            {
                if (win < 10)
                {
                    check10No++;
                }
                else if (win > 9 && win < 20)
                {
                    check20No++;
                }
                else if (win > 19 && win < 30)
                {
                    check30No++;
                }
                else if (win > 29 && win < 40)
                {
                    check40No++;
                }
                else if (win > 39 && win <= 45)
                {
                    check50No++;
                }
            }
            if (check10No >= selectCount)
            {
                count = check10No;
                return 1;
            }
            else if (check20No >= selectCount)
            {
                count = check20No;
                return 2;
            }
            else if (check30No >= selectCount)
            {
                count = check30No;
                return 3;
            }
            else if (check40No >= selectCount)
            {
                count = check40No;
                return 4;
            }
            else if (check50No >= selectCount)
            {
                count = check50No;
                return 5;
            }
            else
            {
                count = 0;
                return 0;
            }
        }

        public List<Win> getAllThirdWin(int roundNo)
        {
            List<Win> result = new List<Win>();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            List<int> winNums = lottoWinBiz.getLottoWinNums(roundNo);

            for (int lottoNo = 1; lottoNo <= LOTTO_END_NO; lottoNo++)
            {
                for (int winCount = 0; winCount < WIN_NUM_CNT; winCount++)
                {
                    List<int> logicWinNums = new List<int>();
                    logicWinNums.AddRange(winNums);
                    logicWinNums[winCount] = lottoNo;
                    if (checkDuplicationWinNo(logicWinNums))
                    {
                        logicWinNums.Sort();
                        Win win = new Win(roundNo, logicWinNums, 3);
                        result.Add(win);
                    }
                }
            }
            return result;
        }

        public List<Win> getAllSecondWin(int roundNo)
        {
            List<Win> result = new List<Win>();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();

            List<int> winNums = lottoWinBiz.getLottoWinNums(roundNo);
            int bnusNo = lottoWinBiz.getLottoWin(roundNo).bnusNo;

            for (int winCount = 0; winCount < WIN_NUM_CNT; winCount++)
            {
                List<int> logicWinNums = new List<int>();
                logicWinNums.AddRange(winNums);
                logicWinNums[winCount] = bnusNo;

                logicWinNums.Sort();
                Win win = new Win(roundNo, logicWinNums, 2);
                result.Add(win);
            }

            return result;
        }

        public bool checkDuplicationWinNo(List<int> lines)
        {
            ArrayList ar = new ArrayList();
            foreach (int line in lines)
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

        public List<Win> getGradeCombination(bool firstCheck, bool secondCheck, bool thirdCheck)
        {
            List<Win> result = new List<Win>();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();

            for (int round = 1; round <= lottoWinBiz.getLottoWinLast().round; round++)
            {
                if(firstCheck)
                {
                    List<Win> firstWinLotto = new List<Win>();
                    firstWinLotto.Add(lottoWinBiz.getLottoWin(round));
                }
                if(secondCheck)
                {
                    List<Win> secondWinLotto = getAllSecondWin(round);
                    result.AddRange(secondWinLotto);
                }
                if(thirdCheck)
                {
                    List<Win> thirdWinLotto = getAllThirdWin(round);
                    result.AddRange(thirdWinLotto);
                }
            }
            return result;
        }

        public long calculatedTex(long price)
        {
            return price - (price / 100 * TEX_PERCENT);
        }
    }

}
