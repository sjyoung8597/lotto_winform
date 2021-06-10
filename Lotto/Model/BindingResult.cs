using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model
{
    public class BindingResult
    {
        [System.ComponentModel.DisplayName("cnt")]
        public int idx { get; set; }
        [System.ComponentModel.DisplayName("1번")]
        public int drwtNo1 { get; set; }
        [System.ComponentModel.DisplayName("2번")]
        public int drwtNo2 { get; set; }
        [System.ComponentModel.DisplayName("3번")]
        public int drwtNo3 { get; set; }
        [System.ComponentModel.DisplayName("4번")]
        public int drwtNo4 { get; set; }
        [System.ComponentModel.DisplayName("5번")]
        public int drwtNo5 { get; set; }
        [System.ComponentModel.DisplayName("6번")]
        public int drwtNo6 { get; set; }

        public BindingResult() { }
        public BindingResult(int idx, int drwtNo1, int drwtNo2, int drwtNo3, int drwtNo4, int drwtNo5, int drwtNo6)
        {
            this.idx = idx;
            this.drwtNo1 = drwtNo1;
            this.drwtNo2 = drwtNo2;
            this.drwtNo3 = drwtNo3;
            this.drwtNo4 = drwtNo4;
            this.drwtNo5 = drwtNo5;
            this.drwtNo6 = drwtNo6;
        }
    }
}
