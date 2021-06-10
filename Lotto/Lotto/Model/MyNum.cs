using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lotto.Model
{
    public class MyNum
    {
        public int idx { get; set; }
        public int round { get; set; }
        public DateTime drwNoDate { get; set; }
        public int drwtNo1 { get; set; }
        public int drwtNo2 { get; set; }
        public int drwtNo3 { get; set; }
        public int drwtNo4 { get; set; }
        public int drwtNo5 { get; set; }
        public int drwtNo6 { get; set; }

        public MyNum() {}

        public MyNum(int idx, int round, List<int> arryData)
        {
            this.idx = idx;
            this.round = round;
            this.drwtNo1 = arryData[0];
            this.drwtNo2 = arryData[1];
            this.drwtNo3 = arryData[2];
            this.drwtNo4 = arryData[3];
            this.drwtNo5 = arryData[4];
            this.drwtNo6 = arryData[5];
            this.drwNoDate = DateTime.Now;
        }
    }
}
