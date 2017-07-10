using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

            if (settingsFromFile.Length>0)
            {
                comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Text = settingsFromFile[0];
                for (int i = 0; i < settingsFromFile.Length; i++)
                {
                    comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Properties.Items.AddRange(new object[] { settingsFromFile[i] });
                }
            }
            else
            {
                MessageBox.Show("Jenkins Server not specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void simpleButton_Form_Jenkins_CreateProject_CreateProject_Click(object sender, EventArgs e)
        {
            if (textEdit_Form_Jenkins_CreateProject_ProjectName.Text!="")
            {
                if (comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Text!="")
                {
                    textBox_Form_Jenkins_CreateProject_Result.Text = "Jenkins: " + comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Text + "\r\n" + "Project: " +
                        textEdit_Form_Jenkins_CreateProject_ProjectName.Text + "\r\n" + "\r\n" +
                        Call_jenkins_createProject.Call(textEdit_Form_Jenkins_CreateProject_ProjectName.Text, comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Text);
                }
                else
                {
                    MessageBox.Show("Please specify Jenkins Server. \r\nEnvironment -> Jenkins", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
            }
            else
            {
                MessageBox.Show("Project name not specified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject.Visible = true;
        }

        private void comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer_Click(object sender, EventArgs e)
        {
            textBox_Form_Jenkins_CreateProject_Result.Text = "";
            textEdit_Form_Jenkins_CreateProject_ProjectName.Text = "";
        }
       
        private void hyperlinkLabelControl_Form_Jenkins_CreateProject_OpenProject_Click(object sender, EventArgs e)
        {
            Process.Start(GetData_for_call.GetHttp("Jenkins", comboBoxEdit_Form_Jenkins_CreateProject_ChooseServer.Text) + "/job/" + textEdit_Form_Jenkins_CreateProject_ProjectName.Text);
        }
    }
}
