using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model.Statistics
{
    public class WinSumAvgBinding
    {
        [System.ComponentModel.DisplayName("당첨회차")]
        public int roundNo { get; set; }

        [System.ComponentModel.DisplayName("총 합계")]
        public int totalSum { get; set; }
    }
}
