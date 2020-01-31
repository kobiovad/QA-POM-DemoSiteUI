using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelExample1.PageObject
{
    public class DashboardPage
    {
        IWebDriver driver;
        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        #region - QuickLaunch
        [FindsBy(How = How.XPath, Using = "//td[1]//div[1]//a[1]")]
        public IWebElement btnAssignLeave { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[2]//div[1]//a[1]")]
        public IWebElement btnLeaveList { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[3]//div[1]//a[1]")]
        public IWebElement btnTimesHeets { get; set; }
        #endregion

        public LeavePage BtnAssignLeave()
        {
            btnAssignLeave.Click();
            return new LeavePage(driver);
        }
        public void BtnLeaveList()
        {
            btnLeaveList.Click();
        }
        public void BtnTimesHeets()
        {
            btnTimesHeets.Click();
        }


    }
}
