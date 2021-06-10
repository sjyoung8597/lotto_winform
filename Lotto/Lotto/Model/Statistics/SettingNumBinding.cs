using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model.Statistics
{
    public class SettingNumBinding
    {
        [System.ComponentModel.DisplayName("회차")]
        public int round { get; set; }

        [System.ComponentModel.DisplayName("당첨번호")]
        public string drwtNo { get; set; }

        [System.ComponentModel.DisplayName("개수")]
        public int count { get; set; }

        public SettingNumBinding(int round, string drwtNo, int count)
        { 
            this.round = round;
            this.drwtNo = drwtNo;
            this.count = count;
        }
    }
}
