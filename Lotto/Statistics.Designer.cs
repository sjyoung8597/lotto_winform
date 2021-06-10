namespace Lotto
{
    partial class Statistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.btn_statistics = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_end = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_start = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_setting_search_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_statistics = new System.Windows.Forms.DataGridView();
            this.gb_option = new System.Windows.Forms.GroupBox();
            this.rb_total_sum = new System.Windows.Forms.RadioButton();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.rb_check_win = new System.Windows.Forms.RadioButton();
            this.rb_win_num_count = new System.Windows.Forms.RadioButton();
            this.rb_setting_search = new System.Windows.Forms.RadioButton();
            this.rb_odd_even = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_odd = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_even = new System.Windows.Forms.RadioButton();
            this.txt_odd_even_count = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_check_6 = new System.Windows.Forms.TextBox();
            this.txt_check_5 = new System.Windows.Forms.TextBox();
            this.txt_check_4 = new System.Windows.Forms.TextBox();
            this.txt_check_3 = new System.Windows.Forms.TextBox();
            this.txt_check_2 = new System.Windows.Forms.TextBox();
            this.txt_check_1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistics)).BeginInit();
            this.gb_option.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_statistics
            // 
            this.btn_statistics.BackColor = System.Drawing.SystemColors.Info;
            this.btn_statistics.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_statistics.Location = new System.Drawing.Point(701, 125);
            this.btn_statistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(75, 29);
            this.btn_statistics.TabIndex = 4;
            this.btn_statistics.Text = "통계";
            this.btn_statistics.UseVisualStyleBackColor = false;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_end);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_start);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_setting_search_count);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(239, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cb_end
            // 
            this.cb_end.BackColor = System.Drawing.SystemColors.Info;
            this.cb_end.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cb_end.FormattingEnabled = true;
            this.cb_end.Location = new System.Drawing.Point(88, 15);
            this.cb_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_end.Name = "cb_end";
            this.cb_end.Size = new System.Drawing.Size(45, 23);
            this.cb_end.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "개";
            // 
            // cb_start
            // 
            this.cb_start.BackColor = System.Drawing.SystemColors.Info;
            this.cb_start.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cb_start.FormattingEnabled = true;
            this.cb_start.Location = new System.Drawing.Point(6, 15);
            this.cb_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_start.Name = "cb_start";
            this.cb_start.Size = new System.Drawing.Size(45, 23);
            this.cb_start.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "까지";
            // 
            // txt_setting_search_count
            // 
            this.txt_setting_search_count.BackColor = System.Drawing.SystemColors.Info;
            this.txt_setting_search_count.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_setting_search_count.Location = new System.Drawing.Point(164, 15);
            this.txt_setting_search_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_setting_search_count.Name = "txt_setting_search_count";
            this.txt_setting_search_count.Size = new System.Drawing.Size(47, 23);
            this.txt_setting_search_count.TabIndex = 12;
            this.txt_setting_search_count.TextChanged += new System.EventHandler(this.txt_6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "에서";
            // 
            // dgv_statistics
            // 
            this.dgv_statistics.AllowUserToAddRows = false;
            this.dgv_statistics.AllowUserToDeleteRows = false;
            this.dgv_statistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_statistics.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_statistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_statistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_statistics.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_statistics.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_statistics.Location = new System.Drawing.Point(12, 186);
            this.dgv_statistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_statistics.Name = "dgv_statistics";
            this.dgv_statistics.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_statistics.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Info;
            this.dgv_statistics.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_statistics.RowTemplate.Height = 23;
            this.dgv_statistics.Size = new System.Drawing.Size(780, 384);
            this.dgv_statistics.TabIndex = 11;
            this.dgv_statistics.Tag = "ASC";
            this.dgv_statistics.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_statistics_ColumnHeaderMouseClick);
            // 
            // gb_option
            // 
            this.gb_option.Controls.Add(this.rb_total_sum);
            this.gb_option.Controls.Add(this.bt_refresh);
            this.gb_option.Controls.Add(this.rb_check_win);
            this.gb_option.Controls.Add(this.rb_win_num_count);
            this.gb_option.Controls.Add(this.rb_setting_search);
            this.gb_option.Controls.Add(this.btn_statistics);
            this.gb_option.Controls.Add(this.rb_odd_even);
            this.gb_option.Controls.Add(this.groupBox3);
            this.gb_option.Controls.Add(this.groupBox1);
            this.gb_option.Controls.Add(this.groupBox2);
            this.gb_option.ForeColor = System.Drawing.SystemColors.Info;
            this.gb_option.Location = new System.Drawing.Point(12, 15);
            this.gb_option.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_option.Name = "gb_option";
            this.gb_option.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_option.Size = new System.Drawing.Size(780, 164);
            this.gb_option.TabIndex = 12;
            this.gb_option.TabStop = false;
            this.gb_option.Text = "옵션";
            // 
            // rb_total_sum
            // 
            this.rb_total_sum.AutoSize = true;
            this.rb_total_sum.Location = new System.Drawing.Point(300, 76);
            this.rb_total_sum.Name = "rb_total_sum";
            this.rb_total_sum.Size = new System.Drawing.Size(77, 19);
            this.rb_total_sum.TabIndex = 14;
            this.rb_total_sum.TabStop = true;
            this.rb_total_sum.Text = "합계 통계";
            this.rb_total_sum.UseVisualStyleBackColor = true;
            // 
            // bt_refresh
            // 
            this.bt_refresh.BackColor = System.Drawing.SystemColors.Info;
            this.bt_refresh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bt_refresh.Location = new System.Drawing.Point(701, 91);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(75, 29);
            this.bt_refresh.TabIndex = 13;
            this.bt_refresh.Text = "초기화";
            this.bt_refresh.UseVisualStyleBackColor = false;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // rb_check_win
            // 
            this.rb_check_win.AutoSize = true;
            this.rb_check_win.Location = new System.Drawing.Point(300, 22);
            this.rb_check_win.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_check_win.Name = "rb_check_win";
            this.rb_check_win.Size = new System.Drawing.Size(209, 19);
            this.rb_check_win.TabIndex = 12;
            this.rb_check_win.TabStop = true;
            this.rb_check_win.Text = "당첨번호 였던 적이 있었는지 검색";
            this.rb_check_win.UseVisualStyleBackColor = true;
            this.rb_check_win.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_win_num_count
            // 
            this.rb_win_num_count.AutoSize = true;
            this.rb_win_num_count.Location = new System.Drawing.Point(16, 125);
            this.rb_win_num_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_win_num_count.Name = "rb_win_num_count";
            this.rb_win_num_count.Size = new System.Drawing.Size(129, 19);
            this.rb_win_num_count.TabIndex = 11;
            this.rb_win_num_count.TabStop = true;
            this.rb_win_num_count.Text = "당첨번호 출현 검색";
            this.rb_win_num_count.UseVisualStyleBackColor = true;
            this.rb_win_num_count.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_setting_search
            // 
            this.rb_setting_search.AutoSize = true;
            this.rb_setting_search.Location = new System.Drawing.Point(16, 71);
            this.rb_setting_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_setting_search.Name = "rb_setting_search";
            this.rb_setting_search.Size = new System.Drawing.Size(169, 19);
            this.rb_setting_search.TabIndex = 10;
            this.rb_setting_search.TabStop = true;
            this.rb_setting_search.Text = "당첨번호 중 범위설정 검색";
            this.rb_setting_search.UseVisualStyleBackColor = true;
            this.rb_setting_search.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_odd_even
            // 
            this.rb_odd_even.AutoSize = true;
            this.rb_odd_even.Location = new System.Drawing.Point(16, 22);
            this.rb_odd_even.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_odd_even.Name = "rb_odd_even";
            this.rb_odd_even.Size = new System.Drawing.Size(145, 19);
            this.rb_odd_even.TabIndex = 9;
            this.rb_odd_even.TabStop = true;
            this.rb_odd_even.Text = "당첨번호 중 홀짝 검색";
            this.rb_odd_even.UseVisualStyleBackColor = true;
            this.rb_odd_even.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_odd);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rb_even);
            this.groupBox3.Controls.Add(this.txt_odd_even_count);
            this.groupBox3.Location = new System.Drawing.Point(42, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(239, 42);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ㅇ";
            // 
            // rb_odd
            // 
            this.rb_odd.AutoSize = true;
            this.rb_odd.Location = new System.Drawing.Point(6, 19);
            this.rb_odd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_odd.Name = "rb_odd";
            this.rb_odd.Size = new System.Drawing.Size(37, 19);
            this.rb_odd.TabIndex = 6;
            this.rb_odd.TabStop = true;
            this.rb_odd.Text = "홀";
            this.rb_odd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "개";
            // 
            // rb_even
            // 
            this.rb_even.AutoSize = true;
            this.rb_even.Location = new System.Drawing.Point(47, 19);
            this.rb_even.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_even.Name = "rb_even";
            this.rb_even.Size = new System.Drawing.Size(37, 19);
            this.rb_even.TabIndex = 7;
            this.rb_even.TabStop = true;
            this.rb_even.Text = "짝";
            this.rb_even.UseVisualStyleBackColor = true;
            // 
            // txt_odd_even_count
            // 
            this.txt_odd_even_count.BackColor = System.Drawing.SystemColors.Info;
            this.txt_odd_even_count.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_odd_even_count.Location = new System.Drawing.Point(164, 15);
            this.txt_odd_even_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_odd_even_count.Name = "txt_odd_even_count";
            this.txt_odd_even_count.Size = new System.Drawing.Size(47, 23);
            this.txt_odd_even_count.TabIndex = 8;
            this.txt_odd_even_count.TextChanged += new System.EventHandler(this.txt_6_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_check_6);
            this.groupBox2.Controls.Add(this.txt_check_5);
            this.groupBox2.Controls.Add(this.txt_check_4);
            this.groupBox2.Controls.Add(this.txt_check_3);
            this.groupBox2.Controls.Add(this.txt_check_2);
            this.groupBox2.Controls.Add(this.txt_check_1);
            this.groupBox2.Location = new System.Drawing.Point(317, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(239, 42);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ㅇ";
            // 
            // txt_check_6
            // 
            this.txt_check_6.BackColor = System.Drawing.SystemColors.Info;
            this.txt_check_6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_check_6.Location = new System.Drawing.Point(185, 15);
            this.txt_check_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_check_6.Name = "txt_check_6";
            this.txt_check_6.Size = new System.Drawing.Size(26, 23);
            this.txt_check_6.TabIndex = 15;
            this.txt_check_6.TextChanged += new System.EventHandler(this.txt_45_TextChanged);
            // 
            // txt_check_5
            // 
            this.txt_check_5.BackColor = System.Drawing.SystemColors.Info;
            this.txt_check_5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_check_5.Location = new System.Drawing.Point(153, 15);
            this.txt_check_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_check_5.Name = "txt_check_5";
            this.txt_check_5.Size = new System.Drawing.Size(26, 23);
            this.txt_check_5.TabIndex = 14;
            this.txt_check_5.TextChanged += new System.EventHandler(this.txt_45_TextChanged);
            // 
            // txt_check_4
            // 
            this.txt_check_4.BackColor = System.Drawing.SystemColors.Info;
            this.txt_check_4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_check_4.Location = new System.Drawing.Point(121, 15);
            this.txt_check_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_check_4.Name = "txt_check_4";
            this.txt_check_4.Size = new System.Drawing.Size(26, 23);
            this.txt_check_4.TabIndex = 13;
            this.txt_check_4.TextChanged += new System.EventHandler(this.txt_45_TextChanged);
            // 
            // txt_check_3
            // 
            this.txt_check_3.BackColor = System.Drawing.SystemColors.Info;
            this.txt_check_3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_check_3.Location = new System.Drawing.Point(89, 15);
            this.txt_check_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_check_3.Name = "txt_check_3";
            this.txt_check_3.Size = new System.Drawing.Size(26, 23);
            this.txt_check_3.TabIndex = 12;
            this.txt_check_3.TextChanged += new System.EventHandler(this.txt_45_TextChanged);
            // 
            // txt_check_2
            // 
            this.txt_check_2.BackColor = System.Drawing.SystemColors.Info;
            this.txt_check_2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_check_2.Location = new System.Drawing.Point(57, 15);
            this.txt_check_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_check_2.Name = "txt_check_2";
            this.txt_check_2.Size = new System.Drawing.Size(26, 23);
            this.txt_check_2.TabIndex = 11;
            this.txt_check_2.TextChanged += new System.EventHandler(this.txt_45_TextChanged);
            // 
            // txt_check_1
            // 
            this.txt_check_1.BackColor = System.Drawing.SystemColors.Info;
            this.txt_check_1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_check_1.Location = new System.Drawing.Point(25, 15);
            this.txt_check_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_check_1.Name = "txt_check_1";
            this.txt_check_1.Size = new System.Drawing.Size(26, 23);
            this.txt_check_1.TabIndex = 8;
            this.txt_check_1.TextChanged += new System.EventHandler(this.txt_45_TextChanged);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.gb_option);
            this.Controls.Add(this.dgv_statistics);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Statistics";
            this.Text = "통계";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistics)).EndInit();
            this.gb_option.ResumeLayout(false);
            this.gb_option.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_statistics;
        private System.Windows.Forms.GroupBox gb_option;
        private System.Windows.Forms.RadioButton rb_odd;
        private System.Windows.Forms.RadioButton rb_even;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_odd_even;
        private System.Windows.Forms.TextBox txt_odd_even_count;
        private System.Windows.Forms.RadioButton rb_setting_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_setting_search_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_win_num_count;
        private System.Windows.Forms.ComboBox cb_end;
        private System.Windows.Forms.ComboBox cb_start;
        private System.Windows.Forms.RadioButton rb_check_win;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_check_6;
        private System.Windows.Forms.TextBox txt_check_5;
        private System.Windows.Forms.TextBox txt_check_4;
        private System.Windows.Forms.TextBox txt_check_3;
        private System.Windows.Forms.TextBox txt_check_2;
        private System.Windows.Forms.TextBox txt_check_1;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.RadioButton rb_total_sum;
    }
}