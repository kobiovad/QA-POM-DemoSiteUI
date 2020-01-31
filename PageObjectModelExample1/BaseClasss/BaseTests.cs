using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectModelExample1.BaseClasss
{
    public class BaseTests
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void OpenUrl()
        {
            driver = new ChromeDriver(); // Initializing the driver which web site 
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [OneTimeTearDown]
        public void CloseWeb()
        {
            Thread.Sleep(5000); // wait little bit 
            driver.Close();
        }
    }
}
    
