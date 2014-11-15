namespace DomainChecker
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(333, 0);
            this.vScrollBar1.MinimumSize = new System.Drawing.Size(10, 50);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 472);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1Scroll);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 472);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ответ Whois-сервера";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseWheel);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void Form4_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (vScrollBar1.Maximum > 100)
            {
                if (e.Delta == -120)
                {
                    //if (this.label1.Location.Y>this.label1.Size.Height)
                    if (this.vScrollBar1.Value < this.vScrollBar1.Maximum - 20)
                    {
                        vScrollBar1.Value += 20;
                        this.label1.Location = new System.Drawing.Point(13, this.label1.Location.Y - 20);
                    }
                    else
                    {
                        if (vScrollBar1.Value != this.vScrollBar1.Maximum)
                            this.label1.Location = new System.Drawing.Point(13, this.label1.Location.Y - 20);
                        vScrollBar1.Value = this.vScrollBar1.Maximum;
                    }
                }
                else
                {
                    if (this.vScrollBar1.Value > this.vScrollBar1.Minimum + 20)
                    {
                        vScrollBar1.Value -= 20;
                        this.label1.Location = new System.Drawing.Point(13, this.label1.Location.Y + 20);
                    }
                    else
                    {
                        if (vScrollBar1.Value != this.vScrollBar1.Minimum)
                            this.label1.Location = new System.Drawing.Point(13, this.label1.Location.Y + 20);
                        vScrollBar1.Value = this.vScrollBar1.Minimum;
                    }
                }
            }
            //throw new System.NotImplementedException();
            //this.label1.Text = "Словил";
            //throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}