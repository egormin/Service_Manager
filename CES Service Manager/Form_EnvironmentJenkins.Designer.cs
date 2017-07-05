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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EnvironmentJenkins));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textEdit_Form_EnvironmentJenkins_Link = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Form_EnvironmentJenkins_Link = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Form_ServerSettings_SaveSettings = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_EnvironmentJenkins_Link.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Dark Side";
            // 
            // textEdit_Form_EnvironmentJenkins_Link
            // 
            this.textEdit_Form_EnvironmentJenkins_Link.Location = new System.Drawing.Point(12, 40);
            this.textEdit_Form_EnvironmentJenkins_Link.Name = "textEdit_Form_EnvironmentJenkins_Link";
            this.textEdit_Form_EnvironmentJenkins_Link.Size = new System.Drawing.Size(353, 20);
            this.textEdit_Form_EnvironmentJenkins_Link.TabIndex = 2;
            // 
            // labelControl_Form_EnvironmentJenkins_Link
            // 
            this.labelControl_Form_EnvironmentJenkins_Link.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_EnvironmentJenkins_Link.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_EnvironmentJenkins_Link.Location = new System.Drawing.Point(13, 20);
            this.labelControl_Form_EnvironmentJenkins_Link.Name = "labelControl_Form_EnvironmentJenkins_Link";
            this.labelControl_Form_EnvironmentJenkins_Link.Size = new System.Drawing.Size(162, 13);
            this.labelControl_Form_EnvironmentJenkins_Link.TabIndex = 3;
            this.labelControl_Form_EnvironmentJenkins_Link.Text = "Specify Jenkins http address";
            // 
            // labelControl_Form_ServerSettings_SaveSettings
            // 
            this.labelControl_Form_ServerSettings_SaveSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Form_ServerSettings_SaveSettings.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_ServerSettings_SaveSettings.Location = new System.Drawing.Point(381, 64);
            this.labelControl_Form_ServerSettings_SaveSettings.Name = "labelControl_Form_ServerSettings_SaveSettings";
            this.labelControl_Form_ServerSettings_SaveSettings.Size = new System.Drawing.Size(66, 11);
            this.labelControl_Form_ServerSettings_SaveSettings.TabIndex = 19;
            this.labelControl_Form_ServerSettings_SaveSettings.Text = "Save settings";
            // 
            // simpleButton_Form_EnvironmentJenkins_SaveSettings
            // 
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Form_EnvironmentJenkins_SaveSettings.Image")));
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Location = new System.Drawing.Point(396, 81);
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Name = "simpleButton_Form_EnvironmentJenkins_SaveSettings";
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Size = new System.Drawing.Size(40, 40);
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.TabIndex = 18;
            this.simpleButton_Form_EnvironmentJenkins_SaveSettings.Click += new System.EventHandler(this.simpleButton_Form_EnvironmentJenkins_SaveSettings_Click);
            // 
            // Form_EnvironmentJenkins
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 169);
            this.Controls.Add(this.labelControl_Form_ServerSettings_SaveSettings);
            this.Controls.Add(this.simpleButton_Form_EnvironmentJenkins_SaveSettings);
            this.Controls.Add(this.textEdit_Form_EnvironmentJenkins_Link);
            this.Controls.Add(this.labelControl_Form_EnvironmentJenkins_Link);
            this.Name = "Form_EnvironmentJenkins";
            this.Text = "Jenkins Environment Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_EnvironmentJenkins_Link.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraEditors.TextEdit textEdit_Form_EnvironmentJenkins_Link;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_EnvironmentJenkins_Link;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_ServerSettings_SaveSettings;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_EnvironmentJenkins_SaveSettings;
    }
}