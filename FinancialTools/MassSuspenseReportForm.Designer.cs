ce(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataMassSuspense)).BeginInit();
            this.grpMassSuspenseShortExport.SuspendLayout();
            this.grpMassSuspenseReportProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMassSuspense
            // 
            this.dataMassSuspense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMassSuspense.Location = new System.Drawing.Point(12, 12);
            this.dataMassSuspense.Name = "dataMassSuspense";
            this.dataMassSuspense.Size = new System.Drawing.Size(776, 300);
            this.dataMassSuspense.TabIndex = 0;
            // 
            // grpMassSuspenseShortExport
            // 
            this.grpMassSuspenseShortExport.Controls.Add(this.btnMassSuspenseShortReportToCSV);
            this.grpMassSuspenseShortExport.Controls.Add(this.btnMassSuspenseShortReportToExcel);
            this.grpMassSuspenseShortExport.Location = new System.Drawing.Point(12, 318);
            this.grpMassSuspenseShortExport.Name = "grpMassSuspenseShortExport";
            this.grpMassSuspenseShortExport.Size = new System.Drawing.Size(776, 100);
            this.grpMassSuspenseShortExport.TabIndex = 1;
            this.grpMassSuspenseShortExport.TabStop = false;
            this.grpMassSuspenseShortExport.Text = "Export Mass Suspense Report";
            // 
            // btnMassSuspenseShortReportToCSV
            // 
            this.btnMassSuspenseShortReportToCSV.Location = new System.Drawing.Point(120, 40);
            this.btnMassSuspenseShortReportToCSV.Name = "btnMassSuspenseShortReportToCSV";
            this.btnMassSuspenseShortReportToCSV.Size = new System.Drawing.Size(120, 40);
            this.btnMassSuspenseShortReportToCSV.TabIndex = 1;
            this.btnMassSuspenseShortReportToCSV.Text = "Export to CSV";
            this.btnMassSuspenseShortReportToCSV.UseVisualStyleBackColor = true;
            // 
            // btnMassSuspenseShortReportToExcel
            // 
            this.btnMassSuspenseShortReportToExcel.Location = new System.Drawing.Point(400, 40);
            this.btnMassSuspenseShortReportToExcel.Name = "btnMassSuspenseShortReportToExcel";
            this.btnMassSuspenseShortReportToExcel.Size = new System.Drawing.Size(120, 40);
            this.btnMassSuspenseShortReportToExcel.TabIndex = 2;
            this.btnMassSuspenseShortReportToExcel.Text = "Export to Excel";
            this.btnMassSuspenseShortReportToExcel.UseVisualStyleBackColor = true;
            // 
            // grpMassSuspenseReportProgress
            // 
            this.grpMassSuspenseReportProgress.Controls.Add(this.barMassSuspenseReportProgress);
            this.grpMassSuspenseReportProgress.Location = new System.Drawing.Point(12, 424);
            this.grpMassSuspenseReportProgress.Name = "grpMassSuspenseReportProgress";
            this.grpMassSuspenseReportProgress.Size = new System.Drawing.Size(776, 50);
            this.grpMassSuspenseReportProgress.TabIndex = 2;
            this.grpMassSuspenseReportProgress.TabStop = false;
            this.grpMassSuspenseReportProgress.Text = "Report Generation Progress";
            // 
            // barMassSuspenseReportProgress
            // 
            this.barMassSuspenseReportProgress.Location = new System.Drawing.Point(120, 20);
            this.barMassSuspenseReportProgress.Name = "barMassSuspenseReportProgress";
            this.barMassSuspenseReportProgress.Size = new System.Drawing.Size(560, 10);
            this.barMassSuspenseReportProgress.TabIndex = 0;
            // 
            // backgroundMassSuspenseCalculation
            // 
            this.backgroundMassSuspenseCalculation.WorkerReportsProgress = true;
            this.backgroundMassSuspenseCalculation.WorkerSupportsCancellation = true;
            this.backgroundMassSuspenseCalculation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundMassSuspenseCalculation_DoWork);
            this.backgroundMassSuspenseCalculation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundMassSuspenseCalculation_ProgressChanged);
            this.backgroundMassSuspenseCalculation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundMassSuspenseCalculation_RunWorkerCompleted);
            // 
            // MassSuspenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.grpMassSuspenseReportProgress);
            this.Controls.Add(this.grpMassSuspenseShortExport);
            this.Controls.Add(this.dataMassSuspense);
            this.Name = "MassSuspenseReportForm";
            this.Text = "Mass Suspense Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataMassSuspense)).EndInit();
            this.grpMassSuspenseShortExport.ResumeLayout(false);
            this.grpMassSuspenseReportProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMassSuspense;
        private System.Windows.Forms.GroupBox grpMassSuspenseShortExport;
        private System.Windows.Forms.Button btnMassSuspenseShortReportToCSV;
        private System.Windows.Forms.Button btnMassSuspenseShortReportToExcel;
        private System.Windows.Forms.GroupBox grpMassSuspenseReportProgress;
        private System.Windows.Forms.ProgressBar barMassSuspenseReportProgress;
        private System.ComponentModel.BackgroundWorker backgroundMassSuspenseCalculation;
        private System.Windows.Forms.BindingSource subscriberBindingSource;
        private System.Windows.Forms.BindingSource subscriberBindingSource1;
        private System.Windows.Forms.BindingSource subscriberBindingSource2;
    }
}t.Location = new System.Drawing.Point(12, 12);
            this.grpMassSuspenseShortExport.Name = "grpMassSuspenseShortExport";
            this.grpMassSuspenseShortExport.Size = new System.Drawing.Size(710, 109);
            this.grpMassSuspenseShortExport.TabIndex = 8;
            this.grpMassSuspenseShortExport.TabStop = false;
            this.grpMassSuspenseShortExport.Text = "Export Short Report";
            // 
            // btnMassSuspenseShortReportToCSV
            // 
            this.btnMassSuspenseShortReportToCSV.Location = new System.Drawing.Point(111, 48);
            this.btnMassSuspenseShortReportToCSV.Name = "btnMassSuspenseShortReportToCSV";
            this.btnMassSuspenseShortReportToCSV.Size = new System.Drawing.Size(75, 23);
            this.btnMassSuspenseShortReportToCSV.TabIndex = 1;
            this.btnMassSuspenseShortReportToCSV.Text = "To CSV";
            this.btnMassSuspenseShortReportToCSV.UseVisualStyleBackColor = true;
            // 
            // btnMassSuspenseShortReportToExcel
            // 
            this.btnMassSuspenseShortReportToExcel.Location = new System.Drawing.Point(6, 48);
            this.btnMassSuspenseShortReportToExcel.Name = "btnMassSuspenseShortReportToExcel";
            this.btnMassSuspenseShortReportToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnMassSuspenseShortReportToExcel.TabIndex = 0;
            this.btnMassSuspenseShortReportToExcel.Text = "To Excel";
            this.btnMassSuspenseShortReportToExcel.UseVisualStyleBackColor = true;
            // 
            // grpMassSuspenseReportProgress
            // 
            this.grpMassSuspenseReportProgress.Controls.Add(this.progMassSuspenseReport);
            this.grpMassSuspenseReportProgress.Location = new System.Drawing.Point(12, 48);
            this.grpMassSuspenseReportProgress.Name = "grpMassSuspenseReportProgress";
            this.grpMassSuspenseReportProgress.Size = new System.Drawing.Size(710, 53);
            this.grpMassSuspenseReportProgress.TabIndex = 9;
            this.grpMassSuspenseReportProgress.TabStop = false;
            this.grpMassSuspenseReportProgress.Text = "Report Progress";
            // 
            // progMassSuspenseReport
            // 
            this.progMassSuspenseReport.Location = new System.Drawing.Point(6, 19);
            this.progMassSuspenseReport.Name = "progMassSuspenseReport";
            this.progMassSuspenseReport.Size = new System.Drawing.Size(698, 23);
            this.progMassSuspenseReport.TabIndex = 0;
            // 
            // MassSuspenseBuildReport
            // 
            this.btnMassSuspenseBuildReport.Location = new System.Drawing.Point(12, 12);
            this.btnMassSuspenseBuildReport.Name = "btnMassSuspenseBuildReport";
            this.btnMassSuspenseBuildReport.Size = new System.Drawing.Size(75, 23);
            this.btnMassSuspenseBuildReport.TabIndex = 10;
            this.btnMassSuspenseBuildReport.Text = "Build Report";
            this.btnMassSuspenseBuildReport.UseVisualStyleBackColor = true;
            this.btnMassSuspenseBuildReport.Click += new System.EventHandler(this.btnMassSuspenseBuildReport_Click);
            // 
            // grpMassSuspenseReportParameters
            // 
            this.grpMassSuspenseReportParameters.Controls.Add(this.btnMassSuspenseReportParameters);
            this.grpMassSuspenseReportParameters.Location = new System.Drawing.Point(93, 12);
            this.grpMassSuspenseReportParameters.Name = "grpMassSuspenseReportParameters";
            this.grpMassSuspenseReportParameters.Size = new System.Drawing.Size(629, 30);
            this.grpMassSuspenseReportParameters.TabIndex = 11;
            this.grpMassSuspenseReportParameters.TabStop = false;
            this.grpMassSuspenseReportParameters.Text = "Report Parameters";
            // 
            // btnMassSuspenseReportParameters
            // 
            this.btnMassSuspenseReportParameters.Location = new System.Drawing.Point(6, 10);
            this.btnMassSuspenseReportParameters.Name = "btnMassSuspenseReportParameters";
            this.btnMassSuspenseReportParameters.Size = new System.Drawing.Size(75, 23);
            this.btnMassSuspenseReportParameters.TabIndex = 0;
            this.btnMassSuspenseReportParameters.Text = "Parameters";
            this.btnMassSuspenseReportParameters.UseVisualStyleBackColor = true;t.Location = new System.Drawing.Point(490, 7);
            this.grpMassSuspenseShortExport.Name = "grpMassSuspenseShortExport";
            this.grpMassSuspenseShortExport.Size = new System.Drawing.Size(233, 48);
            this.grpMassSuspenseShortExport.TabIndex = 9;
            this.grpMassSuspenseShortExport.TabStop = false;
            this.grpMassSuspenseShortExport.Text = "Export report";
            // 
            // btnMassSuspenseShortReportToCSV
            // 
            this.btnMassSuspenseShortReportToCSV.Enabled = false;
            this.btnMassSuspenseShortReportToCSV.Location = new System.Drawing.Point(121, 19);
            this.btnMassSuspenseShortReportToCSV.Name = "btnMassSuspenseShortReportToCSV";
            this.btnMassSuspenseShortReportToCSV.Size = new System.Drawing.Size(105, 25);
            this.btnMassSuspenseShortReportToCSV.TabIndex = 1;
            this.btnMassSuspenseShortReportToCSV.Text = "To CSV";
            this.btnMassSuspenseShortReportToCSV.UseVisualStyleBackColor = true;
            this.btnMassSuspenseShortReportToCSV.Click += new System.EventHandler(this.BtnShortMassSuspenseReportExportToCSV_Click);
            // 
            // btnMassSuspenseShortReportToExcel
            // 
            this.btnMassSuspenseShortReportToExcel.Enabled = false;
            this.btnMassSuspenseShortReportToExcel.Location = new System.Drawing.Point(6, 19);
            this.btnMassSuspenseShortReportToExcel.Name = "btnMassSuspenseShortReportToExcel";
            this.btnMassSuspenseShortReportToExcel.Size = new System.Drawing.Size(105, 25);
            this.btnMassSuspenseShortReportToExcel.TabIndex = 0;
            this.btnMassSuspenseShortReportToExcel.Text = "To Excel";
            this.btnMassSuspenseShortReportToExcel.UseVisualStyleBackColor = true;
            this.btnMassSuspenseShortReportToExcel.Click += new System.EventHandler(this.BtnShortMassSuspenseReportExportToExcel_Click);assSuspenseBuildReport.Name = "btnMassSuspenseBuildReport";
            this.btnMassSuspenseBuildReport.Size = new System.Drawing.Size(75, 23);
            this.btnMassSuspenseBuildReport.TabIndex = 0;
            this.btnMassSuspenseBuildReport.Text = "Build Report";
            this.btnMassSuspenseBuildReport.UseVisualStyleBackColor = true;
            this.btnMassSuspenseBuildReport.Click += new System.EventHandler(this.BtnMassSuspenseBuildReport_Click);
            // 
            // grpMassSuspenseReportOptions
            // 
            this.grpMassSuspenseReportOptions.Controls.Add(this.btnMassSuspenseBuildReport);
            this.grpMassSuspenseReportOptions.Location = new System.Drawing.Point(12, 127);
            this.grpMassSuspenseReportOptions.Name = "grpMassSuspenseReportOptions";
            this.grpMassSuspenseReportOptions.Size = new System.Drawing.Size(711, 60);
            this.grpMassSuspenseReportOptions.TabIndex = 12;
            this.grpMassSuspenseReportOptions.TabStop = false;
            this.grpMassSuspenseReportOptions.Text = "Options";assSuspenseBuildReport.Name = "btnMassSuspenseBuildReport";
            this.btnMassSuspenseBuildReport.Size = new System.Drawing.Size(105, 25);
            this.btnMassSuspenseBuildReport.TabIndex = 4;
            this.btnMassSuspenseBuildReport.Text = "Build Reporta";
            this.btnMassSuspenseBuildReport.UseVisualStyleBackColor = true;
            this.btnMassSuspenseBuildReport.Click += new System.EventHandler(this.BtnMassSuspenseSubmit_Click);
            // 
            // grpMassSuspenseReportParameters
            // 
            this.grpMassSuspenseReportParameters.Controls.Add(this.btnMassSuspenseBuildReport);
            this.grpMassSuspenseReportParameters.Location = new System.Drawing.Point(12, 7);
            this.grpMassSuspenseReportParameters.Name = "grpMassSuspenseReportParameters";
            this.grpMassSuspenseReportParameters.Size = new System.Drawing.Size(120, 48);
            this.grpMassSuspenseReportParameters.TabIndex = 5;
            this.grpMassSuspenseReportParameters.TabStop = false;
            this.grpMassSuspenseReportParameters.Text = "Run";
            // 
            // MassSuspenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.grpMassSuspenseReportProgress);
            this.Controls.Add(this.grpMassSuspenseShortExport);
            this.Controls.Add(this.dataMassSuspense);
            this.Controls.Add(this.grpMassSuspenseReportParameters);
            this.Name = "MassSuspenseReportForm";
            this.Text = "Mass Suspense Report";
            this.Load += new System.EventHandler(this.OnMassSuspenseReportFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataMassSuspense)).EndInit();
            this.grpMassSuspenseShortExport.ResumeLayout(fa
lse);
            this.grpMassSuspenseReportProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).EndInit();
            this.grpMassSuspenseReportParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource subscriberBindingSource2;
        private System.Windows.Forms.BindingSource subscriberBindingSource;
        private System.Windows.Forms.DataGridView dataMassSuspense;
        private System.Windows.Forms.BindingSource subscriberBindingSource1;
        private System.Windows.Forms.GroupBox grpMassSuspenseShortExport;
        private System.Windows.Forms.Button btnMassSuspenseShortReportToCSV;
        private System.Windows.Forms.Button btnMassSuspenseShortReportToExcel;
        private System.Windows.Forms.GroupBox grpMassSuspenseReportProgress;
        private System.Windows.Forms.ProgressBar barMassSuspenseReportProgress;
        private System.ComponentModel.BackgroundWorker backgroundMassSuspenseCalculation;
        private System.Windows.Forms.Button btnMassSuspenseBuildReport;
        private System.Windows.Forms.GroupBox grpMassSuspenseReportParameters;
    }
}