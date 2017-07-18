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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSubscriptionId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlConfigure = new System.Windows.Forms.Panel();
            this.pnlConfigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(1, 184);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(404, 174);
            this.txtLog.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(299, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(99, 13);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subscription Id";
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
            // txtSubscriptionId
            // 
            this.txtSubscriptionId.Location = new System.Drawing.Point(95, 67);
            this.txtSubscriptionId.Name = "txtSubscriptionId";
            this.txtSubscriptionId.Size = new System.Drawing.Size(251, 20);
            this.txtSubscriptionId.TabIndex = 7;
            this.txtSubscriptionId.Text = "bce00b0a-aea5-4354-91e7-87c3851ca2c7";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlConfigure
            // 
            this.pnlConfigure.Controls.Add(this.txtSSID);
            this.pnlConfigure.Controls.Add(this.btnSave);
            this.pnlConfigure.Controls.Add(this.label2);
            this.pnlConfigure.Controls.Add(this.txtSubscriptionId);
            this.pnlConfigure.Controls.Add(this.label3);
            this.pnlConfigure.Controls.Add(this.txtPassword);
            this.pnlConfigure.Controls.Add(this.label4);
            this.pnlConfigure.Location = new System.Drawing.Point(11, 31);
            this.pnlConfigure.Name = "pnlConfigure";
            this.pnlConfigure.Size = new System.Drawing.Size(369, 141);
            this.pnlConfigure.TabIndex = 9;
            this.pnlConfigure.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 364);
            this.Controls.Add(this.pnlConfigure);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Concordia Device Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlConfigure.ResumeLayout(false);
            this.pnlConfigure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSubscriptionId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlConfigure;
    }
}

