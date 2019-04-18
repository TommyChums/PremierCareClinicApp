namespace PremierCare_Clinic_App.Patient
{
    partial class ViewPatientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatientsForm));
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.patientLookUpLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.updatePatientBtn = new System.Windows.Forms.Button();
            this.createAppointment = new System.Windows.Forms.Button();
            this.treatmentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // patientGridView
            // 
            this.patientGridView.AllowUserToAddRows = false;
            this.patientGridView.AllowUserToDeleteRows = false;
            this.patientGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.patientGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Location = new System.Drawing.Point(0, 124);
            this.patientGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientGridView.MultiSelect = false;
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.ReadOnly = true;
            this.patientGridView.Size = new System.Drawing.Size(737, 367);
            this.patientGridView.TabIndex = 0;
            this.patientGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patientGridView_RowHeaderMouseClick);
            this.patientGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.patientGridView_RowHeaderMouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // patientLookUpLabel
            // 
            this.patientLookUpLabel.AutoSize = true;
            this.patientLookUpLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLookUpLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.patientLookUpLabel.Location = new System.Drawing.Point(271, 19);
            this.patientLookUpLabel.Name = "patientLookUpLabel";
            this.patientLookUpLabel.Size = new System.Drawing.Size(206, 35);
            this.patientLookUpLabel.TabIndex = 2;
            this.patientLookUpLabel.Text = "Patient Lookup";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Go Back";
            // 
            // updatePatientBtn
            // 
            this.updatePatientBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePatientBtn.Location = new System.Drawing.Point(277, 87);
            this.updatePatientBtn.Name = "updatePatientBtn";
            this.updatePatientBtn.Size = new System.Drawing.Size(135, 30);
            this.updatePatientBtn.TabIndex = 5;
            this.updatePatientBtn.Text = "Update Patient";
            this.updatePatientBtn.UseVisualStyleBackColor = true;
            this.updatePatientBtn.Click += new System.EventHandler(this.updatePatientBtn_Click);
            // 
            // createAppointment
            // 
            this.createAppointment.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAppointment.Location = new System.Drawing.Point(431, 86);
            this.createAppointment.Name = "createAppointment";
            this.createAppointment.Size = new System.Drawing.Size(161, 30);
            this.createAppointment.TabIndex = 6;
            this.createAppointment.Text = "Create Appointment";
            this.createAppointment.UseVisualStyleBackColor = true;
            this.createAppointment.Click += new System.EventHandler(this.createAppointment_Click);
            // 
            // treatmentBtn
            // 
            this.treatmentBtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentBtn.Location = new System.Drawing.Point(607, 86);
            this.treatmentBtn.Name = "treatmentBtn";
            this.treatmentBtn.Size = new System.Drawing.Size(118, 30);
            this.treatmentBtn.TabIndex = 7;
            this.treatmentBtn.Text = "Prescriptions";
            this.treatmentBtn.UseVisualStyleBackColor = true;
            this.treatmentBtn.Click += new System.EventHandler(this.treatmentBtn_Click);
            // 
            // ViewPatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 491);
            this.Controls.Add(this.treatmentBtn);
            this.Controls.Add(this.createAppointment);
            this.Controls.Add(this.updatePatientBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.patientLookUpLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.patientGridView);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPatientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatients";
            this.Load += new System.EventHandler(this.ViewPatientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label patientLookUpLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button updatePatientBtn;
        private System.Windows.Forms.Button createAppointment;
        private System.Windows.Forms.Button treatmentBtn;
    }
}