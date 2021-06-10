using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lotto.Biz;
using Lotto.Facade;
using Lotto.Model;

namespace Lotto
{
    public partial class CYTest : Form
    {
        public CYTest()
        {
            InitializeComponent();
        }

        private void CYTest_Load(object sender, EventArgs e)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            //라인드콤보박스 데이터바인딩
            cb_round_list.DataSource = lottoWinBiz.getBindingWinRoundList();
            //콤보박스 read only
            cb_round_list.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_calcurator_Click(object sender, EventArgs e)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            textBox1.Clear();
         
            string round = StringHelperBiz.getRoundString(cb_round_list.SelectedItem);
            calcuratorX("237");
            //lottoWinBiz.getLottoWinLast()
            //int count = 0;
            //for (int i = 1; i <= lottoWinBiz.getLottoWinLast().round; i++)
            //{
            //    count += calcuratorX(i.ToString());
            //}
            //textBox1.Text = textBox1.Text + " ===총=== " + count;
        }

        private int calcuratorX(string round)
        {
            int n4Round = Convert.ToInt32(round);
            LottoWinFacade lottoWinFacade = new LottoWinFacade();
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            Win win = lottoWinFacade.getLottoWin(n4Round);
            List<int> winNumList = lottoWinBiz.getLottoWinNumsAndBonus(n4Round);
            List<int> xResult = new List<int>();
            List<int> inlusionResult = new List<int>();
            xResult.AddRange(winNumList);
            foreach (int num in winNumList)
            {
                xResult.AddRange(x1((num % 7) == 0 ? (num/7) : (num/7)  + 1, num));
                xResult.AddRange(x2((num % 7) == 0 ? (num / 7) : (num / 7) + 1, num));
                xResult.AddRange(x3((num % 7) == 0 ? (num / 7) : (num / 7) + 1, num));
                xResult.AddRange(x4((num % 7) == 0 ? (num / 7) : (num / 7) + 1, num));
            }
            xResult = xResult.Distinct().ToList();
            xResult.Sort();

            int exemptionCount = xResult.Count;
            int inclusionCount = 45 - exemptionCount;

            for (int i = 1; i <= 45; i++)
            {
                bool check = true;
                foreach (int n in xResult)
                {
                    if(n == i)
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    inlusionResult.Add(i);
                }
            }

            foreach (int n in xResult)
            {
                textBox1.Text = textBox1.Text + ", " + n;
            }

            textBox1.Text = textBox1.Text + "=====" + round + "회===== 제외번호갯수 : " + xResult.Count + "==";
            string text = "";
            foreach (int n in inlusionResult)
            {
                text +=  n + ", " ;
                
            }
            textBox1.Text = textBox1.Text + text;

            Win lastWinRound = lottoWinBiz.getLottoWinLast();
            if (lastWinRound.round >= n4Round + 1)
            {
                int nextRound = n4Round + 1;
                textBox1.Text = textBox1.Text + " 다음회차 : " + nextRound + " 당첨번호 : ";
                text = "";
                int count = 0;
                List<int> nextWinNumList = lottoWinBiz.getLottoWinNums(n4Round + 1);
                foreach (int n in nextWinNumList)
                {
                    foreach (int i in inlusionResult)
                    {
                        if(n == i)
                        {
                            count++;
                        }
                    }
                    text += ", " + n;
                }
                textBox1.Text = textBox1.Text + text + " 발견된 숫자 갯수 : " + count;
                //if(count == 6)
                //{
                //    textBox1.Text = textBox1.Text + " 회차 : " + n4Round;
                //    return 1;
                //}
                
            }
            return 0;
        }

        private List<int> x1(int line, int num)
        {
            int x = num;
            List<int> x1List = new List<int>();
            if (line != 1)
            {
                for (int i = line - 1; i > 0 ; i--) {
                    int start = ((i - 1) * 7) + 1;
                    int end = i * 7;

                    x = x - 8;
                    if(start <= x && end >= x)
                    {
                        if (x <= 45)
                        {
                            x1List.Add(x);
                        }
                    }
                }
            }
            /*foreach (int n in x1List)
            {
                textBox1.Text = textBox1.Text + ", " + n;
            }*/
            return x1List;
        }

        private List<int> x2(int line, int num)
        {
            int x = num;
            List<int> x1List = new List<int>();
            if (line != 1)
            {
                for (int i = line - 1; i > 0; i--)
                {
                    int start = ((i - 1) * 7) + 1;
                    int end = i * 7;

                    x = x - 6;
                    if (start <= x && end >= x)
                    {
                        if (x <= 45)
                        {
                            x1List.Add(x);
                        }
                    }
                }
            }
            return x1List;
        }

        private List<int> x3(int line, int num)
        {
            int x = num;
            List<int> x1List = new List<int>();
            if (line != 7)
            {
                for (int i = line + 1; i < 8; i++)
                {
                    int start = ((i - 1) * 7) + 1;
                    int end = i * 7;

                    x = x + 6;
                    if (start <= x && end >= x)
                    {
                        if (x <= 45)
                        {
                            x1List.Add(x);
                        }
                    }
                }
            }
            
            return x1List;
        }

        private List<int> x4(int line, int num)
        {
            int x = num;
            List<int> x1List = new List<int>();
            if (line != 7)
            {
                for (int i = line + 1; i < 8; i++)
                {
                    int start = ((i - 1) * 7) + 1;
                    int end = i * 7;

                    x = x + 8;
                    if (start <= x && end >= x)
                    {
                        if (x <= 45)
                        {
                            x1List.Add(x);
                        }
                    }
                }
            }
            return x1List;
        }
    }
}
