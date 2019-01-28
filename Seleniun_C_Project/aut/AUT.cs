using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Seleniun_C_Project.pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seleniun_C_Project.aut
{
    class AUT
    {
        public static IWebDriver driver;

        //===============================Constructors===========================
        public AUT()
        {
            driver = new ChromeDriver();
        }

        //===============================Pages===========================
        public HomePage homePage = new HomePage();


        //===============================Methods=========================

        /**
        * Navigates to the indicated URL
        */
        public void Navigate(String URL)
        {
            driver.Navigate().GoToUrl(URL);
            Console.WriteLine("Navigate to :" + URL);
        }

        /**
	     * Maximizes WebDriver screen
	     */
        public void MaximizeScreen()
        {
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize Screen");
        }

        /**
        * Closes driver instance
        */
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
            Console.WriteLine("Closed Browser");
        }

        /**
         * Checks that the page test contains
         */
        public bool PageContains(String text)
        {
            return driver.PageSource.Contains(text);
        }

        /**
         * Waits for a given amount of seconds
         */
        public void Sleep(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            Console.WriteLine("wait for " + seconds + " seconds");
        }


        /**
         * Takes a screenshot and store it in the indicated output file
         */
        //public void takescreenshot(string outputfile)
        //{
        //    file screenshot = ((takesscreenshot)driver).getscreenshotas(outputtype.file);
        //    try
        //    {
        //        fileutils.copyfile(screenshot, new file(outputfile));
        //    }
        //    catch (ioexception e)
        //    {
        //        e.printstacktrace();
        //    }
        //}

        /**
         * Send keys to browser
         */
        public void SendKeys(String keysToSend)
        {
            Actions action = new Actions(driver);
            action.SendKeys(keysToSend);
            Console.WriteLine("Insert keys: " + keysToSend);
        }

        /**
         * Navigates back
         */
        public void NavigateBack()
        {
            driver.Navigate().Back();
            Console.WriteLine("Navigate back");
        }

        /**
         * Navigates forward
         */
        public void NavigateForward()
        {
            driver.Navigate().Forward();
            Console.WriteLine("Navigate forward");
        }

        /**
         * Refresh page
         */
        public void RefreshPage()
        {
            driver.Navigate().Refresh();
            Console.WriteLine("Refresh page");
        }

        public void SetTimeout(int seconds)
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(seconds);
        }

        /**
         * Switches context to window with given title
         */
        public void SwitchToWindow(String windowTitle)
        {
            driver.SwitchTo().Window(windowTitle);
        }

        /**
         * Switches to last opened window
         */
        public void SwitchToLastWindow()
        {
            ReadOnlyCollection<string> windows = driver.WindowHandles;
            String lastElement = windows[windows.Count - 1].ToString();

            Console.WriteLine("Switched to window = " + lastElement);
            this.SwitchToWindow(lastElement);
        }

        /**
         * Gets Current window handle string
         * @return
         */
        public String GetCurrentWindow()
        {
            return driver.CurrentWindowHandle;
        }

        /**
         * Closes currently selected window
         */
        public void CloseWindow()
        {
            driver.Close();
        }

    }
}
