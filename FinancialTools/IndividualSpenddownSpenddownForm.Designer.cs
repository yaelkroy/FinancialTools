            this.grpIndividualSpenddownReportParameters.SuspendLayout();
            this.grpIndividualSpenddownExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIndividualSpenddownSpenddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIndividualSpenddownReportParameters
            // 
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.lblIndividualSpenddownPickCutOffDate);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.dateIndividualSpenddownCutOffTimePicker);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.btnIndividualSpenddownSubmit);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.txtSubID);
            this.grpIndividualSpenddownReportParameters.Location = new System.Drawing.Point(12, 12);
            this.grpIndividualSpenddownReportParameters.Name = "grpIndividualSpenddownReportParameters";
            this.grpIndividualSpenddownReportParameters.Size = new System.Drawing.Size(776, 100);
            this.grpIndividualSpenddownReportParameters.TabIndex = 0;
            this.grpIndividualSpenddownReportParameters.TabStop = false;
            this.grpIndividualSpenddownReportParameters.Text = "Report Parameters";
            // 
            // lblIndividualSpenddownPickCutOffDate
            // 
            this.lblIndividualSpenddownPickCutOffDate.AutoSize = true;
            this.lblIndividualSpenddownPickCutOffDate.Location = new System.Drawing.Point(6, 31);
            this.lblIndividualSpenddownPickCutOffDate.Name = "lblIndividualSpenddownPickCutOffDate";
            this.lblIndividualSpenddownPickCutOffDate.Size = new System.Drawing.Size(86, 13);
            this.lblIndividualSpenddownPickCutOffDate.TabIndex = 3;
            this.lblIndividualSpenddownPickCutOffDate.Text = "Pick Cut Off Date";
            // 
            // dateIndividualSpenddownCutOffTimePicker
            // 
            this.dateIndividualSpenddownCutOffTimePicker.Location = new System.Drawing.Point(98, 25);
            this.dateIndividualSpenddownCutOffTimePicker.Name = "dateIndividualSpenddownCutOffTimePicker";
            this.dateIndividualSpenddownCutOffTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateIndividualSpenddownCutOffTimePicker.TabIndex = 2;
            // 
            // btnIndividualSpenddownSubmit
            // 
            this.btnIndividualSpenddownSubmit.Location = new System.Drawing.Point(304, 23);
            this.btnIndividualSpenddownSubmit.Name = "btnIndividualSpenddownSubmit";
            this.btnIndividualSpenddownSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnIndividualSpenddownSubmit.TabIndex = 1;
            this.btnIndividualSpenddownSubmit.Text = "Submit";
            this.btnIndividualSpenddownSubmit.UseVisualStyleBackColor = true;
            // 
            // txtSubID
            // 
            this.txtSubID.Location = new System.Drawing.Point(385, 25);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.Size = new System.Drawing.Size(100, 20);
            this.txtSubID.TabIndex = 0;
            // 
            // grpIndividualSpenddownExport
            // 
            this.grpIndividualSpenddownExport.Controls.Add(this.btnIndividualSpenddownToExcelWithoutFormulas);
            this.grpIndividualSpenddownExport.Controls.Add(this.btnIndividualSpenddownToExcel);
            this.grpIndividualSpenddownExport.Location = new System.Drawing.Point(12, 118);
            this.grpIndividualSpenddownExport.Name = "grpIndividualSpenddownExport";
            this.grpIndividualSpenddownExport.Size = new System.Drawing.Size(776, 100);
            this.grpIndividualSpenddownExport.TabIndex = 1;
            this.grpIndividualSpenddownExport.TabStop = false;
            this.grpIndividualSpenddownExport.Text = "Export";
            // 
            // btnIndividualSpenddownToExcelWithoutFormulas
            // 
            this.btnIndividualSpenddownToExcelWithoutFormulas.Location = new System.Drawing.Point(304, 19);
            this.btnIndividualSpenddownToExcelWithoutFormulas.Name = "btnIndividualSpenddownToExcelWithoutFormulas";
            this.btnIndividualSpenddownToExcelWithoutFormulas.Size = new System.Drawing.Size(152, 23);
            this.btnIndividualSpenddownToExcelWithoutFormulas.TabIndex = 1;
            this.btnIndividualSpenddownToExcelWithoutFormulas.Text = "To Excel (Without Formulas)";
            this.btnIndividualSpenddownToExcelWithoutFormulas.UseVisualStyleBackColor = true;
            // 
            // btnIndividualSpenddownToExcel
            // 
            this.btnIndividualSpenddownToExcel.Location = new System.Drawing.Point(462, 19);
            this.btnIndividualSpenddownToExcel.Name = "btnIndividualSpenddownToExcel";
            this.btnIndividualSpenddownToExcel.Size = new System.Drawing.Size(75, 23);
            this.btnIndividualSpenddownToExcel.TabIndex = 0;
            this.btnIndividualSpenddownToExcel.Text = "To Excel";
            this.btnIndividualSpenddownToExcel.UseVisualStyleBackColor = true;
            // 
            // dataIndividualSpenddownSpenddown
            // 
            this.dataIndividualSpenddownSpenddown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIndividualSpenddownSpenddown.Location = new System.Drawing.Point(12, 225);
            this.dataIndividualSpenddownSpenddown.Name = "dataIndividualSpenddownSpenddown";
            this.dataIndividualSpenddownSpenddown.Size = new System.Drawing.Size(776, 213);
            this.dataIndividualSpenddownSpenddown.TabIndex = 2;
            // 
            // IndividualSpenddownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataIndividualSpenddownSpenddown);
            this.Controls.Add(this.grpIndividualSpenddownExport);
            this.Controls.Add(this.grpIndividualSpenddownReportParameters);
            this.Name = "IndividualSpenddownForm";
            this.Text = "Individual Spenddown Report";
            this.grpIndividualSpenddownReportParameters.ResumeLayout(false);
            this.grpIndividualSpenddownReportParameters.PerformLayout();
            this.grpIndividualSpenddownExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataIndividualSpenddownSpenddown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIndividualSpenddownReportParameters;
        private System.Windows.Forms.Label lblIndividualSpenddownPickCutOffDate;
        private System.Windows.Forms.DateTimePicker dateIndividualSpenddownCutOffTimePicker;
        private System.Windows.Forms.Button btnIndividualSpenddownSubmit;
        private System.Windows.Forms.TextBox txtSubID;
        private System.Windows.Forms.GroupBox grpIndividualSpenddownExport;
        private System.Windows.Forms.Button btnIndividualSpenddownToExcelWithoutindows.Forms.BindingSource(this.components);
            this.subscriberBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grpInvididualSpenddownReportProgress = new System.Windows.Forms.GroupBox();
            this.barIndividualSpenddownReportProgress = new System.Windows.Forms.ProgressBar();
            this.backgroundIndividualSpenddownCalculation = new System.ComponentModel.BackgroundWorker();
            this.grpIndividualSpenddownReportParameters.SuspendLayout();
            this.grpIndividualSpenddownExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIndividualSpenddownSpenddown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource2)).BeginInit();
            this.grpInvididualSpenddownReportProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIndividualSpenddownReportParameters
            // 
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.lblIndividualSpenddownPickCutOffDate);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.dateIndividualSpenddownCutOffTimePicker);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.btnIndividualSpenddownSubmit);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.txtSubID);
            this.grpIndividualSpenddownReportParameters.Location = new System.Drawing.Point(12, 13);
            this.grpIndividualSpenddownReportParameters.Name = "grpIndividualSpenddownReportParameters";
            this.grpIndividualSpenddownReportParameters.Size = new System.Drawing.Size(433, 54);
            this.grpIndividualSpenddownReportParameters.TabIndex = 1;idualSpenddownSubmit_Click);
            // 
            // grpIndividualSpenddownReportParameters
            // 
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.btnIndividualSpenddownSubmit);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.dateIndividualSpenddownCutOffTimePicker);
            this.grpIndividualSpenddownReportParameters.Controls.Add(this.lblIndividualSpenddownPickCutOffDate);
            this.grpIndividualSpenddownReportParameters.Location = new System.Drawing.Point(12, 12);
            this.grpIndividualSpenddownReportParameters.Name = "grpIndividualSpenddownReportParameters";
            this.grpIndividualSpenddownReportParameters.Size = new System.Drawing.Size(435, 50);
            this.grpIndividualSpenddownReportParameters.TabIndex = 0;
            this.grpIndividualSpenddownReportParameters.TabStop = false;
            this.grpIndividualSpenddownReportParameters.Text = "Enter Subscriber ID";
// Removed sensitive information such as paths, passwords, logins, database names, and connection strings
idualSpenddownSubmit_Click);
            // 
            // txtSubID
            // 
            this.txtSubID.Location = new System.Drawing.Point(7, 19);
            this.txtSubID.Name = "txtSubID";
            this.txtSubID.Size = new System.Drawing.Size(107, 20);
            this.txtSubID.TabIndex = 0;
            // 
            // grpIndividualSpenddownExport
            // 
            this.grpIndividualSpenddownExport.Controls.Add(this.btnIndividualSpenddownToExcelWithoutFormulas);
            this.grpIndividualSpenddownExport.Controls.Add(this.btnIndividualSpenddownToExcel);
            this.grpIndividualSpenddownExport.Location = new System.Drawing.Point(451, 13);
            this.grpIndividualSpenddownExport.Name = "grpIndividualSpenddownExport";
            this.grpIndividualSpenddownExport.Size = new System.Drawing.Size(274, 54);
            this.grpIndividualSpenddownExport.TabIndex = 4;
            this.grpIndividualSpenddownExport.TabStop = false;
            this.grpIndividualSpenddownExport.Text = "Export";
            // 
            // btnIndividualSpenddownToExcelWithoutFormulas
            // 
            this.btnIndividualSpenddownToExcelWithoutFormulas.Enabled = false;
            this.btnIndividualSpenddownToExcelWithoutFormulas.Location = new System.Drawing.Point(6, 16);
            this.btnIndividualSpenddownToExcelWithoutFormulas.Name = "btnIndividualSpenddownToExcelWithoutFormulas";
            this.btnIndividualSpenddownToExcelWithoutFormulas.Size = new System.Drawing.Size(127, 22);
            this.btnIndividualSpenddownToExcelWithoutFormulas.TabIndex = 1;
            this.btnIndividualSpenddownToExcelWithoutFormulas.Text = "To Excel w/o Formulas";
            this.btnIndividualSpenddownToExcelWithoutFormulas.UseVisualStyleBackColor = true;
            this.btnIndividualSpenddownToExcelWithoutFormulas.Click += new System.EventHandler(this.BtnIndividualSpenddownToExcelWithoutFormulas_Click);
            //             // btnIndividualSpenddownToExcel
            // 
            this.btnIndividualSpenddownToExcel.Enabled = false;
            this.btnIndividualSpenddownToExcel.Location = new System.Drawing.Point(139, 15);
            this.btnIndividualSpenddownToExcel.Name = "btnIndividualSpenddownToExcel";
            this.btnIndividualSpenddownToExcel.Size = new System.Drawing.Size(128, 23);
            this.btnIndividualSpenddownToExcel.TabIndex = 0;
            this.btnIndividualSpenddownToExcel.Text = "To Excel with Formulas";
            this.btnIndividualSpenddownToExcel.UseVisualStyleBackColor = true;
            this.btnIndividualSpenddownToExcel.Click += new System.EventHandler(this.BtnIndividualSpenddownToExcelWithFormulas_Click);
            // 
            // dataIndividualSpenddownSpenddown
            // 
            this.dataIndividualSpenddownSpenddown.AllowUserToAddRows = false;
            this.dataIndividualSpenddownSpenddown.AllowUserToDeleteRows = false;
            this.dataIndividualSpenddownSpenddown.AllowUserToOrderColumns = true;
            this.dataIndividualSpenddownSpenddown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataIndividualSpenddownSpenddown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIndividualSpenddownSpenddown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataIndividualSpenddownSpenddown.Location = new System.Drawing.Point(0, 138);
            this.dataIndividualSpenddownSpenddown.Name = "dataIndividualSpenddownSpenddown";
            this.dataIndividualSpenddownSpenddown.Size = new System.Drawing.Size(734, 373);
            this.dataIndividualSpenddownSpenddown.TabIndex = 3;
            // 
            // grpInvididualSpenddownReportProgress
            // 
            this.grpInvididualSpenddownReportProgress.Controls.Add(this.barIndividualSpenddownReportProgress);
            this.grpInvididualSpenddownReportProgress.Location = new System.Drawing.Point(12, 72);
            this.grpInvididualSpenddownReportProgress.Name = "grpInvididualSpenddownReportProgress";
            this.grpInvididualSpenddownReportProgress.Size = new System.Drawing.Size(713, 60);
            this.grpInvididualSpenddownReportProgress.TabIndex = 12;
            this.grpInvididualSpenddownReportProgress.TabStop = false;
            this.grpInvididualSpenddownReportProgress.Text = "Progress";
            // 
            // barIndividualSpenddownReportProgress
            // 
            this.barIndividualSpenddownReportProgress.Location = new System.Drawing.Point(9, 19);
            this.barIndividualSpenddownReportProgress.Name = "barIndividualSpenddownReportProgress";
            this.barIndividualSpenddownReportProgress.Size = new System.Drawing.Size(695, 35);
            this.barIndividualSpenddownReportProgress.TabIndex = 0;
            // 
            // backgroundMassSpenddownCalculation
            // 
            this.backgroundIndividualSpenddownCalculation.WorkerReportsProgress = true;
            this.backgroundIndividualSpenddownCalculation.WorkerSupportsCancellation = true;
            this.backgroundIndividualSpenddownCalculation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundIndividualSpenddownCalculation_DoWork);
            this.backgroundIndividualSpenddownCalculation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundIndividualSpenddownCalculation_ProgressChanged);
            this.backgroundIndividualSpenddownCalculation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundIndividualSpenddownCalculation_RunWorkerCompleted);
            // 
            // IndividualSpenddownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode =indows.Forms.DataGridView dataIndividualSpenddownSpenddown;
        private System.Windows.Forms.BindingSource subscriberBindingSource1;
        private System.Windows.Forms.BindingSource subscriberBindingSource2;
        private System.Windows.Forms.GroupBox grpInvididualSpenddownReportProgress;indows.Forms.BindingSource subscriberBindingSource1;
        private System.Windows.Forms.DataGridView dataIndividualSpenddownSpenddown;
        private System.Windows.Forms.BindingSource subscriberBindingSource2;
        private System.Windows.Forms.Button btnIndividualSpenddownToExcel;
        private System.Windows.Forms.Button btnIndividualSpenddownToExcelWithoutFormulas;
        private System.Windows.Forms.GroupBox grpInvididualSpenddownReportProgress;
        private System.Windows.Forms.ProgressBar barIndividualSpenddownReportProgress;
        private System.ComponentModel.BackgroundWorker backgroundIndividualSpenddownCalculation;
    }
}