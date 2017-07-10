using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CES_Service_Manager
{
    class GetData_for_call
    {
        public static string GetHttp(string system, string serverName)
        {
            string result = "";
            XDocument xdoc = XDocument.Load("config/Environment/" + system + ".xml");
            foreach (XElement el in xdoc.Root.Elements())
            {
                if (Convert.ToString(el.Name) == serverName)
                {
                    foreach (var item in el.Elements())
                    {
                        if (item.Name=="httpLink")
                        {
                            result = el.Value;
                            break;
                        }
                    }
              
                }
            }

            return result;
        }


        public static string GetScriptPath()
        {
            string result = "";
            XDocument xdoc = XDocument.Load("config/ScriptsConfiguration.xml");
            foreach (XElement el in xdoc.Root.Elements())
            {
                if (Convert.ToString(el.Name) == "ScriptsPath")
                {
                    result = el.Value;
                }
            }

            return result;
        }
    }
}