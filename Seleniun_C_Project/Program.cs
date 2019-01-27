using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project
{
    class Program
    {

        //Create the reference for browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.google.ro");
            Console.WriteLine("Open URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //EnterText(element, value, type)

            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("execute C# selenium test");

            Console.WriteLine("Executed test");
        }

        [Test]
        public void SecondTest()
        {
            Console.WriteLine("Second Test");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
            Console.WriteLine("Closed Browser");
        }
    }
}
