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
    public partial class Form1 : Form
    {
        Kernel core;
        bool Ready = true;
        private delegate void Reader(bool action);
        private delegate bool ListDelegate(ListBox Info, string Text);
        private delegate void ListViewDelegate(ListView Info, ListViewItem Text);
        private delegate void WorkLVDelegate(ListView Info, int action);
        private delegate void ProgressBarDelegate(ProgressBar Info, int action);
        private delegate void LVToDelegate(ListView Info, ref string[] destination);
        private delegate void LabelDelegate(Label Info);
        private delegate void menuDelegate(MenuStrip Info);
        private delegate void form3Delegate(Form1 Info, int k, int n);
        private delegate void form2Delegate(Form1 Info, string msg);

        public Form1(ref bool Ready)
        {
            InitializeComponent();
            this.AcceptButton = button1;
            core = new Kernel(this);
            Ready = this.Ready;
        }

        public void NotReady()
        {
            this.Ready=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (core.AddDomain(textBox1.Text) == true)
            {
                if (тиЦИPRДоменаToolStripMenuItem.Checked == true)
                {
                    pictureBox1.Visible = true;
                    this.pictureBox1.ImageLocation = "http://yandex.ru/cycounter?" + listBox1.Items[listBox1.Items.Count-1];
                }
                экспортToolStripMenuItem.Enabled = true;
                вTxtToolStripMenuItem.Enabled = true;
                вXSLToolStripMenuItem.Enabled = true;
                textBox1.Clear();
            }
        }

        private void DeleteItemsFromList()
        {
            foreach (int k in listBox1.SelectedIndices)
            {
                listBox1.Items.RemoveAt(k);
                if (listView1.Items.Count != 0)
                {
                    listView1.Items.RemoveAt(k);
                    core.DeleteResolve(k);
                }
            }
            if (listBox1.Items.Count == 0)
            {
                pictureBox1.Visible = false;
                тиЦИPRДоменаToolStripMenuItem.Checked = false;
                экспортToolStripMenuItem.Enabled = false;
                вTxtToolStripMenuItem.Enabled = false;
                вXSLToolStripMenuItem.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteItemsFromList();
        }

        private void ClearList()
        {
            listBox1.Items.Clear();
            if (listView1.Items.Count != 0)
            {
                listView1.Items.Clear();
                core.ClearResolves();
            }
            pictureBox1.Visible = false;
            тиЦИPRДоменаToolStripMenuItem.Checked = false;
            экспортToolStripMenuItem.Enabled = false;
            вTxtToolStripMenuItem.Enabled = false;
            вXSLToolStripMenuItem.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private bool ListAdd(string domen)
        {
            if (listBox1.FindString(domen) < 0)
                listBox1.Items.Add(domen);
            else return false;
            return true;
        }

        private bool ListAdd(ListBox Info, string domen)
        {
            if (Info.InvokeRequired)
            {
                ListDelegate DDD = new ListDelegate(ListAdd);
                return (bool)Info.Invoke(DDD, new object[] { Info, domen });
            }
            else
            {
                if (listBox1.FindString(domen) < 0)
                    listBox1.Items.Add(domen);
                else return false;
                return true;
            }

        }

        private void SetMenu(MenuStrip Info)
        {
            if (Info.InvokeRequired)
            {
                menuDelegate DDD = new menuDelegate(SetMenu);
                Info.Invoke(DDD, new object[] { Info });
            }
            else
            {
                экспортToolStripMenuItem.Enabled = true;
                вTxtToolStripMenuItem.Enabled = true;
                вXSLToolStripMenuItem.Enabled = true;
            }

        }

        private void RunForm3(Form1 Info, int k, int n)
        {
            if (Info.InvokeRequired)
            {
                form3Delegate DDD = new form3Delegate(RunForm3);
                Info.Invoke(DDD, new object[] { Info, k, n });
            }
            else
            {
                Form3 f3 = new Form3("Импортировано " + k.ToString() + " из " + n + " записей");
                f3.ShowDialog(this);
            }

        }

        public void RunForm2(Form1 Info, string msg)
        {
            if (Info.InvokeRequired)
            {
                form2Delegate DDD = new form2Delegate(RunForm2);
                Info.Invoke(DDD, new object[] { Info, msg });
            }
            else
            {
                Form2 f2 = new Form2(msg);
                f2.ShowDialog(this);
            }

        }

        private void LabelOff(Label Info)
        {
            if (Info.InvokeRequired)
            {
                LabelDelegate DDD = new LabelDelegate(LabelOff);
                Info.Invoke(DDD, new object[] { Info });
            }
            else
            {
                Info.Visible = false;
            }

        }

        public bool AddToList(string domen)
        {
            return ListAdd(listBox1, domen);
        }

        public void AddToListView(ListView Info, ListViewItem Item)
        {
            if (Info.InvokeRequired)
            {
                ListViewDelegate DDD = new ListViewDelegate(AddToListView);
                Info.Invoke(DDD, new object[] { Info, Item });
            }
            else
            {
                Info.Items.Add(Item);
            }
        }

        public void ListViewTo(ListView Info, ref string[] destination)
        {
            if (Info.InvokeRequired)
            {
                LVToDelegate DDD = new LVToDelegate(ListViewTo);
                Info.Invoke(DDD, new object[] { Info, destination });
            }
            else
            {
                listBox1.Items.CopyTo(destination, 0);
            }
        }

        public void WorkWithListView(ListView Info, int action)
        {
            if (Info.InvokeRequired)
            {
                WorkLVDelegate DDD = new WorkLVDelegate(WorkWithListView);
                Info.Invoke(DDD, new object[] { Info, action });
            }
            else
            {
                switch (action)
                {
                    case 0:
                        listView1.Items.Clear();
                        break;
                    case 1:
                        listView1.BeginUpdate();
                        break;
                    case 2:
                        listView1.EndUpdate();
                        break;
                    default:
                        break;
                }
            }
        }

        public void WorkWithProgressBar(ProgressBar Info, int action)
        {
            if (Info.InvokeRequired)
            {
                ProgressBarDelegate DDD = new ProgressBarDelegate(WorkWithProgressBar);
                Info.Invoke(DDD, new object[] { Info, action });
            }
            else
            {
                switch (action)
                {
                    case 0:
                        progressBar1.Value = progressBar1.Minimum;
                        break;
                    case 1:
                        if (progressBar1.Value != progressBar1.Maximum + 1)
                            progressBar1.Value++;
                        break;
                    case 2:
                        progressBar1.Visible = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ReadFromFile(object act)
        {
            bool action = (bool)act;
                List<string> data;
                data = core.ReadFile(action);
                int k = 0;
                k = core.Import(data);
                LabelOff(label1);
                RunForm3(this, k, data.Count);
        }

        private void изXSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog window = new System.Windows.Forms.OpenFileDialog();
            window.Filter = "Excel Files|*.xlsx|Excel Files Old|*.xls";
            window.Title = "Выберите Excel файл";
            if (window.ShowDialog() == DialogResult.OK)
            {
                core.SetFileName(window.FileName);
                var res = new Thread(ReadFromFile) { IsBackground = true };
                res.Start(true);
                label1.Visible = true;
            }
        }

        private void изTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog window = new System.Windows.Forms.OpenFileDialog();
            window.Filter = "Text Files|*.txt";
            window.Title = "Выберите текстовый файл";
            if (window.ShowDialog() == DialogResult.OK)
            {
                core.SetFileName(window.FileName);
                var res = new Thread(ReadFromFile) { IsBackground = true };
                res.Start(false);
                label1.Visible = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AboutF = new AboutForm();
            AboutF.ShowDialog(this);
        }

        private void сайтПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://cagyo.com/domainchecker/");
        }

        private void GetInfo(object arr)
        {
            List<string> lst = (List<string>)arr;
            int n = lst.Count;
            string[] domains = new string[n];
            bool[] registered = new bool[n];
            lst.CopyTo(domains);
            registered = core.WhoisCheck(domains);
            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;          //0-clear, 1-beginupdate, 2-endupdate
            int k = 0;
            WorkWithProgressBar(progressBar1, 0);
            foreach (string domain in domains)
            {
                lvi = new ListViewItem();
                lvi.Text = domain;
                lvi.ImageIndex = 1;
                lvi.Tag = domain;

                lvsi = new ListViewItem.ListViewSubItem();
                if (registered[k] == true)
                    lvsi.Text = "Занят";
                else lvsi.Text = "Свободен";
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = core.GetIndexes(domain, true).ToString();
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = core.GetIP(domain, registered[k]);
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = core.GetIndexes(domain, false).ToString();
                lvi.SubItems.Add(lvsi);

                AddToListView(listView1, lvi);
                k++;
                //Add2("В спячке");
                WorkWithProgressBar(progressBar1, 1);
                Thread.Sleep(1000);
                if (k == 100)
                {
                    Thread.Sleep(30000);
                }
            }
            WorkWithProgressBar(progressBar1, 2);
            LabelOff(label1);
            SetMenu(menuStrip1);
            //WorkWithListView(listView1, 2);
        }

        private List<string> ListCompare()
        {
            List<string> domains = new List<string>();
            string[] listV = new string[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listV[i] = (string)listView1.Items[i].Tag;
            }
            if (listView1.Items.Count > 0)
                foreach (string s in listBox1.Items)
                {
                    bool contain = false;
                    for (int i = 0; i < listView1.Items.Count; i++ )
                    {
                        if (listV[i].Contains(s) == true)
                        {
                            contain = true;
                            break;
                        }
                    }
                    if (contain == false)
                    {
                        domains.Add(s);
                    }
                }
            else
            {
                foreach (string s in listBox1.Items)
                    domains.Add(s);
            }
            return domains;
        }

        private void WorkOnList()
        {
            if (listBox1.Items.Count > 0)
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                label1.Visible = true;
                List<string> Domains = ListCompare();
                progressBar1.Maximum = Domains.Count;
                var res = new Thread(GetInfo) { IsBackground = true };
                res.Start(Domains);
            }
            else
            {
                Form2 f2 = new Form2("Добавьте хотя бы один адрес!");
                f2.ShowDialog(this);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WorkOnList();
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
                if (listView1.Items[i].Focused == true)
                {
                    Form4 f4 = new Form4(core.GetResolve(i));
                    f4.ShowDialog(this);
                }
        }

        private void тиЦИPRДоменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (тиЦИPRДоменаToolStripMenuItem.Checked == true)
            {
                pictureBox1.Visible = false;
                тиЦИPRДоменаToolStripMenuItem.Checked = false;
            }
            else
            {
                тиЦИPRДоменаToolStripMenuItem.Checked = true;
                if (listBox1.SelectedIndex != -1)
                {
                    pictureBox1.Visible = true;
                    this.pictureBox1.ImageLocation = "http://yandex.ru/cycounter?" + listBox1.Items[listBox1.SelectedIndex].ToString();
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (тиЦИPRДоменаToolStripMenuItem.Checked == true)
                {
                    this.pictureBox1.ImageLocation = "http://yandex.ru/cycounter?" + listBox1.Items[listBox1.SelectedIndex].ToString();
                    pictureBox1.Visible = true;
                }
            }
        }

        private List<string> ExportListView()
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                lst.Add((string)listView1.Items[i].Tag);
                lst.Add((string)listView1.Items[i].SubItems[1].Text.ToString());
                lst.Add((string)listView1.Items[i].SubItems[2].Text);
                lst.Add((string)listView1.Items[i].SubItems[3].Text);
                lst.Add((string)listView1.Items[i].SubItems[4].Text);
            }
            return lst;
        }

        private void SaveToFile(object act)
        {
            bool action = (bool)act;
            core.WriteFile(action);
            LabelOff(label1);
            //RunForm3(this, k, data.Count);
        }

        private void вXSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> data = ExportListView();
            System.Windows.Forms.SaveFileDialog window = new System.Windows.Forms.SaveFileDialog();
            window.Filter = "Excel Files Old|*.xls";
            window.Title = "Выберите Excel файл";
            if (window.ShowDialog() == DialogResult.OK)
            {
                core.SetFileNameExp(window.FileName, data);
                var res = new Thread(SaveToFile) { IsBackground = true };
                res.Start(true);
                label1.Visible = true;
            }
        }

        private void вTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> data = ExportListView();
            System.Windows.Forms.SaveFileDialog window = new System.Windows.Forms.SaveFileDialog();
            window.Filter = "Text Files|*.txt";
            window.Title = "Выберите текстовый файл";
            if (window.ShowDialog() == DialogResult.OK)
            {
                core.SetFileNameExp(window.FileName,data);
                var res = new Thread(SaveToFile) { IsBackground = true };
                res.Start(false);
                label1.Visible = true;
            }
        }

        private void получитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkOnList();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteItemsFromList();
        }


    }
}
