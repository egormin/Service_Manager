﻿namespace CES_Service_Manager
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.textEdit_Form_Jenkins_CreateProject_ProjectName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl_Form_Jenkins_CreateProject_ProjectName = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_Form_Jenkins_CreateProject_Result = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_Jenkins_CreateProject_ProjectName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Dark Side";
            // 
            // textEdit_Form_Jenkins_CreateProject_ProjectName
            // 
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.Location = new System.Drawing.Point(12, 46);
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.Name = "textEdit_Form_Jenkins_CreateProject_ProjectName";
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.Size = new System.Drawing.Size(110, 20);
            this.textEdit_Form_Jenkins_CreateProject_ProjectName.TabIndex = 2;
            // 
            // labelControl_Form_Jenkins_CreateProject_ProjectName
            // 
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Location = new System.Drawing.Point(13, 27);
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Name = "labelControl_Form_Jenkins_CreateProject_ProjectName";
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Size = new System.Drawing.Size(109, 13);
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.TabIndex = 3;
            this.labelControl_Form_Jenkins_CreateProject_ProjectName.Text = "Enter Project Name";
            // 
            // simpleButton_Form_Jenkins_CreateProject_CreateProject
            // 
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Appearance.Options.UseFont = true;
            this.simpleButton_Form_Jenkins_CreateProject_CreateProject.Location = new System.Drawing.Point(141, 39);
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
            this.labelControl_Form_Jenkins_CreateProject_Result.Location = new System.Drawing.Point(12, 101);
            this.labelControl_Form_Jenkins_CreateProject_Result.Name = "labelControl_Form_Jenkins_CreateProject_Result";
            this.labelControl_Form_Jenkins_CreateProject_Result.Size = new System.Drawing.Size(36, 13);
            this.labelControl_Form_Jenkins_CreateProject_Result.TabIndex = 8;
            this.labelControl_Form_Jenkins_CreateProject_Result.Text = "Result";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(13, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 117);
            this.textBox1.TabIndex = 9;
            // 
            // Form_Jenkins_CreateProject
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelControl_Form_Jenkins_CreateProject_Result);
            this.Controls.Add(this.simpleButton_Form_Jenkins_CreateProject_CreateProject);
            this.Controls.Add(this.textEdit_Form_Jenkins_CreateProject_ProjectName);
            this.Controls.Add(this.labelControl_Form_Jenkins_CreateProject_ProjectName);
            this.Name = "Form_Jenkins_CreateProject";
            this.Text = "Form_JenkinsCreateProject";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Form_Jenkins_CreateProject_ProjectName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraEditors.TextEdit textEdit_Form_Jenkins_CreateProject_ProjectName;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_Jenkins_CreateProject_ProjectName;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Form_Jenkins_CreateProject_CreateProject;
        private DevExpress.XtraEditors.LabelControl labelControl_Form_Jenkins_CreateProject_Result;
        private System.Windows.Forms.TextBox textBox1;
    }
}