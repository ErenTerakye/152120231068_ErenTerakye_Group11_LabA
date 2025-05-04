namespace hello4
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
            this.chkElma = new System.Windows.Forms.CheckBox();
            this.chkArmut = new System.Windows.Forms.CheckBox();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkElma
            // 
            this.chkElma.AutoSize = true;
            this.chkElma.Location = new System.Drawing.Point(70, 25);
            this.chkElma.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkElma.Name = "chkElma";
            this.chkElma.Size = new System.Drawing.Size(101, 36);
            this.chkElma.TabIndex = 0;
            this.chkElma.Text = "Elma";
            this.chkElma.UseVisualStyleBackColor = true;
            // 
            // chkArmut
            // 
            this.chkArmut.AutoSize = true;
            this.chkArmut.Location = new System.Drawing.Point(70, 73);
            this.chkArmut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkArmut.Name = "chkArmut";
            this.chkArmut.Size = new System.Drawing.Size(111, 36);
            this.chkArmut.TabIndex = 1;
            this.chkArmut.Text = "Armut";
            this.chkArmut.UseVisualStyleBackColor = true;
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(448, 24);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(443, 390);
            this.txtEkran.TabIndex = 2;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(230, 24);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(175, 67);
            this.btnKontrol.TabIndex = 3;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(42, 21);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(98, 36);
            this.rbGreen.TabIndex = 4;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Yeşil";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(42, 75);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(121, 36);
            this.rbRed.TabIndex = 5;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Kırmızı";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(42, 131);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(95, 36);
            this.rbBlue.TabIndex = 6;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Mavi";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(44, 19);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(109, 36);
            this.rbKadin.TabIndex = 7;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(44, 73);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(107, 36);
            this.rbErkek.TabIndex = 8;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBlue);
            this.panel1.Controls.Add(this.rbRed);
            this.panel1.Controls.Add(this.rbGreen);
            this.panel1.Location = new System.Drawing.Point(28, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 198);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbErkek);
            this.panel2.Controls.Add(this.rbKadin);
            this.panel2.Location = new System.Drawing.Point(289, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 195);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.chkArmut);
            this.Controls.Add(this.chkElma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkElma;
        private System.Windows.Forms.CheckBox chkArmut;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

