using OpenQA.Selenium;
using Seleniun_C_Project.objectTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.pages
{
    class LoginPage
    {
        //==========================Objects on page====================
        public Input email = new Input(By.CssSelector("#user-identifier-input"));
        public Input password = new Input(By.CssSelector("#password-input"));

        public Button submitButton = new Button(By.CssSelector("#submit-button"));

        public CommonObject loginErrorText = new CommonObject(By.CssSelector(".form-message--error .form-message__text"));

        //==========================Methods for this page=============================
        /**
         * Performs a login operation using the given parameters
         * @param email
         * @param password
         */
        public void LoginWithCredentials(String email, String password)
        {
            this.email.InputText(email);
            this.password.InputText(password);
            submitButton.Click();
        }

        public String GetLoginErrorText()
        {
            return this.loginErrorText.GetText();
        }
    }
}
