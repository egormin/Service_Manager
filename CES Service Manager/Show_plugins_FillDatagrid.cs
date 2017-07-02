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
            public int NUM { get { return num; } }
            public string Plugin_Name
            {
                get { return plug_name; }
                set { plug_name = value; }
            }
            public string Age
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


        public void execut()
        {
            var frm = GetForm<Form_Jenkins_PluginList>();

            DataTable dt = new DataTable();
            dt.Columns.Add("Num", Type.GetType("System.String"));
            dt.Columns.Add("Plugin Name", Type.GetType("System.String"));
            dt.Columns.Add("System Name", Type.GetType("System.String"));
            dt.Columns.Add("Plugin Version", Type.GetType("System.String"));

            //   frm.gridColumn1.
        

            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);

            dt.Rows.Clear();


            string ip;
            string user;
            string command;
            int port;
            string key;

            ip = "192.168.138.13";
            port = 22;
            user = "root";
            key = "D:/keys/eg_priv_os.ppk";

            ConnectionInfo ConnInfo = new ConnectionInfo(ip, port, user,
               new AuthenticationMethod[]{
                new PrivateKeyAuthenticationMethod(user, new PrivateKeyFile[]{  // Key Based Authentication (using keys in OpenSSH Format)
                    new PrivateKeyFile(@"" + key + "","passphrase")          }),
                                         }
                                                       );

            string[] variants;
            using (var sshclient = new SshClient(ConnInfo))
            {
                sshclient.Connect();
                using (var cmd = sshclient.CreateCommand("python /tmp/jenkins_plugins.py"))
                // using (var cmd = sshclient.CreateCommand("python --version"))
                {
                    cmd.Execute();
                    string output = (cmd.Result).Replace("b'","");
                     variants = output.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] variants1 = variants[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    string s = variants[0];

                    char[] x = { ' ' };

                    int i = s.IndexOfAny(x);
                    //string sss = variants[0].Remove(35,55);
                    string vvv = variants[0].Substring(35, 55).Trim();
                    // string[] variants2 = sss.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);

                    //string sss = cmd.ExitStatus;
                    // Console.WriteLine("Command>" + cmd.CommandText);
                    // Console.WriteLine("Return Value = {0}", cmd.ExitStatus);
                }
                sshclient.Disconnect();
            }



            List<Record> listDataSource = new List<Record>();

            string a,b,c;

            for (int i = 0; i < variants.Length; i++)
            {
                //a = variants[i].Substring(0, 33).Trim();
                //b = variants[i].Substring(33, 55).Trim();
                //c = variants[i].Substring(50, 53).Trim();
                string sss;
                string[] variants2 = variants[i].Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
                if (variants2.Length==2)
                {
                    try
                    {
                        sss = (variants2[1].Remove(0, 65)).Trim();
                    }
                    catch (Exception e)
                    {
                        sss = "XXXXXXXXXXXXXXXXXX";
                    }
                   
                }
                else
                {
                    try
                    { sss = variants2[2]; }
                    catch (Exception e)
                    {
                        sss = "XXXXXXXXXXXXXXXXXX";
                    }

                }
                // listDataSource.Add(new Record(i, variants[i].Substring(0, 34).Trim(), variants[i].Substring(0, 10).Trim(), variants[i].Substring(0, 5).Trim()));

                try
                { listDataSource.Add(new Record(i+1, variants2[0], variants2[1], sss)); }
                catch (Exception e)
                {
                   
                }
                //listDataSource.Add(new Record(i, a, b, c));
            }

          frm.gridControl1.DataSource = listDataSource;
            frm.gridView1.BestFitColumns();


        }



    }
}
