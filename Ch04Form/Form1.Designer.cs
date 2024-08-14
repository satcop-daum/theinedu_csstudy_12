namespace Ch04Form
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(35, 43);
            this.tbInput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(502, 39);
            this.tbInput.TabIndex = 0;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(35, 118);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(502, 39);
            this.tbOutput.TabIndex = 1;
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(592, 40);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(185, 39);
            this.btnStartWith.TabIndex = 2;
            this.btnStartWith.Text = "StartWith";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(592, 85);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(185, 39);
            this.btnEndWith.TabIndex = 3;
            this.btnEndWith.Text = "EdnWith";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(592, 130);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(185, 39);
            this.btnContains.TabIndex = 4;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(592, 175);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(185, 39);
            this.btnUpper.TabIndex = 5;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(592, 220);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(185, 39);
            this.btnLower.TabIndex = 6;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(592, 265);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(185, 39);
            this.btnSubstring.TabIndex = 7;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(35, 210);
            this.tbResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(502, 225);
            this.tbResult.TabIndex = 8;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(592, 310);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(185, 39);
            this.btnSplit.TabIndex = 9;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 448);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnEndWith);
            this.Controls.Add(this.btnStartWith);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btnSplit;
    }
}

