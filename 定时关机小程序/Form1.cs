using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace 定时关机小程序
{


    public partial class Form1 : Form
    {
        /// <summary>
        /// 全局变量
        /// </summary>
        DateTime datetimeNow;
        bool status = true;

        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx", CharSet = CharSet.Ansi)]
        private static extern int ExitWindowsEx(int uFlags, int dwReserved);

        public void zhuxiao() //注销
        {
            ExitWindowsEx(0, 0);
        }

        public void guanji()//关机
        {
            try
            {
                Process.Start("Shutdown.exe", " -s -t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void chongqi()//重启
        {
            try
            {
                Process.Start("shutdown.exe", " -r -t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnSpcTime_CheckedChanged(object sender, EventArgs e)
        {
            txtMonth.Enabled = !txtMonth.Enabled;
            txtDay.Enabled = !txtDay.Enabled;
            txtHour.Enabled = !txtHour.Enabled;
            txtMinute.Enabled = !txtMinute.Enabled;
        }

        private void rbtnLongTime_CheckedChanged(object sender, EventArgs e)
        {
            txtLhour.Enabled = !txtLhour.Enabled;
            txtLminute.Enabled = !txtLminute.Enabled;
        }

        /// <summary>
        /// 确认按钮的功能实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLhour.Text) && string.IsNullOrEmpty(txtLminute.Text))
            {
                MessageBox.Show("时间不能为空！");
                return;
            }
            btnConfirm.Enabled = false;
            btnCancel.Enabled = true;
            ConfirmCancel();
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 取消按钮功能实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnConfirm.Enabled = true;
            ConfirmCancel();
        }

        /// <summary>
        /// 确认取消计划方法
        /// </summary>
        /// <param name="s"></param>
        private void ConfirmCancel()
        {
            timer1.Enabled = !timer1.Enabled;
            if (rbtnLongTime.Checked == true)
            {
                txtLhour.Enabled = !txtLhour.Enabled;
                txtLminute.Enabled = !txtLminute.Enabled;
                rbtnSpcTime.Enabled = !rbtnSpcTime.Enabled;
            }
            if (rbtnSpcTime.Checked == true)
            {
                txtMinute.Enabled = !txtMinute.Enabled;
                txtMonth.Enabled = !txtMonth.Enabled;
                txtHour.Enabled = !txtHour.Enabled;
                txtDay.Enabled = !txtDay.Enabled;
                rbtnLongTime.Enabled = !rbtnLongTime.Enabled;
            }
            rbtnLogout.Enabled = !rbtnLogout.Enabled;
            rbtnReboot.Enabled = !rbtnReboot.Enabled;
            rbtnShutdown.Enabled = !rbtnShutdown.Enabled;
            txtLhour.Text = "";
            txtLminute.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datetimeNow = DateTime.Now;
            DateTime dt = new DateTime(Convert.ToInt32(lblYear.Text), Convert.ToInt32(txtMonth.Text), Convert.ToInt32(txtDay.Text), Convert.ToInt32(txtHour.Text), Convert.ToInt32(txtMinute.Text), 31);
            TimeSpan lastime = dt - datetimeNow;
            if (Convert.ToInt32(lastime.TotalSeconds) == 30)
            {
                string result = "";
                if (rbtnLogout.Checked) result = rbtnLogout.Text;
                if (rbtnReboot.Checked) result = rbtnReboot.Text;
                if (rbtnShutdown.Checked) result = rbtnShutdown.Text;
                if (MessageBox.Show(this, "系统将在30秒后" + result + ",是否继续执行计划？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                    btnCancel_Click(null, null);
            }
            if (dt.ToString() == datetimeNow.ToString())
            {
                if (rbtnLogout.Checked)
                {
                    zhuxiao();
                    Application.Exit();
                }
                if (rbtnReboot.Checked)
                {
                    chongqi();
                    Application.Exit();
                }
                if (rbtnShutdown.Checked)
                {
                    guanji();
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// 保证按键事件为数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLhour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLhour_TextChanged(object sender, EventArgs e)
        {
            if (txtLhour.Focused == true || txtLminute.Focused == true)
            {
                this.planTime(txtLhour.Text, txtLminute.Text);
            }
        }
        /// <summary>
        /// 窗体加载时设置年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string str = DateTime.Now.ToString();
            lblYear.Text = str.Substring(0, str.ToString().IndexOf('/'));
            txtMonth.Text = str.Substring(str.IndexOf('/') + 1, str.LastIndexOf('/') - str.IndexOf('/') - 1);
            txtHour.Text = str.Substring(str.LastIndexOf(' ') + 1, str.IndexOf(':') - str.LastIndexOf(' ') - 1);
            txtMinute.Text = str.Substring(str.IndexOf(':') + 1, str.LastIndexOf(':') - str.IndexOf(':') - 1);
            txtDay.Text = str.Substring(str.LastIndexOf('/') + 1, str.IndexOf(' ') - str.LastIndexOf('/') - 1);
            rbtnShutdown.Checked = true;
            this.status = false;
            this.notifyIcon1.Visible = false;
        }

        /// <summary>
        /// 按多长时间需要调用的方法
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        public void planTime(string hour, string minute)
        {
            datetimeNow = DateTime.Now;
            if (!string.IsNullOrEmpty(hour) || !string.IsNullOrEmpty(minute))
            {
                if (hour == "") hour = "0";
                if (minute == "") minute = "0";
                DateTime planTime = datetimeNow.AddHours(Convert.ToDouble(hour) + Convert.ToDouble(minute) / 60);
                string str = planTime.ToString();
                lblYear.Text = str.Substring(0, str.IndexOf('/'));
                txtMonth.Text = str.Substring(str.IndexOf('/') + 1, str.LastIndexOf('/') - str.IndexOf('/') - 1);
                txtDay.Text = str.Substring(str.LastIndexOf('/') + 1, str.IndexOf(' ') - str.LastIndexOf('/') - 1);
                txtHour.Text = str.Substring(str.LastIndexOf(' ') + 1, str.IndexOf(':') - str.LastIndexOf(' ') - 1);
                txtMinute.Text = str.Substring(str.IndexOf(':') + 1, str.LastIndexOf(':') - str.IndexOf(':') - 1);
            }
            else
            {
                txtMonth.Text = "";
                txtDay.Text = "";
                txtHour.Text = "";
                txtMinute.Text = "";
            }
        }

        public void planSpcTime(string year, string month, string day, string hour, string minute, KeyPressEventArgs e)
        {

            datetimeNow = DateTime.Now;
            if (e.KeyChar != '\b')
            {
                if (txtMonth.Focused == true)
                {
                    month = txtMonth.Text + e.KeyChar;
                }
                if (txtDay.Focused == true)
                {
                    day = txtDay.Text + e.KeyChar;
                }
                if (txtHour.Focused == true)
                {
                    hour = hour + e.KeyChar;
                }
                if (txtMinute.Focused == true)
                {
                    minute = minute + e.KeyChar;
                }
            }
            else
            {
                if (txtMonth.Focused == true && month != "") month = month.Substring(0, month.Length - 1);
                if (txtDay.Focused == true && day != "") day = day.Substring(0, day.Length - 1);
                if (txtHour.Focused == true && hour != "") hour = hour.Substring(0, hour.Length - 1);
                if (txtMinute.Focused == true && minute != "") minute = minute.Substring(0, minute.Length - 1);
            }

            if (status == false)
            {
                if (month == "" && txtMonth.Focused == false)
                {
                    e.Handled = true;
                    MessageBox.Show("请输入月份！");
                    return;
                }
                else
                {
                    if (day == "" && txtDay.Focused == false && txtMonth.Focused == false)
                    {
                        e.Handled = true;
                        MessageBox.Show("请输入日！");
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(month) || string.IsNullOrEmpty(day))
                        {
                            return;
                        }
                        if (Convert.ToInt32(month) < 1 || Convert.ToInt32(month) > 12)
                        {
                            e.Handled = true;
                            MessageBox.Show("月份必须在1~12之间！");
                            return;
                        }
                        if (Convert.ToInt32(day) < 1 || Convert.ToInt32(day) > 31)
                        {
                            e.Handled = true;
                            MessageBox.Show("天数必须在1~31之间!");
                            return;
                        }

                        if (!string.IsNullOrEmpty(hour))
                        {
                            if (Convert.ToInt32(hour) > 23)
                            {
                                e.Handled = true;
                                MessageBox.Show("小时必须在0~23之间!");
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(minute))
                        {
                            if (Convert.ToInt32(minute) > 59)
                            {
                                e.Handled = true;
                                MessageBox.Show("分钟必须在0~60之间!");
                                return;
                            }
                        }

                    }
                }

                if (!string.IsNullOrEmpty(year) || !string.IsNullOrEmpty(month) || !string.IsNullOrEmpty(day) || !string.IsNullOrEmpty(hour) || !string.IsNullOrEmpty(minute))
                {
                    if (hour == "") hour = "0";
                    if (minute == "") minute = "0";
                    DateTime datetime = new DateTime();
                    try
                    {
                        datetime = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day), Convert.ToInt32(hour), Convert.ToInt32(minute), 0);
                    }
                    catch (Exception)
                    {
                        string strDate = string.Format("{0}年{1}月最多有{2}天！", year, month, GetDays(Convert.ToInt32(month), Convert.ToInt32(year)));
                        MessageBox.Show(strDate);
                        e.Handled = true;
                        return;
                    }

                    TimeSpan ts = datetime - datetimeNow;
                    if (ts.Days != 0)
                    {
                        txtLhour.Text = (ts.Hours * ts.Days / Math.Abs(ts.Days) + ts.Days * 24).ToString();
                    }
                    else
                    {
                        txtLhour.Text = ts.Hours.ToString();
                    }
                    txtLminute.Text = ts.Minutes.ToString();
                }
                else
                {
                    txtLhour.Text = "";
                    txtMinute.Text = "";
                }
            }

        }

        private static int GetDays(int month, int year)//返回一年的某月有多少天
        {

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                    break;
                case 2:
                    if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))//四年一闰，百年不闰，四百年再闰。
                    {
                        return 28;
                    }
                    else
                    {
                        return 29;
                    }
                    break;
                default:
                    return 30;
                    break;
            }
        }

        /// <summary>
        /// 更改“按具体时间点”文本框的内容触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (txtMonth.Focused == true || txtDay.Focused == true || txtHour.Focused == true || txtMinute.Focused == true)
            {
                // planSpcTime(lblYear.Text, txtMonth.Text, txtDay.Text, txtHour.Text, txtMinute.Text);

            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (txtMonth.Focused == true || txtDay.Focused == true || txtHour.Focused == true || txtMinute.Focused == true)
            {
                planSpcTime(lblYear.Text, txtMonth.Text, txtDay.Text, txtHour.Text, txtMinute.Text, e);

            }
        }

        /// <summary>
        /// 设置文本框不能用鼠标选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLhour_MouseUp(object sender, MouseEventArgs e)
        {
            //(sender as TextBox).SelectionLength //选中文本的长度为0
            TextBox tb = sender as TextBox;
            if (tb == null) return;
            if (tb.SelectionLength > 0)
            {
                tb.SelectionStart = tb.TextLength;
                tb.SelectionLength = 0;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }

    }
}
