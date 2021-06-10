using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model.Statistics
{
    public class WinGradeBinding
    {
        [System.ComponentModel.DisplayName("회차")]
        public int round { get; set; }

        [System.ComponentModel.DisplayName("1등 당첨번호")]
        public string drwtNo { get; set; }

        [System.ComponentModel.DisplayName("보너스번호")]
        public int bnusNo { get; set; }

        [System.ComponentModel.DisplayName("등수")]
        public int grade { get; set; }
    }
}
