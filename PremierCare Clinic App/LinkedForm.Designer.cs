﻿namespace PremierCare_Clinic_App
{
    partial class LinkedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkedForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addPatient = new System.Windows.Forms.Button();
            this.viewPatients = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patientBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.welcomeLabel.Location = new System.Drawing.Point(24, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(173, 43);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome ";
            // 
            // formPanel
            // 
            this.formPanel.Location = new System.Drawing.Point(284, 59);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1175, 726);
            this.formPanel.TabIndex = 1;
            this.formPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.formPanel_ControlAdded);
            this.formPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.formPanel_ControlRemoved);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 171);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 540);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.patientBtn);
            this.flowLayoutPanel2.Controls.Add(this.addPatient);
            this.flowLayoutPanel2.Controls.Add(this.viewPatients);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(242, 143);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(242, 55);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(242, 55);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // addPatient
            // 
            this.addPatient.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatient.Location = new System.Drawing.Point(3, 59);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(233, 38);
            this.addPatient.TabIndex = 1;
            this.addPatient.Text = "Add Patient";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // viewPatients
            // 
            this.viewPatients.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPatients.Location = new System.Drawing.Point(3, 103);
            this.viewPatients.Name = "viewPatients";
            this.viewPatients.Size = new System.Drawing.Size(233, 38);
            this.viewPatients.TabIndex = 2;
            this.viewPatients.Text = "View Patients";
            this.viewPatients.UseVisualStyleBackColor = true;
            this.viewPatients.Click += new System.EventHandler(this.viewPatients_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Appointments";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PremierCare_Clinic_App.Properties.Resources.CloseBtn;
            this.pictureBox1.Location = new System.Drawing.Point(1416, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // patientBtn
            // 
            this.patientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patientBtn.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBtn.Image = ((System.Drawing.Image)(resources.GetObject("patientBtn.Image")));
            this.patientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientBtn.Location = new System.Drawing.Point(3, 3);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(233, 50);
            this.patientBtn.TabIndex = 0;
            this.patientBtn.Text = "Patient";
            this.patientBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.patientBtn.UseVisualStyleBackColor = true;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Sign Out";
            // 
            // LinkedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 792);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.formPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LinkedForm";
            this.Text = "0";
            this.Load += new System.EventHandler(this.LinkedForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button viewPatients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}