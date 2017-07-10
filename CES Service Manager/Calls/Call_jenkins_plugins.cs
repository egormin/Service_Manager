using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace CES_Service_Manager
{
    class Call_jenkins_plugins
    {
        public static string Call(string serverName)
        {            
            //Load server config data from config file
            Conf_ServerSettings_xml inst_Conf_ServerSettings_xml = new Conf_ServerSettings_xml();

            string[] settingsFromFile = inst_Conf_ServerSettings_xml.LoadDataFromFile().Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

            if (settingsFromFile.Length != 4)
            { return "NotFilledConf"; }

         
            try { 
                    string ip = settingsFromFile[0];
                    int port = Convert.ToInt32(settingsFromFile[1]);
                    string user = settingsFromFile[2];
                    string key = settingsFromFile[3];

                    Conf_ScriptsSettings_xml inst_Conf_ScriptsSettings_xml = new Conf_ScriptsSettings_xml();
                    string path = inst_Conf_ScriptsSettings_xml.LoadDataFromFile();

                ConnectionInfo ConnInfo = new ConnectionInfo(ip, port, user,
                    new AuthenticationMethod[] {new PrivateKeyAuthenticationMethod(user, new PrivateKeyFile[]
                   {  // Key Based Authentication (using keys in OpenSSH Format)
                           new PrivateKeyFile(@"" + key + "","passphrase") }),});

                    string output;
                    using (var sshclient = new SshClient(ConnInfo))
                    {
                        sshclient.Connect();
                        using (var cmd = sshclient.CreateCommand("python " + path + "jenkins_plugins.py "  + GetData_for_call.GetScriptPath() + " " + GetData_for_call.GetHttp("Jenkins", serverName)))
                        {
                            cmd.Execute();
                            output = (cmd.Result).Replace("b'", "");
                        }
                        sshclient.Disconnect();
                    }
                    return output;
                }               
              
                catch
                {  return "NoConnect";  }          
        }       
    }
}
