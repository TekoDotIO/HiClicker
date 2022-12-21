namespace HiClicker
{
    partial class MainWindow
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
            this.TitleBar = new System.Windows.Forms.Label();
            this.SubTitleBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetX = new System.Windows.Forms.TextBox();
            this.TargetY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WaitTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WaitTimeHelpBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.AutoSize = true;
            this.TitleBar.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleBar.Location = new System.Drawing.Point(28, 24);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(99, 26);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Text = "HiClicker";
            // 
            // SubTitleBar
            // 
            this.SubTitleBar.AutoSize = true;
            this.SubTitleBar.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubTitleBar.Location = new System.Drawing.Point(28, 50);
            this.SubTitleBar.Name = "SubTitleBar";
            this.SubTitleBar.Size = new System.Drawing.Size(121, 20);
            this.SubTitleBar.TabIndex = 1;
            this.SubTitleBar.Text = "鼠标连续点击工具";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "目标位置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // TargetX
            // 
            this.TargetX.Location = new System.Drawing.Point(104, 85);
            this.TargetX.Name = "TargetX";
            this.TargetX.Size = new System.Drawing.Size(45, 23);
            this.TargetX.TabIndex = 4;
            // 
            // TargetY
            // 
            this.TargetY.Location = new System.Drawing.Point(175, 85);
            this.TargetY.Name = "TargetY";
            this.TargetY.Size = new System.Drawing.Size(45, 23);
            this.TargetY.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(235, 85);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(59, 23);
            this.ChooseBtn.TabIndex = 7;
            this.ChooseBtn.Text = "选择...";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChoosePos);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "连点延时";
            // 
            // WaitTime
            // 
            this.WaitTime.Location = new System.Drawing.Point(87, 116);
            this.WaitTime.Name = "WaitTime";
            this.WaitTime.Size = new System.Drawing.Size(45, 23);
            this.WaitTime.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(138, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ms";
            // 
            // WaitTimeHelpBtn
            // 
            this.WaitTimeHelpBtn.Location = new System.Drawing.Point(161, 116);
            this.WaitTimeHelpBtn.Name = "WaitTimeHelpBtn";
            this.WaitTimeHelpBtn.Size = new System.Drawing.Size(31, 23);
            this.WaitTimeHelpBtn.TabIndex = 11;
            this.WaitTimeHelpBtn.Text = "?";
            this.WaitTimeHelpBtn.UseVisualStyleBackColor = true;
            this.WaitTimeHelpBtn.Click += new System.EventHandler(this.WaitTimeHelpBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "注:按Esc以结束连点.";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(28, 183);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 13;
            this.StartBtn.Text = "启动";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartRunning);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "相互科技2022版权所有";
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(235, 24);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(75, 23);
            this.TestBtn.TabIndex = 15;
            this.TestBtn.Text = "调试器";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 263);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WaitTimeHelpBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WaitTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.TargetY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TargetX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubTitleBar);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "HiClicker设置窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.Label SubTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TargetX;
        private System.Windows.Forms.TextBox TargetY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WaitTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button WaitTimeHelpBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button TestBtn;
    }
}