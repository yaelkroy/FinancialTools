MassDBIPickCutOffDate";
            this.lblMassDBIPickCutOffDate.Size = new System.Drawing.Size(112, 13);
            this.lblMassDBIPickCutOffDate.TabIndex = 0;
            this.lblMassDBIPickCutOffDate.Text = "Pick Cut-Off Date:";
            // 
            // dtpMassDBICutOffDate
            // 
            this.dtpMassDBICutOffDate.Location = new System.Drawing.Point(124, 19);
            this.dtpMassDBICutOffDate.Name = "dtpMassDBICutOffDate";
            this.dtpMassDBICutOffDate.Size = new System.Drawing.Size(200, 20);
            this.dtpMassDBICutOffDate.TabIndex = 1;
            // 
            // btnMassDBIExport
            // 
            this.btnMassDBIExport.Location = new System.Drawing.Point(330, 16);
            this.btnMassDBIExport.Name = "btnMassDBIExport";
            this.btnMassDBIExport.Size = new System.Drawing.Size(75, 23);
            this.btnMassDBIExport.TabIndex = 2;
            this.btnMassDBIExport.Text = "Export";
            this.btnMassDBIExport.UseVisualStyleBackColor = true;
            this.btnMassDBIExport.Click += new System.EventHandler(this.btnMassDBIExport_Click);
            // 
            // grpMassDBIReportParameters
            // 
            this.grpMassDBIReportParameters.Controls.Add(this.lblMassDBIPickCutOffDate);
            this.grpMassDBIReportParameters.Controls.Add(this.dtpMassDBICutOffDate);
            this.grpMassDBIReportParameters.Controls.Add(this.btnMassDBIExport);
            this.grpMassDBIReportParameters.Location = new System.Drawing.Point(12, 12);
            this.grpMassDBIReportParameters.Name = "grpMassDBIReportParameters";
            this.grpMassDBIReportParameters.Size = new System.Drawing.Size(411, 51);
            this.grpMassDBIReportParameters.TabIndex = 8;
            this.grpMassDBIReportParameters.TabStop = false;
            this.grpMassDBIReportParameters.Text = "Report Parameters";
            // 
            // grpMassDBIShortExport
            // 
            this.grpMassDBIShortExport.Location = new System.Drawing.Point(12, 69);
            this.grpMassDBIShortExport.Name = "grpMassDBIShortExport";
            this.grpMassDBIShortExport.Size = new System.Drawing.Size(411, 52);
            this.grpMassDBIShortExport.TabIndex = 9;
            this.grpMassDBIShortExport.TabStop = false;
            this.grpMassDBIShortExport.Text = "Short Export";
            // 
            // grpMassDBIReportProgress
            // 
            this.grpMassDBIReportProgress.Controls.Add(this.progressBarMassDBI);
            this.grpMassDBIReportProgress.Location = new System.Drawing.Point(12, 127);
            this.grpMassDBIReportProgress.Name = "grpMassDBIReportProgress";
            this.grpMassDBIReportProgress.Size = new System.Drawing.Size(411, 52);
            this.grpMassDBIReportProgress.TabIndex = 10;
            this.grpMassDBIReportProgress.TabStop = false;
            this.grpMassDBIReportProgress.Text = "Report Progress";
            // 
            // progressBarMassDBI
            // 
            this.progressBarMassDBI.Location = new System.Drawing.Point(6, 19);
            this.progressBarMassDBI.Name = "progressBarMassDBI";
            this.progressBarMassDBI.Size = new System.Drawing.Size(399, 23);
            this.progressBarMassDBI.TabIndex = 0;
            // 
            // MassDBIReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.grpMassDBIReportProgress);
            this.Controls.Add(this.grpMassDBIShortExport);
            this.Controls.Add(this.grpMassDBIReportParameters);
            this.Controls.Add(this.dataMassDBI);
            this.Name = "MassDBIReport";
            this.Text = "MassDBIReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataMassDBI)).EndInit();
            this.grpMassDBIReportParameters.ResumeLayout(false);
            this.grpMassDBIReportParameters.PerformLayout();
            this.grpMassDBIShortExport.ResumeLayout(false);
            this.grpMassDBIReportProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).EndInit();
            this.ResumeLayout(false);Report.Click += new System.EventHandler(this.btnMassDBIBuildReport_Click);
            // 
            // MassDBIReportParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 67);
            this.Controls.Add(this.grpMassDBIReportParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MassDBIReportParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mass DBI Report Parameters";
            this.grpMassDBIReportParameters.ResumeLayout(false);
            this.grpMassDBIReportParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMassDBIPickCutOffDate;
        private System.Windows.Forms.DateTimePicker dateMassDBICutOffTimePicker;
        private System.Windows.Forms.GroupBox grpMassDBIReportParameters;
        private System.Windows.Forms.Button btnMassDBIBuildReport;
    }
}BuildReport.UseVisualStyleBackColor = true;
            this.btnMassDBIBuildReport.Click += new System.EventHandler(this.BtnMassDBISubmit_Click);
            
            // grpMassDBIShortExport
            // 
            this.grpMassDBIShortExport.Controls.Add(this.btnMassDBIShortReportToCSV);
            this.grpMassDBIShortExport.Controls.Add(this.btnMassDBIShortReportToExcel);
            this.grpMassDBIShortExport.Location = new System.Drawing.Point(490, 7);
            this.grpMassDBIShortExport.Name = "grpMassDBIShortExport";
            this.grpMassDBIShortExport.Size = new System.Drawing.Size(233, 63);
            this.grpMassDBIShortExport.TabIndex = 9;
            this.grpMassDBIShortExport.TabStop = false;
            this.grpMassDBIShortExport.Text = "Export report";
            
            // btnMassDBIShortReportToCSV
            // 
            this.btnMassDBIShortReportToCSV.Enabled = false;
            this.btnMassDBIShortReportToCSV.Location = new System.Drawing.Point(121, 23);
            this.btnMassDBIShortReportToCSV.Name = "btnMassDBIShortReportToCSV";
            this.btnMassDBIShortReportToCSV.Size = new System.Drawing.Size(105, 25);
            this.btnMassDBIShortReportToCSV.TabIndex = 1;
            this.btnMassDBIShortReportToCSV.Text = "To CSV";
            this.btnMassDBIShortReportToCSV.UseVisualStyleBackColor = true;
            this.btnMassDBIShortReportToCSV.Click += new System.EventHandler(this.BtnShortMassDBIReportExportToCSV_Click);
            
            // btnMassDBIShortReportToExcel
            // 
            this.btnMassDBIShortReportToExcel.Enabled = false;
            this.btnMassDBIShortReportToExcel.Location = new System.Drawing.Point(7, 23);
            this.btnMassDBIShortReportToExcel.Name = "btnMassDBIShortReportToExcel";
            this.btnMassDBIShortReportToExcel.Size = new System.Drawing.Size(105, 25);
            this.btnMassDBIShortReportToExcel.TabIndex = 0;          this.btnMassDBIShortReportToExcel.Text = "To Excel";
            this.btnMassDBIShortReportToExcel.UseVisualStyleBackColor = true;
            this.btnMassDBIShortReportToExcel.Click += new System.EventHandler(this.BtnShortMassDBIReportExportToExcel_Click);
            // 
            // grpMassDBIReportProgress
            // 
            this.grpMassDBIReportProgress.Controls.Add(this.barMassDBIReportProgress);
            this.grpMassDBIReportProgress.Location = new System.Drawing.Point(12, 61);
            this.grpMassDBIReportProgress.Name = "grpMassDBIReportProgress";
            this.grpMassDBIReportProgress.Size = new System.Drawing.Size(711, 60);
            this.grpMassDBIReportProgress.TabIndex = 11;
            this.grpMassDBIReportProgress.TabStop = false;
            this.grpMassDBIReportProgress.Text = "Progress";
            // 
            // barMassDBIReportProgress
            // 
            this.barMassDBIReportProgress.Location = new System.Drawing.Point(9, 19);
            this.barMassDBIReportProgress.Name = "barMassDBIReportProgress";
            this.barMassDBIReportProgress.Size = new System.Drawing.Size(695, 35);
            this.barMassDBIReportProgress.TabIndex = 0;
            // 
            // backgroundMassDBICalculation
            // 
            this.backgroundMassDBICalculation.WorkerReportsProgress = true;
            this.backgroundMassDBICalculation.WorkerSupportsCancellation = true;
            this.backgroundMassDBICalculation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundMassDBICalculation_DoWork);
            this.backgroundMassDBICalculation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundMassDBICalculation_ProgressChanged);
            this.backgroundMassDBICalculation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundMassDBICalculation_RunWorkerCompleted);
            //// MassDBIReportForm
// 
this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
this.ClientSize = new System.Drawing.Size(734, 511);
this.Controls.Add(this.grpMassDBIReportProgress);
this.Controls.Add(this.grpMassDBIShortExport);
this.Controls.Add(this.dataMassDBI);
this.Controls.Add(this.grpMassDBIReportParameters);
this.Name = "MassDBIReportForm";
this.Text = "Mass DBI Report";
this.Load += new System.EventHandler(this.OnMassDBIReportFormLoad);
((System.ComponentModel.ISupportInitialize)(this.dataMassDBI)).EndInit();
this.grpMassDBIReportParameters.ResumeLayout(false);
this.grpMassDBIReportParameters.PerformLayout();
this.grpMassDBIShortExport.ResumeLayout(false);
this.grpMassDBIReportProgress.ResumeLayout(false);
((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).EndInit();
this.ResumeLayout(false);
}

#endregion

private System.Windows.Forms.BindingSource subscriberBindingSource2;
private System.Windows.Forms.BindingSource subscriberBindingSource;
private System.Windows.Forms.DataGridView dataMassDBI;
private System.Windows.Forms.BindingSource subscriberBindingSource1;
private System.Windows.Forms.Label lblMassDBIPickCutOffDate;
private System.Windows.Forms.DateTimePicker dateMassDBICutOffTimePicker;
private System.Windows.Forms.GroupBox grpMassDBIReportParameters;
private System.Windows.Forms.Button btnMassDBIBuildReport;
private SysSystem.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.Button btnReportToCSV;
        private System.Windows.Forms.Button btnReportToExcel;
        private System.Windows.Forms.GroupBox grpReportProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundCalculation;
    }
}