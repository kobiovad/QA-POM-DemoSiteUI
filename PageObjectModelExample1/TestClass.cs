using PageObjectModelExample1.BaseClasss;
using PageObjectModelExample1.PageObject;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace PageObjectModelExample1
{

    [TestFixture]
    public class TestClass : BaseTests
    {
        [Test]
        public void LoginPageTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            var dashBoard = loginPage.EnterLogin("Admin", "admin123");
           var assign =  dashBoard.BtnAssignLeave();
            assign.assignLeave("Russel Hamilton", "2020-01-16", "2020-01-22","Well Done Blop !!!\nNow Press The Butoon Assing");
            

        }
    }
}
