using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace DomainChecker
{
    public partial class Form3 : Form
    {
        public Form3(string str)
        {
            InitializeComponent();
            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
