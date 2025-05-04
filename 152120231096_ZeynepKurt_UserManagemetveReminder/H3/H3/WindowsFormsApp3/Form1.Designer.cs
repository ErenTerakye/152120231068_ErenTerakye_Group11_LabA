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
            this.chkLbEkle = new System.Windows.Forms.CheckedListBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnTopluEkle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.herhangiBirŞeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buDaBaşkaBişeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buDaBaşkaSeçenekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxListbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tersiniSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçilenleriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.cntxListbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLbEkle
            // 
            this.chkLbEkle.ContextMenuStrip = this.cntxListbox;
            this.chkLbEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkLbEkle.FormattingEnabled = true;
            this.chkLbEkle.Location = new System.Drawing.Point(574, 12);
            this.chkLbEkle.Margin = new System.Windows.Forms.Padding(5);
            this.chkLbEkle.Name = "chkLbEkle";
            this.chkLbEkle.Size = new System.Drawing.Size(550, 555);
            this.chkLbEkle.TabIndex = 0;
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(21, 14);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(308, 34);
            this.txtEkle.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(334, 65);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(220, 36);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(334, 122);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(220, 36);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Çıkar Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(334, 174);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(220, 36);
            this.btnRemoveAt.TabIndex = 4;
            this.btnRemoveAt.Text = "Çıkar Remove At";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnTopluEkle
            // 
            this.btnTopluEkle.Location = new System.Drawing.Point(335, 12);
            this.btnTopluEkle.Name = "btnTopluEkle";
            this.btnTopluEkle.Size = new System.Drawing.Size(220, 36);
            this.btnTopluEkle.TabIndex = 5;
            this.btnTopluEkle.Text = "Toplu Ekle";
            this.btnTopluEkle.UseVisualStyleBackColor = true;
            this.btnTopluEkle.Click += new System.EventHandler(this.btnTopluEkle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herhangiBirŞeyToolStripMenuItem,
            this.buDaBaşkaBişeyToolStripMenuItem,
            this.buDaBaşkaSeçenekToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 76);
            // 
            // herhangiBirŞeyToolStripMenuItem
            // 
            this.herhangiBirŞeyToolStripMenuItem.Name = "herhangiBirŞeyToolStripMenuItem";
            this.herhangiBirŞeyToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.herhangiBirŞeyToolStripMenuItem.Text = "Herhangi bir şey";
            // 
            // buDaBaşkaBişeyToolStripMenuItem
            // 
            this.buDaBaşkaBişeyToolStripMenuItem.Name = "buDaBaşkaBişeyToolStripMenuItem";
            this.buDaBaşkaBişeyToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.buDaBaşkaBişeyToolStripMenuItem.Text = "Bu da Başka Bişey";
            // 
            // buDaBaşkaSeçenekToolStripMenuItem
            // 
            this.buDaBaşkaSeçenekToolStripMenuItem.Name = "buDaBaşkaSeçenekToolStripMenuItem";
            this.buDaBaşkaSeçenekToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.buDaBaşkaSeçenekToolStripMenuItem.Text = "Bu da başka Seçenek";
            // 
            // cntxListbox
            // 
            this.cntxListbox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxListbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümünüSeçToolStripMenuItem,
            this.tersiniSeçToolStripMenuItem,
            this.seçilenleriSilToolStripMenuItem});
            this.cntxListbox.Name = "cntxListbox";
            this.cntxListbox.Size = new System.Drawing.Size(211, 104);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // tersiniSeçToolStripMenuItem
            // 
            this.tersiniSeçToolStripMenuItem.Name = "tersiniSeçToolStripMenuItem";
            this.tersiniSeçToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.tersiniSeçToolStripMenuItem.Text = "Tersini Seç";
            this.tersiniSeçToolStripMenuItem.Click += new System.EventHandler(this.tersiniSeçToolStripMenuItem_Click);
            // 
            // seçilenleriSilToolStripMenuItem
            // 
            this.seçilenleriSilToolStripMenuItem.Name = "seçilenleriSilToolStripMenuItem";
            this.seçilenleriSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.seçilenleriSilToolStripMenuItem.Text = "Seçilenleri Sil";
            this.seçilenleriSilToolStripMenuItem.Click += new System.EventHandler(this.seçilenleriSilToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnTopluEkle);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.chkLbEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.cntxListbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkLbEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnTopluEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herhangiBirŞeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buDaBaşkaBişeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buDaBaşkaSeçenekToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cntxListbox;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tersiniSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçilenleriSilToolStripMenuItem;
    }
}

