using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;

namespace CES_Service_Manager
{
   public partial class Conf_ServerSettings_xml
    {
        private string filePath = "config/configuration.xml";
      
        /// <summary>
        /// Load data from config to form
        /// </summary>

        public string LoadDataFromFile()
        {
            string result = "";

            if (!Directory.Exists(filePath.Split('/')[0]))
            {
                Directory.CreateDirectory(filePath.Split('/')[0]);
            }

            if (File.Exists(filePath))
            {                             
                XDocument xdoc = XDocument.Load(filePath);
                foreach (XElement el in xdoc.Root.Elements())
                {
                    switch (Convert.ToString(el.Name))
                    {
                        case "IP":
                            {
                                result += el.Value + "#";
                                break;
                            }
                        case "Port":
                            {
                                result += el.Value + "#";
                                break;
                            }
                        case "User":
                            {
                                result += el.Value + "#";
                                break;
                            }
                        case "KeyPath":
                            {
                                result += el.Value;
                                break;
                            }
                    }              
                }
            }
            return result;
        }
        
        /// <summary>
        /// Change data in config file
        /// </summary>
        public void Change_settings(string ip, string port, string user, string key)
        {

            XDocument doc = new XDocument(new XElement("RemoteServerConfiguration",
             new XElement("IP", ip),
             new XElement("Port", port),
             new XElement("User", user),
             new XElement("KeyPath", key)));
            //save config
            doc.Save(filePath);

        }

    }
}
