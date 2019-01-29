using NUnit.Framework;
using Seleniun_C_Project.aut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.tests
{
    class ArticlesSearch
    {
        AUT aut = new AUT();
        [SetUp]
        public void Initialize()
        {
            aut.MaximizeScreen();
        }



        [Test]
        public void Articles_Search()
        {
            Console.WriteLine("***Step 1 - Navigate to Homepage***");
            aut.Navigate("http://www.bbc.com");

            Console.WriteLine("***Step 2 - Search for some words***");
            String searchedText = "San Antonio Spurs";
            aut.homePage.SearchForText(searchedText);

            Console.WriteLine("***Step 3 - Check results tile***");
            aut.searchResultsPage.CheckAllHeadlinesContainText(searchedText);
        }



        [TearDown]
        public void CleanUp()
        {
            aut.CloseBrowser();
        }
    }
}
