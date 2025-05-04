namespace WindowsFormsApp5
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
            this.cmbEkle = new System.Windows.Forms.ComboBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbEkle
            // 
            this.cmbEkle.FormattingEnabled = true;
            this.cmbEkle.Items.AddRange(new object[] {
            "Mavi",
            "Yeşil",
            "Kırmızı"});
            this.cmbEkle.Location = new System.Drawing.Point(465, 24);
            this.cmbEkle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbEkle.Name = "cmbEkle";
            this.cmbEkle.Size = new System.Drawing.Size(238, 39);
            this.cmbEkle.TabIndex = 0;
            this.cmbEkle.SelectedIndexChanged += new System.EventHandler(this.cmbEkle_SelectedIndexChanged);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(303, 21);
            this.Ekle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(150, 45);
            this.Ekle.TabIndex = 1;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(24, 25);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(270, 38);
            this.txtEkle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.cmbEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEkle;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TextBox txtEkle;
    }
}

