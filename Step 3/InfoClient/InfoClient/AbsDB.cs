using System;
using System.Xml;
//using Microsoft.EntityFrameworkCore;


namespace InfoClient
{
    partial class Program
    {
        class AbsDB
        {
            public String AbsDBHostname = "";
            public String AbsDBName = "";
            public String AbsDBUser = "";
            public String AbsDBPassword = "";

            public void GetAbsDBSettings()
            {
                XmlDocument config = new XmlDocument();
                XmlNodeList nlconfigAbsDB = config.SelectNodes("/Database/AbsDB");
                config.Load(AppDomain.CurrentDomain.BaseDirectory + "Config.xml");
                foreach (XmlNode nl2 in nlconfigAbsDB)
                {
                    AbsDBHostname = (nl2.SelectSingleNode("Hostname") != null ? nl2["Hostname"].InnerText : "");
                    AbsDBName = (nl2.SelectSingleNode("Name") != null ? nl2["Name"].InnerText : "");
                    AbsDBUser = (nl2.SelectSingleNode("User") != null ? nl2["User"].InnerText : "");
                    AbsDBPassword = (nl2.SelectSingleNode("Password") != null ? nl2["Password"].InnerText : "");
                }
            }
        }
    }
}
