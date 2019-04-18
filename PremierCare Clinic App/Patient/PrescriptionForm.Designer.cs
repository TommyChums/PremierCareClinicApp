namespace PremierCare_Clinic_App.Patient
{
    partial class PrescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.medicineLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patientNameTxtBox = new System.Windows.Forms.TextBox();
            this.medicineBox = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dosageLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.prescriptionFormLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.treatmentBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.refreshPreview = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // medicineLabel
            // 
            this.medicineLabel.AutoSize = true;
            this.medicineLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineLabel.Location = new System.Drawing.Point(19, 201);
            this.medicineLabel.Name = "medicineLabel";
            this.medicineLabel.Size = new System.Drawing.Size(66, 18);
            this.medicineLabel.TabIndex = 2;
            this.medicineLabel.Text = "Medicine";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(19, 128);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 18);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Patient Name";
            // 
            // patientNameTxtBox
            // 
            this.patientNameTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTxtBox.Location = new System.Drawing.Point(22, 152);
            this.patientNameTxtBox.Name = "patientNameTxtBox";
            this.patientNameTxtBox.ReadOnly = true;
            this.patientNameTxtBox.Size = new System.Drawing.Size(161, 29);
            this.patientNameTxtBox.TabIndex = 4;
            // 
            // medicineBox
            // 
            this.medicineBox.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineBox.FormattingEnabled = true;
            this.medicineBox.ItemHeight = 24;
            this.medicineBox.Location = new System.Drawing.Point(22, 222);
            this.medicineBox.Name = "medicineBox";
            this.medicineBox.Size = new System.Drawing.Size(161, 100);
            this.medicineBox.TabIndex = 5;
            this.medicineBox.SelectedIndexChanged += new System.EventHandler(this.medicineBox_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(214, 226);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(63, 29);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dosageLabel
            // 
            this.dosageLabel.AutoSize = true;
            this.dosageLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosageLabel.Location = new System.Drawing.Point(211, 201);
            this.dosageLabel.Name = "dosageLabel";
            this.dosageLabel.Size = new System.Drawing.Size(102, 18);
            this.dosageLabel.TabIndex = 7;
            this.dosageLabel.Text = "Dosage in Days";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(211, 268);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(112, 18);
            this.durationLabel.TabIndex = 9;
            this.durationLabel.Text = "Duration in Days";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(214, 293);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(63, 29);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // prescriptionFormLabel
            // 
            this.prescriptionFormLabel.AutoSize = true;
            this.prescriptionFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.prescriptionFormLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionFormLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.prescriptionFormLabel.Location = new System.Drawing.Point(187, 28);
            this.prescriptionFormLabel.Name = "prescriptionFormLabel";
            this.prescriptionFormLabel.Size = new System.Drawing.Size(171, 35);
            this.prescriptionFormLabel.TabIndex = 10;
            this.prescriptionFormLabel.Text = "Prescription";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PremierCare_Clinic_App.Properties.Resources.BackBtn;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Go Back";
            // 
            // treatmentBtn
            // 
            this.treatmentBtn.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentBtn.Location = new System.Drawing.Point(76, 354);
            this.treatmentBtn.Name = "treatmentBtn";
            this.treatmentBtn.Size = new System.Drawing.Size(237, 31);
            this.treatmentBtn.TabIndex = 12;
            this.treatmentBtn.Text = "Make Prescription";
            this.treatmentBtn.UseVisualStyleBackColor = true;
            this.treatmentBtn.Click += new System.EventHandler(this.treatmentBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::PremierCare_Clinic_App.Properties.Settings.Default, "test", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.BackColor = System.Drawing.SystemColors.Control;
            this.printPreviewControl1.Document = this.printDocument1;
            this.printPreviewControl1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPreviewControl1.Location = new System.Drawing.Point(352, 128);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(201, 257);
            this.printPreviewControl1.TabIndex = 13;
            this.printPreviewControl1.Zoom = 0.22D;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // refreshPreview
            // 
            this.refreshPreview.Location = new System.Drawing.Point(480, 111);
            this.refreshPreview.Name = "refreshPreview";
            this.refreshPreview.Size = new System.Drawing.Size(59, 23);
            this.refreshPreview.TabIndex = 14;
            this.refreshPreview.Text = "Preview";
            this.refreshPreview.UseVisualStyleBackColor = true;
            this.refreshPreview.Click += new System.EventHandler(this.refreshPreview_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 397);
            this.Controls.Add(this.refreshPreview);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.treatmentBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prescriptionFormLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.dosageLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.medicineBox);
            this.Controls.Add(this.patientNameTxtBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.medicineLabel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrescriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientTreatmentForm";
            this.Load += new System.EventHandler(this.PatientTreatmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label medicineLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox patientNameTxtBox;
        private System.Windows.Forms.ListBox medicineBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label dosageLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label prescriptionFormLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button treatmentBtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button refreshPreview;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}