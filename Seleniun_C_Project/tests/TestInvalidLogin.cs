using NUnit.Framework;
using Seleniun_C_Project.aut;
using Seleniun_C_Project.testData.dataObjects;
using Seleniun_C_Project.testData.dataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.tests
{
    class TestInvalidLogin
    {
        AUT aut = new AUT();
        [SetUp]
        public void Initialize()
        {
            aut.MaximizeScreen();
        }

        [Test]
        public void InvalidLogin()
        {
            Console.WriteLine("***Step 1 - Navigate to Homepage***");
            aut.Navigate("http://www.bbc.com");

            Console.WriteLine("***Step 2 - Click on Sign In***");
            aut.homePage.signInButton.Click();

            Console.WriteLine("***Step 3 - Enter Credentials***");
            User testUser = LoginData.invalidUser;
            aut.loginPage.LoginWithCredentials(testUser.email, testUser.password);

            Console.WriteLine("***Step 3 - Check the error message***");
            Assert.AreEqual(aut.loginPage.GetLoginErrorText(), LoginData.invalidCredentialsErrorText, "Check error message");
        }



        [TearDown]
        public void CleanUp()
        {
            aut.CloseBrowser();
        }
    }
}
