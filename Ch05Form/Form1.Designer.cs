namespace Ch05Form
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.nudAlarmHour = new System.Windows.Forms.NumericUpDown();
            this.nudAlarmMinute = new System.Windows.Forms.NumericUpDown();
            this.cbAlarmYn = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlarmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlarmMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(20, 252);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(177, 60);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "버튼 클릭";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.ContextMenuStrip = this.contextMenuStrip1;
            this.lblTime.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(510, 70);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnTextColor,
            this.cmnBackgroundColor});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 48);
            // 
            // cmnTextColor
            // 
            this.cmnTextColor.Name = "cmnTextColor";
            this.cmnTextColor.Size = new System.Drawing.Size(175, 22);
            this.cmnTextColor.Text = "텍스트 색상 변경...";
            this.cmnTextColor.Click += new System.EventHandler(this.cmnTextColor_Click);
            // 
            // cmnBackgroundColor
            // 
            this.cmnBackgroundColor.Name = "cmnBackgroundColor";
            this.cmnBackgroundColor.Size = new System.Drawing.Size(175, 22);
            this.cmnBackgroundColor.Text = "배경 색상 변경...";
            this.cmnBackgroundColor.Click += new System.EventHandler(this.cmnBackgroundColor_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // nudAlarmHour
            // 
            this.nudAlarmHour.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAlarmHour.Location = new System.Drawing.Point(316, 148);
            this.nudAlarmHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudAlarmHour.Name = "nudAlarmHour";
            this.nudAlarmHour.Size = new System.Drawing.Size(80, 46);
            this.nudAlarmHour.TabIndex = 2;
            // 
            // nudAlarmMinute
            // 
            this.nudAlarmMinute.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAlarmMinute.Location = new System.Drawing.Point(411, 148);
            this.nudAlarmMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudAlarmMinute.Name = "nudAlarmMinute";
            this.nudAlarmMinute.Size = new System.Drawing.Size(70, 46);
            this.nudAlarmMinute.TabIndex = 3;
            this.nudAlarmMinute.ValueChanged += new System.EventHandler(this.nudAlarmMinute_ValueChanged);
            // 
            // cbAlarmYn
            // 
            this.cbAlarmYn.AutoSize = true;
            this.cbAlarmYn.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlarmYn.Location = new System.Drawing.Point(279, 163);
            this.cbAlarmYn.Name = "cbAlarmYn";
            this.cbAlarmYn.Size = new System.Drawing.Size(15, 14);
            this.cbAlarmYn.TabIndex = 4;
            this.cbAlarmYn.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 324);
            this.Controls.Add(this.cbAlarmYn);
            this.Controls.Add(this.nudAlarmMinute);
            this.Controls.Add(this.nudAlarmHour);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnOK);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "윈폼 프로그래밍";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAlarmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlarmMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.NumericUpDown nudAlarmHour;
        private System.Windows.Forms.NumericUpDown nudAlarmMinute;
        private System.Windows.Forms.CheckBox cbAlarmYn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmnTextColor;
        private System.Windows.Forms.ToolStripMenuItem cmnBackgroundColor;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

