namespace CES_Service_Manager
{
    partial class Form_ScriptsSettings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("jenkins_plugins.py");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("jenkins_create_project.py");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("..scripts", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("keys", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ScriptsSettings));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textEdit_Form_ScriptsSettings_ScriptsDirectory = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonForm_ScriptsSettings_CheckFiles = new DevExpress.XtraEditors.SimpleButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelControl_Form_ServerSettings_SaveSettings = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Form_ServerSettings_SaveSettings = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_ScriptsSettings_ScriptsDirectory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Dark Side";
            // 
            // textEdit_Form_ScriptsSettings_ScriptsDirectory
            // 
            this.textEdit_Form_ScriptsSettings_ScriptsDirectory.Location = new System.Drawing.Point(12, 43);
            this.textEdit_Form_ScriptsSettings_ScriptsDirectory.Name = "textEdit_Form_ScriptsSettings_ScriptsDirectory";
            this.textEdit_Form_ScriptsSettings_ScriptsDirectory.Size = new System.Drawing.Size(226, 20);
            this.textEdit_Form_ScriptsSettings_ScriptsDirectory.TabIndex = 2;
            // 
            // labelControl_Form_ScriptsSettings_ScriptsDirectory
            // 
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory.Location = new System.Drawing.Point(13, 23);
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory.Name = "labelControl_Form_ScriptsSettings_ScriptsDirectory";
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory.Size = new System.Drawing.Size(192, 13);
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory.TabIndex = 3;
            this.labelControl_Form_ScriptsSettings_ScriptsDirectory.Text = "Scripts directory in remote server";
            // 
            // simpleButtonForm_ScriptsSettings_CheckFiles
            // 
            this.simpleButtonForm_ScriptsSettings_CheckFiles.Location = new System.Drawing.Point(12, 113);
            this.simpleButtonForm_ScriptsSettings_CheckFiles.Name = "simpleButtonForm_ScriptsSettings_CheckFiles";
            this.simpleButtonForm_ScriptsSettings_CheckFiles.Size = new System.Drawing.Size(106, 23);
            this.simpleButtonForm_ScriptsSettings_CheckFiles.TabIndex = 4;
            this.simpleButtonForm_ScriptsSettings_CheckFiles.Text = "Check Files";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.Location = new System.Drawing.Point(13, 142);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "jenkins_plugins.py";
            treeNode2.Name = "Node2";
            treeNode2.Text = "jenkins_create_project.py";
            treeNode3.Name = "Node0";
            treeNode3.Text = "..scripts";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Node5";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Node6";
            treeNode6.Name = "Node4";
            treeNode6.Text = "keys";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(296, 141);
            this.treeView1.TabIndex = 5;
            // 
            // labelControl_Form_ServerSettings_SaveSettings
            // 
            this.labelControl_Form_ServerSettings_SaveSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Form_ServerSettings_SaveSettings.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_ServerSettings_SaveSettings.Location = new System.Drawing.Point(243, 67);
            this.labelControl_Form_ServerSettings_SaveSettings.Name = "labelControl_Form_ServerSettings_SaveSettings";
            this.labelControl_Form_ServerSettings_SaveSettings.Size = new System.Drawing.Size(66, 11);
            this.labelControl_Form_ServerSettings_SaveSettings.TabIndex = 19;
            this.labelControl_Form_ServerSettings_SaveSettings.Text = "Save settings";
            // 
            // simpleButton_Form_ServerSettings_SaveSettings
            // 
            this.simpleButton_Form_ServerSettings_SaveSettings.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Form_ServerSettings_SaveSettings.Image")));
            this.simpleButton_Form_ServerSettings_SaveSettings.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton_Form_ServerSettings_SaveSettings.Location = new System.Drawing.Point(257, 84);
            this.simpleButton_Form_ServerSettings_SaveSettings.Name = "simpleButton_Form_ServerSettings_SaveSettings";
            this.simpleButton_Form_ServerSettings_SaveSettings.Size = new System.Drawing.Size(40, 40);
            this.simpleButton_Form_ServerSettings_SaveSettings.TabIndex = 18;
            this.simpleButton_Form_ServerSettings_SaveSettings.Click += new System.EventHandler(this.simpleButton_Form_ServerSettings_SaveSettings_Click);
            // 
            // Form_ScriptsSettings
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 314);
            this.Controls.Add(this.labelControl_Form_ServerSettings_SaveSettings);
            this.Controls.Add(this.simpleButton_Form_ServerSettings_SaveSettings);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.simpleButtonForm_ScriptsSettings_CheckFiles);
            this.Controls.Add(this.textEdit_Form_ScriptsSettings_ScriptsDirectory);
            this.Controls.Add(this.labelControl_Form_ScriptsSettings_ScriptsDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ScriptsSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote Scripts Settings";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_ScriptsSettings_ScriptsDirectory.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraEditors.TextEdit textEdit_Form_ScriptsSettings_ScriptsDirectory;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_ScriptsSettings_ScriptsDirectory;
        private DevExpress.XtraEditors.SimpleButton simpleButtonForm_ScriptsSettings_CheckFiles;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_ServerSettings_SaveSettings;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_ServerSettings_SaveSettings;
    }
}