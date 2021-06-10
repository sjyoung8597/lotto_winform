using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Biz
{
    public class DateBiz
    {
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

        public bool updateLastWeek(DateTime winRoundTime)
        {
            DateTime currentTime = DateTime.Now;
            DateTime afterOneWeekTime = winRoundTime.AddDays(7); //저장된 마지막 데이터에서 7일 후

            if (currentTime > afterOneWeekTime)
            {
                return true;
            }

            return false;
        }
    }
}
