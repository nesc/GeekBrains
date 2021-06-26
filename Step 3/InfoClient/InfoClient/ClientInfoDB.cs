using System;
using System.Xml;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class ClientInfoDB
        {
            public String ClientInfoDBHostname = "";
            public String ClientInfoDBName = "";
            public String ClientInfoDBUser = "";
            public String ClientInfoDBPassword = "";

            public void GetClientInfoDBSettings()
            {
                XmlDocument config = new XmlDocument();
                XmlNodeList nlconfigInfoClientDB = config.SelectNodes("/Database/InfoClientDB");
                config.Load(AppDomain.CurrentDomain.BaseDirectory + "Config.xml");
                foreach (XmlNode nl2 in nlconfigInfoClientDB)
                {
                    ClientInfoDBHostname = (nl2.SelectSingleNode("Hostname") != null ? nl2["Hostname"].InnerText : "");
                    ClientInfoDBName = (nl2.SelectSingleNode("Name") != null ? nl2["Name"].InnerText : "");
                    ClientInfoDBUser = (nl2.SelectSingleNode("User") != null ? nl2["User"].InnerText : "");
                    ClientInfoDBPassword = (nl2.SelectSingleNode("Password") != null ? nl2["Password"].InnerText : "");
                }
            }
        }
    }
}
