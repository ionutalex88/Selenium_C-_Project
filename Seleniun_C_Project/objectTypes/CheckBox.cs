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
    class CheckBox : CommonObject
    {
        //=======================Constructor===================
        public CheckBox(By selector)
        {
            this.selector = selector;
        }

        //=======================Methods=======================

        /**
	     * Will return true if the check-box is selected
	     */
        public bool IsSelected()
        {
            return FindSelf().Selected;
        }

        /**
         * Sets the value of the check-box to "checked"
         */
        public void SetChecked()
        {
            if (!IsSelected())
                Click();
            Console.WriteLine("Set element as checked " + selector.ToString());
        }

        /**
         * Sets the value of the check-box to "unchecked"
         */
        public void SetUnchecked()
        {
            if (IsSelected())
                Click();
            Console.WriteLine("Set element as unchecked " + selector.ToString());
        }
    }
}
