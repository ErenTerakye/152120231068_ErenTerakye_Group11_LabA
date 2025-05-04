namespace WindowsFormsApp4
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
            this.lstEkle = new System.Windows.Forms.ListBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTopluEkle = new System.Windows.Forms.Button();
            this.txtElemanSayisi = new System.Windows.Forms.TextBox();
            this.txtElemanSil = new System.Windows.Forms.TextBox();
            this.txtElemanSilİndis = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEkle
            // 
            this.lstEkle.ContextMenuStrip = this.contextMenuStrip1;
            this.lstEkle.FormattingEnabled = true;
            this.lstEkle.ItemHeight = 29;
            this.lstEkle.Location = new System.Drawing.Point(479, 12);
            this.lstEkle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstEkle.Name = "lstEkle";
            this.lstEkle.Size = new System.Drawing.Size(574, 613);
            this.lstEkle.TabIndex = 0;
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(12, 12);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(267, 34);
            this.txtEkle.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(285, 13);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(186, 33);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tümünü Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sil (indis)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTopluEkle
            // 
            this.btnTopluEkle.Location = new System.Drawing.Point(285, 52);
            this.btnTopluEkle.Name = "btnTopluEkle";
            this.btnTopluEkle.Size = new System.Drawing.Size(186, 33);
            this.btnTopluEkle.TabIndex = 6;
            this.btnTopluEkle.Text = "Toplu Ekle";
            this.btnTopluEkle.UseVisualStyleBackColor = true;
            this.btnTopluEkle.Click += new System.EventHandler(this.btnTopluEkle_Click);
            // 
            // txtElemanSayisi
            // 
            this.txtElemanSayisi.Location = new System.Drawing.Point(223, 51);
            this.txtElemanSayisi.Name = "txtElemanSayisi";
            this.txtElemanSayisi.Size = new System.Drawing.Size(56, 34);
            this.txtElemanSayisi.TabIndex = 7;
            // 
            // txtElemanSil
            // 
            this.txtElemanSil.Location = new System.Drawing.Point(158, 129);
            this.txtElemanSil.Name = "txtElemanSil";
            this.txtElemanSil.Size = new System.Drawing.Size(121, 34);
            this.txtElemanSil.TabIndex = 8;
            // 
            // txtElemanSilİndis
            // 
            this.txtElemanSilİndis.Location = new System.Drawing.Point(223, 169);
            this.txtElemanSilİndis.Name = "txtElemanSilİndis";
            this.txtElemanSilİndis.Size = new System.Drawing.Size(56, 34);
            this.txtElemanSilİndis.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.topluEkleToolStripMenuItem,
            this.topluSilToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // topluEkleToolStripMenuItem
            // 
            this.topluEkleToolStripMenuItem.Name = "topluEkleToolStripMenuItem";
            this.topluEkleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.topluEkleToolStripMenuItem.Text = "Toplu Ekle";
            this.topluEkleToolStripMenuItem.Click += new System.EventHandler(this.topluEkleToolStripMenuItem_Click);
            // 
            // topluSilToolStripMenuItem
            // 
            this.topluSilToolStripMenuItem.Name = "topluSilToolStripMenuItem";
            this.topluSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.topluSilToolStripMenuItem.Text = "Toplu Sil";
            this.topluSilToolStripMenuItem.Click += new System.EventHandler(this.topluSilToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.txtElemanSilİndis);
            this.Controls.Add(this.txtElemanSil);
            this.Controls.Add(this.txtElemanSayisi);
            this.Controls.Add(this.btnTopluEkle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.lstEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTopluEkle;
        private System.Windows.Forms.TextBox txtElemanSayisi;
        private System.Windows.Forms.TextBox txtElemanSil;
        private System.Windows.Forms.TextBox txtElemanSilİndis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topluEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topluSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}

