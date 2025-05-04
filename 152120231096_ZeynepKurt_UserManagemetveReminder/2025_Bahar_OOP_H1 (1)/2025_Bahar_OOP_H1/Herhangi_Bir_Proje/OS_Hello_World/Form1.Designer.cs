namespace OS_Hello_World
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
            this.btnIslem = new System.Windows.Forms.Button();
            this.lbEkran = new System.Windows.Forms.Label();
            this.btnMerhaba = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIslem
            // 
            this.btnIslem.BackColor = System.Drawing.Color.Red;
            this.btnIslem.BackgroundImage = global::OS_Hello_World.Properties.Resources.png_clipart_cats_cats_thumbnail;
            this.btnIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIslem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslem.ForeColor = System.Drawing.Color.White;
            this.btnIslem.Location = new System.Drawing.Point(12, 12);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(172, 125);
            this.btnIslem.TabIndex = 0;
            this.btnIslem.UseVisualStyleBackColor = false;
            this.btnIslem.Click += new System.EventHandler(this.button1_Click);
            this.btnIslem.MouseEnter += new System.EventHandler(this.btnIslem_MouseEnter);
            this.btnIslem.MouseLeave += new System.EventHandler(this.btnIslem_MouseLeave);
            this.btnIslem.MouseHover += new System.EventHandler(this.btnIslem_MouseHover);
            this.btnIslem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnIslem_MouseMove);
            // 
            // lbEkran
            // 
            this.lbEkran.AutoSize = true;
            this.lbEkran.Location = new System.Drawing.Point(12, 189);
            this.lbEkran.Name = "lbEkran";
            this.lbEkran.Size = new System.Drawing.Size(0, 13);
            this.lbEkran.TabIndex = 1;
            // 
            // btnMerhaba
            // 
            this.btnMerhaba.Location = new System.Drawing.Point(208, 152);
            this.btnMerhaba.Name = "btnMerhaba";
            this.btnMerhaba.Size = new System.Drawing.Size(171, 23);
            this.btnMerhaba.TabIndex = 2;
            this.btnMerhaba.Text = "Merhaba";
            this.btnMerhaba.UseVisualStyleBackColor = true;
            this.btnMerhaba.Click += new System.EventHandler(this.btnMerhaba_Click);
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtAd.Location = new System.Drawing.Point(12, 143);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(190, 13);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtSoyad.Location = new System.Drawing.Point(12, 162);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(190, 13);
            this.txtSoyad.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnMerhaba);
            this.Controls.Add(this.lbEkran);
            this.Controls.Add(this.btnIslem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label lbEkran;
        private System.Windows.Forms.Button btnMerhaba;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}

