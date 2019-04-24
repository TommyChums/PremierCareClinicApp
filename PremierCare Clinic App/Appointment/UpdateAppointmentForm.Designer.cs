namespace PremierCare_Clinic_App.Appointment
{
    partial class UpdateAppointmentForm
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
            this.components = new System.ComponentModel.Container();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientTxtBox = new System.Windows.Forms.TextBox();
            this.serviceTxtBox = new System.Windows.Forms.TextBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorTxtBox = new System.Windows.Forms.TextBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.updateAppointmentFormLabel = new System.Windows.Forms.Label();
            this.updateDate = new System.Windows.Forms.DateTimePicker();
            this.updateDateLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.detailsTxtBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.updateTime = new System.Windows.Forms.DateTimePicker();
            this.chkBxCompleted = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(120, 167);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(124, 35);
            this.patientNameLabel.TabIndex = 0;
            this.patientNameLabel.Text = "Patient: ";
            // 
            // patientTxtBox
            // 
            this.patientTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientTxtBox.Location = new System.Drawing.Point(126, 215);
            this.patientTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientTxtBox.Name = "patientTxtBox";
            this.patientTxtBox.ReadOnly = true;
            this.patientTxtBox.Size = new System.Drawing.Size(329, 38);
            this.patientTxtBox.TabIndex = 1;
            // 
            // serviceTxtBox
            // 
            this.serviceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceTxtBox.Location = new System.Drawing.Point(484, 215);
            this.serviceTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serviceTxtBox.Name = "serviceTxtBox";
            this.serviceTxtBox.ReadOnly = true;
            this.serviceTxtBox.Size = new System.Drawing.Size(180, 38);
            this.serviceTxtBox.TabIndex = 3;
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLabel.Location = new System.Drawing.Point(683, 167);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(109, 35);
            this.doctorLabel.TabIndex = 2;
            this.doctorLabel.Text = "Doctor:";
            // 
            // doctorTxtBox
            // 
            this.doctorTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorTxtBox.Location = new System.Drawing.Point(689, 215);
            this.doctorTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doctorTxtBox.Name = "doctorTxtBox";
            this.doctorTxtBox.ReadOnly = true;
            this.doctorTxtBox.Size = new System.Drawing.Size(329, 38);
            this.doctorTxtBox.TabIndex = 5;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(478, 167);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(128, 35);
            this.serviceLabel.TabIndex = 4;
            this.serviceLabel.Text = "Service: ";
            // 
            // updateAppointmentFormLabel
            // 
            this.updateAppointmentFormLabel.AutoSize = true;
            this.updateAppointmentFormLabel.Font = new System.Drawing.Font("Trebuchet MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAppointmentFormLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.updateAppointmentFormLabel.Location = new System.Drawing.Point(339, 37);
            this.updateAppointmentFormLabel.Name = "updateAppointmentFormLabel";
            this.updateAppointmentFormLabel.Size = new System.Drawing.Size(479, 59);
            this.updateAppointmentFormLabel.TabIndex = 6;
            this.updateAppointmentFormLabel.Text = "Update Appointment";
            // 
            // updateDate
            // 
            this.updateDate.CalendarFont = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDate.CustomFormat = "yyyy/MM/dd";
            this.updateDate.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updateDate.Location = new System.Drawing.Point(484, 351);
            this.updateDate.Name = "updateDate";
            this.updateDate.Size = new System.Drawing.Size(168, 38);
            this.updateDate.TabIndex = 7;
            // 
            // updateDateLabel
            // 
            this.updateDateLabel.AutoSize = true;
            this.updateDateLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDateLabel.Location = new System.Drawing.Point(478, 313);
            this.updateDateLabel.Name = "updateDateLabel";
            this.updateDateLabel.Size = new System.Drawing.Size(73, 35);
            this.updateDateLabel.TabIndex = 8;
            this.updateDateLabel.Text = "Date";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.Location = new System.Drawing.Point(120, 313);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(101, 35);
            this.detailsLabel.TabIndex = 9;
            this.detailsLabel.Text = "Details";
            // 
            // detailsTxtBox
            // 
            this.detailsTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTxtBox.Location = new System.Drawing.Point(126, 351);
            this.detailsTxtBox.Multiline = true;
            this.detailsTxtBox.Name = "detailsTxtBox";
            this.detailsTxtBox.Size = new System.Drawing.Size(329, 188);
            this.detailsTxtBox.TabIndex = 10;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(683, 313);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(78, 35);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "Time";
            // 
            // updateTime
            // 
            this.updateTime.CalendarFont = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTime.CustomFormat = "h:mm tt";
            this.updateTime.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updateTime.Location = new System.Drawing.Point(689, 351);
            this.updateTime.Name = "updateTime";
            this.updateTime.ShowUpDown = true;
            this.updateTime.Size = new System.Drawing.Size(146, 38);
            this.updateTime.TabIndex = 11;
            // 
            // chkBxCompleted
            // 
            this.chkBxCompleted.AutoSize = true;
            this.chkBxCompleted.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxCompleted.Location = new System.Drawing.Point(689, 500);
            this.chkBxCompleted.Name = "chkBxCompleted";
            this.chkBxCompleted.Size = new System.Drawing.Size(172, 39);
            this.chkBxCompleted.TabIndex = 13;
            this.chkBxCompleted.Text = "Completed";
            this.chkBxCompleted.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(437, 627);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(295, 57);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update Appointment";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PremierCare_Clinic_App.Properties.Resources.BackBtn;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Go Back";
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 726);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.chkBxCompleted);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.updateTime);
            this.Controls.Add(this.detailsTxtBox);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.updateDateLabel);
            this.Controls.Add(this.updateDate);
            this.Controls.Add(this.updateAppointmentFormLabel);
            this.Controls.Add(this.doctorTxtBox);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.serviceTxtBox);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.patientTxtBox);
            this.Controls.Add(this.patientNameLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePatientForm";
            this.Load += new System.EventHandler(this.UpdatePatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.TextBox patientTxtBox;
        private System.Windows.Forms.TextBox serviceTxtBox;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.TextBox doctorTxtBox;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label updateAppointmentFormLabel;
        private System.Windows.Forms.DateTimePicker updateDate;
        private System.Windows.Forms.Label updateDateLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.TextBox detailsTxtBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker updateTime;
        private System.Windows.Forms.CheckBox chkBxCompleted;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}