namespace CES_Service_Manager
{
    partial class Form_EnvironmentJenkins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EnvironmentJenkins));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.textEdit_Form_EnvironmentJenkins_Link = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Form_EnvironmentJenkins_Link = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Form_ServerSettings_SaveSettings = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_Form_EnvironmentJenkins_NoServers = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Form_EnvironmentJenkins_AddServer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Form_EnvironmentJenkins_RemoveServer = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Form_EnvironmentJenkins_ModifyServer = new DevExpress.XtraEditors.SimpleButton();
            this.panel_Form_EnvironmentJenkins_AddServer = new System.Windows.Forms.Panel();
            this.labelControl_Form_EnvironmentJenkins_JenkinsName = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_Form_EnvironmentJenkins_JenkinsName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Form_EnvironmentJenkins_ServerList = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_EnvironmentJenkins_Link.Properties)).BeginInit();
            this.panel_Form_EnvironmentJenkins_AddServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_EnvironmentJenkins_JenkinsName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Dark Side";
            // 
            // textEdit_Form_EnvironmentJenkins_Link
            // 
            this.textEdit_Form_EnvironmentJenkins_Link.EditValue = "For example: http://jenkins.epam.com";
            this.textEdit_Form_EnvironmentJenkins_Link.Location = new System.Drawing.Point(3, 83);
            this.textEdit_Form_EnvironmentJenkins_Link.Name = "textEdit_Form_EnvironmentJenkins_Link";
            this.textEdit_Form_EnvironmentJenkins_Link.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.textEdit_Form_EnvironmentJenkins_Link.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_Form_EnvironmentJenkins_Link.Size = new System.Drawing.Size(277, 20);
            this.textEdit_Form_EnvironmentJenkins_Link.TabIndex = 2;
            this.textEdit_Form_EnvironmentJenkins_Link.Click += new System.EventHandler(this.textEdit_Form_EnvironmentJenkins_Link_Click);
            // 
            // labelControl_Form_EnvironmentJenkins_Link
            // 
            this.labelControl_Form_EnvironmentJenkins_Link.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_EnvironmentJenkins_Link.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_EnvironmentJenkins_Link.Location = new System.Drawing.Point(3, 64);
            this.labelControl_Form_EnvironmentJenkins_Link.Name = "labelControl_Form_EnvironmentJenkins_Link";
            this.labelControl_Form_EnvironmentJenkins_Link.Size = new System.Drawing.Size(118, 13);
            this.labelControl_Form_EnvironmentJenkins_Link.TabIndex = 3;
            this.labelControl_Form_EnvironmentJenkins_Link.Text = "Jenkins http address";
            // 
            // labelControl_Form_ServerSettings_SaveSettings
            // 
            this.labelControl_Form_ServerSettings_SaveSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Form_ServerSettings_SaveSettings.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_ServerSettings_SaveSettings.Location = new System.Drawing.Point(303, 46);
            this.labelControl_Form_ServerSettings_SaveSettings.Name = "labelControl_Form_ServerSettings_SaveSettings";
            this.labelControl_Form_ServerSettings_SaveSettings.Size = new System.Drawing.Size(66, 11);
            this.labelControl_Form_ServerSettings_SaveSettings.TabIndex = 19;
            this.labelControl_Form_ServerSettings_SaveSettings.Text = "Save settings";
            // 
            // simpleButton_Form_EnvironmentJenkins_SaveSettings
            // 
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Form_EnvironmentJenkins_SaveSettings.Image")));
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Location = new System.Drawing.Point(316, 63);
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Name = "simpleButton_Form_EnvironmentJenkins_SaveSettings";
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Size = new System.Drawing.Size(40, 40);
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.TabIndex = 18;
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Click += new System.EventHandler(this.simpleButton_Form_EnvironmentJenkins_SaveSettings_Click);
            // 
            // labelControl_Form_EnvironmentJenkins_NoServers
            // 
            this.labelControl_Form_EnvironmentJenkins_NoServers.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_EnvironmentJenkins_NoServers.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl_Form_EnvironmentJenkins_NoServers.Location = new System.Drawing.Point(15, 63);
            this.labelControl_Form_EnvironmentJenkins_NoServers.Name = "labelControl_Form_EnvironmentJenkins_NoServers";
            this.labelControl_Form_EnvironmentJenkins_NoServers.Size = new System.Drawing.Size(172, 13);
            this.labelControl_Form_EnvironmentJenkins_NoServers.TabIndex = 20;
            this.labelControl_Form_EnvironmentJenkins_NoServers.Text = "No configured Jenkins servers ";
            // 
            // simpleButton_Form_EnvironmentJenkins_AddServer
            // 
            this.simpleButton_Form_EnvironmentJenkins_AddServer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Form_EnvironmentJenkins_AddServer.Image")));
            this.simpleButton_Form_EnvironmentJenkins_AddServer.Location = new System.Drawing.Point(13, 25);
            this.simpleButton_Form_EnvironmentJenkins_AddServer.Name = "simpleButton_Form_EnvironmentJenkins_AddServer";
            this.simpleButton_Form_EnvironmentJenkins_AddServer.Size = new System.Drawing.Size(119, 23);
            this.simpleButton_Form_EnvironmentJenkins_AddServer.TabIndex = 21;
            this.simpleButton_Form_EnvironmentJenkins_AddServer.Text = "Add Server";
            this.simpleButton_Form_EnvironmentJenkins_AddServer.Click += new System.EventHandler(this.simpleButton_Form_EnvironmentJenkins_AddServer_Click);
            // 
            // simpleButton_Form_EnvironmentJenkins_RemoveServer
            // 
            this.simpleButton_Form_EnvironmentJenkins_RemoveServer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Form_EnvironmentJenkins_RemoveServer.Image")));
            this.simpleButton_Form_EnvironmentJenkins_RemoveServer.Location = new System.Drawing.Point(166, 25);
            this.simpleButton_Form_EnvironmentJenkins_RemoveServer.Name = "simpleButton_Form_EnvironmentJenkins_RemoveServer";
            this.simpleButton_Form_EnvironmentJenkins_RemoveServer.Size = new System.Drawing.Size(119, 23);
            this.simpleButton_Form_EnvironmentJenkins_RemoveServer.TabIndex = 22;
            this.simpleButton_Form_EnvironmentJenkins_RemoveServer.Text = "Remove Server";
            // 
            // simpleButton_Form_EnvironmentJenkins_ModifyServer
            // 
            this.simpleButton_Form_EnvironmentJenkins_ModifyServer.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Form_EnvironmentJenkins_ModifyServer.Image")));
            this.simpleButton_Form_EnvironmentJenkins_ModifyServer.Location = new System.Drawing.Point(315, 25);
            this.simpleButton_Form_EnvironmentJenkins_ModifyServer.Name = "simpleButton_Form_EnvironmentJenkins_ModifyServer";
            this.simpleButton_Form_EnvironmentJenkins_ModifyServer.Size = new System.Drawing.Size(119, 23);
            this.simpleButton_Form_EnvironmentJenkins_ModifyServer.TabIndex = 23;
            this.simpleButton_Form_EnvironmentJenkins_ModifyServer.Text = "Modify Server";
            // 
            // panel_Form_EnvironmentJenkins_AddServer
            // 
            this.panel_Form_EnvironmentJenkins_AddServer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Form_EnvironmentJenkins_AddServer.Controls.Add(this.labelControl_Form_EnvironmentJenkins_JenkinsName);
            this.panel_Form_EnvironmentJenkins_AddServer.Controls.Add(this.textEdit_Form_EnvironmentJenkins_JenkinsName);
            this.panel_Form_EnvironmentJenkins_AddServer.Controls.Add(this.labelControl_Form_EnvironmentJenkins_Link);
            this.panel_Form_EnvironmentJenkins_AddServer.Controls.Add(this.textEdit_Form_EnvironmentJenkins_Link);
            this.panel_Form_EnvironmentJenkins_AddServer.Controls.Add(this.simpleButton_Form_EnvironmentJenkins_SaveSettings);
            this.panel_Form_EnvironmentJenkins_AddServer.Controls.Add(this.labelControl_Form_ServerSettings_SaveSettings);
            this.panel_Form_EnvironmentJenkins_AddServer.Location = new System.Drawing.Point(14, 164);
            this.panel_Form_EnvironmentJenkins_AddServer.Name = "panel_Form_EnvironmentJenkins_AddServer";
            this.panel_Form_EnvironmentJenkins_AddServer.Size = new System.Drawing.Size(388, 121);
            this.panel_Form_EnvironmentJenkins_AddServer.TabIndex = 24;
            this.panel_Form_EnvironmentJenkins_AddServer.Visible = false;
            // 
            // labelControl_Form_EnvironmentJenkins_JenkinsName
            // 
            this.labelControl_Form_EnvironmentJenkins_JenkinsName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_EnvironmentJenkins_JenkinsName.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_EnvironmentJenkins_JenkinsName.Location = new System.Drawing.Point(3, 8);
            this.labelControl_Form_EnvironmentJenkins_JenkinsName.Name = "labelControl_Form_EnvironmentJenkins_JenkinsName";
            this.labelControl_Form_EnvironmentJenkins_JenkinsName.Size = new System.Drawing.Size(78, 13);
            this.labelControl_Form_EnvironmentJenkins_JenkinsName.TabIndex = 12;
            this.labelControl_Form_EnvironmentJenkins_JenkinsName.Text = "Jenkins Name";
            // 
            // textEdit_Form_EnvironmentJenkins_JenkinsName
            // 
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.EditValue = "May be any";
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.Location = new System.Drawing.Point(3, 27);
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.Name = "textEdit_Form_EnvironmentJenkins_JenkinsName";
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.Size = new System.Drawing.Size(170, 20);
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.TabIndex = 11;
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.Click += new System.EventHandler(this.textEdit_Form_EnvironmentJenkins_JenkinsName_Click);
            // 
            // labelControl_Form_EnvironmentJenkins_ConfiguredServers
            // 
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Location = new System.Drawing.Point(15, 63);
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Name = "labelControl_Form_EnvironmentJenkins_ConfiguredServers";
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Size = new System.Drawing.Size(148, 18);
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.TabIndex = 25;
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Text = "Configured servers:";
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Visible = false;
            // 
            // labelControl_Form_EnvironmentJenkins_ServerList
            // 
            this.labelControl_Form_EnvironmentJenkins_ServerList.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Form_EnvironmentJenkins_ServerList.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelControl_Form_EnvironmentJenkins_ServerList.Location = new System.Drawing.Point(15, 84);
            this.labelControl_Form_EnvironmentJenkins_ServerList.Name = "labelControl_Form_EnvironmentJenkins_ServerList";
            this.labelControl_Form_EnvironmentJenkins_ServerList.Size = new System.Drawing.Size(19, 16);
            this.labelControl_Form_EnvironmentJenkins_ServerList.TabIndex = 26;
            this.labelControl_Form_EnvironmentJenkins_ServerList.Text = "list";
            this.labelControl_Form_EnvironmentJenkins_ServerList.Visible = false;
            // 
            // Form_EnvironmentJenkins
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 366);
            this.Controls.Add(this.labelControl_Form_EnvironmentJenkins_ServerList);
            this.Controls.Add(this.labelControl_Form_EnvironmentJenkins_ConfiguredServers);
            this.Controls.Add(this.panel_Form_EnvironmentJenkins_AddServer);
            this.Controls.Add(this.simpleButton_Form_EnvironmentJenkins_ModifyServer);
            this.Controls.Add(this.simpleButton_Form_EnvironmentJenkins_RemoveServer);
            this.Controls.Add(this.simpleButton_Form_EnvironmentJenkins_AddServer);
            this.Controls.Add(this.labelControl_Form_EnvironmentJenkins_NoServers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_EnvironmentJenkins";
            this.Text = "Jenkins Environment Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_EnvironmentJenkins_Link.Properties)).EndInit();
            this.panel_Form_EnvironmentJenkins_AddServer.ResumeLayout(false);
            this.panel_Form_EnvironmentJenkins_AddServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_EnvironmentJenkins_JenkinsName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraEditors.TextEdit textEdit_Form_EnvironmentJenkins_Link;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_EnvironmentJenkins_Link;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_ServerSettings_SaveSettings;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_EnvironmentJenkins_SaveSettings;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_EnvironmentJenkins_NoServers;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_EnvironmentJenkins_AddServer;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_EnvironmentJenkins_RemoveServer;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_EnvironmentJenkins_ModifyServer;
        private System.Windows.Forms.Panel panel_Form_EnvironmentJenkins_AddServer;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_EnvironmentJenkins_JenkinsName;
        public DevExpress.XtraEditors.TextEdit textEdit_Form_EnvironmentJenkins_JenkinsName;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_EnvironmentJenkins_ConfiguredServers;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_EnvironmentJenkins_ServerList;
    }
}