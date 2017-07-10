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
    public partial class Form_ScriptsSettings : DevExpress.XtraEditors.XtraForm
    {
        public Form_ScriptsSettings()
        {
            InitializeComponent();

            Conf_ScriptsSettings_xml inst_Conf_ScriptsSettings_xml = new Conf_ScriptsSettings_xml();
            string settingsFromFile = inst_Conf_ScriptsSettings_xml.LoadDataFromFile();

            //if settings were saved before, read these date and output to form           
                textEdit_Form_ScriptsSettings_ScriptsDirectory.Text = settingsFromFile;          
        }

        private void simpleButton_Form_ServerSettings_SaveSettings_Click(object sender, EventArgs e)
        {
            Conf_ScriptsSettings_xml inst_Conf_ScriptsSettings_xml = new Conf_ScriptsSettings_xml();

            inst_Conf_ScriptsSettings_xml.Change_settings(textEdit_Form_ScriptsSettings_ScriptsDirectory.Text);
            MessageBox.Show("Config has been saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
