using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CES_Service_Manager
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Jenkins_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel5.Visible = true;
        }

        private void barButtonItem_About_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("made by Egor");
        }

        private void barButton_About_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("CES Service Manager v. 1.0. Designed by Egor");
        }

        private Form_Settings frm_Settings;
        private void barButtonItem_ServerSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        frm_Settings = new Form_Settings();
            frm_Settings.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("create");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("remove");
        }

        private Form_Jenkins_CreateProject frm_Jenkins_CreateProject;
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frm_Jenkins_CreateProject = new Form_Jenkins_CreateProject();
            frm_Jenkins_CreateProject.ShowDialog();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality has not been implemented yet");
        }
    }
}
