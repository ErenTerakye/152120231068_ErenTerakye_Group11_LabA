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
            this.button1 = new System.Windows.Forms.Button();
            this.lbEkran = new System.Windows.Forms.Label();
            this.rb_0_1000 = new System.Windows.Forms.RadioButton();
            this.rb_1001_5000 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSecim_1 = new System.Windows.Forms.CheckBox();
            this.cbSecim_2 = new System.Windows.Forms.CheckBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.cbSecim_3 = new System.Windows.Forms.CheckBox();
            this.cbSecim_4 = new System.Windows.Forms.CheckBox();
            this.cbSecim_5 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(6, 21);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(62, 20);
            this.rbKadin.TabIndex = 0;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(6, 47);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(63, 20);
            this.rbErkek.TabIndex = 1;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Konrol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbEkran
            // 
            this.lbEkran.AutoSize = true;
            this.lbEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbEkran.Location = new System.Drawing.Point(6, 254);
            this.lbEkran.Name = "lbEkran";
            this.lbEkran.Size = new System.Drawing.Size(0, 32);
            this.lbEkran.TabIndex = 3;
            // 
            // rb_0_1000
            // 
            this.rb_0_1000.AutoSize = true;
            this.rb_0_1000.Location = new System.Drawing.Point(6, 33);
            this.rb_0_1000.Name = "rb_0_1000";
            this.rb_0_1000.Size = new System.Drawing.Size(73, 20);
            this.rb_0_1000.TabIndex = 4;
            this.rb_0_1000.TabStop = true;
            this.rb_0_1000.Text = "0 - 1000";
            this.rb_0_1000.UseVisualStyleBackColor = true;
            // 
            // rb_1001_5000
            // 
            this.rb_1001_5000.AutoSize = true;
            this.rb_1001_5000.Location = new System.Drawing.Point(6, 59);
            this.rb_1001_5000.Name = "rb_1001_5000";
            this.rb_1001_5000.Size = new System.Drawing.Size(94, 20);
            this.rb_1001_5000.TabIndex = 5;
            this.rb_1001_5000.TabStop = true;
            this.rb_1001_5000.Text = "1001 - 5000";
            this.rb_1001_5000.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKadin);
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet Seçiniz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_0_1000);
            this.groupBox2.Controls.Add(this.rb_1001_5000);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 96);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gelir Düzeyi Seçiniz";
            // 
            // cbSecim_1
            // 
            this.cbSecim_1.AutoSize = true;
            this.cbSecim_1.Location = new System.Drawing.Point(420, 12);
            this.cbSecim_1.Name = "cbSecim_1";
            this.cbSecim_1.Size = new System.Drawing.Size(77, 20);
            this.cbSecim_1.TabIndex = 8;
            this.cbSecim_1.Text = "Seçim 1";
            this.cbSecim_1.UseVisualStyleBackColor = true;
            // 
            // cbSecim_2
            // 
            this.cbSecim_2.AutoSize = true;
            this.cbSecim_2.Location = new System.Drawing.Point(420, 34);
            this.cbSecim_2.Name = "cbSecim_2";
            this.cbSecim_2.Size = new System.Drawing.Size(77, 20);
            this.cbSecim_2.TabIndex = 9;
            this.cbSecim_2.Text = "Seçim 2";
            this.cbSecim_2.UseVisualStyleBackColor = true;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(422, 214);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(75, 23);
            this.btnKontrol.TabIndex = 10;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // cbSecim_3
            // 
            this.cbSecim_3.AutoSize = true;
            this.cbSecim_3.Location = new System.Drawing.Point(420, 60);
            this.cbSecim_3.Name = "cbSecim_3";
            this.cbSecim_3.Size = new System.Drawing.Size(77, 20);
            this.cbSecim_3.TabIndex = 11;
            this.cbSecim_3.Text = "Seçim 3";
            this.cbSecim_3.UseVisualStyleBackColor = true;
            // 
            // cbSecim_4
            // 
            this.cbSecim_4.AutoSize = true;
            this.cbSecim_4.Location = new System.Drawing.Point(420, 86);
            this.cbSecim_4.Name = "cbSecim_4";
            this.cbSecim_4.Size = new System.Drawing.Size(77, 20);
            this.cbSecim_4.TabIndex = 12;
            this.cbSecim_4.Text = "Seçim 4";
            this.cbSecim_4.UseVisualStyleBackColor = true;
            // 
            // cbSecim_5
            // 
            this.cbSecim_5.AutoSize = true;
            this.cbSecim_5.Location = new System.Drawing.Point(420, 112);
            this.cbSecim_5.Name = "cbSecim_5";
            this.cbSecim_5.Size = new System.Drawing.Size(77, 20);
            this.cbSecim_5.TabIndex = 13;
            this.cbSecim_5.Text = "Seçim 5";
            this.cbSecim_5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSecim_5);
            this.Controls.Add(this.cbSecim_4);
            this.Controls.Add(this.cbSecim_3);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.cbSecim_2);
            this.Controls.Add(this.cbSecim_1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbEkran);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbEkran;
        private System.Windows.Forms.RadioButton rb_0_1000;
        private System.Windows.Forms.RadioButton rb_1001_5000;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSecim_1;
        private System.Windows.Forms.CheckBox cbSecim_2;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.CheckBox cbSecim_3;
        private System.Windows.Forms.CheckBox cbSecim_4;
        private System.Windows.Forms.CheckBox cbSecim_5;
    }
}

