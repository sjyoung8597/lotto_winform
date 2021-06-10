using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model.Statistics
{
    public class OddEvenWin
    {
        public int drwtNo1 { get; set; }
        public int drwtNo2 { get; set; }
        public int drwtNo3 { get; set; }
        public int drwtNo4 { get; set; }
        public int drwtNo5 { get; set; }
        public int drwtNo6 { get; set; }
        public int round { get; set; }
        public List<int> drwtNo { get; set; }

        public int oddCount { get; set; }
        public int eventCount { get; set; }

        public OddEvenWin() { }

        public OddEvenWin(List<int> drwtNo)
        {
            this.drwtNo = drwtNo;
        }
    }
}
