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
            this.ClientSize = new Size(460, 160);

            Conf_EnvironmentJenkins_xml inst_Conf_EnvironmentJenkins_xml = new Conf_EnvironmentJenkins_xml();
            string[] settingsFromFile = inst_Conf_EnvironmentJenkins_xml.LoadDataFromFile().Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);
            //if settings were saved before, read these date and output to form
            if (settingsFromFile.Length==0)
            {
                labelControl_Form_EnvironmentJenkins_NoServers.Visible = true;
            } 
            else
            {
                Change_label_NoServers(settingsFromFile);
            }


            textEdit_Form_EnvironmentJenkins_JenkinsName.Click += new EventHandler(textEdit_Form_EnvironmentJenkins_JenkinsName_Click);
            textEdit_Form_EnvironmentJenkins_Link.Click += new EventHandler(textEdit_Form_EnvironmentJenkins_Link_Click);


            // item1.Description = "Hide Button";
            //radioGroup1.it
            // radioGroup1 item1 = new RadioGroupItem();
            //item1.Description = "Hide Button";
        }


        private void Change_label_NoServers(string [] settingsFromFile)
        {
            this.labelControl_Form_EnvironmentJenkins_ConfiguredServers.Visible = true;

            labelControl_Form_EnvironmentJenkins_ServerList.Text = "";
            labelControl_Form_EnvironmentJenkins_NoServers.Text = "Configured Servers: \r\n";

            for (int i = 0; i < settingsFromFile.Length; i++)
            {
                labelControl_Form_EnvironmentJenkins_ServerList.Text += settingsFromFile[i] + "\r\n";
            }
            labelControl_Form_EnvironmentJenkins_ServerList.Visible = true;
        }


        Conf_EnvironmentJenkins_xml inst_Conf_EnvironmentJenkins_xml = new Conf_EnvironmentJenkins_xml();


        private void simpleButton_Form_EnvironmentJenkins_SaveSettings_Click(object sender, EventArgs e)
        {
            inst_Conf_EnvironmentJenkins_xml.Add_Server(textEdit_Form_EnvironmentJenkins_JenkinsName.Text, textEdit_Form_EnvironmentJenkins_Link.Text);
            Change_label_NoServers(inst_Conf_EnvironmentJenkins_xml.LoadDataFromFile().Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries));
            MessageBox.Show("Server "+ textEdit_Form_EnvironmentJenkins_JenkinsName.Text + " has been added", "Saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton_Form_EnvironmentJenkins_AddServer_Click(object sender, EventArgs e)
        {
            this.ClientSize = new Size(460, 310);
            panel_Form_EnvironmentJenkins_AddServer.Visible = true;
        }

       
        private void textEdit_Form_EnvironmentJenkins_JenkinsName_Click(object sender, EventArgs e)
        {
            textEdit_Form_EnvironmentJenkins_JenkinsName.Text = "";
            this.textEdit_Form_EnvironmentJenkins_JenkinsName.Properties.Appearance.ForeColor = Color.Black;
        }

        private void textEdit_Form_EnvironmentJenkins_Link_Click(object sender, EventArgs e)
        {
            textEdit_Form_EnvironmentJenkins_Link.Text = "";
            this.textEdit_Form_EnvironmentJenkins_Link.Properties.Appearance.ForeColor = Color.Black;
        }
    }
}
