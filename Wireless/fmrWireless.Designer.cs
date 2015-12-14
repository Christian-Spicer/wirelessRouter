namespace Wireless
{
    partial class fmrWireless
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrWireless));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.ttbSSID = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNetWorkTypes = new System.Windows.Forms.ComboBox();
            this.cbbPermission = new System.Windows.Forms.ComboBox();
            this.cbbAddDelete = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.btnBlockedSSIDInfo = new System.Windows.Forms.Button();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ttbSSIDName = new System.Windows.Forms.TextBox();
            this.grbMianControls = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbKeyUsage = new System.Windows.Forms.ComboBox();
            this.ntITaskbar = new System.Windows.Forms.NotifyIcon(this.components);
            this.grbFilter.SuspendLayout();
            this.grbMianControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(225, 109);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(181, 28);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(119, 23);
            this.btnInformation.TabIndex = 1;
            this.btnInformation.Text = "Network Info";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // ttbSSID
            // 
            this.ttbSSID.Location = new System.Drawing.Point(95, 83);
            this.ttbSSID.Name = "ttbSSID";
            this.ttbSSID.Size = new System.Drawing.Size(121, 20);
            this.ttbSSID.TabIndex = 2;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(225, 54);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SSID ";
            // 
            // ttbPassword
            // 
            this.ttbPassword.Location = new System.Drawing.Point(95, 57);
            this.ttbPassword.Name = "ttbPassword";
            this.ttbPassword.Size = new System.Drawing.Size(121, 20);
            this.ttbPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // cbbMode
            // 
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Items.AddRange(new object[] {
            "Allow",
            "Disallow"});
            this.cbbMode.Location = new System.Drawing.Point(95, 30);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(80, 21);
            this.cbbMode.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mode On/Off";
            // 
            // cbbNetWorkTypes
            // 
            this.cbbNetWorkTypes.FormattingEnabled = true;
            this.cbbNetWorkTypes.Items.AddRange(new object[] {
            "Infrastructure",
            "Adhoc"});
            this.cbbNetWorkTypes.Location = new System.Drawing.Point(94, 38);
            this.cbbNetWorkTypes.Name = "cbbNetWorkTypes";
            this.cbbNetWorkTypes.Size = new System.Drawing.Size(121, 21);
            this.cbbNetWorkTypes.TabIndex = 9;
            // 
            // cbbPermission
            // 
            this.cbbPermission.FormattingEnabled = true;
            this.cbbPermission.Items.AddRange(new object[] {
            "Allow",
            "Block",
            "Denyall"});
            this.cbbPermission.Location = new System.Drawing.Point(221, 38);
            this.cbbPermission.Name = "cbbPermission";
            this.cbbPermission.Size = new System.Drawing.Size(121, 21);
            this.cbbPermission.TabIndex = 10;
            // 
            // cbbAddDelete
            // 
            this.cbbAddDelete.FormattingEnabled = true;
            this.cbbAddDelete.Items.AddRange(new object[] {
            "Add",
            "Delete"});
            this.cbbAddDelete.Location = new System.Drawing.Point(351, 38);
            this.cbbAddDelete.Name = "cbbAddDelete";
            this.cbbAddDelete.Size = new System.Drawing.Size(82, 21);
            this.cbbAddDelete.TabIndex = 11;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(12, 36);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Network Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Permission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Add/Delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SSID Filter";
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.btnBlockedSSIDInfo);
            this.grbFilter.Controls.Add(this.btnShowHide);
            this.grbFilter.Controls.Add(this.label9);
            this.grbFilter.Controls.Add(this.ttbSSIDName);
            this.grbFilter.Controls.Add(this.cbbPermission);
            this.grbFilter.Controls.Add(this.label7);
            this.grbFilter.Controls.Add(this.cbbNetWorkTypes);
            this.grbFilter.Controls.Add(this.label6);
            this.grbFilter.Controls.Add(this.cbbAddDelete);
            this.grbFilter.Controls.Add(this.label5);
            this.grbFilter.Controls.Add(this.btnFilter);
            this.grbFilter.Controls.Add(this.label4);
            this.grbFilter.Location = new System.Drawing.Point(12, 12);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(553, 113);
            this.grbFilter.TabIndex = 17;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "SSID filter";
            // 
            // btnBlockedSSIDInfo
            // 
            this.btnBlockedSSIDInfo.Location = new System.Drawing.Point(225, 66);
            this.btnBlockedSSIDInfo.Name = "btnBlockedSSIDInfo";
            this.btnBlockedSSIDInfo.Size = new System.Drawing.Size(75, 23);
            this.btnBlockedSSIDInfo.TabIndex = 20;
            this.btnBlockedSSIDInfo.Text = "Filter Info";
            this.btnBlockedSSIDInfo.UseVisualStyleBackColor = true;
            this.btnBlockedSSIDInfo.Click += new System.EventHandler(this.btnBlockedSSIDInfo_Click);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(12, 66);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(158, 23);
            this.btnShowHide.TabIndex = 19;
            this.btnShowHide.Text = "Show SSID";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(462, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "SSID Name";
            // 
            // ttbSSIDName
            // 
            this.ttbSSIDName.Location = new System.Drawing.Point(439, 38);
            this.ttbSSIDName.Name = "ttbSSIDName";
            this.ttbSSIDName.Size = new System.Drawing.Size(98, 20);
            this.ttbSSIDName.TabIndex = 17;
            // 
            // grbMianControls
            // 
            this.grbMianControls.Controls.Add(this.btnStop);
            this.grbMianControls.Controls.Add(this.label8);
            this.grbMianControls.Controls.Add(this.cbbKeyUsage);
            this.grbMianControls.Controls.Add(this.cbbMode);
            this.grbMianControls.Controls.Add(this.btnStart);
            this.grbMianControls.Controls.Add(this.label3);
            this.grbMianControls.Controls.Add(this.btnInformation);
            this.grbMianControls.Controls.Add(this.ttbSSID);
            this.grbMianControls.Controls.Add(this.label2);
            this.grbMianControls.Controls.Add(this.btnSet);
            this.grbMianControls.Controls.Add(this.ttbPassword);
            this.grbMianControls.Controls.Add(this.label1);
            this.grbMianControls.Location = new System.Drawing.Point(12, 195);
            this.grbMianControls.Name = "grbMianControls";
            this.grbMianControls.Size = new System.Drawing.Size(321, 179);
            this.grbMianControls.TabIndex = 18;
            this.grbMianControls.TabStop = false;
            this.grbMianControls.Text = "Main Controls";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(225, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Key Usage";
            // 
            // cbbKeyUsage
            // 
            this.cbbKeyUsage.FormattingEnabled = true;
            this.cbbKeyUsage.Items.AddRange(new object[] {
            "Persistent",
            "Temporary"});
            this.cbbKeyUsage.Location = new System.Drawing.Point(95, 109);
            this.cbbKeyUsage.Name = "cbbKeyUsage";
            this.cbbKeyUsage.Size = new System.Drawing.Size(121, 21);
            this.cbbKeyUsage.TabIndex = 9;
            // 
            // ntITaskbar
            // 
            this.ntITaskbar.Icon = ((System.Drawing.Icon)(resources.GetObject("ntITaskbar.Icon")));
            this.ntITaskbar.Text = "Wireless Router";
            this.ntITaskbar.Visible = true;
            this.ntITaskbar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntITaskbar_MouseDoubleClick);
            // 
            // fmrWireless
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 399);
            this.Controls.Add(this.grbMianControls);
            this.Controls.Add(this.grbFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrWireless";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Christians Wireless Hotspot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmrWireless_FormClosed);
            this.Load += new System.EventHandler(this.fmrWireless_Load);
            this.Resize += new System.EventHandler(this.fmrWireless_Resize);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.grbMianControls.ResumeLayout(false);
            this.grbMianControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.TextBox ttbSSID;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNetWorkTypes;
        private System.Windows.Forms.ComboBox cbbPermission;
        private System.Windows.Forms.ComboBox cbbAddDelete;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.ComboBox cbbKeyUsage;
        private System.Windows.Forms.GroupBox grbMianControls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbSSIDName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBlockedSSIDInfo;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.NotifyIcon ntITaskbar;
    }
}

