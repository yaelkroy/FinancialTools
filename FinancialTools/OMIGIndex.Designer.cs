            this.SuspendLayout();
            // 
            // grpOMIGIndexReportParameters
            // 
            this.grpOMIGIndexReportParameters.Controls.Add(this.btnOMIGIndexSearch);
            this.grpOMIGIndexReportParameters.Controls.Add(this.txtOMIGIndexSubID);
            this.grpOMIGIndexReportParameters.Location = new System.Drawing.Point(12, 12);
            this.grpOMIGIndexReportParameters.Name = "grpOMIGIndexReportParameters";
            this.grpOMIGIndexReportParameters.Size = new System.Drawing.Size(776, 56);
            this.grpOMIGIndexReportParameters.TabIndex = 0;
            this.grpOMIGIndexReportParameters.TabStop = false;
            this.grpOMIGIndexReportParameters.Text = "OMIG Index Report Parameters";
            // 
            // btnOMIGIndexSearch
            // 
            this.btnOMIGIndexSearch.Location = new System.Drawing.Point(685, 20);
            this.btnOMIGIndexSearch.Name = "btnOMIGIndexSearch";
            this.btnOMIGIndexSearch.Size = new System.Drawing.Size(75, 23);
            this.btnOMIGIndexSearch.TabIndex = 1;
            this.btnOMIGIndexSearch.Text = "Search";
            this.btnOMIGIndexSearch.UseVisualStyleBackColor = true;
            // 
            // txtOMIGIndexSubID
            // 
            this.txtOMIGIndexSubID.Location = new System.Drawing.Point(6, 22);
            this.txtOMIGIndexSubID.Name = "txtOMIGIndexSubID";
            this.txtOMIGIndexSubID.Size = new System.Drawing.Size(100, 20);
            this.txtOMIGIndexSubID.TabIndex = 0;
            // 
            // btnOMIGIndexReindex
            // 
            this.btnOMIGIndexReindex.Location = new System.Drawing.Point(13, 75);
            this.btnOMIGIndexReindex.Name = "btnOMIGIndexReindex";
            this.btnOMIGIndexReindex.Size = new System.Drawing.Size(75, 23);
            this.btnOMIGIndexReindex.TabIndex = 2;
            this.btnOMIGIndexReindex.Text = "Reindex";
            this.btnOMIGIndexReindex.UseVisualStyleBackColor = true;
            // 
            // dataOMIGIndex
            // 
            this.dataOMIGIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOMIGIndex.Location = new System.Drawing.Point(13, 105);
            this.dataOMIGIndex.Name = "dataOMIGIndex";
            this.dataOMIGIndex.Size = new System.Drawing.Size(775, 250);
            this.dataOMIGIndex.TabIndex = 3;
            // 
            // grpOMIGReindexProgress
            // 
            this.grpOMIGReindexProgress.Controls.Add(this.barOMIGIndexProgress);
            this.grpOMIGReindexProgress.Location = new System.Drawing.Point(13, 362);
            this.grpOMIGReindexProgress.Name = "grpOMIGReindexProgress";
            this.grpOMIGReindexProgress.Size = new System.Drawing.Size(775, 56);
            this.grpOMIGReindexProgress.TabIndex = 4;
            this.grpOMIGReindexProgress.TabStop = false;
            this.grpOMIGReindexProgress.Text = "OMIG Reindex Progress";
            // 
            // barOMIGIndexProgress
            // 
            this.barOMIGIndexProgress.Location = new System.Drawing.Point(6, 19);
            this.barOMIGIndexProgress.Name = "barOMIGIndexProgress";
            this.barOMIGIndexProgress.Size = new System.Drawing.Size(763, 23);
            this.barOMIGIndexProgress.TabIndex = 0;
            // 
            // backgroundOMIGIndex
            // 
            this.backgroundOMIGIndex.WorkerReportsProgress = true;
            this.backgroundOMIGIndex.WorkerSupportsCancellation = true;
            // 
            // grpOMIGReindex
            // 
            this.grpOMIGReindex.Location = new System.Drawing.Point(13, 425);
            this.grpOMIGReindex.Name = "grpOMIGReindex";
            this.grpOMIGReindex.Size = new System.Drawing.Size(775, 56);
            this.grpOMIGReindex.TabIndex = 5;
            this.grpOMIGReindex.TabStop = false;
            this.grpOMIGReindex.Text = "OMIG Reindex";
            // 
            // grpOmigExport
            // 
            this.grpOmigExport.Controls.Add(this.btnExportToExcel);
            this.grpOmigExport.Location = new System.Drawing.Point(13, 487);
            this.grpOmigExport.Name = "grpOmigExport";
            this.grpOmigExport.Size = new System.Drawing.Size(775, 56);
            this.grpOmigExport.TabIndex = 6;
            this.grpOmigExport.TabStop = false;
            this.grpOmigExport.Text = "OMIG Export";
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(6, 19);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(129, 23);
            this.btnExportToExcel.TabIndex = 0;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // OMIGIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.grpOmigExport);
            this.Controls.Add(this.grpOMIGReindex);
            this.Controls.Add(this.grpOMIGReindexProgress);
            this.Controls.Add(this.dataOMIGIndex);
            this.Controls.Add(this.btnOMIGIndexReindex);
            this.Controls.Add(this.grpOMIGIndexReportParameters);
            this.Name = "OMIGIndexForm";
            this.Text = "OMIG Index Form";
            this.grpOMIGIndexReportParameters.ResumeLayout(false);
            this.grpOMIGIndexReportParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOMIGIndex)).EndInit();
            this.grpOMIGReindexProgress.ResumeLayout(false);
            this.grpOMIGReindexProgress.PerformLayout();
            this.grpOMIGReindex.ResumeLayout(false);
            this.grpOmigExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOMIGIndexReportParameters;
        private System.Windows.Forms.Button btnOMIGIndexSearch;
        private System.Windows.Forms.TextBox txtOMIGIndexSubID;
        private System.Windows.Forms.Button btnOMIGIndexReindex;
        private System.Windows.Forms.DataGridView dataOMIGIndex;
        private System.Windows.Forms.GroupBox grpOMIGReindexProgress;
        private System.Windows.Forms.ProgressBar barOMIGIndexProgress;
        private System.ComponentModel.BackgroundWorker backgroundOMIGIndex;
        private System.Windows.Forms.GroupBox grpOMIGReindex;
        private System.Windows.Forms.GroupBox grpOmigExport;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}SuspendLayout();
            this.grpOMIGReindex.SuspendLayout();
            this.grpOmigExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOMIGIndexReportParameters
            // 
            this.grpOMIGIndexReportParameters.Controls.Add(this.btnOMIGIndexSearch);
            this.grpOMIGIndexReportParameters.Controls.Add(this.txtOMIGIndexSubID);
            this.grpOMIGIndexReportParameters.Location = new System.Drawing.Point(12, 12);
            this.grpOMIGIndexReportParameters.Name = "grpOMIGIndexReportParameters";
            this.grpOMIGIndexReportParameters.Size = new System.Drawing.Size(517, 200);
            this.grpOMIGIndexReportParameters.TabIndex = 1;
            this.grpOMIGIndexReportParameters.TabStop = false;
            this.grpOMIGIndexReportParameters.Text = "Enter CIN";
            // 
            // btnOMIGIndexSearch
            // 
            this.btnOMIGIndexSearch.Location = new System.Drawing.Point(384, 19);
            this.btnOMIGIndexSearch.Name = "btnOMIGIndexSearch";
            this.btnOMIGIndexSearch.Size = new System.Drawing.Size(127, 23);
            this.btnOMIGIndexSearch.TabIndex = 1;
            this.btnOMIGIndexSearch.Text = "Search";
            this.btnOMIGIndexSearch.UseVisualStyleBackColor = true;
            this.btnOMIGIndexSearch.Click += new System.EventHandler(this.BtnOMIGIndexSubmit_Click);
            // 
            // txtOMIGIndexSubID
            // 
            this.txtOMIGIndexSubID.Location = new System.Drawing.Point(6, 19);
            this.txtOMIGIndexSubID.MaxLength = 2147483647;
            this.txtOMIGIndexSubID.Multiline = true;
            this.txtOMIGIndexSubID.Name = "txtOMIGIndexSubID";
            this.txtOMIGIndexSubID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOMIGIndexSubID.Size = new System.Drawing.Size(372, 175);
            this.txtOMIGIndexSubID.TabIndex = 0;// btnIndexReindex
// 
this.btnIndexReindex.Location = new System.Drawing.Point(15, 19);
this.btnIndexReindex.Name = "btnIndexReindex";
this.btnIndexReindex.Size = new System.Drawing.Size(170, 55);
this.btnIndexReindex.TabIndex = 1;
this.btnIndexReindex.Text = "Reindex Directory";
this.btnIndexReindex.UseVisualStyleBackColor = true;
this.btnIndexReindex.Click += new System.EventHandler(this.BtnReindex_Click);
// 
// dataIndex
// 
this.dataIndex.AllowUserToAddRows = false;
this.dataIndex.AllowUserToDeleteRows = false;
this.dataIndex.AllowUserToOrderColumns = true;
this.dataIndex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
this.dataIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
this.dataIndex.Dock = System.Windows.Forms.DockStyle.Bottom;
this.dataIndex.Location = new System.Drawing.Point(0, 284);
this.dataIndex.Name = "dataIndex";
this.dataIndex.Size = new System.Drawing.Size(753, 363);
this.dataIndex.TabIndex = 3;
this.dataIndex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataIndex_CellContentClick);
// 
// grpReindexProgress
// 
this.grpReindexProgress.Controls.Add(this.barIndexProgress);
this.grpReindexProgress.Location = new System.Drawing.Point(0, 218);
this.grpReindexProgress.Name = "grpReindexProgress";
this.grpReindexProgress.Size = new System.Drawing.Size(741, 60);
this.grpReindexProgress.TabIndex = 12;       this.grpOMIGReindexProgress.TabStop = false;
            this.grpOMIGReindexProgress.Text = "Reindexing Progress";
            // 
            // barOMIGIndexProgress
            // 
            this.barOMIGIndexProgress.Location = new System.Drawing.Point(9, 19);
            this.barOMIGIndexProgress.Name = "barOMIGIndexProgress";
            this.barOMIGIndexProgress.Size = new System.Drawing.Size(726, 35);
            this.barOMIGIndexProgress.TabIndex = 0;
            // 
            // backgroundOMIGIndex
            // 
            this.backgroundOMIGIndex.WorkerReportsProgress = true;
            this.backgroundOMIGIndex.WorkerSupportsCancellation = true;
            this.backgroundOMIGIndex.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundOMIGIndex_DoWork);
            this.backgroundOMIGIndex.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundOMIGIndex_ProgressChanged);
            this.backgroundOMIGIndex.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundOMIGIndex_RunWorkerCompleted);
            // 
            // grpOMIGReindex
            // 
            this.grpOMIGReindex.Controls.Add(this.btnOMIGIndexReindex);
            this.grpOMIGReindex.Location = new System.Drawing.Point(535, 12);
            this.grpOMIGReindex.Name = "grpOMIGReindex";
            this.grpOMIGReindex.Size = new System.Drawing.Size(200, 95);
            this.grpOMIGReindex.TabIndex = 13;
            this.grpOMIGReindex.TabStop = false;
            this.grpOMIGReindex.Text = "Reindex";
            // 
            // grpOmigExport
            // 
            this.grpOmigExport.Controls.Add(this.btnExportToExcel);
            this.grpOmigExport.Location = new System.Drawing.Point(535, 117);
            this.grpOmigExport.Name = "grpOmigExport";
            this.grpOmigExport.Size = new System.Drawing.Size(200, 95);        Export;
        private System.Windows.Forms.GroupBox grpOMIGReindex;
        private System.Windows.Forms.GroupBox grpOMIGReindexProgress;
        private System.Windows.Forms.DataGridView dataOMIGIndex;
        private System.Windows.Forms.GroupBox grpOMIGIndexReportParameters;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.GroupBox grpOmigExport;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_Click;
        private System.Windows.Forms.Button btnExportToExcel_ClickIGIndexReportParameters;
        private System.Windows.Forms.TextBox txtSubID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataOMIGIndex;
        private System.Windows.Forms.Button btnReindex;
        private System.Windows.Forms.GroupBox grpReindexProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox grpReindex;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}