using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Seleniun_C_Project.aut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class Button : CommonObject
    {
        //=======================Constructor===================
        public Button(By selector)
        {
            this.selector = selector;
        }

        //=======================Methods=======================

        /**
         * Performs a double click action on the object
         */
        public void DoubleClick()
        {
            Actions action = new Actions(AUT.driver);
            action.DoubleClick(FindSelf()).Perform();
            Console.WriteLine("Double click on element " + selector.ToString());
        }

        /**
         * Performs a right click action on the object
         */
        public void RightClick()
        {
            Actions action = new Actions(AUT.driver);
            action.ContextClick(FindSelf()).Perform();
            Console.WriteLine("Right click on element " + selector.ToString());
        }
    }
}
