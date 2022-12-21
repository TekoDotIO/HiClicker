using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiClicker
{
    internal static class Program
    {
        static MainWindow m;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            m = new MainWindow();
            var k_hook = new HotKeyApi();
            k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);//钩住键按下
            k_hook.Start();//安装键盘钩子
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            
            Application.Run(m);
        }

        static private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            //判断按下的键（Esc）
            if (e.KeyValue == (int)Keys.Escape)
            {
                m.enableRunning = false;
            }
        }
    }
}
