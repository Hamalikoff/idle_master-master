﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IdleMaster
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIgnoreClientStatus = new System.Windows.Forms.CheckBox();
            this.chkMinToTray = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radIdleMostValue = new System.Windows.Forms.RadioButton();
            this.radIdleLeastDrops = new System.Windows.Forms.RadioButton();
            this.radIdleMostDrops = new System.Windows.Forms.RadioButton();
            this.radIdleDefault = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ttHints = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.chkShowUsername = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkShowUsername);
            this.groupBox1.Controls.Add(this.chkIgnoreClientStatus);
            this.groupBox1.Controls.Add(this.chkMinToTray);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // chkIgnoreClientStatus
            // 
            this.chkIgnoreClientStatus.AutoSize = true;
            this.chkIgnoreClientStatus.Location = new System.Drawing.Point(7, 44);
            this.chkIgnoreClientStatus.Name = "chkIgnoreClientStatus";
            this.chkIgnoreClientStatus.Size = new System.Drawing.Size(148, 17);
            this.chkIgnoreClientStatus.TabIndex = 1;
            this.chkIgnoreClientStatus.Text = "Ignore Steam client status";
            this.chkIgnoreClientStatus.UseVisualStyleBackColor = true;
            // 
            // chkMinToTray
            // 
            this.chkMinToTray.AutoSize = true;
            this.chkMinToTray.Location = new System.Drawing.Point(7, 20);
            this.chkMinToTray.Name = "chkMinToTray";
            this.chkMinToTray.Size = new System.Drawing.Size(188, 17);
            this.chkMinToTray.TabIndex = 0;
            this.chkMinToTray.Text = "Minimize Idle Master to system tray";
            this.chkMinToTray.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radIdleMostValue);
            this.groupBox2.Controls.Add(this.radIdleLeastDrops);
            this.groupBox2.Controls.Add(this.radIdleMostDrops);
            this.groupBox2.Controls.Add(this.radIdleDefault);
            this.groupBox2.Location = new System.Drawing.Point(13, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idling Order";
            // 
            // radIdleMostValue
            // 
            this.radIdleMostValue.AutoSize = true;
            this.radIdleMostValue.Location = new System.Drawing.Point(7, 35);
            this.radIdleMostValue.Name = "radIdleMostValue";
            this.radIdleMostValue.Size = new System.Drawing.Size(233, 17);
            this.radIdleMostValue.TabIndex = 3;
            this.radIdleMostValue.TabStop = true;
            this.radIdleMostValue.Text = "Prioritize games with the highest card values";
            this.radIdleMostValue.UseVisualStyleBackColor = true;
            // 
            // radIdleLeastDrops
            // 
            this.radIdleLeastDrops.AutoSize = true;
            this.radIdleLeastDrops.Location = new System.Drawing.Point(7, 69);
            this.radIdleLeastDrops.Name = "radIdleLeastDrops";
            this.radIdleLeastDrops.Size = new System.Drawing.Size(295, 17);
            this.radIdleLeastDrops.TabIndex = 2;
            this.radIdleLeastDrops.Text = "Prioritize games with the lowest number of available drops";
            this.radIdleLeastDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleMostDrops
            // 
            this.radIdleMostDrops.AutoSize = true;
            this.radIdleMostDrops.Location = new System.Drawing.Point(7, 52);
            this.radIdleMostDrops.Name = "radIdleMostDrops";
            this.radIdleMostDrops.Size = new System.Drawing.Size(299, 17);
            this.radIdleMostDrops.TabIndex = 1;
            this.radIdleMostDrops.Text = "Prioritize games with the highest number of available drops";
            this.radIdleMostDrops.UseVisualStyleBackColor = true;
            // 
            // radIdleDefault
            // 
            this.radIdleDefault.AutoSize = true;
            this.radIdleDefault.Checked = true;
            this.radIdleDefault.Location = new System.Drawing.Point(7, 18);
            this.radIdleDefault.Name = "radIdleDefault";
            this.radIdleDefault.Size = new System.Drawing.Size(155, 17);
            this.radIdleDefault.TabIndex = 0;
            this.radIdleDefault.TabStop = true;
            this.radIdleDefault.Text = "Default (Alphabetical Order)";
            this.radIdleDefault.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(261, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(180, 231);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Accept";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdvanced.Image = global::IdleMaster.Properties.Resources.imgLock;
            this.btnAdvanced.Location = new System.Drawing.Point(12, 231);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(25, 23);
            this.btnAdvanced.TabIndex = 4;
            this.ttHints.SetToolTip(this.btnAdvanced, "Display advanced authentication information");
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // chkShowUsername
            // 
            this.chkShowUsername.AutoSize = true;
            this.chkShowUsername.Location = new System.Drawing.Point(7, 68);
            this.chkShowUsername.Name = "chkShowUsername";
            this.chkShowUsername.Size = new System.Drawing.Size(219, 17);
            this.chkShowUsername.TabIndex = 2;
            this.chkShowUsername.Text = "Show Steam username of signed on user";
            this.chkShowUsername.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(348, 266);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Idle Master Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkMinToTray;
        private GroupBox groupBox2;
        private RadioButton radIdleLeastDrops;
        private RadioButton radIdleMostDrops;
        private RadioButton radIdleDefault;
        private Button btnCancel;
        private Button btnOK;
        private RadioButton radIdleMostValue;
        private Button btnAdvanced;
        private ToolTip ttHints;
        private CheckBox chkIgnoreClientStatus;
        private CheckBox chkShowUsername;
    }
}