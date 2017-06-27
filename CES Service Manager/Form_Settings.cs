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
    public partial class Form_Settings : DevExpress.XtraEditors.XtraForm
    {


        public Form_Settings()
        {
            InitializeComponent();
            Conf_ServerSettings_xml inst_Conf_ServerSettings_xml = new Conf_ServerSettings_xml();
            string[] settingsFromFile = inst_Conf_ServerSettings_xml.LoadDataFromFile().Split('#');
            if (settingsFromFile.Length==4)
            {
                textEdit_Settings_IP.Text = settingsFromFile[0];
                textEdit_Settings_port.Text = settingsFromFile[1];
                textEdit_Settings_user.Text = settingsFromFile[2];
                textEdit_Settings_pubKey.Text = settingsFromFile[3];
            }     
           
        }

        //string publicKeyPass;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Public Key(*.ppk)|*.ppk";
            dialog.Title = "Choose your public key";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               textEdit_Settings_pubKey.Text = dialog.FileName;
            }
        }

        private void simpleButton_Settings_TestConnection_Click(object sender, EventArgs e)
        {
           string res =  Set_TestConnection.Check_Connection(textEdit_Settings_IP.Text, textEdit_Settings_port.Text, textEdit_Settings_user.Text, textEdit_Settings_pubKey.Text);

            if (res=="OK")
            {pictureEdit_Settings_OK.Visible = true;} else { pictureEdit_Settings_NOK.Visible = true; }
        }

        private void simpleButton_Settings_save_Click(object sender, EventArgs e)
        {
            Conf_ServerSettings_xml inst_Conf_ServerSettings_xml = new Conf_ServerSettings_xml();

            inst_Conf_ServerSettings_xml.Change_settings(textEdit_Settings_IP.Text, textEdit_Settings_port.Text, textEdit_Settings_user.Text, textEdit_Settings_pubKey.Text);
            MessageBox.Show("Config has been saved");

        }
    }
}
