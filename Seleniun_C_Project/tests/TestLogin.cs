using NUnit.Framework;
using Seleniun_C_Project.aut;
using Seleniun_C_Project.config;
using Seleniun_C_Project.testData.dataObjects;
using Seleniun_C_Project.testData.dataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.tests
{
    class TestLogin
    {      
        AUT aut = new AUT("Firefox");

        [SetUp]
        public void Initialize()
        {
            aut.MaximizeScreen();
        }

        [Test]
        public void ValidLogin()
        {
            Console.WriteLine("***Step 1 - Navigate to Homepage***");
            aut.Navigate(Config.GetHomepage());

            Console.WriteLine("***Step 2 - Click on Sign In***");
            aut.homePage.signInButton.Click();

            Console.WriteLine("***Step 3 - Enter Credentials***");
            User testUser = LoginData.myUser;
            aut.loginPage.LoginWithCredentials(testUser.email, testUser.password);

            Console.WriteLine("***Step 3 - Check that user was authenticated***");
            Assert.AreEqual(aut.homePage.GetAccountName(), testUser.firstName + " " + testUser.lastName, "User Name Check");
        }


        [TearDown]
        public void CleanUp()
        {
            aut.CloseBrowser();
        }
    }
}
