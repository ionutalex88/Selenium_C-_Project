using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class SelectBox : CommonObject
    {
        //=====================Constructor=====================
        public SelectBox(By selector)
        {
            this.selector=selector;
            // TODO Auto-generated constructor stub
        }

        //=====================Methods==========================
        /**
         * Selects an option by text
        */
        public void SelectOption(String optionText)
        {
            SelectElement selectBox = new SelectElement(FindSelf());
            selectBox.SelectByText(optionText);
            Console.WriteLine("Select option " + optionText + " from element " + selector.ToString());
        }

        /**
         * Selects an option by index
        */
        public void SelectOption(int index)
        {
            SelectElement selectBox = new SelectElement(FindSelf());
            selectBox.SelectByIndex(index);
            Console.WriteLine("Select option at index " + index + " from element " + selector.ToString());
        }


        /**
         * Returns the selected option of the SelectBox
        */
        public String GetSelectedOption()
        {
            SelectElement selectBox = new SelectElement(FindSelf());
            return selectBox.SelectedOption.Text;
        }

        /**
         * Selects an option by value
        */
        public void SelectByValue(String value)
        {
            SelectElement selectBox = new SelectElement(FindSelf());
            selectBox.SelectByValue(value);
            Console.WriteLine("Select option with value " + value + " from element " + selector.ToString());
        }

        /**
         * Returns all the available options
        */

    public List<String> GetOptions()
        {
            SelectElement selectBox = new SelectElement(FindSelf());
            IList<IWebElement> elements = selectBox.Options;
            List<String> elementsText = null;
            for (int i = 0; i < elements.Count; i++)
                elementsText.Add(elements[i].Text);
            return elementsText;
        }
    }

}
