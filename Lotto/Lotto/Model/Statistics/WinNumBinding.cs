using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model.Statistics
{
    public class WinNumBinding
    {
        [System.ComponentModel.DisplayName("당첨번호")]
        public int drwtNo { get; set; }

        [System.ComponentModel.DisplayName("당첨출현횟수")]
        public int lottoCount { get; set; }

        [System.ComponentModel.DisplayName("보너스출현횟수")]
        public int bnusCount { get; set; }

        [System.ComponentModel.DisplayName("전체출현횟수")]
        public int allCount { get; set; }

        [System.ComponentModel.DisplayName("최근출현회차")]
        public int lottoRound { get; set; }
        [System.ComponentModel.DisplayName("보너스최근출현회차")]
        public int bnusRound { get; set; }
    }
}
