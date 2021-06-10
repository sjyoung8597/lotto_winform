using Lotto.Facade;
using Lotto.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Lotto.Biz
{
    public class LottoWinBiz : BaseBiz
    {
        /// <summary>
        /// json get last lotto 
        /// </summary>
        /// <returns></returns>
        public Win getLottoWinLast()
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            return lottoWinFacade.getLottoWinLast();
        }

        /// <summary>
        /// json set lotto
        /// </summary>
        /// <param name="input"></param>
        public void setLottoWinList(List<Win> input)
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            lottoWinFacade.setLottoWinList(input);
        }

        /// <summary>
        /// json get lotto list
        /// </summary>
        /// <returns></returns>
        public List<Win> getLottoWinList()
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            List<Win> winList = lottoWinFacade.getLottoWinList();
            List<Win> result = new List<Win>();
            foreach (Win win in winList)
            {
                win.firstWinTexamnt = win.firstWinamnt - (win.firstWinamnt / 100 * 33);
                result.Add(win);
            }
            return result;
        }

        /// <summary>
        /// json get round lotto
        /// </summary>
        /// <param name="round"></param>
        /// <returns></returns>
        public Win getLottoWin(int round)
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            return lottoWinFacade.getLottoWin(round);
        }

        /// <summary>
        /// drwtNo int list
        /// </summary>
        /// <param name="round"></param>
        /// <returns></returns>
        public List<int> getLottoWinNums(int round)
        {
            Win win = getLottoWin(round);
            List<int> result = new List<int>();
            result.Add(win.drwtNo1);
            result.Add(win.drwtNo2);
            result.Add(win.drwtNo3);
            result.Add(win.drwtNo4);
            result.Add(win.drwtNo5);
            result.Add(win.drwtNo6);
            return result;
        }

        public List<int> getLottoWinNumsAndBonus(int round)
        {
            Win win = getLottoWin(round);
            List<int> result = new List<int>();
            result.Add(win.drwtNo1);
            result.Add(win.drwtNo2);
            result.Add(win.drwtNo3);
            result.Add(win.drwtNo4);
            result.Add(win.drwtNo5);
            result.Add(win.drwtNo6);
            result.Add(win.bnusNo);
            return result;
        }

        public List<int> getLottoWinNums(Win win)
        {
            List<int> result = new List<int>();
            result.Add(win.drwtNo1);
            result.Add(win.drwtNo2);
            result.Add(win.drwtNo3);
            result.Add(win.drwtNo4);
            result.Add(win.drwtNo5);
            result.Add(win.drwtNo6);
            return result;
        }

        public int getLottoWinTotalSum(List<int> winNo)
        {
            int result = 0;
            foreach (int no in winNo)
            {
                result += no;
            }
            return result;
        }

        /// <summary>
        /// json file expire
        /// </summary>
        /// <returns></returns>
        public bool isExpireLottoWin()
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            if (lottoWinFacade.getLottoWinLast() == null)
            {
                return false;
            }
            return true;
        }

        public bool isUpdate()
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            Win lastWin = lottoWinFacade.getLottoWinLast();
            if(lastWin != null)
            {
                return updateLastWeek(lastWin.drwNoDate);
            }
            else
            {
                return true;
            }
            
        }

        public bool updateLastWeek(DateTime winRoundTime)
        {
            DateTime currentTime = DateTime.Now;
            DateTime afterOneWeekTime = winRoundTime.AddDays(7).AddHours(21); //저장된 마지막 데이터에서 7일 후

            if (currentTime > afterOneWeekTime)
            {
                return true;
            }
            if(currentTime == afterOneWeekTime)
            {
                if(currentTime.Hour > 9)
                {
                    return true;
                }
            }

            return false;
        }

        public bool lastWeek(DateTime winRoundTime)
        {
            DateTime currentTime = DateTime.Now;
            DateTime beforOneWeekTime = DateTime.Now.AddDays(-7); //현재시간에서 1주일전
            if (currentTime > winRoundTime)
            {
                if (winRoundTime >= beforOneWeekTime)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public List<BindingWin> getBindingWinList(string sortBy, string sortAscending)
        {
            List<BindingWin> result = new List<BindingWin>();
            List<Win> winList = getWinListSorting(sortBy, sortAscending);

            foreach (Win win in winList)
            {
                result.Add(StringHelperBiz.bindingWin(win));
            }
            return result;
        }

        public List<Win> getWinListSorting(string sortBy, string sortAscending)
        {
            List<Win> result = getLottoWinList();

            if (sortAscending == "ASC")
            {
                result = result
                       .OrderBy(r => r.GetType().GetProperty(sortBy).GetValue(r, null))
                       .ToList();
            }
            if (sortAscending == "DESC")
            {
                result = result
                       .OrderByDescending(r => r.GetType().GetProperty(sortBy).GetValue(r, null))
                       .ToList();
            }
            return result;
        }

        public List<int> getBindingWinRoundList()
        {
            List<int> result = new List<int>();
            List<Win> winList = getLottoWinList();
            winList.Reverse();
            foreach (Win win in winList)
            {
                result.Add(win.round);
            }
            return result;
        }
    }
}
