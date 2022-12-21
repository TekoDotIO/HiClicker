using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace HiClicker
{
    public partial class MainWindow : Form
    {
        public bool enableRunning = false;
        Thread t;
        bool abort = false;

        public MainWindow()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Clicker));
            t.Start();
        }

        ~MainWindow()
        {
            abort = true;
        }

        private void ChoosePos(object sender, EventArgs e)
        {
            ChoosePos cp = new ChoosePos();
            Hide();
            cp.ShowDialog();
            Point p = cp.pos;
            TargetX.Text = p.X.ToString();
            TargetY.Text = p.Y.ToString();
            Show();
            
        }

        private void StartRunning(object sender, EventArgs e)
        {
            enableRunning = true;
        }

        void Clicker()
        {
            while (true)
            {
                if (enableRunning)
                {
                    MouseHelper.SetCursorPos(Convert.ToInt32(TargetX.Text), Convert.ToInt32(TargetY.Text));
                    MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    Thread.Sleep(Convert.ToInt32(WaitTime.Text));
                }
                if (abort)
                {
                    return;
                }
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            abort = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            DebugTool d = new DebugTool();
            d.Show();
        }

        private void WaitTimeHelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这个选项代表两次点击之间的延时,单位是毫秒.\n注意:如果您不在本地测试此程序(需要在游戏/网络软件中使用),请格外关注软件是否有反外挂/连点器功能.过快的点击速度可能导致系统卡顿/掉帧/被封禁!\n将此选项设置为0可停用延时功能.", "这是什么");
        }
    }
}
