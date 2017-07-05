using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace CES_Service_Manager
{
    class Conf_ScriptsSettings_xml
    {
        private string filePath = "config/ScriptsConfiguration.xml";

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
                        case "ScriptsPath":
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

            XDocument doc = new XDocument(new XElement("ScriptsConfiguration",
             new XElement("ScriptsPath", path)));

            //save config
            doc.Save(filePath);

        }

    }
}
