using NUnit.Framework;
using Seleniun_C_Project.aut;
using Seleniun_C_Project.testData.dataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.tests
{
    class ShareArticleToFacebook
    {

        AUT aut = new AUT();
        [SetUp]
        public void Initialize()
        {
            aut.MaximizeScreen();
        }

        [Test]
        public void Article_ShareToFacebook()
        {
            Console.WriteLine("***Step 1 - Navigate to Homepage***");
            aut.Navigate("http://www.bbc.com");

            Console.WriteLine("***Step 2 - Search for some text and click on the first result***");
            String searchedText = "San Antonio Spurs";
            aut.homePage.SearchForText(searchedText);
            aut.searchResultsPage.articleHeadline.Click();

            Console.WriteLine("***Step 3 - Click on share button and check for Facebook Share option***");
            aut.articlePage.shareArticleButton.Click();
            aut.articlePage.CheckForSocialMediaOption("Facebook");

            Console.WriteLine("***Step 4 - Click on Facebook and check redirect***");
            aut.articlePage.ClickOnSocialMediaOption("Facebook");

            String mainWindow = aut.GetCurrentWindow();
            aut.SwitchToLastWindow();
            StringAssert.Contains(SocialMediaData.facebookLoginMessage, aut.facebookShareLogin.content.GetText(), "New window contains message");

            Console.WriteLine("***Step 5 - Close Facebook share window***");
            aut.CloseWindow();
            aut.SwitchToWindow(mainWindow);
        }

        [TearDown]
        public void CleanUp()
        {
            aut.CloseBrowser();
        }
    }
}
