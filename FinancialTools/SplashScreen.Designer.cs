kColor = System.Drawing.Color.Transparent;
            this.pnlStatus.Location = new System.Drawing.Point(317, 438);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(279, 14);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblOMIGIndexTimeRemaining
            // 
            this.lblOMIGIndexTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblOMIGIndexTimeRemaining.Location = new System.Drawing.Point(317, 438);
            this.lblOMIGIndexTimeRemaining.Name = "lblOMIGIndexTimeRemaining";
            this.lblOMIGIndexTimeRemaining.Size = new System.Drawing.Size(279, 14);
            this.lblOMIGIndexTimeRemaining.TabIndex = 2;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Location = new System.Drawing.Point(317, 438);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(279, 14);
            this.lblCopyright.TabIndex = 3;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinancialTools.Properties.Resources.SplashScreen;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblOMIGIndexTimeRemaining);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.ResumeLayout(false);

        }

		#endregion
	}
}kColor = System.Drawing.Color.Transparent;
            this.pnlStatus.Location = new System.Drawing.Point(320, 375);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(441, 42);
            this.pnlStatus.TabIndex = 1;
            //this.pnlStatus.DoubleClick += new System.EventHandler(this.SplashScreen_DoubleClick);
            // 
            // lblOMIGIndexTimeRemaining
            // 
            this.lblOMIGIndexTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblOMIGIndexTimeRemaining.Location = new System.Drawing.Point(317, 420);
            this.lblOMIGIndexTimeRemaining.Name = "lblOMIGIndexTimeRemaining";
            this.lblOMIGIndexTimeRemaining.Size = new System.Drawing.Size(279, 16);
            this.lblOMIGIndexTimeRemaining.TabIndex = 2;
            this.lblOMIGIndexTimeRemaining.Text = "Time remaining";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCopyright.Location = new System.Drawing.Point(483, 439);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(334, 13);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "Centene Finance Department Tool by Yael Demedetskaya";
            // 
            // SplashScreen
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(820, 461);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblOMIGIndexTimeRemaining);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            //this.DoubleClick += new System.EventHandler(this.SplashScreen_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOMIGIndexTimeRemaining;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Panel pnlStatus;
        private Label lblCopyright;
    }
}