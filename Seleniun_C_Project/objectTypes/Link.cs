using OpenQA.Selenium;
using Seleniun_C_Project.aut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class Link : CommonObject
    {
        //====================Constructor===============
        public Link(By selector)
        {
            this.selector=selector;
        }

        //=====================Methods==================
        /**
         * Returns the URL indicated by the link
         * @return String
         */
        public String GetURL()
        {
            return GetAttribute("href");
        }

        /**
         * Returns the URL indicated by the link
         * @return String
         */
        public void NavigateTo()
        {
            AUT.driver.Navigate().GoToUrl(GetURL());
            Console.WriteLine("Navigate to link URL of element " + selector.ToString());
        }

    }
}
