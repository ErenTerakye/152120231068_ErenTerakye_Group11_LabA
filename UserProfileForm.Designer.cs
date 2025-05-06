namespace userManagement
{
    partial class UserProfileForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileSurname = new System.Windows.Forms.Label();
            this.lblProfilePhone = new System.Windows.Forms.Label();
            this.lblProfileAddress = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfilePassword = new System.Windows.Forms.Label();
            this.lblProfilePhoto = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtProfileSurname = new System.Windows.Forms.TextBox();
            this.txtProfileAddress = new System.Windows.Forms.TextBox();
            this.txtProfilePassword = new System.Windows.Forms.TextBox();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.mtbProfilePhone = new System.Windows.Forms.MaskedTextBox();
            this.pbProfilePhoto = new System.Windows.Forms.PictureBox();
            this.btnProfileSave = new System.Windows.Forms.Button();
            this.btnProfileSelectPhoto = new System.Windows.Forms.Button();
            this.buttonPhoneBook = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.buttonReminder = new System.Windows.Forms.Button();
            this.buttonSalaryCalculator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(29, 51);
            this.lblProfileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(23, 13);
            this.lblProfileName.TabIndex = 0;
            this.lblProfileName.Text = "Ad:";
            // 
            // lblProfileSurname
            // 
            this.lblProfileSurname.AutoSize = true;
            this.lblProfileSurname.Location = new System.Drawing.Point(29, 75);
            this.lblProfileSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfileSurname.Name = "lblProfileSurname";
            this.lblProfileSurname.Size = new System.Drawing.Size(40, 13);
            this.lblProfileSurname.TabIndex = 1;
            this.lblProfileSurname.Text = "Soyad:";
            // 
            // lblProfilePhone
            // 
            this.lblProfilePhone.AutoSize = true;
            this.lblProfilePhone.Location = new System.Drawing.Point(29, 100);
            this.lblProfilePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilePhone.Name = "lblProfilePhone";
            this.lblProfilePhone.Size = new System.Drawing.Size(46, 13);
            this.lblProfilePhone.TabIndex = 2;
            this.lblProfilePhone.Text = "Telefon:";
            // 
            // lblProfileAddress
            // 
            this.lblProfileAddress.AutoSize = true;
            this.lblProfileAddress.Location = new System.Drawing.Point(29, 127);
            this.lblProfileAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfileAddress.Name = "lblProfileAddress";
            this.lblProfileAddress.Size = new System.Drawing.Size(37, 13);
            this.lblProfileAddress.TabIndex = 3;
            this.lblProfileAddress.Text = "Adres:";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Location = new System.Drawing.Point(29, 187);
            this.lblProfileEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(46, 13);
            this.lblProfileEmail.TabIndex = 4;
            this.lblProfileEmail.Text = "E-posta:";
            // 
            // lblProfilePassword
            // 
            this.lblProfilePassword.AutoSize = true;
            this.lblProfilePassword.Location = new System.Drawing.Point(29, 160);
            this.lblProfilePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilePassword.Name = "lblProfilePassword";
            this.lblProfilePassword.Size = new System.Drawing.Size(31, 13);
            this.lblProfilePassword.TabIndex = 5;
            this.lblProfilePassword.Text = "Şifre:";
            // 
            // lblProfilePhoto
            // 
            this.lblProfilePhoto.AutoSize = true;
            this.lblProfilePhoto.Location = new System.Drawing.Point(255, 50);
            this.lblProfilePhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilePhoto.Name = "lblProfilePhoto";
            this.lblProfilePhoto.Size = new System.Drawing.Size(77, 13);
            this.lblProfilePhoto.TabIndex = 6;
            this.lblProfilePhoto.Text = "Profil Fotoğrafı:";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(99, 47);
            this.txtProfileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(114, 20);
            this.txtProfileName.TabIndex = 7;
            // 
            // txtProfileSurname
            // 
            this.txtProfileSurname.Location = new System.Drawing.Point(99, 72);
            this.txtProfileSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfileSurname.Name = "txtProfileSurname";
            this.txtProfileSurname.Size = new System.Drawing.Size(114, 20);
            this.txtProfileSurname.TabIndex = 8;
            // 
            // txtProfileAddress
            // 
            this.txtProfileAddress.Location = new System.Drawing.Point(99, 127);
            this.txtProfileAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfileAddress.Name = "txtProfileAddress";
            this.txtProfileAddress.Size = new System.Drawing.Size(114, 20);
            this.txtProfileAddress.TabIndex = 9;
            // 
            // txtProfilePassword
            // 
            this.txtProfilePassword.Location = new System.Drawing.Point(98, 155);
            this.txtProfilePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfilePassword.Name = "txtProfilePassword";
            this.txtProfilePassword.Size = new System.Drawing.Size(114, 20);
            this.txtProfilePassword.TabIndex = 10;
            this.txtProfilePassword.UseSystemPasswordChar = true;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Location = new System.Drawing.Point(99, 179);
            this.txtProfileEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfileEmail.Multiline = true;
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(114, 23);
            this.txtProfileEmail.TabIndex = 11;
            // 
            // mtbProfilePhone
            // 
            this.mtbProfilePhone.Location = new System.Drawing.Point(99, 100);
            this.mtbProfilePhone.Margin = new System.Windows.Forms.Padding(2);
            this.mtbProfilePhone.Mask = "(999) 000 00 00";
            this.mtbProfilePhone.Name = "mtbProfilePhone";
            this.mtbProfilePhone.Size = new System.Drawing.Size(114, 20);
            this.mtbProfilePhone.TabIndex = 12;
            // 
            // pbProfilePhoto
            // 
            this.pbProfilePhoto.Location = new System.Drawing.Point(257, 71);
            this.pbProfilePhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbProfilePhoto.Name = "pbProfilePhoto";
            this.pbProfilePhoto.Size = new System.Drawing.Size(143, 129);
            this.pbProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfilePhoto.TabIndex = 13;
            this.pbProfilePhoto.TabStop = false;
            // 
            // btnProfileSave
            // 
            this.btnProfileSave.Location = new System.Drawing.Point(99, 220);
            this.btnProfileSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfileSave.Name = "btnProfileSave";
            this.btnProfileSave.Size = new System.Drawing.Size(113, 23);
            this.btnProfileSave.TabIndex = 14;
            this.btnProfileSave.Text = "Kaydet";
            this.btnProfileSave.UseVisualStyleBackColor = true;
            this.btnProfileSave.Click += new System.EventHandler(this.btnProfileSave_Click);
            // 
            // btnProfileSelectPhoto
            // 
            this.btnProfileSelectPhoto.Location = new System.Drawing.Point(257, 219);
            this.btnProfileSelectPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfileSelectPhoto.Name = "btnProfileSelectPhoto";
            this.btnProfileSelectPhoto.Size = new System.Drawing.Size(143, 23);
            this.btnProfileSelectPhoto.TabIndex = 15;
            this.btnProfileSelectPhoto.Text = "Fotoğraf Seç";
            this.btnProfileSelectPhoto.UseVisualStyleBackColor = true;
            this.btnProfileSelectPhoto.Click += new System.EventHandler(this.btnProfileSelectPhoto_Click);
            // 
            // buttonPhoneBook
            // 
            this.buttonPhoneBook.Location = new System.Drawing.Point(421, 72);
            this.buttonPhoneBook.Name = "buttonPhoneBook";
            this.buttonPhoneBook.Size = new System.Drawing.Size(100, 23);
            this.buttonPhoneBook.TabIndex = 16;
            this.buttonPhoneBook.Text = "Phone Book";
            this.buttonPhoneBook.UseVisualStyleBackColor = true;
            this.buttonPhoneBook.Click += new System.EventHandler(this.buttonPhoneBook_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Location = new System.Drawing.Point(421, 103);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(100, 23);
            this.buttonNotes.TabIndex = 17;
            this.buttonNotes.Text = "Notes";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // buttonReminder
            // 
            this.buttonReminder.Location = new System.Drawing.Point(421, 132);
            this.buttonReminder.Name = "buttonReminder";
            this.buttonReminder.Size = new System.Drawing.Size(100, 23);
            this.buttonReminder.TabIndex = 18;
            this.buttonReminder.Text = "Reminder";
            this.buttonReminder.UseVisualStyleBackColor = true;
            this.buttonReminder.Click += new System.EventHandler(this.buttonReminder_Click);
            // 
            // buttonSalaryCalculator
            // 
            this.buttonSalaryCalculator.Location = new System.Drawing.Point(421, 161);
            this.buttonSalaryCalculator.Name = "buttonSalaryCalculator";
            this.buttonSalaryCalculator.Size = new System.Drawing.Size(100, 23);
            this.buttonSalaryCalculator.TabIndex = 19;
            this.buttonSalaryCalculator.Text = "Salary Calculator";
            this.buttonSalaryCalculator.UseVisualStyleBackColor = true;
            this.buttonSalaryCalculator.Click += new System.EventHandler(this.buttonSalaryCalculator_Click);
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.buttonSalaryCalculator);
            this.Controls.Add(this.buttonReminder);
            this.Controls.Add(this.buttonNotes);
            this.Controls.Add(this.buttonPhoneBook);
            this.Controls.Add(this.btnProfileSelectPhoto);
            this.Controls.Add(this.btnProfileSave);
            this.Controls.Add(this.pbProfilePhoto);
            this.Controls.Add(this.mtbProfilePhone);
            this.Controls.Add(this.txtProfileEmail);
            this.Controls.Add(this.txtProfilePassword);
            this.Controls.Add(this.txtProfileAddress);
            this.Controls.Add(this.txtProfileSurname);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.lblProfilePhoto);
            this.Controls.Add(this.lblProfilePassword);
            this.Controls.Add(this.lblProfileEmail);
            this.Controls.Add(this.lblProfileAddress);
            this.Controls.Add(this.lblProfilePhone);
            this.Controls.Add(this.lblProfileSurname);
            this.Controls.Add(this.lblProfileName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserProfileForm";
            this.Text = "Telefon:";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileSurname;
        private System.Windows.Forms.Label lblProfilePhone;
        private System.Windows.Forms.Label lblProfileAddress;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfilePassword;
        private System.Windows.Forms.Label lblProfilePhoto;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtProfileSurname;
        private System.Windows.Forms.TextBox txtProfileAddress;
        private System.Windows.Forms.TextBox txtProfilePassword;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.MaskedTextBox mtbProfilePhone;
        private System.Windows.Forms.PictureBox pbProfilePhoto;
        private System.Windows.Forms.Button btnProfileSave;
        private System.Windows.Forms.Button btnProfileSelectPhoto;
        private System.Windows.Forms.Button buttonPhoneBook;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.Button buttonReminder;
        private System.Windows.Forms.Button buttonSalaryCalculator;
    }
}

