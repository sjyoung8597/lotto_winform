using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model.Statistics
{
    public class OddEvenBinding
    {

        [System.ComponentModel.DisplayName("회차")]
        public int round { get; set; }

        [System.ComponentModel.DisplayName("당첨번호")]
        public string drwtNo { get; set; }

        [System.ComponentModel.DisplayName("홀짝여부")]
        public string oddEven { get; set; }

        [System.ComponentModel.DisplayName("개수")]
        public int count { get; set; }
    }
}
