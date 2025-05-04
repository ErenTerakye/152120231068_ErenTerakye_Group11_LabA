namespace Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTıkla = new System.Windows.Forms.Button();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTıkla
            // 
            this.btnTıkla.BackColor = System.Drawing.SystemColors.Control;
            this.btnTıkla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTıkla.Location = new System.Drawing.Point(14, 57);
            this.btnTıkla.Name = "btnTıkla";
            this.btnTıkla.Size = new System.Drawing.Size(300, 91);
            this.btnTıkla.TabIndex = 0;
            this.btnTıkla.Text = "Click ME !!!  4 Color Change";
            this.btnTıkla.UseVisualStyleBackColor = false;
            this.btnTıkla.Click += new System.EventHandler(this.btnTıkla_Click);
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(352, 82);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(283, 66);
            this.txtEkran.TabIndex = 1;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbX.Location = new System.Drawing.Point(14, 217);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(0, 39);
            this.lbX.TabIndex = 2;
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbY.Location = new System.Drawing.Point(14, 267);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(0, 39);
            this.lbY.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 651);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.btnTıkla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTıkla;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
    }
}

