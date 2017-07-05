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
    public partial class Form_EnvironmentJenkins : DevExpress.XtraEditors.XtraForm
    {
        public Form_EnvironmentJenkins()
        {
            InitializeComponent();
        }

        private void simpleButton_Form_EnvironmentJenkins_SaveSettings_Click(object sender, EventArgs e)
        {
            Conf_EnvironmentJenkins_xml inst_Conf_EnvironmentJenkins_xml = new Conf_EnvironmentJenkins_xml();

            inst_Conf_EnvironmentJenkins_xml.Change_settings(textEdit_Form_EnvironmentJenkins_Link.Text);
            MessageBox.Show("Config has been saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
