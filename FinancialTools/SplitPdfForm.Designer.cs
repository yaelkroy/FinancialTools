nation.SuspendLayout();
            this.grpSplitPDFProgress.SuspendLayout();
            this.grpStartSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.btnChooseSrcDirectory);
            this.grpSource.Controls.Add(this.cmbbxSplitPDFDocumentType);
            this.grpSource.Controls.Add(this.lblCurrentSrcDirectory);
            this.grpSource.Controls.Add(this.lblType);
            this.grpSource.Location = new System.Drawing.Point(12, 12);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(760, 100);
            this.grpSource.TabIndex = 0;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source Directory";
            // 
            // btnChooseSrcDirectory
            // 
            this.btnChooseSrcDirectory.Location = new System.Drawing.Point(644, 19);
            this.btnChooseSrcDirectory.Name = "btnChooseSrcDirectory";
            this.btnChooseSrcDirectory.Size = new System.Drawing.Size(110, 23);
            this.btnChooseSrcDirectory.TabIndex = 3;
            this.btnChooseSrcDirectory.Text = "Choose Directory";
            this.btnChooseSrcDirectory.UseVisualStyleBackColor = true;
            this.btnChooseSrcDirectory.Click += new System.EventHandler(this.btnChooseSrcDirectory_Click);
            // 
            // cmbbxSplitPDFDocumentType
            // 
            this.cmbbxSplitPDFDocumentType.FormattingEnabled = true;
            this.cmbbxSplitPDFDocumentType.Location = new System.Drawing.Point(85, 21);
            this.cmbbxSplitPDFDocumentType.Name = "cmbbxSplitPDFDocumentType";
            this.cmbbxSplitPDFDocumentType.Size = new System.Drawing.Size(121, 21);
            this.cmbbxSplitPDFDocumentType.TabIndex = 2;
            // 
            // lblCurrentSrcDirectory
            // 
            this.lblCurrentSrcDirectory.AutoSize = true;
            this.lblCurrentSrcDirectory.Location = new System.Drawing.Point(7, 52);
            this.lblCurrentSrcDirectory.Name = "lblCurrentSrcDirectory";
            this.lblCurrentSrcDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentSrcDirectory.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(72, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Document Type:";
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.btnChooseDstDirectory);
            this.grpDestination.Controls.Add(this.lblCurrentDstDirectory);
            this.grpDestination.Location = new System.Drawing.Point(12, 118);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(760, 100);
            this.grpDestination.TabIndex = 1;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination Directory";
            // 
            // btnChooseDstDirectory
            // 
            this.btnChooseDstDirectory.Location = new System.Drawing.Point(644, 19);
            this.btnChooseDstDirectory.Name = "btnChooseDstDirectory";
            this.btnChooseDstDirectory.Size = new System.Drawing.Size(110, 23);
            this.btnChooseDstDirectory.TabIndex = 4;
            this.btnChooseDstDirectory.Text = "Choose Directory";
            this.btnChooseDstDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDstDirectory.Click += new System.EventHandler(this.btnChooseDstDirectory_Click);
            // 
            // lblCurrentDstDirectory
            // 
            this.lblCurrentDstDirectory.AutoSize = true;
            this.lblCurrentDstDirectory.Location = new System.Drawing.Point(7, 24);
            this.lblCurrentDstDirectory.Name = "lblCurrentDstDirectory";
            this.lblCurrentDstDirectory.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentDstDirectory.TabIndex = 1;
            // 
            // grpSplitPDFProgress
            // 
            this.grpSplitPDFProgress.Controls.Add(this.barSplitPDFProgress);
            this.grpSplitPDFProgress.Location = new System.Drawing.Point(12, 224);
            this.grpSplitPDFProgress.Name = "grpSplitPDFProgress";
            this.grpSplitPDFProgress.Size = new System.Drawing.Size(760, 100);
            this.grpSplitPDFProgress.TabIndex = 2;
            this.grpSplitPDFProgress.TabStop = false;
            this.grpSplitPDFProgress.Text = "Split PDF Progress";
            // 
            // barSplitPDFProgress
            // 
            this.barSplitPDFProgress.Location = new System.Drawing.Point(9, 19);
            this.barSplitPDFProgress.Name = "barSplitPDFProgress";
            this.barSplitPDFProgress.Size = new System.Drawing.Size(745, 23);
            this.barSplitPDFProgress.TabIndex = 0;
            // 
            // grpStartSplit
            // 
            this.grpStartSplit.Controls.Add(this.btnRunSplit);
            this.grpStartSplit.Location = new System.Drawing.Point(12, 330);
            this.grpStartSplit.Name = "grpStartSplit";
            this.grpStartSplit.Size = new System.Drawing.Size(760, 100);
            this.grpStartSplit.TabIndex = 3;
            this.grpStartSplit.TabStop = false;
            this.grpStartSplit.Text = "Start Split";
            // 
            // btnRunSplit
            // 
            this.btnRunSplit.Location = new System.Drawing.Point(322, 42);
            this.btnRunSplit.Name = "btnRunSplit";
            this.btnRunSplit.Size = new System.Drawing.Size(116, 23);
            this.btnRunSplit.TabIndex = 0;
            this.btnRunSplit.Text = "Split PDF";
            this.btnRunSplit.UseVisualStyleBackColor = true;
            this.btnRunSplit.Click += new System.EventHandler(this.btnRunSplit_Click);
            // 
            // backgroundSplitPDF
            // 
            this.backgroundSplitPDF.WorkerReportsProgress = true;
            this.backgroundSplitPDF.WorkerSupportsCancellation = true;
            this.backgroundSplitPDF.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundSplitPDF_DoWork);
            this.backgroundSplitPDF.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundSplitPDF_ProgressChanged);
            this.backgroundSplitPDF.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundSplitPDF_RunWorkerCompleted);
            // 
            // SplitPdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.grpStartSplit);
            this.Controls.Add(this.grpSplitPDFProgress);
            this.Controls.Add(this.grpDestination);
            this.Controls.Add(this.grpSource);
            this.FormBorderStyle = System.Windowsjson.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SplitPdfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Split PDF";
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.grpSplitPDFProgress.ResumeLayout(false);
            this.grpStartSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #nation.ResumeLayout(false);
            this.grpSplitPDFProgress.ResumeLayout(false);
            this.grpStartSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.btnChooseSrcDirectory);
            this.grpSource.Controls.Add(this.cmbbxSplitPDFDocumentType);
            this.grpSource.Controls.Add(this.lblCurrentSrcDirectory);
            this.grpSource.Controls.Add(this.lblType);
            this.grpSource.Location = new System.Drawing.Point(13, 13);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(711, 78);
            this.grpSource.TabIndex = 0;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // btnChooseSrcDirectory
            // 
            this.btnChooseSrcDirectory.Location = new System.Drawing.Point(9, 46);
            this.btnChooseSrcDirectory.Name = "btnChooseSrcDirectory";
            this.btnChooseSrcDirectory.Size = new System.Drawing.Size(132, 23);
            this.btnChooseSrcDirectory.TabIndex = 4;
            this.btnChooseSrcDirectory.Text = "Choose directory";
            this.btnChooseSrcDirectory.UseVisualStyleBackColor = true;
            this.btnChooseSrcDirectory.Click += new System.EventHandler(this.btnChooseSrcDirectory_Click);
            // 
            // cmbbxSplitPDFDocumentType
            // 
            this.cmbbxSplitPDFDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxSplitPDFDocumentType.Items.AddRange(new object[] {
            "Disenrollment Forms",
            "Disenrollment Letters",
            "Notification Letters - A Category",
            "Notification Letters - B Category",
            "Notification Letters - C Category",
            "NAMI Individual Invoices from Web Focus",
            "NAMI Facilities Invoi// Code sanitized. Sensitive information has been removed. 

            "Spenddown Invoices from Web Focus",
            "NAMI Individual Invoices from SAP",
            "NAMI Facilities Invoices from SAP",
            "Spenddown Invoices from SAP"});
            this.cmbbxSplitPDFDocumentType.Location = new System.Drawing.Point(109, 19);
            this.cmbbxSplitPDFDocumentType.Name = "cmbbxSplitPDFDocumentType";
            this.cmbbxSplitPDFDocumentType.Size = new System.Drawing.Size(585, 21);
            this.cmbbxSplitPDFDocumentType.TabIndex = 3;
            // 
            // lblCurrentSrcDirectory
            // 
            this.lblCurrentSrcDirectory.AutoSize = true;
            this.lblCurrentSrcDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSrcDirectory.Location = new System.Drawing.Point(147, 51);
            this.lblCurrentSrcDirectory.Name = "lblCurrentSrcDirectory";
            this.lblCurrentSrcDirectory.Size = new System.Drawing.Size(87, 13);
            this.lblCurrentSrcDirectory.TabIndex = 2;
            this.lblCurrentSrcDirectory.Text = "Current directory:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 22);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(96, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type of document:";
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.btnChooseDstDirectory);
            this.grpDestination.Controls.Add(this.lblCurrentDstDirectory);
            this.grpDestination.Location = new System.Drawing.Point(13, 97);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(585, 45);ize";
            // 
            // barSplitPDFProgress
            // 
            this.barSplitPDFProgress.Location = new System.Drawing.Point(6, 19);
            this.barSplitPDFProgress.Name = "barSplitPDFProgress";
            this.barSplitPDFProgress.Size = new System.Drawing.Size(699, 23);
            this.barSplitPDFProgress.TabIndex = 0;
            // 
            // grpSplitPDF
            // 
            this.grpSplitPDF.Controls.Add(this.lblNumPages);
            this.grpSplitPDF.Controls.Add(this.btnSplitPDF);
            this.grpSplitPDF.Controls.Add(this.lblSplitPDF);
            this.grpSplitPDF.Controls.Add(this.txtSplitPDF);
            this.grpSplitPDF.Location = new System.Drawing.Point(13, 146);
            this.grpSplitPDF.Name = "grpSplitPDF";
            this.grpSplitPDF.Size = new System.Drawing.Size(711, 70);
            this.grpSplitPDF.TabIndex = 11;
            this.grpSplitPDF.TabStop = false;
            this.grpSplitPDF.Text = "Split PDF";
            // 
            // lblNumPages
            // 
            this.lblNumPages.AutoSize = true;
            this.lblNumPages.Location = new System.Drawing.Point(9, 48);
            this.lblNumPages.Name = "lblNumPages";
            this.lblNumPages.Size = new System.Drawing.Size(0, 13);
            this.lblNumPages.TabIndex = 3;
            // 
            // btnSplitPDF
            // 
            this.btnSplitPDF.Location = new System.Drawing.Point(630, 19);
            this.btnSplitPDF.Name = "btnSplitPDF";
            this.btnSplitPDF.Size = new System.Drawing.Size(75, 23);
            this.btnSplitPDF.TabIndex = 2;
            this.btnSplitPDF.Text = "Split PDF";
            this.btnSplitPDF.UseVisualStyleBackColor = true;
            this.btnSplitPDF.Click += new System.EventHandler(this.btnSplitPDF_Click);
            // 
            // lblSplitPDF
            // 
            this.lblSplitPDF.AutoSize = true;
            this.lblSplitPDF.Location = new System.Drawing.Point(6, 22);
            this.lblSplitPDF.Name = "lblSplitPDF";
            this.lblSplitPDF.Size = new System.Drawing.Size(91, 13);
            this.lblSplitPDF.TabIndex = 1;
            this.lblSplitPDF.Text = "Enter number of pages to split:";
            // 
            // txtSplitPDF
            // 
            this.txtSplitPDF.Location = new System.Drawing.Point(103, 19);
            this.txtSplitPDF.Name = "txtSplitPDF";
            this.txtSplitPDF.Size = new System.Drawing.Size(100, 20);
            this.txtSplitPDF.TabIndex = 0;
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.btnChooseSrcFile);
            this.grpSource.Controls.Add(this.lblCurrentSrcFile);
            this.grpSource.Location = new System.Drawing.Point(13, 12);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(711, 56);
            this.grpSource.TabIndex = 0;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // btnChooseSrcFile
            // 
            this.btnChooseSrcFile.Location = new System.Drawing.Point(9, 19);
            this.btnChooseSrcFile.Name = "btnChooseSrcFile";
            this.btnChooseSrcFile.Size = new System.Drawing.Size(132, 23);
            this.btnChooseSrcFile.TabIndex = 6;
            this.btnChooseSrcFile.Text = "Choose file";
            this.btnChooseSrcFile.UseVisualStyleBackColor = true;
            this.btnChooseSrcFile.Click += new System.EventHandler(this.btnChooseSrcFile_Click);
            // 
            // lblCurrentSrcFile
            // 
            this.lblCurrentSrcFile.AutoSize = true;
            this.lblCurrentSrcFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSrcFile.Location = new System.Drawing.Point(147, 24);
            this.lblCurrentSrcFile.Name = "lblCurrentSrcFile";
            this.lblCurrentSrcFile.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentSrcFile.TabIndex = 5;
            this.lblCurrentSrcFile.Text = "Current file: ";";
            // 
            // barSplitPDFProgress
            // 
            this.barSplitPDFProgress.Location = new System.Drawing.Point(9, 19);
            this.barSplitPDFProgress.Name = "barSplitPDFProgress";
            this.barSplitPDFProgress.Size = new System.Drawing.Size(695, 35);
            this.barSplitPDFProgress.TabIndex = 0;
            // 
            // grpStartSplit
            // 
            this.grpStartSplit.Controls.Add(this.btnRunSplit);
            this.grpStartSplit.Location = new System.Drawing.Point(13, 160);
            this.grpStartSplit.Name = "grpStartSplit";
            this.grpStartSplit.Size = new System.Drawing.Size(711, 56);
            this.grpStartSplit.TabIndex = 13;
            this.grpStartSplit.TabStop = false;
            this.grpStartSplit.Text = "Start Split";
            // 
            // btnRunSplit
            // 
            this.btnRunSplit.Location = new System.Drawing.Point(9, 20);
            this.btnRunSplit.Name = "btnRunSplit";
            this.btnRunSplit.Size = new System.Drawing.Size(132, 23);
            this.btnRunSplit.TabIndex = 0;
            this.btnRunSplit.Text = "Split";
            this.btnRunSplit.UseVisualStyleBackColor = true;
            this.btnRunSplit.Click += new System.EventHandler(this.btnRunSplit_Click);
            // 
            // backgroundSplitPDF
            // 
            this.backgroundSplitPDF.WorkerReportsProgress = true;
            this.backgroundSplitPDF.WorkerSupportsCancellation = true;
            this.backgroundSplitPDF.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundSplitPDF_DoWork);
            this.backgroundSplitPDF.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundSplitPDF_ProgressChanged);
            this.backgroundSplitPDF.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundSplitPDF_RunWorkerCompleted);
            //             // SplitPdfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 292);
            this.Controls.Add(this.grpStartSplit);
            this.Controls.Add(this.grpSplitPDFProgress);
            this.Controls.Add(this.grpDestination);
            this.Controls.Add(this.grpSource);
            this.Name = "SplitPdfForm";
            this.Text = "Split PDF";
            this.Load += new System.EventHandler(this.OnSplitPDFFormLoad);
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.grpSplitPDFProgress.ResumeLayout(false);
            this.grpStartSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.ComboBox cmbbxSplitPDFDocumentType;
        private System.Windows.Forms.Label lblCurrentSrcDirectory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnChooseSrcDirectory;
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.Button btnChooseDstDirectory;
        private System.Windows.Forms.Label lblCurrentDstDirectory;
        private System.Windows.Forms.GroupBox grpSplitPDFProgress;
        private System.Windows.Forms.ProgressBar barSplitPDFProgress;
        private System.Windows.Forms.GroupBox grpStartSplit;
        private System.Windows.Forms.Button btnRunSplit;
        private System.ComponentModel.BackgroundWorker backgroundSplitPDF;
    }
}