namespace WindowsFormsApp1
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
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.lbEkran = new System.Windows.Forms.Label();
            this.rb_0_1000 = new System.Windows.Forms.RadioButton();
            this.rb_1001_5000 = new System.Windows.Forms.RadioButton();
            this.rb_5001 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_1 = new System.Windows.Forms.CheckBox();
            this.chk_2 = new System.Windows.Forms.CheckBox();
            this.chk_3 = new System.Windows.Forms.CheckBox();
            this.chk_4 = new System.Windows.Forms.CheckBox();
            this.chk_5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(9, 37);
            this.rbKadin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(109, 36);
            this.rbKadin.TabIndex = 0;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            this.rbKadin.CheckedChanged += new System.EventHandler(this.rbKadin_CheckedChanged);
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(9, 82);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(107, 36);
            this.rbErkek.TabIndex = 1;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(230, 195);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(149, 42);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // lbEkran
            // 
            this.lbEkran.AutoSize = true;
            this.lbEkran.Location = new System.Drawing.Point(15, 250);
            this.lbEkran.Name = "lbEkran";
            this.lbEkran.Size = new System.Drawing.Size(0, 32);
            this.lbEkran.TabIndex = 3;
            // 
            // rb_0_1000
            // 
            this.rb_0_1000.AutoSize = true;
            this.rb_0_1000.Location = new System.Drawing.Point(6, 37);
            this.rb_0_1000.Name = "rb_0_1000";
            this.rb_0_1000.Size = new System.Drawing.Size(124, 36);
            this.rb_0_1000.TabIndex = 4;
            this.rb_0_1000.TabStop = true;
            this.rb_0_1000.Text = "0-1000";
            this.rb_0_1000.UseVisualStyleBackColor = true;
            // 
            // rb_1001_5000
            // 
            this.rb_1001_5000.AutoSize = true;
            this.rb_1001_5000.Location = new System.Drawing.Point(6, 79);
            this.rb_1001_5000.Name = "rb_1001_5000";
            this.rb_1001_5000.Size = new System.Drawing.Size(172, 36);
            this.rb_1001_5000.TabIndex = 5;
            this.rb_1001_5000.TabStop = true;
            this.rb_1001_5000.Text = "1001-5000";
            this.rb_1001_5000.UseVisualStyleBackColor = true;
            // 
            // rb_5001
            // 
            this.rb_5001.AutoSize = true;
            this.rb_5001.Location = new System.Drawing.Point(6, 121);
            this.rb_5001.Name = "rb_5001";
            this.rb_5001.Size = new System.Drawing.Size(197, 36);
            this.rb_5001.TabIndex = 6;
            this.rb_5001.TabStop = true;
            this.rb_5001.Text = "5001 ve üstü";
            this.rb_5001.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_5001);
            this.groupBox2.Controls.Add(this.rb_1001_5000);
            this.groupBox2.Controls.Add(this.rb_0_1000);
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 177);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelir Düzeyi";
            // 
            // chk_1
            // 
            this.chk_1.AutoSize = true;
            this.chk_1.Location = new System.Drawing.Point(591, 12);
            this.chk_1.Name = "chk_1";
            this.chk_1.Size = new System.Drawing.Size(138, 36);
            this.chk_1.TabIndex = 9;
            this.chk_1.Text = "Seçim 1";
            this.chk_1.UseVisualStyleBackColor = true;
            // 
            // chk_2
            // 
            this.chk_2.AutoSize = true;
            this.chk_2.Location = new System.Drawing.Point(591, 54);
            this.chk_2.Name = "chk_2";
            this.chk_2.Size = new System.Drawing.Size(138, 36);
            this.chk_2.TabIndex = 10;
            this.chk_2.Text = "Seçim 2";
            this.chk_2.UseVisualStyleBackColor = true;
            // 
            // chk_3
            // 
            this.chk_3.AutoSize = true;
            this.chk_3.Location = new System.Drawing.Point(591, 96);
            this.chk_3.Name = "chk_3";
            this.chk_3.Size = new System.Drawing.Size(138, 36);
            this.chk_3.TabIndex = 11;
            this.chk_3.Text = "Seçim 3";
            this.chk_3.UseVisualStyleBackColor = true;
            // 
            // chk_4
            // 
            this.chk_4.AutoSize = true;
            this.chk_4.Location = new System.Drawing.Point(591, 138);
            this.chk_4.Name = "chk_4";
            this.chk_4.Size = new System.Drawing.Size(138, 36);
            this.chk_4.TabIndex = 12;
            this.chk_4.Text = "Seçim 4";
            this.chk_4.UseVisualStyleBackColor = true;
            // 
            // chk_5
            // 
            this.chk_5.AutoSize = true;
            this.chk_5.Location = new System.Drawing.Point(591, 180);
            this.chk_5.Name = "chk_5";
            this.chk_5.Size = new System.Drawing.Size(138, 36);
            this.chk_5.TabIndex = 13;
            this.chk_5.Text = "Seçim 5";
            this.chk_5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kontrol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_5);
            this.Controls.Add(this.chk_4);
            this.Controls.Add(this.chk_3);
            this.Controls.Add(this.chk_2);
            this.Controls.Add(this.chk_1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbEkran);
            this.Controls.Add(this.btnKontrol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label lbEkran;
        private System.Windows.Forms.RadioButton rb_0_1000;
        private System.Windows.Forms.RadioButton rb_1001_5000;
        private System.Windows.Forms.RadioButton rb_5001;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_1;
        private System.Windows.Forms.CheckBox chk_2;
        private System.Windows.Forms.CheckBox chk_3;
        private System.Windows.Forms.CheckBox chk_4;
        private System.Windows.Forms.CheckBox chk_5;
        private System.Windows.Forms.Button button1;
    }
}

