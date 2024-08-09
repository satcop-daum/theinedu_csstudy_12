namespace Ch03Form
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbCardYn = new System.Windows.Forms.CheckBox();
            this.cbMnmYn = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "나이 :";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(132, 197);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 21);
            this.tbResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "입장 시간 :";
            // 
            // cbTime
            // 
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbTime.Location = new System.Drawing.Point(132, 62);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(100, 20);
            this.cbTime.TabIndex = 1;
            // 
            // cbCardYn
            // 
            this.cbCardYn.AutoSize = true;
            this.cbCardYn.Location = new System.Drawing.Point(52, 113);
            this.cbCardYn.Name = "cbCardYn";
            this.cbCardYn.Size = new System.Drawing.Size(104, 16);
            this.cbCardYn.TabIndex = 2;
            this.cbCardYn.Text = "복지 카드 여부";
            this.cbCardYn.UseVisualStyleBackColor = true;
            // 
            // cbMnmYn
            // 
            this.cbMnmYn.AutoSize = true;
            this.cbMnmYn.Location = new System.Drawing.Point(199, 113);
            this.cbMnmYn.Name = "cbMnmYn";
            this.cbMnmYn.Size = new System.Drawing.Size(116, 16);
            this.cbMnmYn.TabIndex = 3;
            this.cbMnmYn.Text = "국가 유공자 여부";
            this.cbMnmYn.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(70, 150);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(215, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "입장료 계산 하기";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(132, 29);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 21);
            this.tbAge.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 257);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cbMnmYn);
            this.Controls.Add(this.cbCardYn);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "놀이동산 입장료 계산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.CheckBox cbCardYn;
        private System.Windows.Forms.CheckBox cbMnmYn;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbAge;
    }
}