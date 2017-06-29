using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace CES_Service_Manager
{
    class Set_TestConnection
    {
        public static string Check_Connection(string ip, string port, string user, string key)
        {

            ConnectionInfo ConnInfo = new ConnectionInfo(ip, user, new AuthenticationMethod[]{
                new PrivateKeyAuthenticationMethod(user, new PrivateKeyFile[]{ new PrivateKeyFile(@"" + key + "","") }),});

            string result = "";
            using (var sshclient = new SshClient(ConnInfo))
            {
                try
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
                catch (Exception)
                {
                   
                }
              
            }
            return result;
        }
    }
}
// Key Based Authentication (using keys in OpenSSH Format)