namespace checkBox
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
            this.btnKontrol = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.chkArmut = new System.Windows.Forms.CheckBox();
            this.rbYas18Alti = new System.Windows.Forms.RadioButton();
            this.rb18Ustu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkElma
            // 
            this.chkElma.AutoSize = true;
            this.chkElma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkElma.Location = new System.Drawing.Point(58, 12);
            this.chkElma.Name = "chkElma";
            this.chkElma.Size = new System.Drawing.Size(103, 40);
            this.chkElma.TabIndex = 0;
            this.chkElma.Text = "Elma";
            this.chkElma.UseVisualStyleBackColor = true;
            this.chkElma.CheckedChanged += new System.EventHandler(this.chkElma_CheckedChanged);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(554, 10);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(270, 79);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkran.Location = new System.Drawing.Point(180, 10);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(295, 182);
            this.txtEkran.TabIndex = 2;
            // 
            // chkArmut
            // 
            this.chkArmut.AutoSize = true;
            this.chkArmut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkArmut.Location = new System.Drawing.Point(58, 58);
            this.chkArmut.Name = "chkArmut";
            this.chkArmut.Size = new System.Drawing.Size(116, 40);
            this.chkArmut.TabIndex = 3;
            this.chkArmut.Text = "Armut";
            this.chkArmut.UseVisualStyleBackColor = true;
            // 
            // rbYas18Alti
            // 
            this.rbYas18Alti.AutoSize = true;
            this.rbYas18Alti.Location = new System.Drawing.Point(29, 20);
            this.rbYas18Alti.Name = "rbYas18Alti";
            this.rbYas18Alti.Size = new System.Drawing.Size(74, 24);
            this.rbYas18Alti.TabIndex = 4;
            this.rbYas18Alti.TabStop = true;
            this.rbYas18Alti.Text = "18 Altı";
            this.rbYas18Alti.UseVisualStyleBackColor = true;
            // 
            // rb18Ustu
            // 
            this.rb18Ustu.AutoSize = true;
            this.rb18Ustu.Location = new System.Drawing.Point(29, 62);
            this.rb18Ustu.Name = "rb18Ustu";
            this.rb18Ustu.Size = new System.Drawing.Size(86, 24);
            this.rb18Ustu.TabIndex = 5;
            this.rb18Ustu.TabStop = true;
            this.rb18Ustu.Text = "18 Üstü";
            this.rb18Ustu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb18Ustu);
            this.panel1.Controls.Add(this.rbYas18Alti);
            this.panel1.Location = new System.Drawing.Point(29, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 164);
            this.panel1.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(260, 208);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(260, 238);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkArmut);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.chkElma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkElma;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.CheckBox chkArmut;
        private System.Windows.Forms.RadioButton rbYas18Alti;
        private System.Windows.Forms.RadioButton rb18Ustu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

