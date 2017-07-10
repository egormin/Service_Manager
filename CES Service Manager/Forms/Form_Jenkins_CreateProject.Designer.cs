namespace CES_Service_Manager
{
    partial class Form_Jenkins_CreateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jenkins_CreateProject));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textEdit_Form_Jenkins_CreateProject_ProjectName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Form_Jenkins_CreateProject_ProjectName = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_Form_Jenkins_CreateProject_Result = new DevExpress.XtraEditors.LabelControl();
            this.textBox_Form_Jenkins_CreateProject_Result = new System.Windows.Forms.TextBox();
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_Jenkins_CreateProject_ProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Dark Side";
            // 
            // textEdit_Form_Jenkins_CreateProject_ProjectName
            // 
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.Location = new System.Drawing.Point(13, 85);
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.Name = "textEdit_Form_Jenkins_CreateProject_ProjectName";
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.Size = new System.Drawing.Size(110, 20);
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.TabIndex = 2;
            // 
            // labelControl_Form_Jenkins_CreateProject_ProjectName
            // 
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Location = new System.Drawing.Point(14, 66);
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Name = "labelControl_Form_Jenkins_CreateProject_ProjectName";
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Size = new System.Drawing.Size(109, 13);
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.TabIndex = 3;
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Text = "Enter Project Name";
            // 
            // simpleButton_Form_Jenkins_CreateProject_CreateProject
            // 
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Appearance.Options.UseFont = true;
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Location = new System.Drawing.Point(142, 78);
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Name = "simpleButton_Form_Jenkins_CreateProject_CreateProject";
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Size = new System.Drawing.Size(118, 27);
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.TabIndex = 6;
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Text = "Create Project";
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Click += new System.EventHandler(this.simpleButton_Form_Jenkins_CreateProject_CreateProject_Click);
            // 
            // labelControl_Form_Jenkins_CreateProject_Result
            // 
            this.labelControl_Form_Jenkins_CreateProject_Result.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_Jenkins_CreateProject_Result.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_Jenkins_CreateProject_Result.Location = new System.Drawing.Point(12, 120);
            this.labelControl_Form_Jenkins_CreateProject_Result.Name = "labelControl_Form_Jenkins_CreateProject_Result";
            this.labelControl_Form_Jenkins_CreateProject_Result.Size = new System.Drawing.Size(36, 13);
            this.labelControl_Form_Jenkins_CreateProject_Result.TabIndex = 8;
            this.labelControl_Form_Jenkins_CreateProject_Result.Text = "Result";
            // 
            // textBox_Form_Jenkins_CreateProject_Result
            // 
            this.textBox_Form_Jenkins_CreateProject_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_Form_Jenkins_CreateProject_Result.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Form_Jenkins_CreateProject_Result.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_Form_Jenkins_CreateProject_Result.Location = new System.Drawing.Point(13, 139);
            this.textBox_Form_Jenkins_CreateProject_Result.Multiline = true;
            this.textBox_Form_Jenkins_CreateProject_Result.Name = "textBox_Form_Jenkins_CreateProject_Result";
            this.textBox_Form_Jenkins_CreateProject_Result.Size = new System.Drawing.Size(259, 117);
            this.textBox_Form_Jenkins_CreateProject_Result.TabIndex = 9;
            // 
            // comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer
            // 
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.EditValue = "";
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Location = new System.Drawing.Point(12, 33);
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Name = "comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer";
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Size = new System.Drawing.Size(265, 20);
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.TabIndex = 10;
            this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer_Click);
            // 
            // labelControl_Form_Jenkins_CreateProject_ChooseJenkins
            // 
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins.Location = new System.Drawing.Point(14, 13);
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins.Name = "labelControl_Form_Jenkins_CreateProject_ChooseJenkins";
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins.Size = new System.Drawing.Size(87, 13);
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins.TabIndex = 11;
            this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins.Text = "Choose Jenkins";
            // 
            // hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject
            // 
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Location = new System.Drawing.Point(21, 237);
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Name = "hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject";
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Size = new System.Drawing.Size(75, 13);
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.TabIndex = 12;
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Tag = "sfsfsf";
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Text = "Open project...";
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Visible = false;
            this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Click += new System.EventHandler(this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject_Click);
            // 
            // Form_Jenkins_CreateProject
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 273);
            this.Controls.Add(this.hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject);
            this.Controls.Add(this.labelControl_Form_Jenkins_CreateProject_ChooseJenkins);
            this.Controls.Add(this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer);
            this.Controls.Add(this.textBox_Form_Jenkins_CreateProject_Result);
            this.Controls.Add(this.labelControl_Form_Jenkins_CreateProject_Result);
            this.Controls.Add(this.simpleButton_Form_Jenkins_CreateProject_CreateProject);
            this.Controls.Add(this.textEdit_Form_Jenkins_CreateProject_ProjectName);
            this.Controls.Add(this.labelControl_Form_Jenkins_CreateProject_ProjectName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Jenkins_CreateProject";
            this.Text = "Create Jenkins Project";
            this.Load += new System.EventHandler(this.Form_Jenkins_CreateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_Jenkins_CreateProject_ProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraEditors.TextEdit textEdit_Form_Jenkins_CreateProject_ProjectName;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_Jenkins_CreateProject_ProjectName;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_Jenkins_CreateProject_CreateProject;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_Jenkins_CreateProject_Result;
        private System.Windows.Forms.TextBox textBox_Form_Jenkins_CreateProject_Result;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_Jenkins_CreateProject_ChooseJenkins;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject;
    }
}