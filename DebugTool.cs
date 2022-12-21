using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HiClicker
{
    public partial class DebugTool : Form
    {
        int count = 0;
        public DebugTool()
        {
            InitializeComponent();
        }

        private void DebugTool_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            DisplayCount.Text = $"当前已点击{count}次";
        }
    }
}
