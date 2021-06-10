using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Model
{
    public class BindingMyNum
    {
        [System.ComponentModel.DisplayName("인덱스")]
        public int idx { get; set; }
        [System.ComponentModel.DisplayName("회차")]
        public int round { get; set; }
        [System.ComponentModel.DisplayName("입력번호")]
        public string drwtNo { get; set; }
        [System.ComponentModel.DisplayName("당첨여부")]
        public string winSuccess { get; set; }
        [System.ComponentModel.DisplayName("입력날짜")]
        public DateTime drwNoDate { get; set; }
    }
}
