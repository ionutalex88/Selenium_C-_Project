using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Seleniun_C_Project.aut;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class CommonObject
    {
        protected By selector;

        //=====================Constructor===================
        public CommonObject(By selector)
        {
            this.selector = selector;
        }
        public CommonObject() { }
        //=====================Methods=======================
        /**Returns a IWebElement as a result of applying the suitable find method
         * @return
         */
        public IWebElement FindSelf()
        {
            return AUT.driver.FindElement(selector);
        }

        /**Returns a <List>IWebElement as a result of applying the suitable find method
         * @return
         */
        public ReadOnlyCollection<IWebElement> FindAll()
        {
            return AUT.driver.FindElements(selector);
        }

        /**
         * Returns the plain text of the selected object
         * @return text under object
         */
        public String GetText()
        {
            return FindSelf().Text;
        }

        /**
         * Performs a click action on the object
         */
        public void Click()
        {
            FindSelf().Click();
            Console.WriteLine("Click on element " + selector.ToString());
        }

        /**Verifies if the object is enabled
         * @return bool value
         */
        public bool IsEnabled()
        {
            return FindSelf().Enabled;
        }

        /**Verifies if the object is visible
         * @return bool value
         */
        public bool IsDisplayed()
        {
            return FindSelf().Displayed;
        }

        /**
         * Returns the value of the given attribute
         * @param attributeName
         * @return String value of the attribute
         */
        public String GetAttribute(String attributeName)
        {
            return FindSelf().GetAttribute(attributeName);
        }

        /**
        * Moves the mouse over the selected object
        */
        public void Hover()
        {
            Actions action = new Actions(AUT.driver);
            action.MoveToElement(FindSelf()).Perform();
            Console.WriteLine("Hover over element " + selector.ToString());
        }
    }
}
