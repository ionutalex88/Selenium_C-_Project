using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniun_C_Project.objectTypes
{
    class Table : CommonObject
    {
        //=====================Constructor=====================
        public Table(By selector)
        {
            this.selector=selector;
        }

        //=======================Methods=======================

        //Note - these methods might be changed to match different types of tables

        /**
         * Returns the IWebElement representing the cell positioned at the indicated location by parameters
         */
        public IWebElement GetCell(int row, int column)
        {
            return FindSelf().FindElement(By.CssSelector("tr:nth-of-type(" + row + ") td:nth-of-type(" + column + ")"));
        }


        /**
         * Returns the text contained by the cell positioned at the indicated location by parameters
         */
        public String GetCellText(int row, int column)
        {
            return GetCell(row, column).Text;
        }

        /**
         * Returns the column's header text indicated by parameter
         */
        public String GetHeaderText(int column)
        {
            IWebElement headerCell = FindSelf().FindElement(By.CssSelector("th:nth-of-type(" + column + ")"));
            return headerCell.Text;
        }

        /**
         * Clicks on the center of the cell at index provided by parameters
         * First cell 1,1
         */
        public void ClickCell(int row, int column)
        {
            GetCell(row, column).Click();
            Console.WriteLine("Click on row " + row + " column " + column + " of table " + selector.ToString());
        }

    }
}
