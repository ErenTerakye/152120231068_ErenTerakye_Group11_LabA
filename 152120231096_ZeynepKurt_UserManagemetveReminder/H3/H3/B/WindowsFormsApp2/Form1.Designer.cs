namespace WindowsFormsApp2
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
            this.btnMsg = new System.Windows.Forms.Button();
            this.btnMsg2 = new System.Windows.Forms.Button();
            this.btnMsg3 = new System.Windows.Forms.Button();
            this.btnMsg4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMsg
            // 
            this.btnMsg.Location = new System.Drawing.Point(14, 14);
            this.btnMsg.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(248, 63);
            this.btnMsg.TabIndex = 0;
            this.btnMsg.Text = "Mesaj Kutusu 1";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // btnMsg2
            // 
            this.btnMsg2.Location = new System.Drawing.Point(14, 107);
            this.btnMsg2.Margin = new System.Windows.Forms.Padding(5);
            this.btnMsg2.Name = "btnMsg2";
            this.btnMsg2.Size = new System.Drawing.Size(248, 63);
            this.btnMsg2.TabIndex = 1;
            this.btnMsg2.Text = "Mesaj Kutusu 2";
            this.btnMsg2.UseVisualStyleBackColor = true;
            this.btnMsg2.Click += new System.EventHandler(this.btnMsg2_Click);
            // 
            // btnMsg3
            // 
            this.btnMsg3.Location = new System.Drawing.Point(14, 190);
            this.btnMsg3.Margin = new System.Windows.Forms.Padding(5);
            this.btnMsg3.Name = "btnMsg3";
            this.btnMsg3.Size = new System.Drawing.Size(248, 63);
            this.btnMsg3.TabIndex = 2;
            this.btnMsg3.Text = "Mesaj Kutusu 3";
            this.btnMsg3.UseVisualStyleBackColor = true;
            this.btnMsg3.Click += new System.EventHandler(this.btnMsg3_Click);
            // 
            // btnMsg4
            // 
            this.btnMsg4.Location = new System.Drawing.Point(14, 274);
            this.btnMsg4.Margin = new System.Windows.Forms.Padding(5);
            this.btnMsg4.Name = "btnMsg4";
            this.btnMsg4.Size = new System.Drawing.Size(248, 63);
            this.btnMsg4.TabIndex = 3;
            this.btnMsg4.Text = "Mesaj Kutusu 4";
            this.btnMsg4.UseVisualStyleBackColor = true;
            this.btnMsg4.Click += new System.EventHandler(this.btnMsg4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.btnMsg4);
            this.Controls.Add(this.btnMsg3);
            this.Controls.Add(this.btnMsg2);
            this.Controls.Add(this.btnMsg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.Button btnMsg2;
        private System.Windows.Forms.Button btnMsg3;
        private System.Windows.Forms.Button btnMsg4;
    }
}

