namespace hello_3
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
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnInitOgr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(29, 12);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(431, 345);
            this.txtEkran.TabIndex = 0;
            // 
            // btnInitOgr
            // 
            this.btnInitOgr.Location = new System.Drawing.Point(479, 13);
            this.btnInitOgr.Name = "btnInitOgr";
            this.btnInitOgr.Size = new System.Drawing.Size(154, 42);
            this.btnInitOgr.TabIndex = 1;
            this.btnInitOgr.Text = "Listele";
            this.btnInitOgr.UseVisualStyleBackColor = true;
            this.btnInitOgr.Click += new System.EventHandler(this.btnInitOgr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInitOgr);
            this.Controls.Add(this.txtEkran);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnInitOgr;
    }
}

