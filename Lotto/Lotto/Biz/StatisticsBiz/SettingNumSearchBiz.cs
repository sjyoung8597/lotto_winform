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
    public class SettingNumSearchBiz
    {
        public List<SettingNumBinding> getSettingNumStatistics(int startNum, int endNum, int selectCount, string sortBy, string sortAscending)
        {
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            List<Win> winList = lottoWinFacade.getLottoWinList();
            List<SettingNumBinding> result = new List<SettingNumBinding>();
            
            for(int index = 0; index < winList.Count; index++)
            {
                Win win = winList[index];
                List<int> winNums = lottoWinBiz.getLottoWinNums(win);
                int checkNo = 0;
                foreach (int num in winNums)
                {
                    if (startNum <= num && endNum >= num)
                    {
                        checkNo++;
                    }
                }
                if(checkNo == selectCount)
                {
                    result.Add(new SettingNumBinding(win.round, StringHelperBiz.getWinNums(winNums), selectCount));
                }
            }
            result.Reverse();
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
