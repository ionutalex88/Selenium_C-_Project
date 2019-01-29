using OpenQA.Selenium;
using Seleniun_C_Project.aut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class Iframe : CommonObject
    {
        //=======================Constructor===============
        public Iframe(By selector)
        {
            this.selector = selector;
        }

        //=======================Methods===================

        public By GetSelector()
        {
            return this.selector;
        }

        public void SwitchTo()
        {
            AUT.driver.SwitchTo().Frame(this.FindSelf());
        }
        public String GetSource()
        {
            return this.FindSelf().GetAttribute("src");
        }

    }
}
