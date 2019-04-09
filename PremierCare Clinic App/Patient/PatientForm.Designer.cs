namespace PremierCare_Clinic_App.Patient
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.bloodTypeLabel = new System.Windows.Forms.Label();
            this.allergiesLabel = new System.Windows.Forms.Label();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.patientNameTxtBox = new System.Windows.Forms.TextBox();
            this.contactNoTxtBox = new System.Windows.Forms.TextBox();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.allergiesTxtBox = new System.Windows.Forms.TextBox();
            this.patientFormLabel = new System.Windows.Forms.Label();
            this.addPatientBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.DOBTxtBox = new System.Windows.Forms.DateTimePicker();
            this.bloodTypeTxtBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientIDTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // patientNameLabel
            // 
            resources.ApplyResources(this.patientNameLabel, "patientNameLabel");
            this.patientNameLabel.Name = "patientNameLabel";
            // 
            // contactNoLabel
            // 
            resources.ApplyResources(this.contactNoLabel, "contactNoLabel");
            this.contactNoLabel.Name = "contactNoLabel";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // bloodTypeLabel
            // 
            resources.ApplyResources(this.bloodTypeLabel, "bloodTypeLabel");
            this.bloodTypeLabel.Name = "bloodTypeLabel";
            // 
            // allergiesLabel
            // 
            resources.ApplyResources(this.allergiesLabel, "allergiesLabel");
            this.allergiesLabel.Name = "allergiesLabel";
            // 
            // DOBLabel
            // 
            resources.ApplyResources(this.DOBLabel, "DOBLabel");
            this.DOBLabel.Name = "DOBLabel";
            // 
            // patientNameTxtBox
            // 
            resources.ApplyResources(this.patientNameTxtBox, "patientNameTxtBox");
            this.patientNameTxtBox.Name = "patientNameTxtBox";
            // 
            // contactNoTxtBox
            // 
            resources.ApplyResources(this.contactNoTxtBox, "contactNoTxtBox");
            this.contactNoTxtBox.Name = "contactNoTxtBox";
            this.contactNoTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.contactNoTxtBox_Validating);
            // 
            // addressTxtBox
            // 
            resources.ApplyResources(this.addressTxtBox, "addressTxtBox");
            this.addressTxtBox.Name = "addressTxtBox";
            // 
            // allergiesTxtBox
            // 
            resources.ApplyResources(this.allergiesTxtBox, "allergiesTxtBox");
            this.allergiesTxtBox.Name = "allergiesTxtBox";
            // 
            // patientFormLabel
            // 
            resources.ApplyResources(this.patientFormLabel, "patientFormLabel");
            this.patientFormLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.patientFormLabel.Name = "patientFormLabel";
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.addPatientBtn, "addPatientBtn");
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.UseVisualStyleBackColor = true;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            this.addPatientBtn.MouseHover += new System.EventHandler(this.addPatientBtn_MouseHover);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.backBtn, "backBtn");
            this.backBtn.Name = "backBtn";
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            this.backBtn.MouseHover += new System.EventHandler(this.backBtn_MouseHover);
            // 
            // DOBTxtBox
            // 
            resources.ApplyResources(this.DOBTxtBox, "DOBTxtBox");
            this.DOBTxtBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBTxtBox.Name = "DOBTxtBox";
            // 
            // bloodTypeTxtBox
            // 
            this.bloodTypeTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.bloodTypeTxtBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.bloodTypeTxtBox, "bloodTypeTxtBox");
            this.bloodTypeTxtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bloodTypeTxtBox.FormattingEnabled = true;
            this.bloodTypeTxtBox.Items.AddRange(new object[] {
            resources.GetString("bloodTypeTxtBox.Items"),
            resources.GetString("bloodTypeTxtBox.Items1"),
            resources.GetString("bloodTypeTxtBox.Items2"),
            resources.GetString("bloodTypeTxtBox.Items3"),
            resources.GetString("bloodTypeTxtBox.Items4"),
            resources.GetString("bloodTypeTxtBox.Items5"),
            resources.GetString("bloodTypeTxtBox.Items6"),
            resources.GetString("bloodTypeTxtBox.Items7"),
            resources.GetString("bloodTypeTxtBox.Items8")});
            this.bloodTypeTxtBox.Name = "bloodTypeTxtBox";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Name = "label1";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Go Back";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Register Patient";
            // 
            // patientIDLabel
            // 
            resources.ApplyResources(this.patientIDLabel, "patientIDLabel");
            this.patientIDLabel.Name = "patientIDLabel";
            // 
            // patientIDTxtBox
            // 
            resources.ApplyResources(this.patientIDTxtBox, "patientIDTxtBox");
            this.patientIDTxtBox.Name = "patientIDTxtBox";
            this.patientIDTxtBox.TabStop = false;
            // 
            // PatientForm
            // 
            this.AcceptButton = this.addPatientBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientIDTxtBox);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bloodTypeTxtBox);
            this.Controls.Add(this.DOBTxtBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addPatientBtn);
            this.Controls.Add(this.patientFormLabel);
            this.Controls.Add(this.allergiesTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.contactNoTxtBox);
            this.Controls.Add(this.patientNameTxtBox);
            this.Controls.Add(this.bloodTypeLabel);
            this.Controls.Add(this.allergiesLabel);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.contactNoLabel);
            this.Controls.Add(this.patientNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label bloodTypeLabel;
        private System.Windows.Forms.Label allergiesLabel;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.TextBox patientNameTxtBox;
        private System.Windows.Forms.TextBox contactNoTxtBox;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox allergiesTxtBox;
        private System.Windows.Forms.Label patientFormLabel;
        private System.Windows.Forms.Button addPatientBtn;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.DateTimePicker DOBTxtBox;
        private System.Windows.Forms.ComboBox bloodTypeTxtBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox patientIDTxtBox;
        private System.Windows.Forms.Label patientIDLabel;
    }
}