using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace CES_Service_Manager
{
    class Conf_EnvironmentJenkins_xml
    {
        private string filePath = "config/EnvironmentJenkins.xml";

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
                        case "Host":
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
        public void Change_settings(string path)
        {

            XDocument doc = new XDocument(new XElement("JenkinsHosts",
             new XElement("Host", path)));

            //save config
            doc.Save(filePath);

        }

    }
}
