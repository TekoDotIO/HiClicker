using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HiClicker
{
    public partial class ChoosePos : Form
    {
        public ChoosePos()
        {
            InitializeComponent();
        }

        public Point pos = new Point(-1, -1);

        private void GetPos(object sender, EventArgs e)
        {
            pos = Control.MousePosition;
            Close();
        }

    }
}
