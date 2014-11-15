namespace DomainChecker
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изXSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вXSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утилитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиЦИPRДоменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сайтПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.domen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.register = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TiC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.данныеToolStripMenuItem,
            this.утилитыToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.файлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изTxtToolStripMenuItem,
            this.изXSLToolStripMenuItem});
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.импортToolStripMenuItem.Text = "Импорт списка";
            // 
            // изTxtToolStripMenuItem
            // 
            this.изTxtToolStripMenuItem.Name = "изTxtToolStripMenuItem";
            this.изTxtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.изTxtToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.изTxtToolStripMenuItem.Text = "Из txt";
            this.изTxtToolStripMenuItem.Click += new System.EventHandler(this.изTxtToolStripMenuItem_Click);
            // 
            // изXSLToolStripMenuItem
            // 
            this.изXSLToolStripMenuItem.Name = "изXSLToolStripMenuItem";
            this.изXSLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.изXSLToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.изXSLToolStripMenuItem.Text = "Из XSL";
            this.изXSLToolStripMenuItem.Click += new System.EventHandler(this.изXSLToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вTxtToolStripMenuItem,
            this.вXSLToolStripMenuItem});
            this.экспортToolStripMenuItem.Enabled = false;
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт результата";
            // 
            // вTxtToolStripMenuItem
            // 
            this.вTxtToolStripMenuItem.Enabled = false;
            this.вTxtToolStripMenuItem.Name = "вTxtToolStripMenuItem";
            this.вTxtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.вTxtToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.вTxtToolStripMenuItem.Text = "В txt";
            this.вTxtToolStripMenuItem.Click += new System.EventHandler(this.вTxtToolStripMenuItem_Click);
            // 
            // вXSLToolStripMenuItem
            // 
            this.вXSLToolStripMenuItem.Enabled = false;
            this.вXSLToolStripMenuItem.Name = "вXSLToolStripMenuItem";
            this.вXSLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.вXSLToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.вXSLToolStripMenuItem.Text = "В XSL";
            this.вXSLToolStripMenuItem.Click += new System.EventHandler(this.вXSLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.получитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // получитьToolStripMenuItem
            // 
            this.получитьToolStripMenuItem.Name = "получитьToolStripMenuItem";
            this.получитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.получитьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.получитьToolStripMenuItem.Text = "Получить";
            this.получитьToolStripMenuItem.Click += new System.EventHandler(this.получитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.удалитьToolStripMenuItem.Text = "Выделение";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // утилитыToolStripMenuItem
            // 
            this.утилитыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тиЦИPRДоменаToolStripMenuItem});
            this.утилитыToolStripMenuItem.Name = "утилитыToolStripMenuItem";
            this.утилитыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.утилитыToolStripMenuItem.Text = "Утилиты";
            // 
            // тиЦИPRДоменаToolStripMenuItem
            // 
            this.тиЦИPRДоменаToolStripMenuItem.Name = "тиЦИPRДоменаToolStripMenuItem";
            this.тиЦИPRДоменаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.T)));
            this.тиЦИPRДоменаToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.тиЦИPRДоменаToolStripMenuItem.Text = "Тиц";
            this.тиЦИPRДоменаToolStripMenuItem.Click += new System.EventHandler(this.тиЦИPRДоменаToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Visible = false;
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьF1ToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.toolStripSeparator1,
            this.сайтПрограммыToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьF1ToolStripMenuItem
            // 
            this.помощьF1ToolStripMenuItem.Name = "помощьF1ToolStripMenuItem";
            this.помощьF1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьF1ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.помощьF1ToolStripMenuItem.Text = "Помощь (F1)";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // сайтПрограммыToolStripMenuItem
            // 
            this.сайтПрограммыToolStripMenuItem.Name = "сайтПрограммыToolStripMenuItem";
            this.сайтПрограммыToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.сайтПрограммыToolStripMenuItem.Text = "Сайт программы";
            this.сайтПрограммыToolStripMenuItem.Click += new System.EventHandler(this.сайтПрограммыToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(79, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 95);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(284, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Проверить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.domen,
            this.register,
            this.TiC,
            this.IP,
            this.PR});
            this.listView1.Location = new System.Drawing.Point(12, 208);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 161);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // domen
            // 
            this.domen.Text = "Домен";
            this.domen.Width = 150;
            // 
            // register
            // 
            this.register.Text = "Занятость";
            this.register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.register.Width = 65;
            // 
            // TiC
            // 
            this.TiC.Text = "ТиЦ";
            this.TiC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IP
            // 
            this.IP.Text = "IP домена";
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IP.Width = 86;
            // 
            // PR
            // 
            this.PR.Text = "PR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выполняется обработка... Ожидайте...";
            this.label1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(221, 179);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 17);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(347, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 32);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(447, 393);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Domain Checker v1.0b";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изXSLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вXSLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сайтПрограммыToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader domen;
        private System.Windows.Forms.ColumnHeader register;
        private System.Windows.Forms.ToolStripMenuItem утилитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиЦИPRДоменаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader TiC;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader PR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
    }
}

