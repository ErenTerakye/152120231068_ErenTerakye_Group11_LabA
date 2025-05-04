namespace OOP_Çalışma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SIFIRLA = new Button();
            Kaydol = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(156, 32);
            label1.Name = "label1";
            label1.Size = new Size(244, 46);
            label1.TabIndex = 0;
            label1.Text = "GİRİŞ NOKTASI";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 27);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // SIFIRLA
            // 
            SIFIRLA.Location = new Point(156, 392);
            SIFIRLA.Name = "SIFIRLA";
            SIFIRLA.Size = new Size(94, 29);
            SIFIRLA.TabIndex = 4;
            SIFIRLA.Text = "SIFIRLA";
            SIFIRLA.UseVisualStyleBackColor = true;
            SIFIRLA.Click += SIFIRLA_Click;
            // 
            // Kaydol
            // 
            Kaydol.Location = new Point(302, 392);
            Kaydol.Name = "Kaydol";
            Kaydol.Size = new Size(94, 29);
            Kaydol.TabIndex = 5;
            Kaydol.Text = "KAYDOL";
            Kaydol.UseVisualStyleBackColor = true;
            Kaydol.Click += Kaydol_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 124);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 6;
            label2.Text = "AD";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 205);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 7;
            label3.Text = "SOYAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 283);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "E-POSTA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 343);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 343);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Kaydol);
            Controls.Add(SIFIRLA);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button SIFIRLA;
        private Button Kaydol;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
