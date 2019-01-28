using NUnit.Framework;
using Seleniun_C_Project.aut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.tests
{
    class DummyTest
    {
        AUT aut = new AUT();
        [SetUp]
        public void Initialize()
        {
            aut.MaximizeScreen();
        }



        [Test]
        public void myTest()
        {
            aut.Navigate("http://www.bbc.com");
            aut.homePage.signInButton.Click();
            aut.Sleep(5);

          
            
        }



        [TearDown]
        public void CleanUp()
        {
            aut.CloseBrowser();
        }
    }
}
