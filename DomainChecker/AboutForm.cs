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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }
    }
}
