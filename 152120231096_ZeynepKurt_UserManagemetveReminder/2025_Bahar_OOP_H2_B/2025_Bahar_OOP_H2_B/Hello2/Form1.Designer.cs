namespace Hello2
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
            this.btnRandomEleman = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnElemanListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomEleman
            // 
            this.btnRandomEleman.Location = new System.Drawing.Point(24, 23);
            this.btnRandomEleman.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRandomEleman.Name = "btnRandomEleman";
            this.btnRandomEleman.Size = new System.Drawing.Size(410, 45);
            this.btnRandomEleman.TabIndex = 0;
            this.btnRandomEleman.Text = "Random Eleman Doldur";
            this.btnRandomEleman.UseVisualStyleBackColor = true;
            this.btnRandomEleman.Click += new System.EventHandler(this.btnRandomEleman_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(491, 23);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(360, 444);
            this.txtEkran.TabIndex = 1;
            // 
            // btnElemanListele
            // 
            this.btnElemanListele.Location = new System.Drawing.Point(24, 89);
            this.btnElemanListele.Margin = new System.Windows.Forms.Padding(6);
            this.btnElemanListele.Name = "btnElemanListele";
            this.btnElemanListele.Size = new System.Drawing.Size(410, 45);
            this.btnElemanListele.TabIndex = 2;
            this.btnElemanListele.Text = "Eleman Listele";
            this.btnElemanListele.UseVisualStyleBackColor = true;
            this.btnElemanListele.Click += new System.EventHandler(this.btnElemanListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.btnElemanListele);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnRandomEleman);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandomEleman;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnElemanListele;
    }
}

