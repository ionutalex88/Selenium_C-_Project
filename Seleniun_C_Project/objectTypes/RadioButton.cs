using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class RadioButton : CommonObject
    {
        //===================Constructor================
        public RadioButton(By selector)
        {
            this.selector=selector;
            // TODO Auto-generated constructor stub
        }

        //===================Methods====================
        /**
         * Will return true if the radio button is selected
         * @return boolean value
         */
        public bool IsSelected()
        {
            return FindSelf().Selected;
        }

        /**
         * Sets the value of the radio button to "checked"
         */
        public void Select()
        {
            Click();
            Console.WriteLine("Click Radio selection " + selector.ToString());
        }

    }
}
