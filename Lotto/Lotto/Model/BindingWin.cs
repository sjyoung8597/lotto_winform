using Lotto.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Model
{
    public class BindingWin
    {
        [System.ComponentModel.DisplayName("회차")]
        public int round { get; set; }

        [System.ComponentModel.DisplayName("당첨번호")]
        public string drwtNo { get; set; }

        [System.ComponentModel.DisplayName("보너스번호")]
        public int bnusNo { get; set; }

        //1등 1명당 당첨금액
        [System.ComponentModel.DisplayName("1등당첨액")]
        public string firstWinamnt { get; set; }

        //총 판매액
        [System.ComponentModel.DisplayName("1등실수령액")]
        public string firstWinTexamnt { get; set; }

        //1등 당첨 총 금액
        [System.ComponentModel.DisplayName("1등총당첨액")]
        public string firstAccumamnt { get; set; }

        //총 판매액
        [System.ComponentModel.DisplayName("총판매액")]
        public string totSellamnt { get; set; }

        //1등 당첨자 수
        [System.ComponentModel.DisplayName("당첨자수")]
        public int firstPrzwnerCo { get; set; }

        //추첨일자
        [System.ComponentModel.DisplayName("추첨일")]
        public string drwNoDate { get; set; }

    }
}
