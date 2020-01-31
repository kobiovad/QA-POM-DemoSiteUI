using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjectModelExample1.PageObject
{
    public class LeavePage
    {
        IWebDriver driver;
        public LeavePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "assignleave_txtEmployee_empName")]
        public IWebElement txtEmployeeName { get; set; }

        [FindsBy(How = How.Id, Using = "assignleave_txtFromDate")]
        public IWebElement txtFromDate { get; set; }

        [FindsBy(How = How.Id, Using = "assignleave_txtToDate")]
        public IWebElement txtToDate { get; set; }

        [FindsBy(How = How.Id, Using = "assignleave_txtComment")]
        public IWebElement txtComment { get; set; }

        //[FindsBy(How = How.XPath, Using = "")]
        //public IWebElement btnAssing { get; set; }


        public void assignLeave(string EmployeeName, string FromDate, string ToDate, string Comment)
        {
            txtEmployeeName.SendKeys(EmployeeName);
            dropDownSelected();
            txtFromDate.Clear();
            txtFromDate.SendKeys(FromDate);
            txtToDate.Clear();
            txtToDate.SendKeys(ToDate);
            dropDownSelectedHidden();
            txtComment.SendKeys(Comment);
            //btnAssing.Click();
        }
        public void dropDownSelected()
        {
            SelectElement drpLeaveType = new SelectElement(driver.FindElement(By.Id("assignleave_txtLeaveType")));
            drpLeaveType.SelectByText("Paternity US");
        }
        public void dropDownSelectedHidden()
        {
            SelectElement drpPartialDays = new SelectElement(driver.FindElement(By.Id("assignleave_txtLeaveType")));

             // לבדוק למה המשתנה מוסתר וכיצד לחפש אותו ???

            
        }

    }
}
