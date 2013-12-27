namespace 定时关机小程序
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLhour = new System.Windows.Forms.TextBox();
            this.txtLminute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.rbtnLongTime = new System.Windows.Forms.RadioButton();
            this.rbtnSpcTime = new System.Windows.Forms.RadioButton();
            this.rbtnShutdown = new System.Windows.Forms.RadioButton();
            this.rbtnLogout = new System.Windows.Forms.RadioButton();
            this.rbtnReboot = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpb = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpb.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLhour
            // 
            this.txtLhour.Location = new System.Drawing.Point(121, 19);
            this.txtLhour.Name = "txtLhour";
            this.txtLhour.Size = new System.Drawing.Size(66, 21);
            this.txtLhour.TabIndex = 0;
            this.txtLhour.TextChanged += new System.EventHandler(this.txtLhour_TextChanged);
            this.txtLhour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLhour_KeyPress);
            this.txtLhour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLhour_MouseUp);
            // 
            // txtLminute
            // 
            this.txtLminute.Location = new System.Drawing.Point(233, 19);
            this.txtLminute.Name = "txtLminute";
            this.txtLminute.Size = new System.Drawing.Size(65, 21);
            this.txtLminute.TabIndex = 1;
            this.txtLminute.TextChanged += new System.EventHandler(this.txtLhour_TextChanged);
            this.txtLminute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLhour_KeyPress);
            this.txtLminute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLhour_MouseUp);
            // 
            // txtHour
            // 
            this.txtHour.Enabled = false;
            this.txtHour.Location = new System.Drawing.Point(258, 72);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(28, 21);
            this.txtHour.TabIndex = 5;
            this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            this.txtHour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLhour_MouseUp);
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Location = new System.Drawing.Point(156, 72);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(28, 21);
            this.txtMonth.TabIndex = 3;
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            this.txtMonth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLhour_MouseUp);
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Location = new System.Drawing.Point(207, 72);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(28, 21);
            this.txtDay.TabIndex = 4;
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            this.txtDay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLhour_MouseUp);
            // 
            // txtMinute
            // 
            this.txtMinute.Enabled = false;
            this.txtMinute.Location = new System.Drawing.Point(309, 72);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(28, 21);
            this.txtMinute.TabIndex = 6;
            this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            this.txtMinute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtLhour_MouseUp);
            // 
            // rbtnLongTime
            // 
            this.rbtnLongTime.AutoSize = true;
            this.rbtnLongTime.Checked = true;
            this.rbtnLongTime.Location = new System.Drawing.Point(8, 21);
            this.rbtnLongTime.Name = "rbtnLongTime";
            this.rbtnLongTime.Size = new System.Drawing.Size(107, 16);
            this.rbtnLongTime.TabIndex = 13;
            this.rbtnLongTime.TabStop = true;
            this.rbtnLongTime.Text = "按多长时间后：";
            this.rbtnLongTime.UseVisualStyleBackColor = true;
            this.rbtnLongTime.CheckedChanged += new System.EventHandler(this.rbtnLongTime_CheckedChanged);
            // 
            // rbtnSpcTime
            // 
            this.rbtnSpcTime.AutoSize = true;
            this.rbtnSpcTime.Location = new System.Drawing.Point(8, 74);
            this.rbtnSpcTime.Name = "rbtnSpcTime";
            this.rbtnSpcTime.Size = new System.Drawing.Size(107, 16);
            this.rbtnSpcTime.TabIndex = 2;
            this.rbtnSpcTime.Text = "按具体时间点：";
            this.rbtnSpcTime.UseVisualStyleBackColor = true;
            this.rbtnSpcTime.CheckedChanged += new System.EventHandler(this.rbtnSpcTime_CheckedChanged);
            // 
            // rbtnShutdown
            // 
            this.rbtnShutdown.AutoSize = true;
            this.rbtnShutdown.Location = new System.Drawing.Point(33, 3);
            this.rbtnShutdown.Name = "rbtnShutdown";
            this.rbtnShutdown.Size = new System.Drawing.Size(47, 16);
            this.rbtnShutdown.TabIndex = 8;
            this.rbtnShutdown.TabStop = true;
            this.rbtnShutdown.Text = "关机";
            this.rbtnShutdown.UseVisualStyleBackColor = true;
            // 
            // rbtnLogout
            // 
            this.rbtnLogout.AutoSize = true;
            this.rbtnLogout.Location = new System.Drawing.Point(125, 3);
            this.rbtnLogout.Name = "rbtnLogout";
            this.rbtnLogout.Size = new System.Drawing.Size(47, 16);
            this.rbtnLogout.TabIndex = 9;
            this.rbtnLogout.TabStop = true;
            this.rbtnLogout.Text = "注销";
            this.rbtnLogout.UseVisualStyleBackColor = true;
            // 
            // rbtnReboot
            // 
            this.rbtnReboot.AutoSize = true;
            this.rbtnReboot.Location = new System.Drawing.Point(217, 3);
            this.rbtnReboot.Name = "rbtnReboot";
            this.rbtnReboot.Size = new System.Drawing.Size(47, 16);
            this.rbtnReboot.TabIndex = 10;
            this.rbtnReboot.TabStop = true;
            this.rbtnReboot.Text = "重启";
            this.rbtnReboot.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(14, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Tag = "0";
            this.btnConfirm.Text = "确认计划[&S]";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(121, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消计划[&C]";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "小时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "分";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(113, 76);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(0, 12);
            this.lblYear.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "月";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "时";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "分";
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.txtHour);
            this.gpb.Controls.Add(this.label7);
            this.gpb.Controls.Add(this.txtLhour);
            this.gpb.Controls.Add(this.label6);
            this.gpb.Controls.Add(this.txtLminute);
            this.gpb.Controls.Add(this.label5);
            this.gpb.Controls.Add(this.txtMonth);
            this.gpb.Controls.Add(this.label4);
            this.gpb.Controls.Add(this.txtDay);
            this.gpb.Controls.Add(this.label3);
            this.gpb.Controls.Add(this.txtMinute);
            this.gpb.Controls.Add(this.lblYear);
            this.gpb.Controls.Add(this.rbtnLongTime);
            this.gpb.Controls.Add(this.label2);
            this.gpb.Controls.Add(this.rbtnSpcTime);
            this.gpb.Controls.Add(this.label1);
            this.gpb.Location = new System.Drawing.Point(15, 12);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(371, 119);
            this.gpb.TabIndex = 21;
            this.gpb.TabStop = false;
            this.gpb.Text = "设置任务执行时间：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnLogout);
            this.panel1.Controls.Add(this.rbtnShutdown);
            this.panel1.Controls.Add(this.rbtnReboot);
            this.panel1.Location = new System.Drawing.Point(56, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 29);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(93, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 27);
            this.panel2.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "定时关机小工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 216);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时关机小工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.gpb.ResumeLayout(false);
            this.gpb.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLhour;
        private System.Windows.Forms.TextBox txtLminute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.RadioButton rbtnLongTime;
        private System.Windows.Forms.RadioButton rbtnSpcTime;
        private System.Windows.Forms.RadioButton rbtnShutdown;
        private System.Windows.Forms.RadioButton rbtnLogout;
        private System.Windows.Forms.RadioButton rbtnReboot;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

