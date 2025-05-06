namespace Reminder
{
    partial class AddEditReminderForm
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
            rbMeeting = new RadioButton();
            rbTask = new RadioButton();
            label1 = new Label();
            txtSummary = new TextBox();
            rtbDescription = new TextBox();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            numHour = new NumericUpDown();
            numMinute = new NumericUpDown();
            txtLocation = new TextBox();
            label3 = new Label();
            lstAttendees = new ListBox();
            pnlMeetingFields = new Panel();
            cmbCategory = new ComboBox();
            chckIsCompleted = new CheckBox();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pnlTaskFields = new Panel();
            ((System.ComponentModel.ISupportInitialize)numHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).BeginInit();
            SuspendLayout();
            // 
            // rbMeeting
            // 
            rbMeeting.AutoSize = true;
            rbMeeting.Location = new Point(22, 86);
            rbMeeting.Name = "rbMeeting";
            rbMeeting.Size = new Size(84, 24);
            rbMeeting.TabIndex = 0;
            rbMeeting.TabStop = true;
            rbMeeting.Text = "Toplantı";
            rbMeeting.UseVisualStyleBackColor = true;
            // 
            // rbTask
            // 
            rbTask.AutoSize = true;
            rbTask.Location = new Point(175, 86);
            rbTask.Name = "rbTask";
            rbTask.Size = new Size(69, 24);
            rbTask.TabIndex = 1;
            rbTask.TabStop = true;
            rbTask.Text = "Görev";
            rbTask.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 138);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Başlık:";
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(142, 135);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(125, 27);
            txtSummary.TabIndex = 3;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(142, 293);
            rtbDescription.Multiline = true;
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(125, 123);
            rtbDescription.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 296);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "Açıklama: ";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(291, 23);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 6;
            // 
            // numHour
            // 
            numHour.Location = new Point(391, 86);
            numHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numHour.Name = "numHour";
            numHour.Size = new Size(150, 27);
            numHour.TabIndex = 7;
            // 
            // numMinute
            // 
            numMinute.Location = new Point(391, 140);
            numMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numMinute.Name = "numMinute";
            numMinute.Size = new Size(150, 27);
            numMinute.TabIndex = 8;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(142, 185);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 188);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 10;
            label3.Text = "Yer:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstAttendees
            // 
            lstAttendees.FormattingEnabled = true;
            lstAttendees.Location = new Point(391, 188);
            lstAttendees.Name = "lstAttendees";
            lstAttendees.Size = new Size(150, 104);
            lstAttendees.TabIndex = 11;
            // 
            // pnlMeetingFields
            // 
            pnlMeetingFields.Location = new Point(547, 23);
            pnlMeetingFields.Name = "pnlMeetingFields";
            pnlMeetingFields.Size = new Size(250, 125);
            pnlMeetingFields.TabIndex = 12;
            pnlMeetingFields.Paint += pnlMeetingFields_Paint;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(390, 316);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(151, 28);
            cmbCategory.TabIndex = 0;
            // 
            // chckIsCompleted
            // 
            chckIsCompleted.AutoSize = true;
            chckIsCompleted.Location = new Point(390, 370);
            chckIsCompleted.Name = "chckIsCompleted";
            chckIsCompleted.Size = new Size(140, 24);
            chckIsCompleted.TabIndex = 13;
            chckIsCompleted.Text = "Tamamlandı mı?";
            chckIsCompleted.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(391, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 88);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 15;
            label4.Text = "Saat Seçimi: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 142);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 16;
            label5.Text = "Dakika Seçimi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 324);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 17;
            label6.Text = "Saat Seçimi: ";
            // 
            // pnlTaskFields
            // 
            pnlTaskFields.Location = new Point(547, 191);
            pnlTaskFields.Name = "pnlTaskFields";
            pnlTaskFields.Size = new Size(250, 125);
            pnlTaskFields.TabIndex = 13;
            // 
            // AddEditReminderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 450);
            Controls.Add(pnlTaskFields);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(chckIsCompleted);
            Controls.Add(cmbCategory);
            Controls.Add(pnlMeetingFields);
            Controls.Add(lstAttendees);
            Controls.Add(label3);
            Controls.Add(txtLocation);
            Controls.Add(numMinute);
            Controls.Add(numHour);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(rtbDescription);
            Controls.Add(txtSummary);
            Controls.Add(label1);
            Controls.Add(rbTask);
            Controls.Add(rbMeeting);
            Name = "AddEditReminderForm";
            Text = "AddEditReminderForm";
            ((System.ComponentModel.ISupportInitialize)numHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbMeeting;
        private RadioButton rbTask;
        private Label label1;
        private TextBox txtSummary;
        private TextBox rtbDescription;
        private Label label2;
        private DateTimePicker dtpDate;
        private NumericUpDown numHour;
        private NumericUpDown numMinute;
        private TextBox txtLocation;
        private Label label3;
        private ListBox lstAttendees;
        private Panel pnlMeetingFields;
        private ComboBox cmbCategory;
        private CheckBox chckIsCompleted;
        private Button btnSave;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel pnlTaskFields;
    }
}