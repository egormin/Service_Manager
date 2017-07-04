using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using Renci.SshNet;

namespace CES_Service_Manager
{
    class Show_plugins_FillDatagrid
    {
        public T GetForm<T>() where T : Form
        {
            return (T)Application.OpenForms[typeof(T).Name];
        }


        public class Record
        {
            int num;
            string plug_name, age, plugin_version;
            public Record(int num, string plug_name, string age, string plugin_version)
            {
                this.num = num;
                this.plug_name = plug_name;
                this.age = age;
                this.plugin_version = plugin_version;
            }
            public int Num { get { return num; } }
            public string Plugin_ID
            {
               
                get {  return plug_name; }
                set {  plug_name = value; }
            }
            public string Plugin_Name
            {
                get { return age; }
                set { age = value; }
            }
            public string Plugin_Version
            {
                get { return plugin_version; }
                set { plugin_version = value; }
            }
        }


        public void execute()
        {
            var frm = GetForm<Form_Jenkins_PluginList>();


            string output = Call_jenkins_plugins.Meth_Call_jenkins_plugins();
            if (output == "NotFilledConf")
            {
                MessageBox.Show("Please fill server config at first \n Settings -> Server Settings", "Server config not filled properly", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (output== "NoConnect")
            {
                MessageBox.Show("Please check network connection and server config \n Settings -> Server Settings", "Jenkins or automation server is unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }      

            string[] plugin_array = output.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<Record> listDataSource = new List<Record>();

            string plugin_id;
            string plugin_name;
            string plugin_version;
            for (int i = 0; i < plugin_array.Length; i++)
            {
                plugin_id = (plugin_array[i].Split(' '))[0];
                plugin_array[i] = plugin_array[i].Remove(0, plugin_id.Length);
                string[] each_plugin = plugin_array[i].Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

                if (each_plugin.Length == 2)
                {
                    plugin_name = each_plugin[0];
                    plugin_version = each_plugin[1];
                }  
                else
                {
                    plugin_name = each_plugin[0].Remove(65, each_plugin[0].Length - 65);
                    plugin_version = each_plugin[0].Remove(0, 64);
                }             
           
                listDataSource.Add(new Record(i+1, plugin_id.Trim(), plugin_name.Trim(), plugin_version.Trim()));  
            }

            frm.gridControl_Form_Jenkins_PluginList.DataSource = listDataSource;
            frm.gridView_Form_Jenkins_PluginList.BestFitColumns();
            frm.labelControl_Form_Jenkins_PluginList.Text = "Jenkins Plugins List (" + output.Length + ")";
        }
    }
}
