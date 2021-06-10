using Lotto.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class CreateLottoNum : Form
    {
        private const int DEFAULT_LOTTO_COUNT = 45;
        private const int ROW_COUNT = 10;
        private const int X_PLUS_VALUE = 40;
        private const int Y_PLUS_VALUE = 20;

        private const int LIMIT_ADD_CHECK_COUNT = 4;
        private const int LIMIT_DEL_CHECK_COUNT = 36;

        public CreateLottoNum()
        {
            InitializeComponent();
        }

        private void checkProbability(int add, int del)
        {
            //1등확률
            ulong winProbability = factorial(45, 6);
            ulong a = factorial(45 - (ulong)add - (ulong)del, 6 - (ulong)add);
            ulong b = factorial(6 - (ulong)add, 6 - (ulong)add);
            ulong c = a / b;
            double d = (winProbability / 720) / c;
            double e = 100.0 / (winProbability / 720);
            lb_probability.Text = (winProbability/720).ToString();
            lb_probability2.Text = d.ToString() + " 배 1등당첨 확률이 늘었습니다.";
            lb_probability3.Text = e.ToString() + "%";
        }

        private static ulong factorial(ulong num, ulong size)
        {
            ulong result = num;
            for (ulong i = 1; i < size; i++)
            {
                if (num != i)
                {
                    result = result * (num - i);
                }
            }

            if (result == 0) result = 1;

            return result;
        }

        private void ckb_CheckedChanged(object sender, EventArgs e)
        {
            
            CheckBox[] addCheckBoxList = new CheckBox[DEFAULT_LOTTO_COUNT];
            CheckBox[] delCheckBoxList = new CheckBox[DEFAULT_LOTTO_COUNT];

            string ctrlName = ((Control)sender).Name;
            int addCount = 0;
            int delCount = 0;

            for (int index = 0; index < DEFAULT_LOTTO_COUNT; index++)
            {
                addCheckBoxList[index] = gb_add.Controls["ckb_add_" + index] as CheckBox;
                delCheckBoxList[index] = gb_del.Controls["ckb_del_" + index] as CheckBox;
                
                if(addCheckBoxList[index].Checked)
                {
                    if (addCount >= LIMIT_ADD_CHECK_COUNT)
                    {
                        CheckBox selectCheckBox = gb_add.Controls[ctrlName] as CheckBox;
                        selectCheckBox.Checked = false;
                        MessageBox.Show(StringHelperBiz.limitCheckBox(LIMIT_ADD_CHECK_COUNT));
                        return;
                    }
                    delCheckBoxList[index].Checked = false;
                    delCheckBoxList[index].Enabled = false;
                    addCount++;
                }
                else if(!addCheckBoxList[index].Checked)
                {
                    delCheckBoxList[index].Enabled = true;
                }

                if (delCheckBoxList[index].Checked)
                {
                    if (delCount >= LIMIT_DEL_CHECK_COUNT)
                    {
                        CheckBox selectCheckBox = gb_del.Controls[ctrlName] as CheckBox;
                        selectCheckBox.Checked = false;
                        MessageBox.Show(StringHelperBiz.limitCheckBox(LIMIT_DEL_CHECK_COUNT));
                        return;
                    }
                    addCheckBoxList[index].Checked = false;
                    addCheckBoxList[index].Enabled = false;
                    delCount++;
                }
                else if (!delCheckBoxList[index].Checked)
                {
                    addCheckBoxList[index].Enabled = true;
                }
            }

            int addCheckNum = addCheckBoxList.Select(x => x).Where(x => x.Checked).Count();
            int delCheckNum = delCheckBoxList.Select(x => x).Where(x => x.Checked).Count();
            checkProbability(addCheckNum, delCheckNum);
        }
        

        private void CreateLottoNum_Load(object sender, EventArgs e)
        {
            LodingCheckBox();
            checkProbability(0, 0);
        }

        private void LodingCheckBox()
        {
            CheckBox[] addCheckBox = new CheckBox[DEFAULT_LOTTO_COUNT];
            CheckBox[] delCheckBox = new CheckBox[DEFAULT_LOTTO_COUNT];

            int row = 0;

            for(int index = 0; index < DEFAULT_LOTTO_COUNT; index++)
            {
                addCheckBox[index] = new CheckBox();
                addCheckBox[index].AutoSize = true;
                addCheckBox[index].Margin = new Padding(3, 4, 3, 4);
                addCheckBox[index].Name = "ckb_add_" + index;
                addCheckBox[index].Size = new Size(40, 19);
                addCheckBox[index].TabIndex = index;
                addCheckBox[index].Text = Convert.ToString(index + 1);
                addCheckBox[index].UseVisualStyleBackColor = true;
                addCheckBox[index].CheckedChanged += new EventHandler(this.ckb_CheckedChanged);

                delCheckBox[index] = new CheckBox();
                delCheckBox[index].AutoSize = true;
                delCheckBox[index].Margin = new Padding(3, 4, 3, 4);
                delCheckBox[index].Name = "ckb_del_" + index;
                delCheckBox[index].Size = new Size(40, 19);
                delCheckBox[index].TabIndex = index;
                delCheckBox[index].Text = Convert.ToString(index + 1);
                delCheckBox[index].UseVisualStyleBackColor = true;
                delCheckBox[index].CheckedChanged += new EventHandler(this.ckb_CheckedChanged);

                if (index != 0 && index % 10 == 0)
                {
                    row++;
                }

                addCheckBox[index].Location = new Point(17 + (X_PLUS_VALUE * (index - (row * 10))), 25 + (Y_PLUS_VALUE * row));
                delCheckBox[index].Location = new Point(17 + (X_PLUS_VALUE * (index - (row * 10))), 25 + (Y_PLUS_VALUE * row));

                gb_add.Controls.Add(addCheckBox[index]);
                gb_del.Controls.Add(delCheckBox[index]);
            }
        }

        private void btn_game1_Click(object sender, EventArgs e)
        {
            gameCreate(1);
        }

        private void btn_game5_Click(object sender, EventArgs e)
        {
            gameCreate(5);
        }

        private void btn_game10_Click(object sender, EventArgs e)
        {
            if(ckb_logic_create.Checked)
            {
                MessageBox.Show("프리미엄 생성은 5개까지만 가능");
                return;
            }
            gameCreate(10);
        }

        private void btn_game20_Click(object sender, EventArgs e)
        {
            if (ckb_logic_create.Checked)
            {
                MessageBox.Show("프리미엄 생성은 5개까지만 가능");
                return;
            }
            gameCreate(20);
        }

        private void btn_game50_Click(object sender, EventArgs e)
        {
            if (ckb_logic_create.Checked)
            {
                MessageBox.Show("프리미엄 생성은 5개까지만 가능");
                return;
            }
            gameCreate(50);
        }

        private void gameCreate(int count)
        {
            LottoBiz lottoBiz = new LottoBiz();
            CheckBox[] addCheckBoxList = new CheckBox[DEFAULT_LOTTO_COUNT];
            CheckBox[] delCheckBoxList = new CheckBox[DEFAULT_LOTTO_COUNT];

            int randomCount = 6;
            List<int> randomRangeList = new List<int>();
            List<int> addNumList = new List<int>();

            for (int index = 0; index < DEFAULT_LOTTO_COUNT; index++)
            {
                CheckBox addCheckBox = gb_add.Controls["ckb_add_" + index] as CheckBox;
                CheckBox delCheckBox = gb_del.Controls["ckb_del_" + index] as CheckBox;

                if (addCheckBox.Checked || delCheckBox.Checked)
                {
                    if (addCheckBox.Checked)
                    {
                        randomCount--;
                        addNumList.Add(index + 1);
                    }
                }
                else
                {
                    randomRangeList.Add(index + 1);
                }
            }
            //txt_result.Text = StringHelperBiz.gameResult(lottoBiz.lottoCreateList(ckb_logic_create.Checked, randomCount, randomRangeList, addNumList, count));
            dgv_result.DataSource = lottoBiz.lottoCreateList(ckb_logic_create.Checked, randomCount, randomRangeList, addNumList, count);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            LottoBiz lottoBiz = new LottoBiz();
            CheckBox[] addCheckBoxList = new CheckBox[DEFAULT_LOTTO_COUNT];
            CheckBox[] delCheckBoxList = new CheckBox[DEFAULT_LOTTO_COUNT];

            int randomCount = 6;
            List<int> randomRangeList = new List<int>();
            List<int> addNumList = new List<int>();

            for (int index = 0; index < DEFAULT_LOTTO_COUNT; index++)
            {
                CheckBox addCheckBox = gb_add.Controls["ckb_add_" + index] as CheckBox;
                CheckBox delCheckBox = gb_del.Controls["ckb_del_" + index] as CheckBox;

                if (addCheckBox.Checked || delCheckBox.Checked)
                {
                    if (addCheckBox.Checked)
                    {
                        randomCount--;
                        addNumList.Add(index + 1);
                    }
                }
                else
                {
                    randomRangeList.Add(index + 1);
                }
            }
            dgv_result.DataSource = lottoBiz.testLottoCreateList(ckb_logic_create.Checked, randomCount, randomRangeList, addNumList, 16);
        }
    }
}
