using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Seleniun_C_Project.config
{
    class Config
    {
        public static String profile;
        public static String browser;
        public static String homepage;
        public static String language;
        public const String configFilePath = "config/config.xml";
	
	    public static String GetHomepage()
        {
            return homepage;
        }

        public static void SetTestProfile(String[] testArgs)
        {
            if (testArgs.Length > 0)
            {
                LoadProfile(testArgs[0]);
            }
            else
            {
                LoadProfile("Default");
            }
        }

        public static void LoadProfile(String profileName)
        {
            try
            {
                bool profileFound = false;
                string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));

                XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
                xmlDoc.Load(projectPath + "/" + configFilePath);
                Console.WriteLine("CONFIGURATION:");
                Console.WriteLine("----------------------------");

                XmlNodeList nList = xmlDoc.GetElementsByTagName("profile");
                for (int temp = 0; temp < nList.Count; temp++)
                {
                    XmlNode nNode = nList[temp];
                   
                    XmlElement eElement = (XmlElement)nNode;
                    profile = eElement.GetAttribute("name");

                    if (profile.Equals(profileName))
                    {
                        profileFound = true;
                        Console.WriteLine("Profile : " + profile);
                        homepage = eElement.GetElementsByTagName("homepage")[0].InnerText;
                        Console.WriteLine("homepage : " + homepage);
                        browser = eElement.GetElementsByTagName("browser")[0].InnerText;
                        Console.WriteLine("browser : " + browser);
                        language = eElement.GetElementsByTagName("language")[0].InnerText;
                        Console.WriteLine("language : " + language);
                        break;
                    }
                }
                if (!profileFound)
                {
                    throw new Exception("Profile: " + profileName + " NOT FOUND");
                }
                Console.WriteLine("----------------------------");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + e.StackTrace);
            }
        }

    }
}
