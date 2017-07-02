using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_Service_Manager
{
    public partial class Form_ServerSettings : DevExpress.XtraEditors.XtraForm
    {
        ManageControls inst_MC = new ManageControls();

        public Form_ServerSettings()
        {
            InitializeComponent();

            Conf_ServerSettings_xml inst_Conf_ServerSettings_xml = new Conf_ServerSettings_xml();
            string[] settingsFromFile = inst_Conf_ServerSettings_xml.LoadDataFromFile().Split('#');
            //if settings were saved before, read these date and output to form
            if (settingsFromFile.Length==4)
            {
                textEdit_Form_ServerSettings_IP.Text = settingsFromFile[0];
                textEdit_Form_ServerSettings_Port.Text = settingsFromFile[1];
                textEdit_Form_ServerSettings_User.Text = settingsFromFile[2];
                textEdit_Form_ServerSettings_PubKey.Text = settingsFromFile[3];
            }     
           
        }

        private void simpleButton_Form_ServerSettings_PubKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Public Key(*.ppk)|*.ppk";
            dialog.Title = "Choose your public key";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               textEdit_Form_ServerSettings_PubKey.Text = dialog.FileName;
            }
        }

        private void simpleButton_Settings_TestConnection_Click(object sender, EventArgs e)
        {
            inst_MC.Setting_frm_contr_initial();           
            inst_MC.Setting_frm_contr_IsServerAvailable(textEdit_Form_ServerSettings_IP.Text, Convert.ToInt32(textEdit_Form_ServerSettings_Port.Text), textEdit_Form_ServerSettings_User.Text, textEdit_Form_ServerSettings_PubKey.Text);            
        }

        private void simpleButton_Form_ServerSettings_SaveSettings_Click(object sender, EventArgs e)
        {
            Conf_ServerSettings_xml inst_Conf_ServerSettings_xml = new Conf_ServerSettings_xml();

            inst_Conf_ServerSettings_xml.Change_settings(textEdit_Form_ServerSettings_IP.Text, textEdit_Form_ServerSettings_Port.Text, textEdit_Form_ServerSettings_User.Text, textEdit_Form_ServerSettings_PubKey.Text);
            MessageBox.Show("Config has been saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
    }
}
