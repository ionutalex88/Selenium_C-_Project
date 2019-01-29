using OpenQA.Selenium;
using Seleniun_C_Project.objectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.pages
{
    class HomePage
    {
        //==========================Objects on page====================
        public Button signInButton = new Button(By.CssSelector("#idcta-username"));
        public CommonObject accountSection = new CommonObject(By.CssSelector("#idcta-statusbar"));

        public Input seachInput = new Input(By.CssSelector("#orb-search-q"));
        public Button searchButton = new Button(By.CssSelector("#orb-search-button"));
        //==========================Methods for this page=============================

        public String GetAccountName()
        {
            return this.accountSection.GetText();
        }

        /**
         * Performs a search for a specific text
         */
        public void SearchForText(String text)
        {
            this.seachInput.InputText(text);
            this.searchButton.Click();
        }
    }
}
