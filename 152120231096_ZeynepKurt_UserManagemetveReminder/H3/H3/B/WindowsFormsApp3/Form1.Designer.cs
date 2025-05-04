namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.chkListbox = new System.Windows.Forms.CheckedListBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCikar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hepsiniSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçimiTersineÇevirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçilmişleriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçiliOlanıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkListbox
            // 
            this.chkListbox.ContextMenuStrip = this.contextMenuStrip1;
            this.chkListbox.FormattingEnabled = true;
            this.chkListbox.Location = new System.Drawing.Point(428, 25);
            this.chkListbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkListbox.Name = "chkListbox";
            this.chkListbox.Size = new System.Drawing.Size(255, 497);
            this.chkListbox.TabIndex = 0;
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(24, 25);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(227, 34);
            this.txtEkle.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(257, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(151, 38);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtCikar
            // 
            this.txtCikar.Location = new System.Drawing.Point(24, 201);
            this.txtCikar.Name = "txtCikar";
            this.txtCikar.Size = new System.Drawing.Size(227, 34);
            this.txtCikar.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hepsiniSeçToolStripMenuItem,
            this.seçimiTersineÇevirToolStripMenuItem,
            this.seçilmişleriSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 76);
            // 
            // hepsiniSeçToolStripMenuItem
            // 
            this.hepsiniSeçToolStripMenuItem.Name = "hepsiniSeçToolStripMenuItem";
            this.hepsiniSeçToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.hepsiniSeçToolStripMenuItem.Text = "Hepsini Seç";
            this.hepsiniSeçToolStripMenuItem.Click += new System.EventHandler(this.hepsiniSeçToolStripMenuItem_Click);
            // 
            // seçimiTersineÇevirToolStripMenuItem
            // 
            this.seçimiTersineÇevirToolStripMenuItem.Name = "seçimiTersineÇevirToolStripMenuItem";
            this.seçimiTersineÇevirToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.seçimiTersineÇevirToolStripMenuItem.Text = "Seçimi Tersine Çevir";
            this.seçimiTersineÇevirToolStripMenuItem.Click += new System.EventHandler(this.seçimiTersineÇevirToolStripMenuItem_Click);
            // 
            // seçilmişleriSilToolStripMenuItem
            // 
            this.seçilmişleriSilToolStripMenuItem.Name = "seçilmişleriSilToolStripMenuItem";
            this.seçilmişleriSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.seçilmişleriSilToolStripMenuItem.Text = "Seçilmişleri Sil";
            this.seçilmişleriSilToolStripMenuItem.Click += new System.EventHandler(this.seçilmişleriSilToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(700, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 497);
            this.listBox1.TabIndex = 9;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçiliOlanıSilToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(211, 56);
            // 
            // seçiliOlanıSilToolStripMenuItem
            // 
            this.seçiliOlanıSilToolStripMenuItem.Name = "seçiliOlanıSilToolStripMenuItem";
            this.seçiliOlanıSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.seçiliOlanıSilToolStripMenuItem.Text = "Seçili olanı Sil";
            this.seçiliOlanıSilToolStripMenuItem.Click += new System.EventHandler(this.seçiliOlanıSilToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 1055);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtCikar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.chkListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListbox;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCikar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hepsiniSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçimiTersineÇevirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçilmişleriSilToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem seçiliOlanıSilToolStripMenuItem;
    }
}

