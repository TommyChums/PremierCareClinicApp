namespace PremierCare_Clinic_App.Appointment
{
    partial class ViewAppointmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointmentsForm));
            this.appointmentSearch = new System.Windows.Forms.TextBox();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.appointmentLookupLabel = new System.Windows.Forms.Label();
            this.updateAppointmentBtn = new System.Windows.Forms.Button();
            this.appointmentCompleteBtn = new System.Windows.Forms.Button();
            this.generateInvoiceBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentSearch
            // 
            this.appointmentSearch.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentSearch.Location = new System.Drawing.Point(2, 167);
            this.appointmentSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.appointmentSearch.Name = "appointmentSearch";
            this.appointmentSearch.Size = new System.Drawing.Size(391, 38);
            this.appointmentSearch.TabIndex = 2;
            this.appointmentSearch.TextChanged += new System.EventHandler(this.appointmentSearch_TextChanged);
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.AllowUserToAddRows = false;
            this.appointmentGridView.AllowUserToDeleteRows = false;
            this.appointmentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.appointmentGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.appointmentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGridView.Location = new System.Drawing.Point(1, 211);
            this.appointmentGridView.MultiSelect = false;
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.ReadOnly = true;
            this.appointmentGridView.Size = new System.Drawing.Size(1172, 514);
            this.appointmentGridView.TabIndex = 3;
            this.appointmentGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.appointmentGridView_RowHeaderMouseClick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Go Back";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(410, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 38);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // appointmentLookupLabel
            // 
            this.appointmentLookupLabel.AutoSize = true;
            this.appointmentLookupLabel.Font = new System.Drawing.Font("Trebuchet MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLookupLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.appointmentLookupLabel.Location = new System.Drawing.Point(337, 37);
            this.appointmentLookupLabel.Name = "appointmentLookupLabel";
            this.appointmentLookupLabel.Size = new System.Drawing.Size(486, 59);
            this.appointmentLookupLabel.TabIndex = 6;
            this.appointmentLookupLabel.Text = "Appointment Lookup";
            // 
            // updateAppointmentBtn
            // 
            this.updateAppointmentBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAppointmentBtn.Location = new System.Drawing.Point(624, 167);
            this.updateAppointmentBtn.Name = "updateAppointmentBtn";
            this.updateAppointmentBtn.Size = new System.Drawing.Size(199, 38);
            this.updateAppointmentBtn.TabIndex = 7;
            this.updateAppointmentBtn.Text = "Update Appointment";
            this.updateAppointmentBtn.UseVisualStyleBackColor = true;
            this.updateAppointmentBtn.Click += new System.EventHandler(this.updateAppointmentBtn_Click);
            // 
            // appointmentCompleteBtn
            // 
            this.appointmentCompleteBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentCompleteBtn.Location = new System.Drawing.Point(998, 167);
            this.appointmentCompleteBtn.Name = "appointmentCompleteBtn";
            this.appointmentCompleteBtn.Size = new System.Drawing.Size(175, 38);
            this.appointmentCompleteBtn.TabIndex = 8;
            this.appointmentCompleteBtn.Text = "Mark un/complete";
            this.appointmentCompleteBtn.UseVisualStyleBackColor = true;
            this.appointmentCompleteBtn.Click += new System.EventHandler(this.appointmentCompleteBtn_Click);
            // 
            // generateInvoiceBtn
            // 
            this.generateInvoiceBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateInvoiceBtn.Location = new System.Drawing.Point(829, 167);
            this.generateInvoiceBtn.Name = "generateInvoiceBtn";
            this.generateInvoiceBtn.Size = new System.Drawing.Size(163, 38);
            this.generateInvoiceBtn.TabIndex = 9;
            this.generateInvoiceBtn.Text = "Generate Invoice";
            this.generateInvoiceBtn.UseVisualStyleBackColor = true;
            this.generateInvoiceBtn.Click += new System.EventHandler(this.generateInvoiceBtn_Click);
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
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ViewAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 726);
            this.Controls.Add(this.generateInvoiceBtn);
            this.Controls.Add(this.appointmentCompleteBtn);
            this.Controls.Add(this.updateAppointmentBtn);
            this.Controls.Add(this.appointmentLookupLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.appointmentGridView);
            this.Controls.Add(this.appointmentSearch);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewAppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAppointments";
            this.Load += new System.EventHandler(this.ViewAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appointmentSearch;
        private System.Windows.Forms.DataGridView appointmentGridView;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label appointmentLookupLabel;
        private System.Windows.Forms.Button updateAppointmentBtn;
        private System.Windows.Forms.Button appointmentCompleteBtn;
        private System.Windows.Forms.Button generateInvoiceBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}