using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Lotto.Service;
using Lotto.Model;
using Lotto.Biz;
using Lotto.Repository;

namespace Lotto
{
    public partial class Convertor : Form
    {
        public Convertor()
        {
            InitializeComponent();
            //업데이트 체크
            checkUpdate();
            //프로그래스바 맥시멈
            prog_update.Maximum = 800;
        }

        //중복 폼 처리 로직
        protected void FrmShow(Form frm)
        {
            bool FrmisExist = new bool();
            FrmisExist = false;

            foreach (Form form1 in Application.OpenForms)
            {
                if (form1.GetType() == frm.GetType())
                {
                    FrmisExist = true;
                }
            }
            // 폼존재여부에 따라서 생성과 파기
            if (!FrmisExist)
            {
                frm.Show();
                frm.Activate();
            }
            else
            {
                frm.Dispose();
            }
        }

        
        /// <summary>
        /// 업데이트 체크
        /// </summary>
        private void checkUpdate()
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            //로또번호가 있는지 체크
            if (lottoWinBiz.isExpireLottoWin())
            {
                lb_update.Text = "Update 해야 합니다." + StringHelperBiz.updateText();
                lb_update.ForeColor = System.Drawing.Color.DarkOrange;
            }
            //업데이트가 되어 있는상태
            if (!lottoWinBiz.isUpdate())
            {
                //업데이트 라벨 녹색변경
                updateLabel();
            }
        }

        private void updateLabel()
        {
            lb_update.Text = "Update 완료. " + StringHelperBiz.updateText();
            lb_update.ForeColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// 업데이트 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            LottoWinBiz lottoWinBiz = new LottoWinBiz();
            LottoApiBiz lottoApiBiz = new LottoApiBiz();

            if (lottoWinBiz.isUpdate())
            {
                List<Win> input = new List<Win>();
                Win lastWin = lottoWinBiz.getLottoWinLast();
                int roundNo = 1;
                DateTime lastWinTime = DateTime.MinValue;

                if (lottoWinBiz.isExpireLottoWin())
                {
                    roundNo = lastWin.round + 1;
                    lastWinTime = lastWin.drwNoDate;
                    input = lottoWinBiz.getLottoWinList();
                    prog_update.Maximum = 1;
                }

                while (lottoWinBiz.lastWeek(lastWinTime))
                {
                    Win win = lottoApiBiz.getLottoApi(roundNo);
                    if (win != null)
                    {
                        if (win.returnValue.Equals("success"))
                        {
                            win.round = roundNo;
                            lastWinTime = win.drwNoDate;
                            input.Add(win);
                            roundNo++;
                            prog_update.PerformStep();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                lottoWinBiz.setLottoWinList(input);

                updateLabel();
            }
        }

        /// <summary>
        /// 통계 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_statistics_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            FrmShow(statistics);
        }

        /// <summary>
        /// 모든 회차 당첨창 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_all_win_Click(object sender, EventArgs e)
        {
            AllWinNum allWinNum = new AllWinNum();
            FrmShow(allWinNum);
        }

        private void btn_my_win_Click(object sender, EventArgs e)
        {
            MyWin myWin = new MyWin();
            FrmShow(myWin);
        }

        private void btn_create_lotto_Click(object sender, EventArgs e)
        {
            CreateLottoNum createLottoNum = new CreateLottoNum();
            FrmShow(createLottoNum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CYTest cyTest = new CYTest();
            FrmShow(cyTest);
        }

        private void Convertor_Load(object sender, EventArgs e)
        {
            login(false);
            
        }

        private void login(bool login)
        {
            MyNumBiz myNumBiz = new MyNumBiz();
            if(login)
            {
                string loginId = myNumBiz.getLoginId();
                gb_menu.Enabled = true;
                gb_update.Enabled = true;

                //로그인창 부분
                rb_changed("login");
                btn_login.Visible = false;
                btn_log_out.Visible = true;

                lb_login.Text = loginId + " 로그인";
                lb_login.ForeColor = System.Drawing.Color.DarkOrange;
            }
            else
            {
                myNumBiz.updateLogout();
                gb_menu.Enabled = false;
                gb_update.Enabled = false;

                //로그인창 부분
                rb_changed("old");
                btn_login.Visible = true;
                btn_log_out.Visible = false;

                lb_login.Text = ".";
                lb_login.ForeColor = System.Drawing.Color.White;
                closeForm();
            }
            cb_id.DataSource = myNumBiz.getBindingIdList();
        }

        private void checkLogin(int loginType)
        {
            if(loginType == 1)
            {
                if(cb_id.SelectedIndex != -1)
                {
                    MyNumBiz myNumBiz = new MyNumBiz();
                    myNumBiz.updateLoginInfo(cb_id.SelectedValue.ToString());
                    login(true);
                }
            }
            else if(loginType == 2)
            {
                if(txt_id.Text != "")
                {
                    MyNumBiz myNumBiz = new MyNumBiz();
                    myNumBiz.insertLoginInfo(txt_id.Text);
                    login(true);
                }
            }
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            login(false);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            checkLogin(rb_IDValue());
        }

        private int rb_IDValue()
        {
            if (rb_old.Checked)
                return 1;
            else if (rb_new.Checked)
                return 2;
            else
                return 3;
        }

        private void rb_old_CheckedChanged(object sender, EventArgs e)
        {
            rb_changed("old");
        }

        private void rb_new_CheckedChanged(object sender, EventArgs e)
        {
            rb_changed("new");
        }

        private void rb_changed(string checkedText)
        {
            if(checkedText == "new")
            {
                //라디오버튼
                rb_new.Visible = true;
                rb_old.Visible = true;
                cb_id.Visible = false;
                txt_id.Text = "";
                txt_id.Visible = true;
            }
            else if(checkedText == "old")
            {
                //라디오버튼
                rb_new.Visible = true; 
                rb_old.Visible = true;
                cb_id.Visible = true;
                txt_id.Visible = false;
            }
            else if(checkedText == "login")
            {
                rb_old.Checked = true;
                rb_new.Checked = false;
                rb_new.Visible = false; //라디오버튼
                rb_old.Visible = false;
                cb_id.Visible = false;
                txt_id.Visible = false;
            }
        }

        private void closeForm()
        {
            Form[] formsList = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form openForm in formsList)
            {
                if(!(openForm is Convertor))
                {
                    openForm.Close();
                }
            }
        }

        
    }
}
