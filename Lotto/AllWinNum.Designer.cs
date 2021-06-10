namespace Lotto
{
    partial class AllWinNum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllWinNum));
            this.dgv_all_win_list = new System.Windows.Forms.DataGridView();
            this.btn_open_browser = new System.Windows.Forms.Button();
            this.cb_round_list = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_totalSearchCount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lb_help = new System.Windows.Forms.Label();
            this.bs_all_win = new System.Windows.Forms.BindingSource(this.components);
            this.bs_round = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_win_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_all_win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_round)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_all_win_list
            // 
            this.dgv_all_win_list.AllowUserToAddRows = false;
            this.dgv_all_win_list.AllowUserToDeleteRows = false;
            this.dgv_all_win_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_all_win_list.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_all_win_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_all_win_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_all_win_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_all_win_list.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_all_win_list.Location = new System.Drawing.Point(6, 52);
            this.dgv_all_win_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_all_win_list.Name = "dgv_all_win_list";
            this.dgv_all_win_list.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_all_win_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Info;
            this.dgv_all_win_list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_all_win_list.RowTemplate.Height = 23;
            this.dgv_all_win_list.Size = new System.Drawing.Size(878, 389);
            this.dgv_all_win_list.TabIndex = 3;
            this.dgv_all_win_list.Tag = "ASC";
            this.dgv_all_win_list.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_all_win_list_ColumnHeaderMouseClick);
            // 
            // btn_open_browser
            // 
            this.btn_open_browser.BackColor = System.Drawing.SystemColors.Info;
            this.btn_open_browser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_open_browser.Location = new System.Drawing.Point(101, 19);
            this.btn_open_browser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_open_browser.Name = "btn_open_browser";
            this.btn_open_browser.Size = new System.Drawing.Size(75, 29);
            this.btn_open_browser.TabIndex = 4;
            this.btn_open_browser.Text = "회차 확인";
            this.btn_open_browser.UseVisualStyleBackColor = false;
            this.btn_open_browser.Click += new System.EventHandler(this.btn_open_browser_Click);
            // 
            // cb_round_list
            // 
            this.cb_round_list.BackColor = System.Drawing.SystemColors.Info;
            this.cb_round_list.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cb_round_list.FormattingEnabled = true;
            this.cb_round_list.Location = new System.Drawing.Point(8, 21);
            this.cb_round_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_round_list.Name = "cb_round_list";
            this.cb_round_list.Size = new System.Drawing.Size(76, 23);
            this.cb_round_list.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_round_list);
            this.groupBox1.Controls.Add(this.btn_open_browser);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(15, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(193, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "직접 확인";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Info;
            this.txt_search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_search.Location = new System.Drawing.Point(83, 18);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.MaxLength = 2;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(61, 23);
            this.txt_search.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "당첨번호";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Info;
            this.btn_search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.Location = new System.Drawing.Point(150, 18);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(49, 26);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "찾기";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_totalSearchCount
            // 
            this.lb_totalSearchCount.AutoSize = true;
            this.lb_totalSearchCount.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalSearchCount.Location = new System.Drawing.Point(229, 23);
            this.lb_totalSearchCount.Name = "lb_totalSearchCount";
            this.lb_totalSearchCount.Size = new System.Drawing.Size(15, 14);
            this.lb_totalSearchCount.TabIndex = 12;
            this.lb_totalSearchCount.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_all_win_list);
            this.groupBox2.Controls.Add(this.lb_totalSearchCount);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(15, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(890, 450);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회차별 당첨정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "finds";
            // 
            // lb_help
            // 
            this.lb_help.AutoSize = true;
            this.lb_help.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_help.Location = new System.Drawing.Point(850, 51);
            this.lb_help.Name = "lb_help";
            this.lb_help.Size = new System.Drawing.Size(49, 15);
            this.lb_help.TabIndex = 15;
            this.lb_help.Text = "?도움말";
            // 
            // bs_all_win
            // 
            this.bs_all_win.Sort = "";
            // 
            // AllWinNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(917, 543);
            this.Controls.Add(this.lb_help);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AllWinNum";
            this.Text = "회차별 당첨정보";
            this.Load += new System.EventHandler(this.AllWinNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_all_win_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_all_win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_round)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_all_win_list;
        private System.Windows.Forms.BindingSource bs_all_win;
        private System.Windows.Forms.Button btn_open_browser;
        private System.Windows.Forms.ComboBox cb_round_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bs_round;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lb_totalSearchCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lb_help;
    }
}