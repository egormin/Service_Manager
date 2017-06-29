namespace CES_Service_Manager
{
    partial class Form_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.textEdit_Settings_IP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Settings_IP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Settings_PubKey = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_Settings_pubKey = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_Settings_PubKey = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Settings_TestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit_Settings_NOK = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit_Settings_OK = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton_Settings_save = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_Settings_port = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Settings_port = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Settings_user = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_Settings_user = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Settings_result = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit_Settings_Wait = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_IP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_pubKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Settings_NOK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Settings_OK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Settings_Wait.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit_Settings_IP
            // 
            this.textEdit_Settings_IP.Location = new System.Drawing.Point(12, 59);
            this.textEdit_Settings_IP.Name = "textEdit_Settings_IP";
            this.textEdit_Settings_IP.Size = new System.Drawing.Size(170, 20);
            this.textEdit_Settings_IP.TabIndex = 0;
            // 
            // labelControl_Settings_IP
            // 
            this.labelControl_Settings_IP.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Settings_IP.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Settings_IP.Location = new System.Drawing.Point(13, 39);
            this.labelControl_Settings_IP.Name = "labelControl_Settings_IP";
            this.labelControl_Settings_IP.Size = new System.Drawing.Size(150, 13);
            this.labelControl_Settings_IP.TabIndex = 1;
            this.labelControl_Settings_IP.Text = "Remote Server IP Address";
            // 
            // labelControl_Settings_PubKey
            // 
            this.labelControl_Settings_PubKey.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Settings_PubKey.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Settings_PubKey.Location = new System.Drawing.Point(12, 136);
            this.labelControl_Settings_PubKey.Name = "labelControl_Settings_PubKey";
            this.labelControl_Settings_PubKey.Size = new System.Drawing.Size(57, 13);
            this.labelControl_Settings_PubKey.TabIndex = 2;
            this.labelControl_Settings_PubKey.Text = "Public Key";
            // 
            // textEdit_Settings_pubKey
            // 
            this.textEdit_Settings_pubKey.Location = new System.Drawing.Point(12, 155);
            this.textEdit_Settings_pubKey.Name = "textEdit_Settings_pubKey";
            this.textEdit_Settings_pubKey.Size = new System.Drawing.Size(222, 20);
            this.textEdit_Settings_pubKey.TabIndex = 3;
            // 
            // simpleButton_Settings_PubKey
            // 
            this.simpleButton_Settings_PubKey.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Settings_PubKey.Image")));
            this.simpleButton_Settings_PubKey.Location = new System.Drawing.Point(240, 136);
            this.simpleButton_Settings_PubKey.Name = "simpleButton_Settings_PubKey";
            this.simpleButton_Settings_PubKey.Size = new System.Drawing.Size(38, 36);
            this.simpleButton_Settings_PubKey.TabIndex = 4;
            this.simpleButton_Settings_PubKey.Text = "simpleButton1";
            this.simpleButton_Settings_PubKey.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton_Settings_TestConnection
            // 
            this.simpleButton_Settings_TestConnection.Location = new System.Drawing.Point(12, 181);
            this.simpleButton_Settings_TestConnection.Name = "simpleButton_Settings_TestConnection";
            this.simpleButton_Settings_TestConnection.Size = new System.Drawing.Size(170, 23);
            this.simpleButton_Settings_TestConnection.TabIndex = 5;
            this.simpleButton_Settings_TestConnection.Text = "Test Connection";
            this.simpleButton_Settings_TestConnection.Click += new System.EventHandler(this.simpleButton_Settings_TestConnection_Click);
            // 
            // pictureEdit_Settings_NOK
            // 
            this.pictureEdit_Settings_NOK.EditValue = ((object)(resources.GetObject("pictureEdit_Settings_NOK.EditValue")));
            this.pictureEdit_Settings_NOK.Location = new System.Drawing.Point(12, 210);
            this.pictureEdit_Settings_NOK.Name = "pictureEdit_Settings_NOK";
            this.pictureEdit_Settings_NOK.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pictureEdit_Settings_NOK.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit_Settings_NOK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit_Settings_NOK.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_Settings_NOK.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit_Settings_NOK.Size = new System.Drawing.Size(44, 38);
            this.pictureEdit_Settings_NOK.TabIndex = 6;
            this.pictureEdit_Settings_NOK.Visible = false;
            // 
            // pictureEdit_Settings_OK
            // 
            this.pictureEdit_Settings_OK.EditValue = ((object)(resources.GetObject("pictureEdit_Settings_OK.EditValue")));
            this.pictureEdit_Settings_OK.Location = new System.Drawing.Point(12, 210);
            this.pictureEdit_Settings_OK.Name = "pictureEdit_Settings_OK";
            this.pictureEdit_Settings_OK.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pictureEdit_Settings_OK.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit_Settings_OK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit_Settings_OK.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_Settings_OK.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit_Settings_OK.Size = new System.Drawing.Size(44, 38);
            this.pictureEdit_Settings_OK.TabIndex = 7;
            this.pictureEdit_Settings_OK.Visible = false;
            // 
            // simpleButton_Settings_save
            // 
            this.simpleButton_Settings_save.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Settings_save.Image")));
            this.simpleButton_Settings_save.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton_Settings_save.Location = new System.Drawing.Point(269, 262);
            this.simpleButton_Settings_save.Name = "simpleButton_Settings_save";
            this.simpleButton_Settings_save.Size = new System.Drawing.Size(40, 40);
            this.simpleButton_Settings_save.TabIndex = 8;
            this.simpleButton_Settings_save.Click += new System.EventHandler(this.simpleButton_Settings_save_Click);
            // 
            // textEdit_Settings_port
            // 
            this.textEdit_Settings_port.Location = new System.Drawing.Point(221, 59);
            this.textEdit_Settings_port.Name = "textEdit_Settings_port";
            this.textEdit_Settings_port.Size = new System.Drawing.Size(57, 20);
            this.textEdit_Settings_port.TabIndex = 9;
            // 
            // labelControl_Settings_port
            // 
            this.labelControl_Settings_port.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Settings_port.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Settings_port.Location = new System.Drawing.Point(221, 40);
            this.labelControl_Settings_port.Name = "labelControl_Settings_port";
            this.labelControl_Settings_port.Size = new System.Drawing.Size(24, 13);
            this.labelControl_Settings_port.TabIndex = 10;
            this.labelControl_Settings_port.Text = "Port";
            // 
            // labelControl_Settings_user
            // 
            this.labelControl_Settings_user.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Settings_user.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Settings_user.Location = new System.Drawing.Point(13, 91);
            this.labelControl_Settings_user.Name = "labelControl_Settings_user";
            this.labelControl_Settings_user.Size = new System.Drawing.Size(26, 13);
            this.labelControl_Settings_user.TabIndex = 12;
            this.labelControl_Settings_user.Text = "User";
            // 
            // textEdit_Settings_user
            // 
            this.textEdit_Settings_user.Location = new System.Drawing.Point(13, 110);
            this.textEdit_Settings_user.Name = "textEdit_Settings_user";
            this.textEdit_Settings_user.Size = new System.Drawing.Size(91, 20);
            this.textEdit_Settings_user.TabIndex = 11;
            // 
            // labelControl_Settings_result
            // 
            this.labelControl_Settings_result.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Settings_result.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelControl_Settings_result.Location = new System.Drawing.Point(62, 219);
            this.labelControl_Settings_result.Name = "labelControl_Settings_result";
            this.labelControl_Settings_result.Size = new System.Drawing.Size(121, 13);
            this.labelControl_Settings_result.TabIndex = 13;
            this.labelControl_Settings_result.Text = "Server xx is available";
            this.labelControl_Settings_result.Visible = false;
            // 
            // pictureEdit_Settings_Wait
            // 
            this.pictureEdit_Settings_Wait.EditValue = ((object)(resources.GetObject("pictureEdit_Settings_Wait.EditValue")));
            this.pictureEdit_Settings_Wait.Location = new System.Drawing.Point(12, 210);
            this.pictureEdit_Settings_Wait.Name = "pictureEdit_Settings_Wait";
            this.pictureEdit_Settings_Wait.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.pictureEdit_Settings_Wait.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit_Settings_Wait.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit_Settings_Wait.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_Settings_Wait.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit_Settings_Wait.Size = new System.Drawing.Size(44, 38);
            this.pictureEdit_Settings_Wait.TabIndex = 14;
            this.pictureEdit_Settings_Wait.Visible = false;
            // 
            // Form_Settings
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 314);
            this.Controls.Add(this.pictureEdit_Settings_Wait);
            this.Controls.Add(this.labelControl_Settings_result);
            this.Controls.Add(this.labelControl_Settings_user);
            this.Controls.Add(this.textEdit_Settings_user);
            this.Controls.Add(this.labelControl_Settings_port);
            this.Controls.Add(this.textEdit_Settings_port);
            this.Controls.Add(this.simpleButton_Settings_save);
            this.Controls.Add(this.pictureEdit_Settings_OK);
            this.Controls.Add(this.pictureEdit_Settings_NOK);
            this.Controls.Add(this.simpleButton_Settings_TestConnection);
            this.Controls.Add(this.simpleButton_Settings_PubKey);
            this.Controls.Add(this.textEdit_Settings_pubKey);
            this.Controls.Add(this.labelControl_Settings_PubKey);
            this.Controls.Add(this.labelControl_Settings_IP);
            this.Controls.Add(this.textEdit_Settings_IP);
            this.Name = "Form_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Settings";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_IP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_pubKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Settings_NOK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Settings_OK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Settings_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Settings_Wait.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl_Settings_IP;
        private DevExpress.XtraEditors.LabelControl labelControl_Settings_PubKey;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Settings_PubKey;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Settings_TestConnection;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Settings_NOK;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Settings_OK;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Settings_save;
        private DevExpress.XtraEditors.LabelControl labelControl_Settings_port;
        public DevExpress.XtraEditors.TextEdit textEdit_Settings_IP;
        public DevExpress.XtraEditors.TextEdit textEdit_Settings_pubKey;
        public DevExpress.XtraEditors.TextEdit textEdit_Settings_port;
        private DevExpress.XtraEditors.LabelControl labelControl_Settings_user;
        public DevExpress.XtraEditors.TextEdit textEdit_Settings_user;
        private DevExpress.XtraEditors.LabelControl labelControl_Settings_result;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Settings_Wait;
    }
}