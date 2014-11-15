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
    public partial class Form2 : Form
    {
        public Form2(string str)
        {
            InitializeComponent();
            label1.Text = str;
            panel1.Size = new System.Drawing.Size(80+label1.Size.Width, 45 + label1.Size.Height);
            this.Size = new System.Drawing.Size(82+label1.Size.Width, 85 + label1.Size.Height);
            button1.Location = new Point(label1.Size.Width/2+24, 20 + label1.Size.Height);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Top / 2 + label1.Size.Height/2 - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
