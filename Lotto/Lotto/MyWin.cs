using Lotto.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Lotto
{
    public partial class MyWin : Form
    {
        public int LOTTO_END_NO = Properties.Settings.Default.DefaultLottoCount;

        public MyWin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 내 번호 허용범위 체크
        /// </summary>
        /// <param name="round"></param>
        /// <param name="win1"></param>
        /// <param name="win2"></param>
        /// <param name="win3"></param>
        /// <param name="win4"></param>
        /// <param name="win5"></param>
        /// <param name="win6"></param>
        /// <returns></returns>
        private bool checkInputText(string round, string win1, string win2, string win3, string win4, string win5, string win6)
        {
            if(String.IsNullOrEmpty(round) || String.IsNullOrEmpty(win1) || String.IsNullOrEmpty(win2) || String.IsNullOrEmpty(win3) || String.IsNullOrEmpty(win4) ||
                String.IsNullOrEmpty(win5) || String.IsNullOrEmpty(win6))
            {
                return false;
            }
            if(Convert.ToInt32(win1) > 45 || Convert.ToInt32(win2) > 45 || Convert.ToInt32(win3) > 45 || 
                Convert.ToInt32(win4) > 45 || Convert.ToInt32(win5) > 45 || Convert.ToInt32(win6) > 45)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 내 번호 저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_my_save_Click(object sender, EventArgs e)
        {
            MyNumBiz myNumBiz = new MyNumBiz();
            //허용 범위 (숫자, 미입력) 체크
            if (checkInputText(txt_my_round.Text, txt_win1.Text, txt_win2.Text, txt_win3.Text, txt_win4.Text, txt_win5.Text, txt_win6.Text))
            {

                //저장 및 메세지리턴
                string message = myNumBiz.insertAndMessageMyNum(Convert.ToInt32(txt_my_round.Text)
                    , Convert.ToInt32(txt_win1.Text), Convert.ToInt32(txt_win2.Text)
                    , Convert.ToInt32(txt_win3.Text), Convert.ToInt32(txt_win4.Text)
                    , Convert.ToInt32(txt_win5.Text), Convert.ToInt32(txt_win6.Text));

                txt_win1.Text = "";
                txt_win2.Text = "";
                txt_win3.Text = "";
                txt_win4.Text = "";
                txt_win5.Text = "";
                txt_win6.Text = "";
                txt_win1.Select(0, 0);

                //내번호 가져오기
                loadMyNum();
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show(StringHelperBiz.getInputFalse());
            }
        }

        private void MyWin_Load(object sender, EventArgs e)
        {
            loadMyNum();
        }

        private void loadMyNum()
        {
            MyNumBiz myNumBiz = new MyNumBiz();
            dgv_myNum.DataSource = myNumBiz.getBindingMyNumList();
        }

        /// <summary>
        /// 내 번호 지우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            MyNumBiz myNumBiz = new MyNumBiz();
            if (dgv_myNum.CurrentRow != null)
            {
                int slectIdx = Convert.ToInt32(dgv_myNum.CurrentRow.Cells[0].Value);
                myNumBiz.delMyNum(slectIdx);
                loadMyNum();
            }
        }

        #region only number textbox

        private void txt_my_round_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_my_round.Text, "[^0-9]"))
            {
                txt_my_round.Text = txt_my_round.Text.Remove(txt_my_round.Text.Length - 1);
            }
        }
        private void txt_45_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
            if (textBox.Text != "")
            {
                if (Convert.ToInt32(textBox.Text) > LOTTO_END_NO || Convert.ToInt32(textBox.Text) == 0)
                {
                    textBox.Text = "";
                }
            }
        }
        #endregion
    }
}
