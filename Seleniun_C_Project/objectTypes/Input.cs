using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class Input : CommonObject
    {
        //===================Constructor==================
        public Input(By selector)
        {
            this.selector = selector;
        }
        public Input() { }

        //====================Methods=====================
        /**
         * Fills the input field with the given text
         */
        public void InputText(String text)
        {
            FindSelf().SendKeys(text);
            Console.WriteLine("Set text " + text + " on field " + selector.ToString());
        }

        /**
         * Clears all text in the input filed
         */
        public void ClearText()
        {
            FindSelf().Clear();
            Console.WriteLine("Clear all text on filed" + selector.ToString());
        }

    }
}
