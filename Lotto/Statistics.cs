using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Lotto.Biz;
using Lotto.Model;
using Lotto.Biz.StatisticsBiz;
using Lotto.EnumType;
using Lotto.Repository;

namespace Lotto
{
    public partial class Statistics : Form
    {
        private DateBiz dateBiz = new DateBiz();
        private FileBiz fileBiz = new FileBiz();
        public int LOTTO_END_NO = Properties.Settings.Default.DefaultLottoCount;
        public int WIN_NUM_CNT = Properties.Settings.Default.DefaultWinCount;

        public Statistics()
        {
            InitializeComponent();

            List<int> startNums = BaseBiz.getWinNums();
            List<int> endNums = BaseBiz.getWinNums();
            endNums.Reverse();
            cb_start.DataSource = startNums;
            cb_end.DataSource = endNums;
            rb_odd.Checked = true;
            controlDisabled();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            setStatisticsGrid("","");
        }

        private void setStatisticsGrid(string sortBy, string sortAscending)
        {
            if (rb_odd_even.Checked && txt_odd_even_count.Text.Length != 0)
            {
                OddEvenBiz odd = new OddEvenBiz();
                OddEvenType type = rb_even.Checked ? OddEvenType.EVEN : OddEvenType.ODD;
                dgv_statistics.DataSource = odd.getOddEvenStatistics(type, Convert.ToInt32(txt_odd_even_count.Text));
            }
            if (rb_setting_search.Checked && txt_setting_search_count.Text.Length != 0)
            {
                SettingNumSearchBiz settingNumBiz = new SettingNumSearchBiz();
                dgv_statistics.DataSource = settingNumBiz.getSettingNumStatistics(Convert.ToInt32(cb_start.SelectedValue), Convert.ToInt32(cb_end.SelectedValue), Convert.ToInt32(txt_setting_search_count.Text), sortBy, sortAscending);
            }
            if (rb_win_num_count.Checked)
            {
                WinNumCountSearchBiz winNumCountSearchBiz = new WinNumCountSearchBiz();
                dgv_statistics.DataSource = winNumCountSearchBiz.getWinNumCountSearch(sortBy, sortAscending);
            }
            if(rb_check_win.Checked)
            {
                WinSearchBiz winSearchBiz = new WinSearchBiz();
                dgv_statistics.DataSource = winSearchBiz.getWinSearch(txt_check_1.Text, txt_check_2.Text, txt_check_3.Text, txt_check_4.Text, txt_check_5.Text, txt_check_6.Text, sortBy, sortAscending);
            }
            if (rb_total_sum.Checked)
            {
                WinNumSumAvrBiz winNumSumAvrBiz = new WinNumSumAvrBiz();
                dgv_statistics.DataSource = winNumSumAvrBiz.getTotalSumAvr(sortBy, sortAscending);
            }
        }

        private void dgv_statistics_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ascending = dgv_statistics.Tag.ToString() == "ASC" ? "DESC" : "ASC";
            dgv_statistics.Tag = ascending;
            string propertieName = dgv_statistics.Columns[e.ColumnIndex].Name;
            setStatisticsGrid(dgv_statistics.Columns[e.ColumnIndex].Name, ascending);
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

        private void txt_6_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
            if (textBox.Text != "")
            {
                if (Convert.ToInt32(textBox.Text) > WIN_NUM_CNT || Convert.ToInt32(textBox.Text) == 0)
                {
                    textBox.Text = "";
                }
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            controlDisabled();
            if (rb_odd_even.Checked)
            {
                rb_odd.Enabled = true;
                rb_even.Enabled = true;
                txt_odd_even_count.Enabled = true;
            }
            if (rb_setting_search.Checked)
            {
                cb_start.Enabled = true;
                cb_end.Enabled = true;
                txt_setting_search_count.Enabled = true;
            }
            if (rb_check_win.Checked)
            {
                txt_check_1.Enabled = true;
                txt_check_2.Enabled = true;
                txt_check_3.Enabled = true;
                txt_check_4.Enabled = true;
                txt_check_5.Enabled = true;
                txt_check_6.Enabled = true;
            }
        }

        private void controlDisabled()
        {
            //홀수 라디오
            rb_odd.Enabled = false;
            //짝수 라디오
            rb_even.Enabled = false;
            //홀짝 갯수
            txt_odd_even_count.Enabled = false;

            //시작범위번호
            cb_start.Enabled = false;
            //끝범위번호
            cb_end.Enabled = false;
            //범위 갯수
            txt_setting_search_count.Enabled = false;

            //당첨내역 확인
            txt_check_1.Enabled = false;
            txt_check_2.Enabled = false;
            txt_check_3.Enabled = false;
            txt_check_4.Enabled = false;
            txt_check_5.Enabled = false;
            txt_check_6.Enabled = false;
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            txt_odd_even_count.Text = "";
            txt_setting_search_count.Text = "";
            txt_check_1.Text = "";
            txt_check_2.Text = "";
            txt_check_3.Text = "";
            txt_check_4.Text = "";
            txt_check_5.Text = "";
            txt_check_6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebServiceRepository eddd = new WebServiceRepository();
            eddd.getLottoParsing(844);
        }
    }
}
