﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.IO;

namespace CES_Service_Manager
{
    class Call_jenkins_createProject
    {
        public static string Call(string projectName, string serverName)
        {
            //Load server config data from config file
            Conf_ServerSettings_xml inst_Conf_ServerSettings_xml = new Conf_ServerSettings_xml();

            string[] settingsFromFile = inst_Conf_ServerSettings_xml.LoadDataFromFile().Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

            if (settingsFromFile.Length != 4)
            { return "NotFilledConf"; }


            try
            {
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

                string output = "";
                using (var sshclient = new SshClient(ConnInfo))
                {
                    sshclient.Connect();
                    using (var cmd = sshclient.CreateCommand("python " + path + "jenkins_create_project.py " + GetData_for_call.GetHttp("Jenkins", serverName) + " " + projectName))
                    {
                        cmd.Execute();       
                        string[] stepsArray = (cmd.Result).Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);                     

                        for (int i = 0; i < stepsArray.Length; i++)
                        {
                            output += stepsArray[i] + "\r\n";
                        }
                    }
                    sshclient.Disconnect();
                }
                return output;
            }

            catch
            { return "NoConnect"; }
        }
    }
}