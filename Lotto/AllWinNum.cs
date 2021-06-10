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
using System.Diagnostics;

namespace Lotto
{
    public partial class AllWinNum : Form 
    {
        private string searchUrl = Properties.Settings.Default.SearchLottoWinUrl;

        private FileBiz fileBiz = new FileBiz();
        public AllWinNum()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btn_search, "클릭 때마다 해당 회차를 찾습니다."); 
            toolTip1.SetToolTip(lb_help, "회차, 보너스번호, 등등 당첨번호를 제외한 나머지 head 클릭시 정렬 됩니다."); 
        }

        private void AllWinNum_Load(object sender, EventArgs e)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();

            //전체 당첨정보 데이터뷰 데이터바인딩
            dgv_all_win_list.DataSource = GetBindingSource("round", "DESC");

            //라인드콤보박스 데이터바인딩
            cb_round_list.DataSource = lottoWinBiz.getBindingWinRoundList();
            //콤보박스 read only
            cb_round_list.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private List<BindingWin> GetBindingSource(string sortBy, string sortAscending)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            return lottoWinBiz.getBindingWinList(sortBy, sortAscending);
        }

        /// <summary>
        /// 웹브라우저 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_browser_Click(object sender, EventArgs e)
        {
            Process.Start(StringHelperBiz.searchUrl(cb_round_list.SelectedItem));
        }

        private void dgv_all_win_list_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ascending = dgv_all_win_list.Tag.ToString() == "ASC" ? "DESC" : "ASC";
            dgv_all_win_list.Tag = ascending;
            string propertieName = dgv_all_win_list.Columns[e.ColumnIndex].Name;
            if (propertieName != "drwtNo")
            {
                dgv_all_win_list.DataSource = GetBindingSource(dgv_all_win_list.Columns[e.ColumnIndex].Name, ascending);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchValue = txt_search.Text;
            if(String.IsNullOrEmpty(searchValue))
            {
                return;
            }
            lb_totalSearchCount.Text = getTotalSearchCount(searchValue).ToString();

            int currentRowIndex = dgv_all_win_list.SelectedRows.Count != 0 ? dgv_all_win_list.SelectedRows[0].Index + 1 : 0;
            int totalRowIndex = dgv_all_win_list.Rows.Count;

            for(int index = 0; index < currentRowIndex; index++)
            {
                dgv_all_win_list.Rows[index].Selected = false;
            }

            for (; currentRowIndex <= totalRowIndex; currentRowIndex++)
            {
                if (totalRowIndex == currentRowIndex)
                {
                    DialogResult dr = MessageBox.Show("끝까지 찾았습니다. 처음부터 찾으시겠습니까?.", "찾기 끝"
                        , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        currentRowIndex = 0;
                    }
                }
                else
                {
                    DataGridViewRow row = dgv_all_win_list.Rows[currentRowIndex];
                    string[] cellValue = row.Cells[1].Value.ToString().Split(',');
                    foreach(string num in cellValue)
                    {
                        if(num.Equals(searchValue))
                        {
                            dgv_all_win_list.Rows[currentRowIndex].Selected = true;
                            dgv_all_win_list.FirstDisplayedScrollingRowIndex = currentRowIndex;
                            return;
                        }
                    }
                }
            }
        }

        private int getTotalSearchCount(string searchValue)
        {
            int result = 0;
            for (int index = 0; index < dgv_all_win_list.Rows.Count; index++)
            {
                DataGridViewRow row = dgv_all_win_list.Rows[index];
                string[] cellValue = row.Cells[1].Value.ToString().Split(',');
                foreach (string num in cellValue)
                {
                    if (num.Equals(searchValue))
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
