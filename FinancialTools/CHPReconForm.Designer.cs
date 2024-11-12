System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCHPRecon)).BeginInit();
            this.grpCHPReconReportParameters.SuspendLayout();
            this.grpCHPReconReportProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCHPRecon
            // 
            this.dataCHPRecon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCHPRecon.Location = new System.Drawing.Point(12, 12);
            this.dataCHPRecon.Name = "dataCHPRecon";
            this.dataCHPRecon.Size = new System.Drawing.Size(776, 200);
            this.dataCHPRecon.TabIndex = 0;
            // 
            // lblCHPReconPickCutOffDate
            // 
            this.lblCHPReconPickCutOffDate.AutoSize = true;
            this.lblCHPReconPickCutOffDate.Location = new System.Drawing.Point(12, 215);
            this.lblCHPReconPickCutOffDate.Name = "lblCHPReconPickCutOffDate";
            this.lblCHPReconPickCutOffDate.Size = new System.Drawing.Size(95, 13);
            this.lblCHPReconPickCutOffDate.TabIndex = 1;
            this.lblCHPReconPickCutOffDate.Text = "Pick Cut-Off Date:";
            // 
            // grpCHPReconReportParameters
            // 
            this.grpCHPReconReportParameters.Controls.Add(this.btnCHPReconBuildReport);
            this.grpCHPReconReportParameters.Location = new System.Drawing.Point(12, 241);
            this.grpCHPReconReportParameters.Name = "grpCHPReconReportParameters";
            this.grpCHPReconReportParameters.Size = new System.Drawing.Size(776, 100);
            this.grpCHPReconReportParameters.TabIndex = 2;
            this.grpCHPReconReportParameters.TabStop = false;
            this.grpCHPReconReportParameters.Text = "Report Parameters";
            // 
            // btnCHPReconBuildReport
            // 
            this.btnCHPReconBuildReport.Location = new System.Drawing.Point(6, 19);
            this.btnCHPReconBuildReport.Name = "btnCHPReconBuildReport";
            this.btnCHPReconBuildReport.Size = new System.Drawing.Size(75, 23);
            this.btnCHPReconBuildReport.TabIndex = 0;
            this.btnCHPReconBuildReport.Text = "Build Report";
            this.btnCHPReconBuildReport.UseVisualStyleBackColor = true;
            // 
            // grpCHPReconReportProgress
            // 
            this.grpCHPReconReportProgress.Controls.Add(this.barCHPReconReportProgress);
            this.grpCHPReconReportProgress.Location = new System.Drawing.Point(12, 347);
            this.grpCHPReconReportProgress.Name = "grpCHPReconReportProgress";
            this.grpCHPReconReportProgress.Size = new System.Drawing.Size(776, 100);
            this.grpCHPReconReportProgress.TabIndex = 3;
            this.grpCHPReconReportProgress.TabStop = false;
            this.grpCHPReconReportProgress.Text = "Report Progress";
            // 
            // barCHPReconReportProgress
            // 
            this.barCHPReconReportProgress.Location = new System.Drawing.Point(6, 19);
            this.barCHPReconReportProgress.Name = "barCHPReconReportProgress";
            this.barCHPReconReportProgress.Size = new System.Drawing.Size(764, 23);
            this.barCHPReconReportProgress.TabIndex = 0;
            // 
            // backgroundCHPReconCalculation
            // 
            this.backgroundCHPReconCalculation.WorkerReportsProgress = true;
            this.backgroundCHPReconCalculation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundCHPReconCalculation_DoWork);
            this.backgroundCHPReconCalculation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundCHPReconCalculation_ProgressChanged);
            this.backgroundCHPReconCalculation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundCHPReconCalculation_RunWorkerCompleted);
            // 
            // subscriberBindingSource2
            // 
            this.subscriberBindingSource2.DataSource = typeof(FinancialTools.Subscriber);
            // 
            // subscriberBindingSource
            // 
            this.subscriberBindingSource.DataSource = typeof(FinancialTools.Subscriber);
            // 
            // subscriberBindingSource1
            // 
            this.subscriberBindingSource1.DataSource = typeof(FinancialTools.Subscriber);
            // 
            // btnCHPReconBuildReports
            // 
            this.btnCHPReconBuildReports.Location = new System.Drawing.Point(12, 453);
            this.btnCHPReconBuildReports.Name = "btnCHPReconBuildReports";
            this.btnCHPReconBuildReports.Size = new System.Drawing.Size(776, 23);
            this.btnCHPReconBuildReports.TabIndex = 4;
            this.btnCHPReconBuildReports.Text = "Build Reports";
            this.btnCHPReconBuildReports.UseVisualStyleBackColor = true;
            this.btnCHPReconBuildReports.Click += new System.EventHandler(this.btnCHPReconBuildReports_Click);
            // 
            // CHPReconReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnCHPReconBuildReports);
            this.Controls.Add(this.grpCHPReconReportProgress);
            this.Controls.Add(this.grpCHPReconReportParameters);
            this.Controls.Add(this.lblCHPReconPickCutOffDate);
            this.Controls.Add(this.dataCHPRecon);
            this.Name = "CHPReconReportForm";
            this.Text = "CHP Recon Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataCHPRecon)).EndInit();
            this.grpCHPReconReportParameters.ResumeLayout(false);
            this.grpCHPReconReportProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCHPRecon;
        private System.Windows.Forms.Label lblCHPReconPickCutOffDate;
        private System.Windows.Forms.GroupBox grpCHPReconReportParameters;
        private System.Windows.Forms.Button btnCHPReconBuildReport;
        private System.Windows.Forms.GroupBox grpCHPReconReportProgress;
        private System.Windows.Forms.ProgressBar barCHPReconReportProgress;
        private System.ComponentModel.BackgroundWorker backgroundCHPReconCalculation;
        private System.Windows.Forms.BindingSource subscriberBindingSource2;
        private System.Windows.Forms.BindingSource subscriberBindingSource;
        private System.Windows.Forms.BindingSource subscriberBindingSource1;
        private SystemSystem.Windows.Forms.Button();
            this.lstbxReconPickDate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecon)).BeginInit();
            this.grpReconReportParameters.SuspendLayout();
            this.grpReconReportProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRecon
            // 
            this.dataRecon.AllowUserToAddRows = false;
            this.dataRecon.AllowUserToDeleteRows = false;
            this.dataRecon.AllowUserToOrderColumns = true;
            this.dataRecon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRecon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataRecon.Location = new System.Drawing.Point(0, 130);
            this.dataRecon.Name = "dataRecon";
            this.dataRecon.Size = new System.Drawing.Size(734, 381);
            this.dataRecon.TabIndex = 7;
            // 
            // lblReconPickCutOffDate
            // 
            this.lblReconPickCutOffDate.AutoSize = true;
            this.lblReconPickCutOffDate.Location = new System.Drawing.Point(6, 23);
            this.lblReconPickCutOffDate.Name = "lblReconPickCutOffDate";
            this.lblReconPickCutOffDate.Size = new System.Drawing.Size(191, 13);
            this.lblReconPickCutOffDate.TabIndex = 3;
            this.lblReconPickCutOffDate.Text = "Pick a month and an";rtProgress.Text = "Report Progress";
            // 
            // barCHPReconReportProgress
            // 
            this.barCHPReconReportProgress.Location = new System.Drawing.Point(6, 19);
            this.barCHPReconReportProgress.Name = "barCHPReconReportProgress";
            this.barCHPReconReportProgress.Size = new System.Drawing.Size(700, 23);
            this.barCHPReconReportProgress.TabIndex = 0;
            // 
            // lstbxCHPReconPickDate
            // 
            this.lstbxCHPReconPickDate.FormattingEnabled = true;
            this.lstbxCHPReconPickDate.Location = new System.Drawing.Point(9, 20);
            this.lstbxCHPReconPickDate.Name = "lstbxCHPReconPickDate";
            this.lstbxCHPReconPickDate.Size = new System.Drawing.Size(121, 21);
            this.lstbxCHPReconPickDate.TabIndex = 0;
            // 
            // btnCHPReconBuildReports
            // 
            this.btnCHPReconBuildReports.Location = new System.Drawing.Point(120, 101);
            this.btnCHPReconBuildReports.Name = "btnCHPReconBuildReports";
            this.btnCHPReconBuildReports.Size = new System.Drawing.Size(105, 25);
            this.btnCHPReconBuildReports.TabIndex = 4;
            this.btnCHPReconBuildReports.Text = "Build Reports";
            this.btnCHPReconBuildReports.UseVisualStyleBackColor = true;rtProgress.Text = "Progress";
            // 
            // barCHPReconReportProgress
            // 
            this.barCHPReconReportProgress.Location = new System.Drawing.Point(9, 19);
            this.barCHPReconReportProgress.Name = "barCHPReconReportProgress";
            this.barCHPReconReportProgress.Size = new System.Drawing.Size(695, 35);
            this.barCHPReconReportProgress.TabIndex = 0;
            // 
            // backgroundCHPReconCalculation
            // 
            this.backgroundCHPReconCalculation.WorkerReportsProgress = true;
            this.backgroundCHPReconCalculation.WorkerSupportsCancellation = true;
            this.backgroundCHPReconCalculation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCHPReconCalculation_DoWork);
            this.backgroundCHPReconCalculation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundCHPReconCalculation_ProgressChanged);
            this.backgroundCHPReconCalculation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundCHPReconCalculation_RunWorkerCompleted);
            // 
            // btnCHPReconBuildReports
            // 
            this.btnCHPReconBuildReports.Location = new System.Drawing.Point(589, 18);
            this.btnCHPReconBuildReports.Name = "btnCHPReconBuildReports";
            this.btnCHPReconBuildReports.Size = new System.Drawing.Size(103, 23);
            this.btnCHPReconBuildReports.TabIndex = 5;
            this.btnCHPReconBuildReports.Text = "Build Reports";
            this.btnCHPReconBuildReports.UseVisualStyleBackColor = true;
            this.btnCHPReconBuildReports.Click += new System.EventHandler(this.btnCHPReconBuildReports_Click);
            // 
            // lstbxCHPReconPickDate
            // 
            this.lstbxCHPReconPickDate.FormattingEnabled = true;
            this.lstbxCHPReconPickDate.Location = new System.Drawing.oint(203, 20);
            this.lstbxCHPReconPickDate.Name = "lstbxCHPReconPickDate";
            this.lstbxCHPReconPickDate.Size = new System.Drawing.Size(379, 21);
            this.lstbxCHPReconPickDate.TabIndex = 6;
            // 
            // CHPReconReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.grpCHPReconReportProgress);
            this.Controls.Add(this.dataCHPRecon);
            this.Controls.Add(this.grpCHPReconReportParameters);
            this.Name = "CHPReconReportForm";
            this.Text = "CHP Recon Report";
            this.Load += new System.EventHandler(this.OnCHPReconReportFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataCHPRecon)).EndInit();
            this.grpCHPReconReportParameters.ResumeLayout(false);
            this.grpCHPReconReportParameters.PerformLayout();
            this.grpCHPReconReportProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource subscriberBindingSource2;
        private System.Windows.Forms.BindingSource subscriberBindingSource;
        private System.Windows.Forms.DataGridView dataCHPRecon;
        private System.Windows.Forms.BindingSource subscriberBindingSource1;
        private System.Windows.Forms.Label lblCHPReconPickCutOffDate;
        private System.Windows.Forms.GroupBox grpCHPReconReportParameters;
        private System.Windows.ms.Button btnBuildReport;
        private System.Windows.Forms.GroupBox grpReportProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundCalculation;
        private System.Windows.Forms.ComboBox lstbxPickDate;
        private System.Windows.Forms.Button btnBuildReports;
    }
}