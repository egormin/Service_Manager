namespace CES_Service_Manager
{
    partial class Form_Jenkins_PluginList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jenkins_PluginList));
            this.gridControl_Form_Jenkins_PluginList = new DevExpress.XtraGrid.GridControl();
            this.gridView_Form_Jenkins_PluginList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1_Form_Jenkins_PluginList = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl_Form_Jenkins_PluginList = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Form_Jenkins_PluginList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Form_Jenkins_PluginList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Form_Jenkins_PluginList
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gridControl_Form_Jenkins_PluginList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl_Form_Jenkins_PluginList.Location = new System.Drawing.Point(2, 52);
            this.gridControl_Form_Jenkins_PluginList.MainView = this.gridView_Form_Jenkins_PluginList;
            this.gridControl_Form_Jenkins_PluginList.Name = "gridControl_Form_Jenkins_PluginList";
            this.gridControl_Form_Jenkins_PluginList.Size = new System.Drawing.Size(673, 627);
            this.gridControl_Form_Jenkins_PluginList.TabIndex = 0;
            this.gridControl_Form_Jenkins_PluginList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Form_Jenkins_PluginList});
            // 
            // gridView_Form_Jenkins_PluginList
            // 
            this.gridView_Form_Jenkins_PluginList.GridControl = this.gridControl_Form_Jenkins_PluginList;
            this.gridView_Form_Jenkins_PluginList.Name = "gridView_Form_Jenkins_PluginList";
            this.gridView_Form_Jenkins_PluginList.OptionsFind.AlwaysVisible = true;
            // 
            // simpleButton1_Form_Jenkins_PluginList
            // 
            this.simpleButton1_Form_Jenkins_PluginList.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButton1_Form_Jenkins_PluginList.Appearance.Options.UseFont = true;
            this.simpleButton1_Form_Jenkins_PluginList.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1_Form_Jenkins_PluginList.Image")));
            this.simpleButton1_Form_Jenkins_PluginList.Location = new System.Drawing.Point(565, 12);
            this.simpleButton1_Form_Jenkins_PluginList.Name = "simpleButton1_Form_Jenkins_PluginList";
            this.simpleButton1_Form_Jenkins_PluginList.Size = new System.Drawing.Size(99, 34);
            this.simpleButton1_Form_Jenkins_PluginList.TabIndex = 1;
            this.simpleButton1_Form_Jenkins_PluginList.Text = "Refresh";
            this.simpleButton1_Form_Jenkins_PluginList.Click += new System.EventHandler(this.simpleButton1_Form_Jenkins_PluginList_Click);
            // 
            // labelControl_Form_Jenkins_PluginList
            // 
            this.labelControl_Form_Jenkins_PluginList.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl_Form_Jenkins_PluginList.Location = new System.Drawing.Point(12, 27);
            this.labelControl_Form_Jenkins_PluginList.Name = "labelControl_Form_Jenkins_PluginList";
            this.labelControl_Form_Jenkins_PluginList.Size = new System.Drawing.Size(159, 19);
            this.labelControl_Form_Jenkins_PluginList.TabIndex = 2;
            this.labelControl_Form_Jenkins_PluginList.Text = "Jenkins Plugins List";
            // 
            // Form_Jenkins_PluginList
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 679);
            this.Controls.Add(this.labelControl_Form_Jenkins_PluginList);
            this.Controls.Add(this.simpleButton1_Form_Jenkins_PluginList);
            this.Controls.Add(this.gridControl_Form_Jenkins_PluginList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Jenkins_PluginList";
            this.Text = "Jenkins Plugin List";
            this.Load += new System.EventHandler(this.Form_Jenkins_PluginList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Form_Jenkins_PluginList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Form_Jenkins_PluginList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1_Form_Jenkins_PluginList;
        public DevExpress.XtraGrid.GridControl gridControl_Form_Jenkins_PluginList;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView_Form_Jenkins_PluginList;
        public DevExpress.XtraEditors.LabelControl labelControl_Form_Jenkins_PluginList;
    }
}