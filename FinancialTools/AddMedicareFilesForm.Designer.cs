ogress.SuspendLayout();
            this.grpAddMedicareFilesStartUpload.SuspendLayout();
            this.grpAddMedicareFilesCriteriaList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddMedicareFilesSource
            // 
            this.grpAddMedicareFilesSource.Controls.Add(this.btnAddMedicareFilesChooseFiles);
            this.grpAddMedicareFilesSource.Location = new System.Drawing.Point(12, 27);
            this.grpAddMedicareFilesSource.Name = "grpAddMedicareFilesSource";
            this.grpAddMedicareFilesSource.Size = new System.Drawing.Size(760, 100);
            this.grpAddMedicareFilesSource.TabIndex = 0;
            this.grpAddMedicareFilesSource.TabStop = false;
            this.grpAddMedicareFilesSource.Text = "Select Medicare Files to Upload";
            // 
            // btnAddMedicareFilesChooseFiles
            // 
            this.btnAddMedicareFilesChooseFiles.Location = new System.Drawing.Point(6, 19);
            this.btnAddMedicareFilesChooseFiles.Name = "btnAddMedicareFilesChooseFiles";
            this.btnAddMedicareFilesChooseFiles.Size = new System.Drawing.Size(143, 23);
            this.btnAddMedicareFilesChooseFiles.TabIndex = 0;
            this.btnAddMedicareFilesChooseFiles.Text = "Choose Files";
            this.btnAddMedicareFilesChooseFiles.UseVisualStyleBackColor = true;
            this.btnAddMedicareFilesChooseFiles.Click += new System.EventHandler(this.btnAddMedicareFilesChooseFiles_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grpAddMedicareFilesProgress
            // 
            this.grpAddMedicareFilesProgress.Controls.Add(this.barAddMedicareFilesProgress);
            this.grpAddMedicareFilesProgress.Location = new System.Drawing.Point(12, 133);
            this.grpAddMedicareFilesProgress.Name = "grpAddMedicareFilesProgress";
            this.grpAddMedicareFilesProgress.Size = new System.Drawing.Size(760, 100);
            this.grpAddMedicareFilesProgress.TabIndex = 2;
            this.grpAddMedicareFilesProgress.TabStop = false;
            this.grpAddMedicareFilesProgress.Text = "Progress";
            // 
            // barAddMedicareFilesProgress
            // 
            this.barAddMedicareFilesProgress.Location = new System.Drawing.Point(6, 19);
            this.barAddMedicareFilesProgress.Name = "barAddMedicareFilesProgress";
            this.barAddMedicareFilesProgress.Size = new System.Drawing.Size(748, 23);
            this.barAddMedicareFilesProgress.TabIndex = 0;
            // 
            // grpAddMedicareFilesStartUpload
            // 
            this.grpAddMedicareFilesStartUpload.Controls.Add(this.btnAddMedicareFilesRunSplit);
            this.grpAddMedicareFilesStartUpload.Location = new System.Drawing.Point(12, 239);
            this.grpAddMedicareFilesStartUpload.Name = "grpAddMedicareFilesStartUpload";
            this.grpAddMedicareFilesStartUpload.Size = new System.Drawing.Size(760, 100);
            this.grpAddMedicareFilesStartUpload.TabIndex = 3;
            this.grpAddMedicareFilesStartUpload.TabStop = false;
            this.grpAddMedicareFilesStartUpload.Text = "Start Upload";
            // 
            // btnAddMedicareFilesRunSplit
            // 
            this.btnAddMedicareFilesRunSplit.Location = new System.Drawing.Point(6, 19);
            this.btnAddMedicareFilesRunSplit.Name = "btnAddMedicareFilesRunSplit";
            this.btnAddMedicareFilesRunSplit.Size = new System.Drawing.Size(143, 23);
            this.btnAddMedicareFilesRunSplit.TabIndex = 0;
            this.btnAddMedicareFilesRunSplit.Text = "Start Upload";
            this.btnAddMedicareFilesRunSplit.UseVisualStyleBackColor = true;
            this.btnAddMedicareFilesRunSplit.Click += new System.EventHandler(this.btnAddMedicareFilesRunSplit_Click);
            // 
            // backgroundAddMedicareFiles
            // 
            this.backgroundAddMedicareFiles.WorkerReportsProgress = true;
            this.backgroundAddMedicareFiles.WorkerSupportsCancellation = true;
            this.backgroundAddMedicareFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundAddMedicareFiles_DoWork);
            this.backgroundAddMedicareFiles.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundAddMedicareFiles_ProgressChanged);
            this.backgroundAddMedicareFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundAddMedicareFiles_RunWorkerCompleted);
            // 
            // grpAddMedicareFilesCriteriaList
            // 
            this.grpAddMedicareFilesCriteriaList.Controls.Add(this.lstbxMedicareFilesToUpload);
            this.grpAddMedicareFilesCriteriaList.Location = new System.Drawing.Point(12, 346);
            this.grpAddMedicareFilesCriteriaList.Name = "grpAddMedicareFilesCriteriaList";
            this.grpgrpAddMedicareFilesCriteriaList.Size = new System.Drawing.Size(760, 100);
            this.grpAddMedicareFilesCriteriaList.TabIndex = 4;
            this.grpAddMedicareFilesCriteriaList.TabStop = false;
            this.grpAddMedicareFilesCriteriaList.Text = "Files to Upload";
            // 
            // lstbxMedicareFilesToUpload
            // 
            this.lstbxMedicareFilesToUpload.FormattingEnabled = true;
            this.lstbxMedicareFilesToUpload.Location = new System.Drawing.Point(6, 19);
            this.lstbxMedicareFilesToUpload.Name = "lstbxMedicareFilesToUpload";
            this.lstbxMedicareFilesToUpload.Size = new System.Drawing.Size(748, 69);
            this.lstbxMedicareFilesToUpload.TabIndex = 0;
            // 
            // dlgMedicareFilesToUpload
            // 
            this.dlgMedicareFilesToUpload.FileName = "dlgMedicareFilesToUpload";
            this.dlgMedicareFilesToUpload.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgMedicareFilesToUpload_FileOk);
            // 
            // AddMedicareFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grpAddMedicareFilesCriteriaList);
            this.Controls.Add(this.grpAddMedicareFilesStartUpload);
            this.Controls.Add(this.grpAddMedicareFilesProgress);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpAddMedicareFilesSource);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddMedicareFilesForm";
            this.Text = "Add Medicare Files";
            this.grpAddMedicareFilesSource.ResumeLayout(false);
            this.grpAddMedicareFilesProgress.ResumeLayout(false);
            this.grpAddMedicareFilesStartUpload.ResumeLayout(false);
            this.grpAddMedicareFilesCriteriaList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Systemthis.grpAddMedicareFilesProgress.SuspendLayout();
            this.grpAddMedicareFilesStartUpload.SuspendLayout();
            this.grpAddMedicareFilesCriteriaList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddMedicareFilesSource
            // 
            this.grpAddMedicareFilesSource.Controls.Add(this.btnAddMedicareFilesChooseFiles);
            this.grpAddMedicareFilesSource.Controls.Add(this.menuStrip1);
            this.grpAddMedicareFilesSource.Location = new System.Drawing.Point(12, 240);
            this.grpAddMedicareFilesSource.Name = "grpAddMedicareFilesSource";
            this.grpAddMedicareFilesSource.Size = new System.Drawing.Size(711, 53);
            this.grpAddMedicareFilesSource.TabIndex = 0;
            this.grpAddMedicareFilesSource.TabStop = false;
            this.grpAddMedicareFilesSource.Text = "Source";
            // 
            // btnAddMedicareFilesChooseFiles
            // 
            this.btnAddMedicareFilesChooseFiles.Location = new System.Drawing.Point(6, 19);
            this.btnAddMedicareFilesChooseFiles.Name = "btnAddMedicareFilesChooseFiles";
            this.btnAddMedicareFilesChooseFiles.Size = new System.Drawing.Size(132, 23);
            this.btnAddMedicareFilesChooseFiles.TabIndex = 4;
            this.btnAddMedicareFilesChooseFiles.Text = "Choose file(s)";
            this.btnAddMedicareFilesChooseFiles.UseVisualStyleBackColor = true;
            this.btnAddMedicareFilesChooseFiles.Click += new System.EventHandler(this.btnChooseSrcDirectory_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grpAddMedicareFilesProgressthis.grpAddMedicareFilesProgress.Controls.Add(this.barAddMedicareFilesProgress);
            this.grpAddMedicareFilesProgress.Location = new System.Drawing.Point(12, 361);
            this.grpAddMedicareFilesProgress.Name = "grpAddMedicareFilesProgress";
            this.grpAddMedicareFilesProgress.Size = new System.Drawing.Size(711, 60);
            this.grpAddMedicareFilesProgress.TabIndex = 12;
            this.grpAddMedicareFilesProgress.TabStop = false;
            this.grpAddMedicareFilesProgress.Text = "Progress";
            
            this.barAddMedicareFilesProgress.Location = new System.Drawing.Point(9, 19);
            this.barAddMedicareFilesProgress.Name = "barAddMedicareFilesProgress";
            this.barAddMedicareFilesProgress.Size = new System.Drawing.Size(695, 35);
            this.barAddMedicareFilesProgress.TabIndex = 0;
            
            this.grpAddMedicareFilesStartUpload.Controls.Add(this.btnAddMedicareFilesRunSplit);
            this.grpAddMedicareFilesStartUpload.Location = new System.Drawing.Point(12, 299);
            this.grpAddMedicareFilesStartUpload.Name = "grpAddMedicareFilesStartUpload";
            this.grpAddMedicareFilesStartUpload.Size = new System.Drawing.Size(711, 56);
            this.grpAddMedicareFilesStartUpload.TabIndex = 13;
            this.grpAddMedicareFilesStartUpload.TabStop = false;
            this.grpAddMedicareFilesStartUpload.Text = "Start Upload";
            
            this.btnAddMedicareFilesRunSplit.Location = new System.Drawing.Point(9, 20);
            this.btnAddMedicareFilesRunSplit.Name = "btnAddMedicareFilesRunSplit";
            this.btnAddMedicareFilesRunSplit.Size = new System.Drawing.Size(132, 23);
            this.btnAddMedicareFilesRunSplit.TabIndex = 0; this.lstbxMedicareFilesToUpload.Size(692, 186);
            this.lstbxMedicareFilesToUpload.TabIndex = 0;
            // 
            // btnAddMedicareFilesRemove
            // 
            this.btnAddMedicareFilesRemove.Location = new System.Drawing.Point(12, 240);
            this.btnAddMedicareFilesRemove.Name = "btnAddMedicareFilesRemove";
            this.btnAddMedicareFilesRemove.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedicareFilesRemove.TabIndex = 15;
            this.btnAddMedicareFilesRemove.Text = "Remove";
            this.btnAddMedicareFilesRemove.UseVisualStyleBackColor = true;
            this.btnAddMedicareFilesRemove.Click += new System.EventHandler(this.btnAddMedicareFilesRemove_Click);
            // 
            // btnAddMedicareFilesClear
            // 
            this.btnAddMedicareFilesClear.Location = new System.Drawing.Point(93, 240);
            this.btnAddMedicareFilesClear.Name = "btnAddMedicareFilesClear";
            this.btnAddMedicareFilesClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedicareFilesClear.TabIndex = 16;
            this.btnAddMedicareFilesClear.Text = "Clear";
            this.btnAddMedicareFilesClear.UseVisualStyleBackColor = true;
            this.btnAddMedicareFilesClear.Click += new System.EventHandler(this.btnAddMedicareFilesClear_Click);
            // 
            // btnAddMedicareFilesRunSplit
            // 
            this.btnAddMedicareFilesRunSplit.Location = new System.Drawing.Point(174, 240);
            this.btnAddMedicareFilesRunSplit.Name = "btnAddMedicareFilesRunSplit";
            this.btnAddMedicareFilesRunSplit.Size = new System.Drawing.Size(75, 23);
            this.btnAddMedicareFilesRunSplit.TabIndex = 17;System.Drawing.Size(695, 186);
            this.lstbxMedicareFilesToUpload.TabIndex = 0;
            // 
            // dlgMedicareFilesToUpload
            // 
            this.dlgMedicareFilesToUpload.Filter = "Text (*.TXT;*.CSV)|*.TXT;*.CSV|All files (*.*)|*.*";
            this.dlgMedicareFilesToUpload.Multiselect = true;
            this.dlgMedicareFilesToUpload.Title = "Select text file(s) to upload";
            // 
            // AddMedicareFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 427);
            this.Controls.Add(this.grpAddMedicareFilesCriteriaList);
            this.Controls.Add(this.grpAddMedicareFilesStartUpload);
            this.Controls.Add(this.grpAddMedicareFilesProgress);
            this.Controls.Add(this.grpAddMedicareFilesSource);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddMedicareFilesForm";
            this.Text = "Medicare Files Upload";
            this.Load += new System.EventHandler(this.OnAddMedicareFilesFormLoad);
            this.grpAddMedicareFilesSource.ResumeLayout(false);
            this.grpAddMedicareFilesSource.PerformLayout();
            this.grpAddMedicareFilesProgress.ResumeLayout(false);
            this.grpAddMedicareFilesStartUpload.ResumeLayout(false);
            this.grpAddMedicareFilesCriteriaList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddMedicareFilesSource;
        private System.Windows.Forms.Button btnAddMedicareFilesChooseFiles;
        private System.Windows.Forms.GroupBox grpAddMedicareFilesProgress;
        private System.Windows.Forms.ProgressBar barAddMedicareFilesProgress;
        private System.Windows.Forms.GroupBox grpAddMedicareFilesStartUpload;
        private System.Windows.Forms.Button btnAddFilesRunSplit;
        private System.ComponentModel.BackgroundWorker backgroundAddFiles;
        private System.Windows.Forms.GroupBox grpAddFilesCriteriaList;
        private System.Windows.Forms.ListBox lstbxFilesToUpload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog dlgFilesToUpload;
    }
}