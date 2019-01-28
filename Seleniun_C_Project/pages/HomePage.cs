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
        public Button signInButton = new Button(By.CssSelector("#idcta-username"));
    }
}
