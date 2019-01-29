using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.pages
{
    class SearchResultsPage
    {
        //==========================Objects on page====================
        public objectTypes.CommonObject articleHeadline = new objectTypes.CommonObject(By.CssSelector("article [itemprop=\"headline\"]"));

        //==========================Methods for this page=============================

        /**
         * Checks that all listed articles contain text
         * @param expectedText
         */
        public void CheckAllHeadlinesContainText(String expectedText)
        {
            ReadOnlyCollection<IWebElement> articles = this.articleHeadline.FindAll();
            foreach (IWebElement article in articles)
            {
                StringAssert.Contains(expectedText, article.Text, "Title contains text");
                Console.WriteLine("Check text contains: " + article.Text + " expected " + expectedText);
            }
        }

    }
}
