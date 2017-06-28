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

            using (var sshclient = new SshClient(ConnInfo))
            {
                sshclient.Connect();
                using (var cmd = sshclient.CreateCommand("mkdir /tmp/XXX"))
                {
                    cmd.Execute();
                    //string sss = cmd.ExitStatus;
                   // Console.WriteLine("Command>" + cmd.CommandText);
                   // Console.WriteLine("Return Value = {0}", cmd.ExitStatus);
                }
                sshclient.Disconnect();
            }

            return "OK";
        }
    }
}
// Key Based Authentication (using keys in OpenSSH Format)