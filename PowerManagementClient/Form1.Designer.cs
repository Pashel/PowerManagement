namespace PowerManagementClient
{
    partial class PowerManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LastSleepTime = new System.Windows.Forms.Button();
            this.LastWakeTime = new System.Windows.Forms.Button();
            this.SystemBatteryState = new System.Windows.Forms.Button();
            this.SystemPowerInformation = new System.Windows.Forms.Button();
            this.ReserveHibernationFile = new System.Windows.Forms.Button();
            this.DeleteHibernationFile = new System.Windows.Forms.Button();
            this.HibernateSystem = new System.Windows.Forms.Button();
            this.SuspendSystem = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LastSleepTime
            // 
            this.LastSleepTime.Location = new System.Drawing.Point(12, 12);
            this.LastSleepTime.Name = "LastSleepTime";
            this.LastSleepTime.Size = new System.Drawing.Size(151, 23);
            this.LastSleepTime.TabIndex = 0;
            this.LastSleepTime.Text = "LastSleepTime";
            this.LastSleepTime.UseVisualStyleBackColor = true;
            this.LastSleepTime.Click += new System.EventHandler(this.LastSleepTime_Click);
            // 
            // LastWakeTime
            // 
            this.LastWakeTime.Location = new System.Drawing.Point(12, 41);
            this.LastWakeTime.Name = "LastWakeTime";
            this.LastWakeTime.Size = new System.Drawing.Size(151, 23);
            this.LastWakeTime.TabIndex = 1;
            this.LastWakeTime.Text = "LastWakeTime";
            this.LastWakeTime.UseVisualStyleBackColor = true;
            this.LastWakeTime.Click += new System.EventHandler(this.LastWakeTime_Click);
            // 
            // SystemBatteryState
            // 
            this.SystemBatteryState.Location = new System.Drawing.Point(12, 70);
            this.SystemBatteryState.Name = "SystemBatteryState";
            this.SystemBatteryState.Size = new System.Drawing.Size(151, 23);
            this.SystemBatteryState.TabIndex = 2;
            this.SystemBatteryState.Text = "SystemBatteryState";
            this.SystemBatteryState.UseVisualStyleBackColor = true;
            this.SystemBatteryState.Click += new System.EventHandler(this.SystemBatteryState_Click);
            // 
            // SystemPowerInformation
            // 
            this.SystemPowerInformation.Location = new System.Drawing.Point(12, 99);
            this.SystemPowerInformation.Name = "SystemPowerInformation";
            this.SystemPowerInformation.Size = new System.Drawing.Size(151, 23);
            this.SystemPowerInformation.TabIndex = 3;
            this.SystemPowerInformation.Text = "SystemPowerInformation";
            this.SystemPowerInformation.UseVisualStyleBackColor = true;
            this.SystemPowerInformation.Click += new System.EventHandler(this.SystemPowerInformation_Click);
            // 
            // ReserveHibernationFile
            // 
            this.ReserveHibernationFile.Location = new System.Drawing.Point(189, 41);
            this.ReserveHibernationFile.Name = "ReserveHibernationFile";
            this.ReserveHibernationFile.Size = new System.Drawing.Size(147, 23);
            this.ReserveHibernationFile.TabIndex = 4;
            this.ReserveHibernationFile.Text = "ReserveHibernationFile";
            this.ReserveHibernationFile.UseVisualStyleBackColor = true;
            this.ReserveHibernationFile.Click += new System.EventHandler(this.ReserveHibernationFile_Click);
            // 
            // DeleteHibernationFile
            // 
            this.DeleteHibernationFile.Location = new System.Drawing.Point(189, 70);
            this.DeleteHibernationFile.Name = "DeleteHibernationFile";
            this.DeleteHibernationFile.Size = new System.Drawing.Size(147, 23);
            this.DeleteHibernationFile.TabIndex = 5;
            this.DeleteHibernationFile.Text = "DeleteHibernationFile";
            this.DeleteHibernationFile.UseVisualStyleBackColor = true;
            this.DeleteHibernationFile.Click += new System.EventHandler(this.DeleteHibernationFile_Click);
            // 
            // HibernateSystem
            // 
            this.HibernateSystem.Location = new System.Drawing.Point(362, 41);
            this.HibernateSystem.Name = "HibernateSystem";
            this.HibernateSystem.Size = new System.Drawing.Size(116, 23);
            this.HibernateSystem.TabIndex = 6;
            this.HibernateSystem.Text = "HibernateSystem";
            this.HibernateSystem.UseVisualStyleBackColor = true;
            this.HibernateSystem.Click += new System.EventHandler(this.HibernateSystem_Click);
            // 
            // SuspendSystem
            // 
            this.SuspendSystem.Location = new System.Drawing.Point(362, 70);
            this.SuspendSystem.Name = "SuspendSystem";
            this.SuspendSystem.Size = new System.Drawing.Size(116, 23);
            this.SuspendSystem.TabIndex = 7;
            this.SuspendSystem.Text = "SuspendSystem";
            this.SuspendSystem.UseVisualStyleBackColor = true;
            this.SuspendSystem.Click += new System.EventHandler(this.SuspendSystem_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.White;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Output.Location = new System.Drawing.Point(0, 137);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(491, 209);
            this.Output.TabIndex = 8;
            this.Output.Text = "";
            // 
            // PowerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 346);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.SuspendSystem);
            this.Controls.Add(this.HibernateSystem);
            this.Controls.Add(this.DeleteHibernationFile);
            this.Controls.Add(this.ReserveHibernationFile);
            this.Controls.Add(this.SystemPowerInformation);
            this.Controls.Add(this.SystemBatteryState);
            this.Controls.Add(this.LastWakeTime);
            this.Controls.Add(this.LastSleepTime);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(507, 385);
            this.MinimumSize = new System.Drawing.Size(507, 385);
            this.Name = "PowerManagementForm";
            this.Text = "Power Management Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LastSleepTime;
        private System.Windows.Forms.Button LastWakeTime;
        private System.Windows.Forms.Button SystemBatteryState;
        private System.Windows.Forms.Button SystemPowerInformation;
        private System.Windows.Forms.Button ReserveHibernationFile;
        private System.Windows.Forms.Button DeleteHibernationFile;
        private System.Windows.Forms.Button HibernateSystem;
        private System.Windows.Forms.Button SuspendSystem;
        private System.Windows.Forms.RichTextBox Output;
    }
}

