namespace Lotto
{
    partial class Convertor
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Convertor));
            this.btn_update = new System.Windows.Forms.Button();
            this.lb_update = new System.Windows.Forms.Label();
            this.prog_update = new System.Windows.Forms.ProgressBar();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.btn_all_win = new System.Windows.Forms.Button();
            this.btn_my_win = new System.Windows.Forms.Button();
            this.gb_update = new System.Windows.Forms.GroupBox();
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.btn_create_lotto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lb_login = new System.Windows.Forms.Label();
            this.rb_old = new System.Windows.Forms.RadioButton();
            this.rb_new = new System.Windows.Forms.RadioButton();
            this.btn_login = new System.Windows.Forms.Button();
            this.cb_id = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_update.SuspendLayout();
            this.gb_menu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Info;
            this.btn_update.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_update.Location = new System.Drawing.Point(477, 15);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(108, 26);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lb_update
            // 
            this.lb_update.AutoSize = true;
            this.lb_update.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_update.Location = new System.Drawing.Point(6, 43);
            this.lb_update.Name = "lb_update";
            this.lb_update.Size = new System.Drawing.Size(116, 15);
            this.lb_update.TabIndex = 5;
            this.lb_update.Text = "Update 해야 합니다.";
            // 
            // prog_update
            // 
            this.prog_update.Location = new System.Drawing.Point(8, 25);
            this.prog_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prog_update.Name = "prog_update";
            this.prog_update.Size = new System.Drawing.Size(448, 16);
            this.prog_update.Step = 1;
            this.prog_update.TabIndex = 6;
            // 
            // btn_statistics
            // 
            this.btn_statistics.BackColor = System.Drawing.SystemColors.Info;
            this.btn_statistics.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_statistics.Location = new System.Drawing.Point(234, 25);
            this.btn_statistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(108, 29);
            this.btn_statistics.TabIndex = 20;
            this.btn_statistics.Text = "통계";
            this.btn_statistics.UseVisualStyleBackColor = false;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_all_win
            // 
            this.btn_all_win.BackColor = System.Drawing.SystemColors.Info;
            this.btn_all_win.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_all_win.Location = new System.Drawing.Point(8, 25);
            this.btn_all_win.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_all_win.Name = "btn_all_win";
            this.btn_all_win.Size = new System.Drawing.Size(108, 29);
            this.btn_all_win.TabIndex = 21;
            this.btn_all_win.Text = "회차별당첨정보";
            this.btn_all_win.UseVisualStyleBackColor = false;
            this.btn_all_win.Click += new System.EventHandler(this.btn_all_win_Click);
            // 
            // btn_my_win
            // 
            this.btn_my_win.BackColor = System.Drawing.SystemColors.Info;
            this.btn_my_win.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_my_win.Location = new System.Drawing.Point(121, 25);
            this.btn_my_win.Margin = new System.Windows.Forms.Padding(2);
            this.btn_my_win.Name = "btn_my_win";
            this.btn_my_win.Size = new System.Drawing.Size(108, 29);
            this.btn_my_win.TabIndex = 22;
            this.btn_my_win.Text = "내 로또 이력";
            this.btn_my_win.UseVisualStyleBackColor = false;
            this.btn_my_win.Click += new System.EventHandler(this.btn_my_win_Click);
            // 
            // gb_update
            // 
            this.gb_update.Controls.Add(this.btn_update);
            this.gb_update.Controls.Add(this.prog_update);
            this.gb_update.Controls.Add(this.lb_update);
            this.gb_update.ForeColor = System.Drawing.SystemColors.Info;
            this.gb_update.Location = new System.Drawing.Point(12, 191);
            this.gb_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_update.Name = "gb_update";
            this.gb_update.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_update.Size = new System.Drawing.Size(594, 65);
            this.gb_update.TabIndex = 23;
            this.gb_update.TabStop = false;
            this.gb_update.Text = "Update";
            // 
            // gb_menu
            // 
            this.gb_menu.Controls.Add(this.btn_create_lotto);
            this.gb_menu.Controls.Add(this.btn_my_win);
            this.gb_menu.Controls.Add(this.btn_all_win);
            this.gb_menu.Controls.Add(this.btn_statistics);
            this.gb_menu.ForeColor = System.Drawing.SystemColors.Info;
            this.gb_menu.Location = new System.Drawing.Point(141, 13);
            this.gb_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_menu.Size = new System.Drawing.Size(465, 76);
            this.gb_menu.TabIndex = 24;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "Menu";
            // 
            // btn_create_lotto
            // 
            this.btn_create_lotto.BackColor = System.Drawing.SystemColors.Info;
            this.btn_create_lotto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_create_lotto.Location = new System.Drawing.Point(348, 25);
            this.btn_create_lotto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_create_lotto.Name = "btn_create_lotto";
            this.btn_create_lotto.Size = new System.Drawing.Size(108, 29);
            this.btn_create_lotto.TabIndex = 23;
            this.btn_create_lotto.Text = "조합 번호생성";
            this.btn_create_lotto.UseVisualStyleBackColor = false;
            this.btn_create_lotto.Click += new System.EventHandler(this.btn_create_lotto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_log_out);
            this.groupBox3.Controls.Add(this.lb_login);
            this.groupBox3.Controls.Add(this.rb_old);
            this.groupBox3.Controls.Add(this.rb_new);
            this.groupBox3.Controls.Add(this.btn_login);
            this.groupBox3.Controls.Add(this.cb_id);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 171);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login";
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.SystemColors.Info;
            this.btn_log_out.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_log_out.Location = new System.Drawing.Point(9, 128);
            this.btn_log_out.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(100, 26);
            this.btn_log_out.TabIndex = 28;
            this.btn_log_out.Text = "로그아웃";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(6, 69);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(0, 15);
            this.lb_login.TabIndex = 27;
            // 
            // rb_old
            // 
            this.rb_old.AutoSize = true;
            this.rb_old.Checked = true;
            this.rb_old.Location = new System.Drawing.Point(9, 22);
            this.rb_old.Name = "rb_old";
            this.rb_old.Size = new System.Drawing.Size(61, 19);
            this.rb_old.TabIndex = 26;
            this.rb_old.TabStop = true;
            this.rb_old.Text = "기존ID";
            this.rb_old.UseVisualStyleBackColor = true;
            this.rb_old.CheckedChanged += new System.EventHandler(this.rb_old_CheckedChanged);
            // 
            // rb_new
            // 
            this.rb_new.AutoSize = true;
            this.rb_new.Location = new System.Drawing.Point(9, 47);
            this.rb_new.Name = "rb_new";
            this.rb_new.Size = new System.Drawing.Size(61, 19);
            this.rb_new.TabIndex = 25;
            this.rb_new.Text = "신규ID";
            this.rb_new.UseVisualStyleBackColor = true;
            this.rb_new.CheckedChanged += new System.EventHandler(this.rb_new_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Info;
            this.btn_login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.Location = new System.Drawing.Point(9, 128);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(100, 26);
            this.btn_login.TabIndex = 24;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cb_id
            // 
            this.cb_id.BackColor = System.Drawing.SystemColors.Window;
            this.cb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_id.FormattingEnabled = true;
            this.cb_id.IntegralHeight = false;
            this.cb_id.Location = new System.Drawing.Point(9, 84);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(100, 23);
            this.cb_id.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(9, 84);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 23);
            this.txt_id.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(149, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "창용 테스트버전";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(619, 269);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_menu);
            this.Controls.Add(this.gb_update);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Convertor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JY Lotto v0.51001";
            this.Load += new System.EventHandler(this.Convertor_Load);
            this.gb_update.ResumeLayout(false);
            this.gb_update.PerformLayout();
            this.gb_menu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lb_update;
        private System.Windows.Forms.ProgressBar prog_update;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Button btn_all_win;
        private System.Windows.Forms.Button btn_my_win;
        private System.Windows.Forms.GroupBox gb_update;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.Button btn_create_lotto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.RadioButton rb_old;
        private System.Windows.Forms.RadioButton rb_new;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox cb_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button button1;
    }
}

