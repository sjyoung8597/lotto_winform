using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lotto.Model
{
    public class Win
    {
        public int round { get; set; }
        //읽기 성공 여부 success , fail
        public string returnValue  { get; set; }
        //추첨일자
        public DateTime drwNoDate { get; set; }
        public int drwtNo1 { get; set; }
        public int drwtNo2 { get; set; }
        public int drwtNo3 { get; set; }
        public int drwtNo4 { get; set; }
        public int drwtNo5 { get; set; }
        public int drwtNo6 { get; set; }
        public int bnusNo { get; set; }
        //총 판매액
        public long totSellamnt { get; set; }
        //1등 당첨 총 금액
        public long firstAccumamnt { get; set; }
        //1등 당첨자 수
        public int firstPrzwnerCo { get; set; }
        //1등 1명당 당첨금액}
        public long firstWinamnt { get; set; }

        public int grade { get; set; }
        
        //1등 실수령액
        public long firstWinTexamnt { get; set; }

        public Win() { }

        public Win(string returnValue, int round,  DateTime drwNoDate, int drwtNo1, int drwtNo2, int drwtNo3, int drwtNo4, int drwtNo5, int drwtNo6, 
            int bnusNo, long totSellamnt, long firstAccumamnt, int firstPrzwnerCo, long firstWinamnt)
        {
            this.round = round;
            this.returnValue = returnValue;
            this.drwNoDate = drwNoDate;
            this.drwtNo1 = drwtNo1;
            this.drwtNo2 = drwtNo2;
            this.drwtNo3 = drwtNo3;
            this.drwtNo4 = drwtNo4;
            this.drwtNo5 = drwtNo5;
            this.drwtNo6 = drwtNo6;
            this.bnusNo = bnusNo;
            this.totSellamnt = totSellamnt;
            this.firstAccumamnt = firstAccumamnt;
            this.firstPrzwnerCo = firstPrzwnerCo;
            this.firstWinamnt = firstWinamnt;
        }

        public Win(int round, int drwtNo1, int drwtNo2, int drwtNo3, int drwtNo4, int drwtNo5, int drwtNo6)
        {
            this.round = round;
            this.drwtNo1 = drwtNo1;
            this.drwtNo2 = drwtNo2;
            this.drwtNo3 = drwtNo3;
            this.drwtNo4 = drwtNo4;
            this.drwtNo5 = drwtNo5;
            this.drwtNo6 = drwtNo6;
        }

        public Win(int round, int drwtNo1, int drwtNo2, int drwtNo3, int drwtNo4, int drwtNo5, int drwtNo6, int bnusNo)
        {
            this.round = round;
            this.drwtNo1 = drwtNo1;
            this.drwtNo2 = drwtNo2;
            this.drwtNo3 = drwtNo3;
            this.drwtNo4 = drwtNo4;
            this.drwtNo5 = drwtNo5;
            this.drwtNo6 = drwtNo6;
            this.bnusNo = bnusNo;
        }

        public Win(int round, List<int> arryData)
        {
            this.round = round;
            this.drwtNo1 = arryData[0];
            this.drwtNo2 = arryData[1];
            this.drwtNo3 = arryData[2];
            this.drwtNo4 = arryData[3];
            this.drwtNo5 = arryData[4];
            this.drwtNo6 = arryData[5];
        }

        public Win(int round, List<int> arryData, int grade)
        {
            this.round = round;
            this.drwtNo1 = arryData[0];
            this.drwtNo2 = arryData[1];
            this.drwtNo3 = arryData[2];
            this.drwtNo4 = arryData[3];
            this.drwtNo5 = arryData[4];
            this.drwtNo6 = arryData[5];
            this.grade = grade;
        }

        public string getAllWinText()
        {
            return round+ "회 당첨번호 "+ drwtNo1 + "," + drwtNo2 + "," + drwtNo3 + "," + drwtNo4 + "," + drwtNo5 + "," + drwtNo6
                + " 보너스 " + bnusNo + "\r\n" + "총 판매액 " + totSellamnt + ",  1등 당첨 총 금액"  + firstAccumamnt + "원,  당첨자수 " + firstPrzwnerCo + "\r\n"
                + "1인 당첨금액 " + firstWinamnt;
        }

    }
}
