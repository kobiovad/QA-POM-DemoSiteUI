using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObjectModelExample1.PageObject
{
    public class LoginPage
    {

        IWebDriver driver;
        public LoginPage(IWebDriver driver) // to build auto constractor write ctor and double click
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this); // need to reflect the driverUrl           
        }

        [FindsBy(How = How.Id,Using = "txtUsername")]
        public IWebElement txtuserName { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        public IWebElement btnLogin { get; set; }


        public DashboardPage EnterLogin(string userNmae,string password)
        {
            //UserName
            txtuserName.SendKeys(userNmae);
            //Password
            txtPassword.SendKeys(password);
            //Click button
            btnLogin.Submit();
            
            // Navigate To Dashboard 
            return new DashboardPage(driver); 
        }
        
    }
}
