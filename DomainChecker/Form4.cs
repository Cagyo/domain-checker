using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DomainChecker
{
    public partial class Form4 : Form
    {
        int digit;
        public Form4(string str)
        {
            InitializeComponent();
            label1.Text = str;
            digit = this.label1.Size.Height / 100;
            vScrollBar1.Maximum = this.label1.Size.Height-vScrollBar1.Size.Height+50;
            this.ClientSize = new System.Drawing.Size(this.label1.Size.Width+vScrollBar1.Size.Width+15, 472);
            if (vScrollBar1.Maximum < 100)
            {
                this.ClientSize = new System.Drawing.Size(this.label1.Size.Width + 15, this.label1.Size.Height+15);
                vScrollBar1.Visible = false;
            }
        }
        void VScrollBar1Scroll(object sender, ScrollEventArgs e)
        {
            this.label1.Location = new System.Drawing.Point(13, 13 - vScrollBar1.Value);
        }
    }
}
