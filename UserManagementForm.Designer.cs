namespace userManagement
{
    partial class UserManagementForm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnChangeType = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarMail = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPhoneBook = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.buttonSalaryCalculator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(19, 2);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(494, 153);
            this.dgvUsers.TabIndex = 2;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Location = new System.Drawing.Point(16, 157);
            this.lblSelectedUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(90, 13);
            this.lblSelectedUser.TabIndex = 3;
            this.lblSelectedUser.Text = "Seçilen Kullanıcı:-";
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(113, 182);
            this.cmbUserType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(115, 21);
            this.cmbUserType.TabIndex = 4;
            // 
            // btnChangeType
            // 
            this.btnChangeType.Location = new System.Drawing.Point(247, 182);
            this.btnChangeType.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeType.Name = "btnChangeType";
            this.btnChangeType.Size = new System.Drawing.Size(118, 22);
            this.btnChangeType.TabIndex = 5;
            this.btnChangeType.Text = "Tip Değiştir";
            this.btnChangeType.UseVisualStyleBackColor = true;
            this.btnChangeType.Click += new System.EventHandler(this.btnChangeType_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(247, 212);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(118, 22);
            this.btnSendEmail.TabIndex = 6;
            this.btnSendEmail.Text = "E Posta Gönder";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(113, 248);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(115, 20);
            this.txtNewPassword.TabIndex = 7;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(16, 187);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(93, 13);
            this.lblUserType.TabIndex = 8;
            this.lblUserType.Text = "Yeni Kullanıcı Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yeni Şifre:";
            // 
            // progressBarMail
            // 
            this.progressBarMail.Location = new System.Drawing.Point(247, 250);
            this.progressBarMail.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarMail.Name = "progressBarMail";
            this.progressBarMail.Size = new System.Drawing.Size(118, 18);
            this.progressBarMail.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // buttonPhoneBook
            // 
            this.buttonPhoneBook.Location = new System.Drawing.Point(400, 177);
            this.buttonPhoneBook.Name = "buttonPhoneBook";
            this.buttonPhoneBook.Size = new System.Drawing.Size(100, 23);
            this.buttonPhoneBook.TabIndex = 12;
            this.buttonPhoneBook.Text = "Phone Book";
            this.buttonPhoneBook.UseVisualStyleBackColor = true;
            this.buttonPhoneBook.Click += new System.EventHandler(this.buttonPhoneBook_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Location = new System.Drawing.Point(400, 206);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(100, 23);
            this.buttonNotes.TabIndex = 13;
            this.buttonNotes.Text = "Notes";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonReminder
            // 
            this.buttonReminder.Location = new System.Drawing.Point(400, 264);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(100, 23);
            this.buttonReminder.TabIndex = 14;
            this.buttonReminder.Text = "Reminder";
            this.buttonReminder.UseVisualStyleBackColor = true;
            this.buttonReminder.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSalaryCalculator
            // 
            this.buttonSalaryCalculator.Location = new System.Drawing.Point(400, 235);
            this.buttonSalaryCalculator.Name = "buttonSalaryCalculator";
            this.buttonSalaryCalculator.Size = new System.Drawing.Size(100, 23);
            this.buttonSalaryCalculator.TabIndex = 15;
            this.buttonSalaryCalculator.Text = "Salary Calculator";
            this.buttonSalaryCalculator.UseVisualStyleBackColor = true;
            this.buttonSalaryCalculator.Click += new System.EventHandler(this.buttonSalaryCalculator_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.buttonSalaryCalculator);
            this.Controls.Add(this.buttonReminder);
            this.Controls.Add(this.buttonNotes);
            this.Controls.Add(this.buttonPhoneBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnChangeType);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.lblSelectedUser);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.Load += new System.EventHandler(this.UserManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblSelectedUser;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnChangeType;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPhoneBook;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonReminder;
        private System.Windows.Forms.Button buttonSalaryCalculator;
    }
}