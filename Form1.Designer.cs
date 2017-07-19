namespace Concordia.DeviceManager
{
    partial class Form1
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSaveWifiConfig = new System.Windows.Forms.Button();
            this.pnlWifiConfig = new System.Windows.Forms.Panel();
            this.pnlConcordiaConfig = new System.Windows.Forms.Panel();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.btnSaveConcordiaConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubscriptionId = new System.Windows.Forms.TextBox();
            this.pnlWifiConfig.SuspendLayout();
            this.pnlConcordiaConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(1, 185);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(404, 189);
            this.txtLog.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(155, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(228, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Listening for device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SSID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(95, 15);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(251, 20);
            this.txtSSID.TabIndex = 5;
            this.txtSSID.Text = "Hysonix";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(95, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "champster";
            // 
            // btnSaveWifiConfig
            // 
            this.btnSaveWifiConfig.Location = new System.Drawing.Point(143, 79);
            this.btnSaveWifiConfig.Name = "btnSaveWifiConfig";
            this.btnSaveWifiConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWifiConfig.TabIndex = 8;
            this.btnSaveWifiConfig.Text = "Save";
            this.btnSaveWifiConfig.UseVisualStyleBackColor = true;
            this.btnSaveWifiConfig.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlWifiConfig
            // 
            this.pnlWifiConfig.Controls.Add(this.txtSSID);
            this.pnlWifiConfig.Controls.Add(this.btnSaveWifiConfig);
            this.pnlWifiConfig.Controls.Add(this.label2);
            this.pnlWifiConfig.Controls.Add(this.label3);
            this.pnlWifiConfig.Controls.Add(this.txtPassword);
            this.pnlWifiConfig.Location = new System.Drawing.Point(11, 31);
            this.pnlWifiConfig.Name = "pnlWifiConfig";
            this.pnlWifiConfig.Size = new System.Drawing.Size(369, 120);
            this.pnlWifiConfig.TabIndex = 9;
            this.pnlWifiConfig.Visible = false;
            // 
            // pnlConcordiaConfig
            // 
            this.pnlConcordiaConfig.Controls.Add(this.txtDeviceName);
            this.pnlConcordiaConfig.Controls.Add(this.btnSaveConcordiaConfig);
            this.pnlConcordiaConfig.Controls.Add(this.label1);
            this.pnlConcordiaConfig.Controls.Add(this.label4);
            this.pnlConcordiaConfig.Controls.Add(this.txtSubscriptionId);
            this.pnlConcordiaConfig.Location = new System.Drawing.Point(11, 31);
            this.pnlConcordiaConfig.Name = "pnlConcordiaConfig";
            this.pnlConcordiaConfig.Size = new System.Drawing.Size(369, 120);
            this.pnlConcordiaConfig.TabIndex = 10;
            this.pnlConcordiaConfig.Visible = false;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(95, 15);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(251, 20);
            this.txtDeviceName.TabIndex = 5;
            this.txtDeviceName.Text = "Basement Temp/Humidity";
            // 
            // btnSaveConcordiaConfig
            // 
            this.btnSaveConcordiaConfig.Location = new System.Drawing.Point(143, 79);
            this.btnSaveConcordiaConfig.Name = "btnSaveConcordiaConfig";
            this.btnSaveConcordiaConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConcordiaConfig.TabIndex = 8;
            this.btnSaveConcordiaConfig.Text = "Save";
            this.btnSaveConcordiaConfig.UseVisualStyleBackColor = true;
            this.btnSaveConcordiaConfig.Click += new System.EventHandler(this.btnSaveConcordiaConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subscription ID";
            // 
            // txtSubscriptionId
            // 
            this.txtSubscriptionId.Location = new System.Drawing.Point(95, 41);
            this.txtSubscriptionId.Name = "txtSubscriptionId";
            this.txtSubscriptionId.Size = new System.Drawing.Size(251, 20);
            this.txtSubscriptionId.TabIndex = 6;
            this.txtSubscriptionId.Text = "bce00b0a-aea5-4354-91e7-87c3851ca2c7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 380);
            this.Controls.Add(this.pnlConcordiaConfig);
            this.Controls.Add(this.pnlWifiConfig);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Concordia Device Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlWifiConfig.ResumeLayout(false);
            this.pnlWifiConfig.PerformLayout();
            this.pnlConcordiaConfig.ResumeLayout(false);
            this.pnlConcordiaConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSaveWifiConfig;
        private System.Windows.Forms.Panel pnlWifiConfig;
        private System.Windows.Forms.Panel pnlConcordiaConfig;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Button btnSaveConcordiaConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubscriptionId;
    }
}

