        this.dgvBulkPDFSearchCriteriaList = new System.Windows.Forms.DataGridView();
            this.colBulkPDFSearchCriteriaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBulkPDFSearchCriteriaValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBulkPDFSearchSource.SuspendLayout();
            this.grpBulkPDFSearchDestination.SuspendLayout();
            this.grpBulkPDFSearchProgress.SuspendLayout();
            this.grpBulkPDFSearchStartSearch.SuspendLayout();
            this.grpBulkPDFSearchCriteriaList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBulkPDFSearchCriteriaList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBulkPDFSearchSource
            // 
            this.grpBulkPDFSearchSource.Controls.Add(this.btnBulkPDFSearchChooseSrcDirectory);
            this.grpBulkPDFSearchSource.Controls.Add(this.lblBulkPDFSearchCurrentSrcDirectory);
            this.grpBulkPDFSearchSource.Location = new System.Drawing.Point(12, 12);
            this.grpBulkPDFSearchSource.Name = "grpBulkPDFSearchSource";
            this.grpBulkPDFSearchSource.Size = new System.Drawing.Size(776, 100);
            this.grpBulkPDFSearchSource.TabIndex = 0;
            this.grpBulkPDFSearchSource.TabStop = false;
            this.grpBulkPDFSearchSource.Text = "Source Directory";
            // 
            // btnBulkPDFSearchChooseSrcDirectory
            // 
            this.btnBulkPDFSearchChooseSrcDirectory.Location = new System.Drawing.Point(6, 71);
            this.btnBulkPDFSearchChooseSrcDirectory.Name = "btnBulkPDFSearchChooseSrcDirectory";
            this.btnBulkPDFSearchChooseSrcDirectory.Size = new System.Drawing.Size(764, 23);
            this.btnBulkPDFSearchChooseSrcDirectory.TabIndex = 1;
            this.btnBulkPDFSearchChooseSrcDirectory.Text = "Choose Source Directory";
            this.btnBulkPDFSearchChooseSrcDirectory.UseVisualStyleBackColor = true;
            this.btnBulkPDFSearchChooseSrcDirectory.Click += new System.EventHandler(this.btnBulkPDFSearchChooseSrcDirectory_Click);
            // 
            // lblBulkPDFSearchCurrentSrcDirectory
            // 
            this.lblBulkPDFSearchCurrentSrcDirectory.AutoSize = true;
            this.lblBulkPDFSearchCurrentSrcDirectory.Location = new System.Drawing.Point(6, 16);
            this.lblBulkPDFSearchCurrentSrcDirectory.Name = "lblBulkPDFSearchCurrentSrcDirectory";
            this.lblBulkPDFSearchCurrentSrcDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblBulkPDFSearchCurrentSrcDirectory.TabIndex = 0;
            // 
            // grpBulkPDFSearchDestination
            // 
            this.grpBulkPDFSearchDestination.Controls.Add(this.btnBulkPDFSearchChooseDstDirectory);
            this.grpBulkPDFSearchDestination.Controls.Add(this.lblBulkPDFSearchCurrentDstDirectory);
            this.grpBulkPDFSearchDestination.Location = new System.Drawing.Point(12, 118);
            this.grpBulkPDFSearchDestination.Name = "grpBulkPDFSearchDestination";
            this.grpBulkPDFSearchDestination.Size = new System.Drawing.Size(776, 100);
            this.grpBulkPDFSearchDestination.TabIndex = 1;
            this.grpBulkPDFSearchDestination.TabStop = false;
            this.grpBulkPDFSearchDestination.Text = "Destination Directory";
            // 
            // btnBulkPDFSearchChooseDstDirectory
            // 
            this.btnBulkPDFSearchChooseDstDirectory.Location = new System.Drawing.Point(6, 71);
            this.btnBulkPDFSearchChooseDstDirectory.Name = "btnBulkPDFSearchChooseDstDirectory";
            this.btnBulkPDFSearchChooseDstDirectory.Size = new System.Drawing.Size(764, 23);
            this.btnBulkPDFSearchChooseDstDirectory.TabIndex = 1;
            this.btnBulkPDFSearchChooseDstDirectory.Text = "Choose Destination Directory";
            this.btnBulkPDFSearchChooseDstDirectory.UseVisualStyleBackColor = true;
            this.btnBulkPDFSearchChooseDstDirectory.Click += new System.EventHandler(this.btnBulkPDFSearchChooseDstDirectory_Click);
            // 
            // lblBulkPDFSearchCurrentDstDirectory
            // 
            this.lblBulkPDFSearchCurrentDstDirectory.AutoSize = true;
            this.lblBulkPDFSearchCurrentDstDirectory.Location = new System.Drawing.Point(6, 16);
            this.lblBulkPDFSearchCurrentDstDirectory.Name = "lblBulkPDFSearchCurrentDstDirectory";
            this.lblBulkPDFSearchCurrentDstDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblBulkPDFSearchCurrentDstDirectory.TabIndex = 0;
            // 
            // grpBulkPDFSearchProgress
            // 
            this.grpBulkPDFSearchProgress.Controls.Add(this.barBulkPDFSearchProgress);
            this.grpBulkPDFSearchProgress.Location = new System.Drawing.Point(12, 224);
            this.grpBulkPDFSearchProgress.Name = "grpBulkPDFSearchProgress";
            this.grpBulkPDFSearchProgress.Size = new System.Drawing.Size(776, 100);
            this.grpBulkPDFSearchProgress.TabIndex = 2;
            this.grpBulkPDFSearchProgress.TabStop = false;
            this.grpBulkPDFSearchProgress.Text = "Progress";
            // 
            // barBulkPDFSearchProgress
            // 
            this.barBulkPDFSearchProgress.Location = new System.Drawing.Point(6, 19);
            this.barBulkPDFSearchProgress.Name = "barBulkPDFSearchProgress";
            this.barBulkPDFSearchProgress.Size = new System.Drawing.Size(764, 23);
            this.barBulkPDFSearchProgress.TabIndex = 0;
            // 
            // grpBulkPDFSearchStartSearch
            // 
            this.grpBulkPDFSearchStartSearch.Controls.Add(this.btnBulkPDFSearchRunSplit);
            this.grpBulkPDFSearchStartSearch.Location = new System.Drawing.Point(12, 330);
            this.grpBulkPDFSearchStartSearch.Name = "grpBulkPDFSearchStartSearch";
            this.grpBulkPDFSearchStartSearch.Size = new System.Drawing.Size(776, 100);
            this.grpBulkPDFSearchStartSearch.TabIndex = 3;
            this.grpBulkPDFSearchStartSearch.TabStop = false;
            this.grpBulkPDFSearchStartSearch.Text = "Start Search";
            // 
            // btnBulkPDFSearchRunSplit
            // 
            this.btnBulkPDFSearchRunSplit.Location = new System.Drawing.Point(6, 19);
            this.btnBulkPDFSearchRunSplit.Name = "btnBulkPDFSearchRunSplit";
            this.btnBulkPDFSearchRunSplit.Size = new System.Drawing.Size(764, 75);
            this.btnBulkPDFSearchRunSplit.TabIndex = 0;
            this.btnBulkPDFSearchRunSplit.Text = "Run Split";
            this.btnBulkPDFSearchRunSplit.UseVisualStyleBackColor = true;
            this.btnBulkPDFSearchRunSplit.Click += new System.EventHandler(this.btnBulkPDFSearchRunSplit_Click);
            // 
            // backgroundBulkPDFSearch
            // 
            this.backgroundBulkPDFSearch.WorkerReportsProgress = true;
            this.backgroundBulkPDFSearch.WorkerSupportsCancellation = true;
            this.backgroundBulkPDFSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBulkPDFSearch_DoWork);
            this.backgroundBulkPDFSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBulkPDFSearch_ProgressChanged);
            this.backgroundBulkPDFSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBulkPDFSearch_RunWorkerCompleted);
            // 
            // grpBulkPDFSearchCriteriaList
            // 
            this.grpBulkPDFSearchCriteriaList.Controls.Add(this.dgvBulkPDFSearchCriteriaList            this.lblBulkPDFSearchCurrentSrcDirectory.Location = new System.Drawing.Point(144, 24);
            this.lblBulkPDFSearchCurrentSrcDirectory.Name = "lblBulkPDFSearchCurrentSrcDirectory";
            this.lblBulkPDFSearchCurrentSrcDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblBulkPDFSearchCurrentSrcDirectory.TabIndex = 5;
            // 
            // grpBulkPDFSearchDestination
            // 
            this.grpBulkPDFSearchDestination.Controls.Add(this.btnBulkPDFSearchChooseDestDirectory);
            this.grpBulkPDFSearchDestination.Controls.Add(this.lblBulkPDFSearchCurrentDestDirectory);
            this.grpBulkPDFSearchDestination.Location = new System.Drawing.Point(12, 299);
            this.grpBulkPDFSearchDestination.Name = "grpBulkPDFSearchDestination";
            this.grpBulkPDFSearchDestination.Size = new System.Drawing.Size(711, 53);
            this.grpBulkPDFSearchDestination.TabIndex = 1;
            this.grpBulkPDFSearchDestination.TabStop = false;
            this.grpBulkPDFSearchDestination.Text = "Destination";
            // 
            // btnBulkPDFSearchChooseDestDirectory
            // 
            this.btnBulkPDFSearchChooseDestDirectory.Location = new System.Drawing.Point(6, 19);
            this.btnBulkPDFSearchChooseDestDirectory.Name = "btnBulkPDFSearchChooseDestDirectory";
            this.btnBulkPDFSearchChooseDestDirectory.Size = new System.Drawing.Size(132, 23);
            this.btnBulkPDFSearchChooseDestDirectory.TabIndex = 5;
            this.btnBulkPDFSearchChooseDestDirectory.Text = "Choose directory";
            this.btnBulkPDFSearchChooseDestDirectory.UseVisualStyleBackColor = true;
            this.btnBulkPDFSearchChooseDestDirectory.Click += new System.EventHandler(this.btnChooseDestDirectory_Click);
            // 
            // lblBulkPDFSearchCurrentDestDirectory
            // 
            this.lblBulkPDFSearchCurrentDestDirectory.AutoSize = true;
            this.lblBulkPDFSearchCurrentDestDirectory.Location = new System.Drawing.Point(144, 24);
            this.lblBulkPDFSearchCurrentDestDirectory.Name = "lblBulkPDFSearchCurrentDestDirectory";
            this.lblBulkPDFSearchCurrentDestDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblBulkPDFSearchCurrentDestDirectory.TabIndex = 6;
            // 
            // grpBulkPDFSearchProgress
            // 
            this.grpBulkPDFSearchProgress.Controls.Add(this.progressBarBulkPDFSearch);
            this.grpBulkPDFSearchProgress.Location = new System.Drawing.Point(12, 358);
            this.grpBulkPDFSearchProgress.Name = "grpBulkPDFSearchProgress";
            this.grpBulkPDFSearchProgress.Size = new System.Drawing.Size(711, 53);
            this.grpBulkPDFSearchProgress.TabIndex = 2;
            this.grpBulkPDFSearchProgress.TabStop = false;
            this.grpBulkPDFSearchProgress.Text = "Progress";
            // 
            // progressBarBulkPDFSearch
            // 
            this.progressBarBulkPDFSearch.Location = new System.Drawing.Point(6, 19);
            this.progressBarBulkPDFSearch.Name = "progressBarBulkPDFSearch";
            this.progressBarBulkPDFSearch.Size = new System.Drawing.Size(699, 23);
            this.progressBarBulkPDFSearch.TabIndex = 0;
            // 
            // grpBulkPDFSearchStartSearch
            // 
            this.grpBulkPDFSearchStartSearch.Controls.Add(this.btnBulkPDFSearchStartSearch);
            this.grpBulkPDFSearchStartSearch.Location = new System.Drawing.Point(12, 417);
            this.grpBulkPDFSearchStartSearch.Name = "grpBulkPDFSearchStartSearch";
            this.grpBulkPDFSearchStartSearch.Size = new System.Drawing.Size(711, 53);
            this.grpBulkPDFSearchStartSearch.TabIndex = 3;
            this.grpBulkPDFSearchStartSearch.TabStop = false;
            this.grpBulkPDFSearchStartSearch.Text = "Start Search";
            // 
            // btnBulkPDFSearchStartSearch
            // 
            this.btnBulkPDFSearchStartSearch.Location = new System.Drawing.Point(6, 19);
            this.btnBulkPDFSearchStartSearch.Name = "btnBulkPDFSearchStartSearch";
            this.btnBulkPDFSearchStartSearch.Size = new System.Drawing.Size(132, 23);
            this.btnBulkPDFSearchStartSearch.TabIndex = 6;
            this.btnBulkPDFSearchStartSearch.Text = "Start Search";
            this.btnBulkPDFSearchStartSearch.UseVisualStyleBackColor = true;
            this.btnBulkPDFSearchStartSearch.Click += new System.EventHandler(this.btnBulkPDFSearchStartSearch_Click);
            // 
            // grpBulkPDFSearchCriteriaList
            // 
            this.grpBulkPDFSearchCriteriaList.Controls.Add(this.txtbxBulkPDFSearchCriteriaList);
            this.grpBulkPDFSearchCriteriaList.Location = new System.Drawing.Point(12, 12);
            this.grpBulkPDFSearchCriteriaList.Name = "grpBulkPDFSearchCriteriaList";
            this.grpBulkPDFSearchCriteriaList.Size = new System.Drawing.Size(711, 222);
            this.grpBulkPDFSearchCriteriaList.TabIndex = 4;
            this.grpBulkPDFSearchCriteriaList.TabStop = false;
            this.grpBulkPDFSearchCriteriaList.Text = "Search Criteria List";
            // 
            // txtbxBulkPDFSearchCriteriaList
            // 
            this.txtbxBulkPDFSearchCriteriaList.Location = new System.Drawing.Point(6, 19);
            this.txtbxBulkPDFSearchCriteriaList.Multiline = true;
            this.txtbxBulkPDFSearchCriteriaList.Name = "txtbxBulkPDFSearchCriteriaList";
            this.txtbxBulkPDFSearchCriteriaList.Size = new System.Drawing.Size(699, 197);
            this.txtbxBulkPDFSearchCriteriaList.TabIndex = 0;FSearchChooseDstDirectory.Click += new System.EventHandler(this.btnBulkPDFSearchChooseDstDirectory_Click);
            // 
            // lblBulkPDFSearchCurrentDstDirectory
            // 
            this.lblBulkPDFSearchCurrentDstDirectory.AutoSize = true;
            this.lblBulkPDFSearchCurrentDstDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulkPDFSearchCurrentDstDirectory.Location = new System.Drawing.Point(147, 24);
            this.lblBulkPDFSearchCurrentDstDirectory.Name = "lblBulkPDFSearchCurrentDstDirectory";
            this.lblBulkPDFSearchCurrentDstDirectory.Size = new System.Drawing.Size(87, 13);
            this.lblBulkPDFSearchCurrentDstDirectory.TabIndex = 7;
            this.lblBulkPDFSearchCurrentDstDirectory.Text = "Current directory:";
s.Add(this.btnBulkPDFSearchStartSearch);
            this.grpBulkPDFSearchStartSearch.Controls.Add(this.lblBulkPDFSearchStartSearch);
            this.grpBulkPDFSearchStartSearch.Controls.Add(this.txtBulkPDFSearchStartSearch);
            this.grpBulkPDFSearchStartSearch.Location = new System.Drawing.Point(12, 62);
            this.grpBulkPDFSearchStartSearch.Name = "grpBulkPDFSearchStartSearch";
            this.grpBulkPDFSearchStartSearch.Size = new System.Drawing.Size(711, 85);
            this.grpBulkPDFSearchStartSearch.TabIndex = 6;
            this.grpBulkPDFSearchStartSearch.TabStop = false;
            this.grpBulkPDFSearchStartSearch.Text = "Start Search";
            // 
            // btnBulkPDFSearchStartSearch
            // 
            this.btnBulkPDFSearchStartSearch.Location = new System.Drawing.Point(630, 56);
            this.btnBulkPDFSearchStartSearch.Name = "btnBulkPDFSearchStartSearch";
            this.btnBulkPDFSearchStartSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBulkPDFSearchStartSearch.TabIndex = 2;
            this.btnBulkPDFSearchStartSearch.Text = "Start Search";
            this.btnBulkPDFSearchStartSearch.UseVisualStyleBackColor = true;
            this.btnBulkPDFSearchStartSearch.Click += new System.EventHandler(this.btnBulkPDFSearchStartSearch_Click);
            // 
            // lblBulkPDFSearchStartSearch
            // 
            this.lblBulkPDFSearchStartSearch.AutoSize = true;
            this.lblBulkPDFSearchStartSearch.Location = new System.Drawing.Point(6, 31);
            this.lblBulkPDFSearchStartSearch.Name = "lblBulkPDFSearchStartSearch";
            this.lblBulkPDFSearchStartSearch.Size = new System.Drawing.Size(0, 13);
            this.lblBulkPDFSearchStartSearch.TabIndex = 1;
            // 
            // txtBulkPDFSearchStartSearch
            // 
            this.txtBulkPDFSearchStartSearch.Location = new System.Drawing.Point(9, 56);
            this.txtBulkPDFSearchStartSearch.Name = "txtBulkPDFSearchStartSearch";
            this.txtBulkPDFSearchStartSearch.Size = new System.Drawing.Size(615, 20);
            this.txtBulkPDFSearchStartSearch.TabIndex = 0;BulkPDFSearchCriteriaList.Location = new System.Drawing.Point(12, 12);
            this.grpBulkPDFSearchCriteriaList.Name = "grpBulkPDFSearchCriteriaList";
            this.grpBulkPDFSearchCriteriaList.Size = new System.Drawing.Size(711, 344);
            this.grpBulkPDFSearchCriteriaList.TabIndex = 12;
            this.grpBulkPDFSearchCriteriaList.TabStop = false;
            this.grpBulkPDFSearchCriteriaList.Text = "Criteria List";
            // 
            // txtbxBulkPDFSearchCriteriaList
            // 
            this.txtbxBulkPDFSearchCriteriaList.Location = new System.Drawing.Point(9, 20);
            this.txtbxBulkPDFSearchCriteriaList.Multiline = true;
            this.txtbxBulkPDFSearchCriteriaList.Name = "txtbxBulkPDFSearchCriteriaList";
            this.txtbxBulkPDFSearchCriteriaList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxBulkPDFSearchCriteriaList.Size = new System.Drawing.Size(696, 318);
            this.txtbxBulkPDFSearchCriteriaList.TabIndex = 0;BulkPDFSearchCriteriaList.Location = new System.Drawing.Point(12, 13);
            this.grpBulkPDFSearchCriteriaList.Name = "grpBulkPDFSearchCriteriaList";
            this.grpBulkPDFSearchCriteriaList.Size = new System.Drawing.Size(711, 221);
            this.grpBulkPDFSearchCriteriaList.TabIndex = 14;
            this.grpBulkPDFSearchCriteriaList.TabStop = false;
            this.grpBulkPDFSearchCriteriaList.Text = "Enter the list of search criteria";
            // 
            // txtbxBulkPDFSearchCriteriaList
            // 
            this.txtbxBulkPDFSearchCriteriaList.Location = new System.Drawing.Point(9, 20);
            this.txtbxBulkPDFSearchCriteriaList.MaxLength = 2147483647;
            this.txtbxBulkPDFSearchCriteriaList.Multiline = true;
            this.txtbxBulkPDFSearchCriteriaList.Name = "txtbxBulkPDFSearchCriteriaList";
            this.txtbxBulkPDFSearchCriteriaList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxBulkPDFSearchCriteriaList.Size = new System.Drawing.Size(696, 195);
            this.txtbxBulkPDFSearchCriteriaList.TabIndex = 0;
            // 
            // BulkPDFSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 485);
            this.Controls.Add(this.grpBulkPDFSearchCriteriaList);
            this.Controls.Add(this.grpBulkPDFSearchStartSearch);
            this.Controls.Add(this.grpBulkPDFSearchProgress);
            this.Controls.Add(this.grpBulkPDFSearchDestination);
            this.Controls.Add(this.grpBulkPDFSearchSource);
            this.Name = "BulkPDFSearchForm";
            this.Text = "Bulk PDF Search";
            this.Load += new System.EventHandler(this.OnBulkPDFSearchFormLoad);
            this.grpBulkPDFSearchSource.ResumeLayout(false);
            this.grpBulkPDFSearchSource.PerformLayout();
            this.grpBulkPDFSearchDestination.ResumeLayout(false);
            this.grpBulkPDFSearchDestination.PerformLayout();
            this.grpBulkPDFSearchProgress.ResumeLayout(false);
            this.grpBulkPDFSearchStartSearch.ResumeLayout(false);
            this.grpBulkPDFSearchCriteriaList.ResumeLayout(false);
            this.grpBulkPDFSearchCriteriaList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBulkPDFSearchSource;
        private System.Windows.Forms.Label lblBulkPDFSearchCurrentSrcDirectory;
        private System.Windows.Forms.Button btnBulkPDFSearchChooseSrcDirectory;
        private System.Windows.Forms.GroupBox grpBulkPDFSearchDestination;
        private System.Windows.Forms.Button btnBulkPDFSearchChooseDstDirectory;
        private System.Windows.Forms.Label lblBulkPDFSearchCurrentDstDirectory;
        private System.Windows.Forms.GroupBox grpBulkPDFSearchProgress;
        private System.Windows.Forms.ProgressBar barBulkPDFSearchProgress;
        private System.Windows.Forms.GroupBox grpBulkPDFSearchStartSearch;
        private System.Windows.Forms.Button btnBulkPDFSearchRunSplit;
        private System.ComponentModel.BackgroundWorker backgroundBulkPDFSearch;
        private System.Windows.Forms.GroupBox grpBulkPDFSearchCriteriaList;
        private System.Windows.Forms.TextBox txtbxBulkPDFSearchCriteriaList;
    }
}