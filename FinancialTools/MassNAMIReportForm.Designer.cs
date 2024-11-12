            this.backgroundWorkerMassNAMICalculation = new System.ComponentModel.BackgroundWorker();
            this.grpMassNAMIReportParameters.SuspendLayout();
            this.grpMassNAMIShortExport.SuspendLayout();
            this.grpMassNAMIReportProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMassNAMI)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMassNAMI
            // 
            this.dataMassNAMI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMassNAMI.Location = new System.Drawing.Point(12, 12);
            this.dataMassNAMI.Name = "dataMassNAMI";
            this.dataMassNAMI.Size = new System.Drawing.Size(776, 150);
            this.dataMassNAMI.TabIndex = 0;
            // 
            // lblMassNAMIPickCutOffDate
            // 
            this.lblMassNAMIPickCutOffDate.AutoSize = true;
            this.lblMassNAMIPickCutOffDate.Location = new System.Drawing.Point(12, 175);
            this.lblMassNAMIPickCutOffDate.Name = "lblMassNAMIPickCutOffDate";
            this.lblMassNAMIPickCutOffDate.Size = new System.Drawing.Size(101, 13);
            this.lblMassNAMIPickCutOffDate.TabIndex = 1;
            this.lblMassNAMIPickCutOffDate.Text = "Pick Cut-off Date:";
            // 
            // dateMassNAMICutOffTimePicker
            // 
            this.dateMassNAMICutOffTimePicker.Location = new System.Drawing.Point(119, 175);
            this.dateMassNAMICutOffTimePicker.Name = "dateMassNAMICutOffTimePicker";
            this.dateMassNAMICutOffTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateMassNAMICutOffTimePicker.TabIndex = 2;
            // 
            // grpMassNAMIReportParameters
            // 
            this.grpMassNAMIReportParameters.Controls.Add(this.btnMassNAMIBuildReport);
            this.grpMassNAMIReportParameters.Location = new System.Drawing.Point(12, 201);
            this.grpMassNAMIReportParameters.Name = "grpMassNAMIReportParameters";
            this.grpMassNAMIReportParameters.Size = new System.Drawing.Size(776, 100);
            this.grpMassNAMIReportParameters.TabIndex = 3;
            this.grpMassNAMIReportParameters.TabStop = false;
            this.grpMassNAMIReportParameters.Text = "Report Parameters";
            // 
            // btnMassNAMIBuildReport
            // 
            this.btnMassNAMIBuildReport.Location = new System.Drawing.Point(6, 19);
            this.btnMassNAMIBuildReport.Name = "btnMassNAMIBuildReport";
            this.btnMassNAMIBuildReport.Size = new System.Drawing.Size(150, 23);
            this.btnMassNAMIBuildReport.TabIndex = 0;
            this.btnMassNAMIBuildReport.Text = "Build Report";
            this.btnMassNAMIBuildReport.UseVisualStyleBackColor = true;
            // 
            // grpMassNAMIShortExport
            // 
            this.grpMassNAMIShortExport.Controls.Add(this.btnMassNAMIShortReportToCSV);
            this.grpMassNAMIShortExport.Controls.Add(this.btnMassNAMIShortReportToExcel);
            this.grpMassNAMIShortExport.Location = new System.Drawing.Point(12, 307);
            this.grpMassNAMIShortExport.Name = "grpMassNAMIShortExport";
            this.grpMassNAMIShortExport.Size = new System.Drawing.Size(776, 100);
            this.grpMassNAMIShortExport.TabIndex = 4;
            this.grpMassNAMIShortExport.TabStop = false;
            this.grpMassNAMIShortExport.Text = "Short Export Options";
            // 
            // btnMassNAMIShortReportToCSV
            // 
            this.btnMassNAMIShortReportToCSV.Location = new System.Drawing.Point(6, 19);
            this.btnMassNAMIShortReportToCSV.Name = "btnMassNAMIShortReportToCSV";
            this.btnMassNAMIShortReportToCSV.Size = new System.Drawing.Size(150, 23);
            this.btnMassNAMIShortReportToCSV.TabIndex = 1;
            this.btnMassNAMIShortReportToCSV.Text = "Export to CSV";
            this.btnMassNAMIShortReportToCSV.UseVisualStyleBackColor = true;
            // 
            // btnMassNAMIShortReportToExcel
            // 
            this.btnMassNAMIShortReportToExcel.Location = new System.Drawing.Point(162, 19);
            this.btnMassNAMIShortReportToExcel.Name = "btnMassNAMIShortReportToExcel";
            this.btnMassNAMIShortReportToExcel.Size = new System.Drawing.Size(150, 23);
            this.btnMassNAMIShortReportToExcel.TabIndex = 0;
            this.btnMassNAMIShortReportToExcel.Text = "Export to Excel";
            this.btnMassNAMIShortReportToExcel.UseVisualStyleBackColor = true;
            // 
            // grpMassNAMIReportProgress
            // 
            this.grpMassNAMIReportProgress.Controls.Add(this.barMassNAMIReportProgress);
            this.grpMassNAMIReportProgress.Location = new System.Drawing.Point(12, 413);
            this.grpMassNAMIReportProgress.Name = "grpMassNAMIReportProgress";
            this.grpMassNAMIReportProgress.Size = new System.Drawing.Size(776, 100);
            this.grpMassNAMIReportProgress.TabIndex = 5;
            this.grpMassNAMIReportProgress.TabStop = false;
            this.grpMassNAMIReportProgress.Text = "Report Progress";
            // 
            // barMassNAMIReportProgress
            // 
            this.barMassNAMIReportProgress.Location = new System.Drawing.Point(6, 19);
            this.barMassNAMIReportProgress.Name = "barMassNAMIReportProgress";
            this.barMassNAMIReportProgress.Size = new System.Drawing.Size(764, 23);
            this.barMassNAMIReportProgress.TabIndex = 0;
            // 
            // backgroundMassNAMICalculation
            // 
            this.backgroundMassNAMICalculation.WorkerReportsProgress = true;
            this.backgroundMassNAMICalculation.WorkerSupportsCancellation = true;
            this.backgroundMassNAMICalculation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundMassNAMICalculation_DoWork);
            this.backgroundMassNAMICalculation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundMassNAMICalculation_ProgressChanged);
            this.backgroundMassNAMICalculation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundMassNAMICalculation_RunWorkerCompleted);
            // 
            // MassNAMIReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.AddssNAMIPickCutOffDate.Name = "lblMassNAMIPickCutOffDate";
            this.lblMassNAMIPickCutOffDate.Size = new System.Drawing.Size(85, 13);
            this.lblMassNAMIPickCutOffDate.TabIndex = 0;
            this.lblMassNAMIPickCutOffDate.Text = "Pick Cut Off Date:";
            // 
            // dtpMassNAMICutOffDate
            // 
            this.dtpMassNAMICutOffDate.Location = new System.Drawing.Point(97, 19);
            this.dtpMassNAMICutOffDate.Name = "dtpMassNAMICutOffDate";
            this.dtpMassNAMICutOffDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMassNAMICutOffDate.TabIndex = 1;
            // 
            // btnMassNAMIGenerateReport
            // 
            this.btnMassNAMIGenerateReport.Location = new System.Drawing.Point(303, 16);
            this.btnMassNAMIGenerateReport.Name = "btnMassNAMIGenerateReport";
            this.btnMassNAMIGenerateReport.Size = new System.Drawing.Size(113, 23);
            this.btnMassNAMIGenerateReport.TabIndex = 2;
            this.btnMassNAMIGenerateReport.Text = "Generate Report";
            this.btnMassNAMIGenerateReport.UseVisualStyleBackColor = true;
            this.btnMassNAMIGenerateReport.Click += new System.EventHandler(this.btnMassNAMIGenerateReport_Click);
            // 
            // grpMassNAMIReportParameters
            // 
            this.grpMassNAMIReportParameters.Controls.Add(this.lblMassNAMIPickCutOffDate);
            this.grpMassNAMIReportParameters.Controls.Add(this.btnMassNAMIGenerateReport);
            this.grpMassNAMIReportParameters.Controls.Add(this.dtpMassNAMICutOffDate);
            this.grpMassNAMIReportParameters.Location = new System.Drawing.Point(12, 12);
            this.grpMassNAMIReportParameters.Name = "grpMassNAMIReportParameters";
            this.grpMassNAMIReportParameters.Size = new System.Drawing.Size(422, 49);
            this.grpMassNAMIReportParameters.TabIndex = 8;
            this.grpMassNAMIReportParameters.TabStop = false;
            this.grpMassNAMIReportParameters.Text = "Report Parameters";
            // 
            // grpMassNAMIShortExport
            // 
            this.grpMassNAMIShortExport.Location = new System.Drawing.Point(440, 12);
            this.grpMassNAMIShortExport.Name = "grpMassNAMIShortExport";
            this.grpMassNAMIShortExport.Size = new System.Drawing.Size(282, 49);
            this.grpMassNAMIShortExport.TabIndex = 9;
            this.grpMassNAMIShortExport.TabStop = false;
            this.grpMassNAMIShortExport.Text = "Short Export";
            // 
            // grpMassNAMIReportProgress
            // 
            this.grpMassNAMIReportProgress.Location = new System.Drawing.Point(12, 67);
            this.grpMassNAMIReportProgress.Name = "grpMassNAMIReportProgress";
            this.grpMassNAMIReportProgress.Size = new System.Drawing.Size(710, 54);
            this.grpMassNAMIReportProgress.TabIndex = 10;
            this.grpMassNAMIReportProgress.TabStop = false;
            this.grpMassNAMIReportProgress.Text = "Report Progress";IPickCutOffDate.Name = "lblMassNAMIPickCutOffDate";
            this.lblMassNAMIPickCutOffDate.Size = new System.Drawing.Size(106, 13);
            this.lblMassNAMIPickCutOffDate.TabIndex = 3;
            this.lblMassNAMIPickCutOffDate.Text = "Pick the cut off date:";
            // 
            // dateMassNAMICutOffTimePicker
            // 
            this.dateMassNAMICutOffTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMassNAMICutOffTimePicker.Location = new System.Drawing.Point(127, 17);
            this.dateMassNAMICutOffTimePicker.Name = "dateMassNAMICutOffTimePicker";
            this.dateMassNAMICutOffTimePicker.Size = new System.Drawing.Size(81, 20);
            this.dateMassNAMICutOffTimePicker.TabIndex = 2;
            // 
            // grpMassNAMIReportParameters
            // 
            this.grpMassNAMIReportParameters.Controls.Add(this.btnMassNAMIBuildReport);
            this.grpMassNAMIReportParameters.Controls.Add(this.lblMassNAMIPickCutOffDate);
            this.grpMassNAMIReportParameters.Controls.Add(this.dateMassNAMICutOffTimePicker);
            this.grpMassNAMIReportParameters.Location = new System.Drawing.Point(12, 7);
            this.grpMassNAMIReportParameters.Name = "grpMassNAMIReportParameters";
            this.grpMassNAMIReportParameters.Size = new System.Drawing.Size(369, 48);
            this.grpMassNAMIReportParameters.TabIndex = 5;
            this.grpMassNAMIReportParameters.TabStop = false;
            this.grpMassNAMIReportParameters.Text = "Inquiry parameters";
            // 
            // btnMassNAMIBuildReport
            // 
            this.btnMassNAMIBuildReport.Location = new System.Drawing.Point(233, 12);
            this.btnMassNAMIBuildReport.Name = "btnMassNAMIBuildReport";
            this.btnMassNAMIBuildReport.Size = new System.Drawing.Size(105, 25);
            this.btnMassNAMIBuildReport.TabIndex = 4;
            this.btnMassNAMIBuildReport.Text = "Build Report";
            this.btnMassNAMIBuildReport.UseVisualStyleBackColor = true;
            this.btnMassNAMIBuildReport.Click += new System.EventHandler(this.BtnMassNAMISubmit_Click);
            // 
            // grpMassNAMIShortExport
            // 
            this.grpMassNAMIShortExport.Controls.Add(this.btnMassNAMIShortReportToCSV);
            this.grpMassNAMIShortExport.Controls.Add(this.btnMassNAMIShortReportToExcel);
            this.grpMassNAMIShortExport.Location = new System.Drawing.Point(490, 7);
            this.grpMassNAMIShortExport.Name = "grpMassNAMIShortExport";
            this.grpMassNAMIShortExport.Size = new System.Drawing.Size(233, 63);
            this.grpMassNAMIShortExport.TabIndex = 9;
            this.grpMassNAMIShortExport.TabStop = false;
            this.grpMassNAMIShortExport.Text = "Export report";
            // 
            // btnMassNAMIShortReportToCSV
            // 
            this.btnMassNAMIShortReportToCSV.Enabled = false;
            this.btnMassNAMIShortReportToCSV.Location = new System.Drawing.Point(121, 23);
            this.btnMassNAMIShortReportToCSV.Name = "btnMassNAMIShortReportToCSV";
            this.btnMassNAMIShortReportToCSV.Size = new System.Drawing.Size(105, 25);
            this.btnMassNAMIShortReportToCSV.TabIndex = 1;
            this.btnMassNAMIShortReportToCSV.Text = "To CSV";
            this.btnMassNAMIShortReportToCSV.UseVisualStyleBackColor = true;
            this.btnMassNAMIShortReportToCSV.Click += new System.EventHandler(this.BtnShortMassNAMIReportExportToCSV_Click);
            // 
            // btnMassNAMIShortReportToExcel
            this.btnMassNAMIShortReportToExcel.Enabled = false;
            this.btnMassNAMIShortReportToExcel.Location = new System.Drawing.Point(7, 23);
            this.btnMassNAMIShortReportToExcel.Name = "btnMassNAMIShortReportToExcel";
            this.btnMassNAMIShortReportToExcel.Size = netem.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundMassNAMICalculation_RunWorkerCompleted);
            // 
            // MassNAMIReportExportToExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 140);
            this.Controls.Add(this.grpMassNAMIReportProgress);
            this.Controls.Add(this.btnMassNAMIShortReportToExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MassNAMIReportExportToExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mass NAMI Report Export To Excel";
            this.grpMassNAMIReportProgress.ResumeLayout(false);
            this.ResumeLayout(false);        private System.Windows.Forms.GroupBox grpMassNAMIReportParameters;
        private System.Windows.Forms.GroupBox grpMassNAMIShortExport;
        private System.Windows.Forms.GroupBox grpMassNAMIReportProgress;
        private System.Windows.Forms.Label lblMassNAMIPickCutOffDate;
        private System.Windows.Forms.DateTimePicker dateMassNAMICutOffTimePicker;

        public MassNAMIReportForm()
        {
            InitializeComponent();
        }

        private void BackgroundMassNAMICalculation_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // Code for handling background worker completion
        }

        private void OnMassNAMIReportFormLoad(object sender, System.EventArgs e)
        {
            // Code to execute when the form loads
        }em.Windows.Forms.GroupBox grpReportParameters;
        private System.Windows.Forms.Button btnBuildReport;
        private System.Windows.Forms.GroupBox grpShortExport;
        private System.Windows.Forms.Button btnShortReportToCSV;
        private System.Windows.Forms.Button btnShortReportToExcel;
        private System.Windows.Forms.GroupBox grpReportProgress;
        private System.Windows.Forms.ProgressBar barReportProgress;
        private System.ComponentModel.BackgroundWorker backgroundCalculation;
    }
}