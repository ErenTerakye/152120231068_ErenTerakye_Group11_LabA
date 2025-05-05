namespace Reminder
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
            label2 = new Label();
            label3 = new Label();
            txtReminderTitle = new TextBox();
            txtReminderDesc = new TextBox();
            dtpReminderDate = new DateTimePicker();
            btnSaveReminder = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 164);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Başlık: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 207);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Açıklama: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 253);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // txtReminderTitle
            // 
            txtReminderTitle.Location = new Point(148, 163);
            txtReminderTitle.Name = "txtReminderTitle";
            txtReminderTitle.Size = new Size(219, 27);
            txtReminderTitle.TabIndex = 3;
            // 
            // txtReminderDesc
            // 
            txtReminderDesc.Location = new Point(148, 207);
            txtReminderDesc.Multiline = true;
            txtReminderDesc.Name = "txtReminderDesc";
            txtReminderDesc.Size = new Size(219, 120);
            txtReminderDesc.TabIndex = 4;
            // 
            // dtpReminderDate
            // 
            dtpReminderDate.Location = new Point(148, 352);
            dtpReminderDate.Name = "dtpReminderDate";
            dtpReminderDate.Size = new Size(250, 27);
            dtpReminderDate.TabIndex = 5;
            // 
            // btnSaveReminder
            // 
            btnSaveReminder.Location = new Point(489, 343);
            btnSaveReminder.Name = "btnSaveReminder";
            btnSaveReminder.Size = new Size(137, 49);
            btnSaveReminder.TabIndex = 6;
            btnSaveReminder.Text = "Kaydet";
            btnSaveReminder.UseVisualStyleBackColor = true;
            btnSaveReminder.Click += btnSaveReminder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F);
            label4.Location = new Point(234, 37);
            label4.Name = "label4";
            label4.Size = new Size(298, 67);
            label4.TabIndex = 7;
            label4.Text = "HATIRLATICI";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnSaveReminder);
            Controls.Add(dtpReminderDate);
            Controls.Add(txtReminderDesc);
            Controls.Add(txtReminderTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtReminderTitle;
        private TextBox txtReminderDesc;
        private DateTimePicker dtpReminderDate;
        private Button btnSaveReminder;
        private Label label4;
    }
}
