using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;   // Key Based Authentication (using keys in OpenSSH Format)

namespace CES_Service_Manager
{
    class Set_TestConnection
    {
        public static string Check_Connection(string ip, int port, string user, string key)
        {
            string result = "";
           
            try
            {
                ConnectionInfo ConnInfo = new ConnectionInfo(ip, port, user, new AuthenticationMethod[]{
                new PrivateKeyAuthenticationMethod(user, new PrivateKeyFile[]{ new PrivateKeyFile(@"" + key + "","") }),});
              
                using (var sshclient = new SshClient(ConnInfo))
                {
                    sshclient.Connect();
                    using (var cmd = sshclient.CreateCommand("hostname"))
                    {
                        cmd.Execute();
                        result = (cmd.Result).Replace("\n", "\r\n");
                        //string sss = cmd.ExitStatus;
                        // Console.WriteLine("Command>" + cmd.CommandText);
                        // Console.WriteLine("Return Value = {0}", cmd.ExitStatus);
                    }
                    sshclient.Disconnect();
                }
            }
            catch (Exception ex)
            {
               // string err = ex.ToString();
            }

            return result;
        }       
    }
}
