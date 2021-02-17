using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Com.Test.SajuAlexander.Pages
{
    public class AccountsPage
    {
        [FindsBy(How = How.XPath, Using = "//a[@title='View my customer account']")]
        private IWebElement lnkCustomerAccount;

        [FindsBy(How = How.XPath, Using = "//span[text()='My personal information']")]
        private IWebElement btnpersonalInformation;

        [FindsBy(How = How.XPath, Using = "//input[@id='firstname']")]
        private IWebElement txtfirstName;

        [FindsBy(How = How.XPath, Using = "//button[@name='submitIdentity']")]
        private IWebElement btnSave;
        

        public bool navigatetopersonalInformation()
        {
            lnkCustomerAccount.Click();
            btnpersonalInformation.Click();

            
            
            return true;
        }
        public bool updateFirstName()
        {
         

            txtfirstName.Clear();
            txtfirstName.SendKeys("firstnameupdated");

            btnSave.Click();
            return true;
        }
    }
}
