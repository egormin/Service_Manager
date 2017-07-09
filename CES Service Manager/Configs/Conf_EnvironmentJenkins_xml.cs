using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace CES_Service_Manager
{
    class Conf_EnvironmentJenkins_xml
    {
        private string filePath = "config/Environment/Jenkins.xml";

        public string LoadDataFromFile()
        {
            string result = "";

            if (!Directory.Exists(filePath.Split('/')[1]))
            {
                Directory.CreateDirectory("config/" + filePath.Split('/')[1]);
            }

            if (File.Exists(filePath))
            {
                XDocument xdoc = XDocument.Load(filePath);
                foreach (XElement el in xdoc.Root.Elements())
                {
                    result += el.Name + "#";
                    //switch (Convert.ToString(el.Name))
                    //{
                    //    case "Jenkins":
                    //        {
                    //            result += el.Value;
                    //            break;
                    //        }
                    //}
                }
            }
            else
            {
                XmlTextWriter textWritter = new XmlTextWriter(filePath, Encoding.UTF8);

                textWritter.WriteStartDocument();
                textWritter.WriteStartElement("Jenkins");

                textWritter.WriteEndElement();
                textWritter.Close();
            }
            return result;
        }

        /// <summary>
        /// Change data in config file
        /// </summary>
        public void Change_settings(string path)
        {

            //XDocument doc = new XDocument(new XElement("JenkinsHosts",
            // new XElement("Host", path)));

            //   XDocument doc = new XDocument(new XElement("JenkinsHosts", new XElement("jenkins.epam.com", new XElement("httpLink", "https://jenkins/epam.com"), new XElement("host","evpbyminsv485"), new XElement("ip", "10.6.87.12"))));

            //save config
            //    doc.Save(filePath);
            

            XmlTextWriter textWritter = new XmlTextWriter(filePath, Encoding.UTF8);

            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("Jenkins");

            textWritter.WriteEndElement();
            textWritter.Close();
        }


        public void Add_Server(string name, string http)
        {
            name = name.Replace(" ","");
            XmlDocument document = new XmlDocument();
            document.Load(filePath);    

            XmlNode element = document.CreateElement(name);
            document.DocumentElement.AppendChild(element);

            XmlNode subElement = document.CreateElement("httpLink");
            subElement.InnerText = http;
            element.AppendChild(subElement);

            document.Save(filePath);
        }

    }
}
