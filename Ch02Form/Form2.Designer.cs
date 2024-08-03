namespace Ch02Form
{
    partial class Form2
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tb50000 = new System.Windows.Forms.TextBox();
            this.tb10000 = new System.Windows.Forms.TextBox();
            this.tb5000 = new System.Windows.Forms.TextBox();
            this.tb1000 = new System.Windows.Forms.TextBox();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(225, 32);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 21);
            this.tbInput.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(193, 81);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "계산하기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tb50000
            // 
            this.tb50000.Location = new System.Drawing.Point(225, 131);
            this.tb50000.Name = "tb50000";
            this.tb50000.Size = new System.Drawing.Size(100, 21);
            this.tb50000.TabIndex = 2;
            // 
            // tb10000
            // 
            this.tb10000.Location = new System.Drawing.Point(225, 158);
            this.tb10000.Name = "tb10000";
            this.tb10000.Size = new System.Drawing.Size(100, 21);
            this.tb10000.TabIndex = 2;
            // 
            // tb5000
            // 
            this.tb5000.Location = new System.Drawing.Point(225, 185);
            this.tb5000.Name = "tb5000";
            this.tb5000.Size = new System.Drawing.Size(100, 21);
            this.tb5000.TabIndex = 2;
            // 
            // tb1000
            // 
            this.tb1000.Location = new System.Drawing.Point(225, 212);
            this.tb1000.Name = "tb1000";
            this.tb1000.Size = new System.Drawing.Size(100, 21);
            this.tb1000.TabIndex = 2;
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(225, 239);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(100, 21);
            this.tbTip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "입력 금액:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "오만원:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "만원:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "오천원:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "천원:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "팁:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 333);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.tb1000);
            this.Controls.Add(this.tb5000);
            this.Controls.Add(this.tb10000);
            this.Controls.Add(this.tb50000);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbInput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tb50000;
        private System.Windows.Forms.TextBox tb10000;
        private System.Windows.Forms.TextBox tb5000;
        private System.Windows.Forms.TextBox tb1000;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}