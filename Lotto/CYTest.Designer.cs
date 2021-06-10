namespace Lotto
{
    partial class CYTest
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
            this.cb_round_list = new System.Windows.Forms.ComboBox();
            this.chb_x_calcurator = new System.Windows.Forms.CheckBox();
            this.btn_calcurator = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_round_list
            // 
            this.cb_round_list.BackColor = System.Drawing.SystemColors.Info;
            this.cb_round_list.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cb_round_list.FormattingEnabled = true;
            this.cb_round_list.Location = new System.Drawing.Point(24, 27);
            this.cb_round_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_round_list.Name = "cb_round_list";
            this.cb_round_list.Size = new System.Drawing.Size(76, 20);
            this.cb_round_list.TabIndex = 6;
            // 
            // chb_x_calcurator
            // 
            this.chb_x_calcurator.AutoSize = true;
            this.chb_x_calcurator.Location = new System.Drawing.Point(28, 73);
            this.chb_x_calcurator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chb_x_calcurator.Name = "chb_x_calcurator";
            this.chb_x_calcurator.Size = new System.Drawing.Size(72, 16);
            this.chb_x_calcurator.TabIndex = 49;
            this.chb_x_calcurator.Text = "X축 계산";
            this.chb_x_calcurator.UseVisualStyleBackColor = true;
            // 
            // btn_calcurator
            // 
            this.btn_calcurator.Location = new System.Drawing.Point(324, 27);
            this.btn_calcurator.Name = "btn_calcurator";
            this.btn_calcurator.Size = new System.Drawing.Size(75, 23);
            this.btn_calcurator.TabIndex = 50;
            this.btn_calcurator.Text = "계산";
            this.btn_calcurator.UseVisualStyleBackColor = true;
            this.btn_calcurator.Click += new System.EventHandler(this.btn_calcurator_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 350);
            this.textBox1.TabIndex = 51;
            // 
            // CYTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_calcurator);
            this.Controls.Add(this.chb_x_calcurator);
            this.Controls.Add(this.cb_round_list);
            this.Name = "CYTest";
            this.Text = "CYTest";
            this.Load += new System.EventHandler(this.CYTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_round_list;
        private System.Windows.Forms.CheckBox chb_x_calcurator;
        private System.Windows.Forms.Button btn_calcurator;
        private System.Windows.Forms.TextBox textBox1;
    }
}