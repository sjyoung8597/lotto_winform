namespace Lotto
{
    partial class CreateLottoNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLottoNum));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ckb_logic_create = new System.Windows.Forms.CheckBox();
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.gb_del = new System.Windows.Forms.GroupBox();
            this.btn_game50 = new System.Windows.Forms.Button();
            this.btn_game20 = new System.Windows.Forms.Button();
            this.btn_game10 = new System.Windows.Forms.Button();
            this.btn_game1 = new System.Windows.Forms.Button();
            this.btn_game5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.prog_game = new System.Windows.Forms.ProgressBar();
            this.lb_probability = new System.Windows.Forms.Label();
            this.lb_probability2 = new System.Windows.Forms.Label();
            this.lb_probability3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_test);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ckb_logic_create);
            this.groupBox1.Controls.Add(this.gb_add);
            this.groupBox1.Controls.Add(this.gb_del);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(450, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조합옵션";
            // 
            // btn_test
            // 
            this.btn_test.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_test.Location = new System.Drawing.Point(362, 49);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 55;
            this.btn_test.Text = "테스트";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 30F);
            this.label5.Location = new System.Drawing.Point(55, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 54);
            this.label5.TabIndex = 54;
            this.label5.Text = "추가 기능 개발중";
            // 
            // ckb_logic_create
            // 
            this.ckb_logic_create.AutoSize = true;
            this.ckb_logic_create.Location = new System.Drawing.Point(26, 22);
            this.ckb_logic_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckb_logic_create.Name = "ckb_logic_create";
            this.ckb_logic_create.Size = new System.Drawing.Size(126, 19);
            this.ckb_logic_create.TabIndex = 48;
            this.ckb_logic_create.Text = "프리미엄조합 사용";
            this.ckb_logic_create.UseVisualStyleBackColor = true;
            // 
            // gb_add
            // 
            this.gb_add.ForeColor = System.Drawing.SystemColors.Info;
            this.gb_add.Location = new System.Drawing.Point(15, 191);
            this.gb_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_add.Name = "gb_add";
            this.gb_add.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_add.Size = new System.Drawing.Size(422, 142);
            this.gb_add.TabIndex = 47;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "번호 추가";
            // 
            // gb_del
            // 
            this.gb_del.ForeColor = System.Drawing.SystemColors.Info;
            this.gb_del.Location = new System.Drawing.Point(15, 341);
            this.gb_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_del.Name = "gb_del";
            this.gb_del.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_del.Size = new System.Drawing.Size(422, 142);
            this.gb_del.TabIndex = 48;
            this.gb_del.TabStop = false;
            this.gb_del.Text = "번호 제외";
            // 
            // btn_game50
            // 
            this.btn_game50.BackColor = System.Drawing.SystemColors.Info;
            this.btn_game50.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_game50.Location = new System.Drawing.Point(712, 24);
            this.btn_game50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_game50.Name = "btn_game50";
            this.btn_game50.Size = new System.Drawing.Size(54, 32);
            this.btn_game50.TabIndex = 53;
            this.btn_game50.Text = "50게임";
            this.btn_game50.UseVisualStyleBackColor = false;
            this.btn_game50.Click += new System.EventHandler(this.btn_game50_Click);
            // 
            // btn_game20
            // 
            this.btn_game20.BackColor = System.Drawing.SystemColors.Info;
            this.btn_game20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_game20.Location = new System.Drawing.Point(652, 24);
            this.btn_game20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_game20.Name = "btn_game20";
            this.btn_game20.Size = new System.Drawing.Size(54, 32);
            this.btn_game20.TabIndex = 52;
            this.btn_game20.Text = "20게임";
            this.btn_game20.UseVisualStyleBackColor = false;
            this.btn_game20.Click += new System.EventHandler(this.btn_game20_Click);
            // 
            // btn_game10
            // 
            this.btn_game10.BackColor = System.Drawing.SystemColors.Info;
            this.btn_game10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_game10.Location = new System.Drawing.Point(592, 24);
            this.btn_game10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_game10.Name = "btn_game10";
            this.btn_game10.Size = new System.Drawing.Size(54, 32);
            this.btn_game10.TabIndex = 51;
            this.btn_game10.Text = "10게임";
            this.btn_game10.UseVisualStyleBackColor = false;
            this.btn_game10.Click += new System.EventHandler(this.btn_game10_Click);
            // 
            // btn_game1
            // 
            this.btn_game1.BackColor = System.Drawing.SystemColors.Info;
            this.btn_game1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_game1.Location = new System.Drawing.Point(472, 24);
            this.btn_game1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_game1.Name = "btn_game1";
            this.btn_game1.Size = new System.Drawing.Size(54, 32);
            this.btn_game1.TabIndex = 49;
            this.btn_game1.Text = "1게임";
            this.btn_game1.UseVisualStyleBackColor = false;
            this.btn_game1.Click += new System.EventHandler(this.btn_game1_Click);
            // 
            // btn_game5
            // 
            this.btn_game5.BackColor = System.Drawing.SystemColors.Info;
            this.btn_game5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_game5.Location = new System.Drawing.Point(532, 24);
            this.btn_game5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_game5.Name = "btn_game5";
            this.btn_game5.Size = new System.Drawing.Size(54, 32);
            this.btn_game5.TabIndex = 50;
            this.btn_game5.Text = "5게임";
            this.btn_game5.UseVisualStyleBackColor = false;
            this.btn_game5.Click += new System.EventHandler(this.btn_game5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_result);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Location = new System.Drawing.Point(468, 64);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(303, 442);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "결과";
            // 
            // dgv_result
            // 
            this.dgv_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_result.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_result.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_result.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_result.Location = new System.Drawing.Point(6, 23);
            this.dgv_result.Name = "dgv_result";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_result.RowHeadersWidth = 20;
            this.dgv_result.RowTemplate.Height = 23;
            this.dgv_result.Size = new System.Drawing.Size(292, 411);
            this.dgv_result.TabIndex = 0;
            // 
            // prog_game
            // 
            this.prog_game.Location = new System.Drawing.Point(8, 543);
            this.prog_game.Name = "prog_game";
            this.prog_game.Size = new System.Drawing.Size(763, 11);
            this.prog_game.TabIndex = 3;
            // 
            // lb_probability
            // 
            this.lb_probability.AutoSize = true;
            this.lb_probability.ForeColor = System.Drawing.Color.White;
            this.lb_probability.Location = new System.Drawing.Point(12, 510);
            this.lb_probability.Name = "lb_probability";
            this.lb_probability.Size = new System.Drawing.Size(27, 15);
            this.lb_probability.TabIndex = 54;
            this.lb_probability.Text = "text";
            // 
            // lb_probability2
            // 
            this.lb_probability2.AutoSize = true;
            this.lb_probability2.ForeColor = System.Drawing.Color.White;
            this.lb_probability2.Location = new System.Drawing.Point(90, 510);
            this.lb_probability2.Name = "lb_probability2";
            this.lb_probability2.Size = new System.Drawing.Size(27, 15);
            this.lb_probability2.TabIndex = 55;
            this.lb_probability2.Text = "text";
            // 
            // lb_probability3
            // 
            this.lb_probability3.AutoSize = true;
            this.lb_probability3.ForeColor = System.Drawing.Color.White;
            this.lb_probability3.Location = new System.Drawing.Point(361, 510);
            this.lb_probability3.Name = "lb_probability3";
            this.lb_probability3.Size = new System.Drawing.Size(27, 15);
            this.lb_probability3.TabIndex = 56;
            this.lb_probability3.Text = "text";
            // 
            // CreateLottoNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(783, 566);
            this.Controls.Add(this.lb_probability3);
            this.Controls.Add(this.lb_probability2);
            this.Controls.Add(this.lb_probability);
            this.Controls.Add(this.btn_game50);
            this.Controls.Add(this.prog_game);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_game20);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_game10);
            this.Controls.Add(this.btn_game1);
            this.Controls.Add(this.btn_game5);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CreateLottoNum";
            this.Text = "조합 번호 생성";
            this.Load += new System.EventHandler(this.CreateLottoNum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_del;
        private System.Windows.Forms.Button btn_game50;
        private System.Windows.Forms.Button btn_game20;
        private System.Windows.Forms.Button btn_game10;
        private System.Windows.Forms.Button btn_game5;
        private System.Windows.Forms.Button btn_game1;
        private System.Windows.Forms.CheckBox ckb_logic_create;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar prog_game;
        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lb_probability;
        private System.Windows.Forms.Label lb_probability2;
        private System.Windows.Forms.Label lb_probability3;
    }
}