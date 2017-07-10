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
    public partial class Form_Jenkins_PluginList : DevExpress.XtraEditors.XtraForm
    {
        public Form_Jenkins_PluginList()
        {
            InitializeComponent();
        }

        Show_plugins_FillDatagrid inst_ShowPlugins = new Show_plugins_FillDatagrid();

        private void Form_Jenkins_PluginList_Load(object sender, EventArgs e)
        {           
           
            Conf_EnvironmentJenkins_xml inst_Conf_EnvironmentJenkins_xml = new Conf_EnvironmentJenkins_xml();
            string[] settingsFromFile = inst_Conf_EnvironmentJenkins_xml.LoadDataFromFile().Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

           

            comboBoxEdit_Form_Jenkins_ChooseServer.Text = settingsFromFile[0];
            for (int i = 0; i < settingsFromFile.Length; i++)
            {
                comboBoxEdit_Form_Jenkins_ChooseServer.Properties.Items.AddRange(new object[] { settingsFromFile[i] });
            }

            inst_ShowPlugins.execute(comboBoxEdit_Form_Jenkins_ChooseServer.Text);
        }

        private void simpleButton1_Form_Jenkins_Refresh_Click(object sender, EventArgs e)
        {
            inst_ShowPlugins.execute(comboBoxEdit_Form_Jenkins_ChooseServer.Text);
        }

        private void comboBoxEdit_Form_Jenkins_ChooseServer_Click(object sender, EventArgs e)
        {
            inst_ShowPlugins.execute(comboBoxEdit_Form_Jenkins_ChooseServer.Text);
        }
    }
}
