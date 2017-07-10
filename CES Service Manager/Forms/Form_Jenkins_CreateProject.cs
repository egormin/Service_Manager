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
    public partial class Form_Jenkins_CreateProject : DevExpress.XtraEditors.XtraForm
    {
        public Form_Jenkins_CreateProject()
        {
            InitializeComponent();
        }

       
        private void Form_Jenkins_CreateProject_Load(object sender, EventArgs e)
        {
            Conf_EnvironmentJenkins_xml inst_Conf_EnvironmentJenkins_xml = new Conf_EnvironmentJenkins_xml();
            string[] settingsFromFile = inst_Conf_EnvironmentJenkins_xml.LoadDataFromFile().Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

            comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Text = settingsFromFile[0];
            for (int i = 0; i < settingsFromFile.Length; i++)
            {
                comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Properties.Items.AddRange(new object[] { settingsFromFile[i] });
            }
        }

        private void simpleButton_Form_Jenkins_CreateProject_CreateProject_Click(object sender, EventArgs e)
        {
            textBox_Form_Jenkins_CreateProject_Result.Text = Call_jenkins_createProject.Call(textEdit_Form_Jenkins_CreateProject_ProjectName.Text, comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Text);
        }
    }
}
