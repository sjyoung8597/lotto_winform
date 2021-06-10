using Lotto.Biz.StatisticsBiz;
using Lotto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Biz
{
    public class LottoBiz : BaseBiz
    {
        public List<int> lottoCreate(bool premiumCheck, int randomCount, List<int> randomRangeList, List<int> addNumList, List<Win> combinationList)
        {
            bool failRandom = true;
            List<int> randomWinList = new List<int>();
            int checkCount = 0;

            while (failRandom)
            {
                randomWinList = randomWinNum(randomRangeList, randomCount);
                randomWinList.AddRange(addNumList);
                randomWinList.Sort();

                if (premiumCheck)
                {
                    foreach (Win win in combinationList)
                    {
                        if (randomWinList[0] == win.drwtNo1 && randomWinList[1] == win.drwtNo2 &&
                        randomWinList[2] == win.drwtNo3 && randomWinList[3] == win.drwtNo4 &&
                        randomWinList[4] == win.drwtNo5 && randomWinList[5] == win.drwtNo6)
                        {
                            checkCount++;
                        }
                    }
                }
                else
                {
                    failRandom = false;
                }
                if(checkCount == 0)
                {
                    failRandom = false;
                }
            }

            return randomWinList;
        }

        public List<BindingResult> lottoCreateList(bool premiumCheck, int randomCount, List<int> randomRangeList, List<int> addNumList, int createCount)
        {
            StatisticsBaseBiz statisticsBiz = new StatisticsBaseBiz();
            MyNumBiz myNumBiz = new MyNumBiz();
            List<BindingResult> result = new List<BindingResult>(); 

            //List<List<int>> result = new List<List<int>>();
            List<Win> combinationList = new List<Win>();

            if (premiumCheck)
            {
                combinationList = statisticsBiz.getGradeCombination(true, true, true);
                //randomRangeList = removeRangeList(randomRangeList, randomWinNum());
                combinationList.AddRange(myNumBiz.getConvertMyNumList());
            }
            for (int index = 0; index < createCount; index++)
            {
                List<int> winNumList = lottoCreate(premiumCheck, randomCount, randomRangeList, addNumList, combinationList);
                result.Add(new BindingResult(index + 1, winNumList[0], winNumList[1], winNumList[2], winNumList[3], winNumList[4], winNumList[5]));
            }
            return result;
        }

        public List<TestBindingResult> testLottoCreateList(bool premiumCheck, int randomCount, List<int> randomRangeList, List<int> addNumList, int createCount)
        {
            StatisticsBaseBiz statisticsBiz = new StatisticsBaseBiz();
            MyNumBiz myNumBiz = new MyNumBiz();
            List<TestBindingResult> result = new List<TestBindingResult>();

            //List<List<int>> result = new List<List<int>>();
            List<Win> combinationList = new List<Win>();

            if (premiumCheck)
            {
                combinationList = statisticsBiz.getGradeCombination(true, true, true);
                //randomRangeList = removeRangeList(randomRangeList, randomWinNum());
                combinationList.AddRange(myNumBiz.getConvertMyNumList());
            }
            for (int index = 0; index < createCount; index++)
            {
                List<int> winNumList = lottoCreate(premiumCheck, randomCount, randomRangeList, addNumList, combinationList);
                result.Add(new TestBindingResult(index + 1, winNumList[0], winNumList[1], winNumList[2], winNumList[3], winNumList[4], winNumList[5]));
            }
            return result;
        }

        public List<int> removeRangeList(List<int> rangeList, List<int> removeList)
        {
            List<int> result = new List<int>(rangeList);
            foreach (int range in rangeList)
            {
                foreach(int remove in removeList)
                {
                    if(range == remove)
                    {
                        result.Remove(range);
                    }
                }
            }
            return result;
        }

        public List<int> randomWinNum(List<int> randomRangeList, int count)
        {
            List<int> winNum = new List<int>();

            for (int index = 0; index < count; index++)
            {
                winNum.Add(RandomNumBiz.GenerateRandom(0, randomRangeList));
                for (int j = 0; j < index; j++)
                {
                    if (winNum[index] == winNum[j])
                    {
                        index--;
                        winNum.Remove(winNum[j]);
                    }
                }
            }
            winNum.Sort();

            return winNum;
        }

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
    }
}
