using NUnit.Framework;
using OpenQA.Selenium;
using Seleniun_C_Project.objectTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.pages
{
    class ArticlePage
    {
        //==========================Objects on page====================
        public Button shareArticleButton = new Button(By.CssSelector("button[title=\"Share this page\"]"));
        public Link socialMediaOption = new Link(By.CssSelector(".s-b-p-networks a"));

        //==========================Methods for this page=============================

        public void CheckForSocialMediaOption(String socialMediaOption)
        {
            List<String> socialMediaOptionsTitles = new List<String>();
            ReadOnlyCollection<IWebElement> options = this.socialMediaOption.FindAll();
            foreach (IWebElement option in options)
            {
                socialMediaOptionsTitles.Add(option.Text.Trim());
            }
            Assert.Contains(socialMediaOption, socialMediaOptionsTitles, "Check presence of " + socialMediaOption);
        }

        public void ClickOnSocialMediaOption(String socialMediaOption)
        {
            List<String> socialMediaOptionsTitles = new List<String>();
            ReadOnlyCollection<IWebElement> options = this.socialMediaOption.FindAll();
            bool found = false;
            foreach (IWebElement option in options) {
                if(option.Text.Trim().Equals(socialMediaOption)){
                    option.Click();
                    found = true;
                }
            }
            if (!found){
                Assert.Fail("Media option: " + socialMediaOption + " NOT FOUND");
            }
        }
    }
}
