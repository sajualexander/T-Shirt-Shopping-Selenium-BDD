using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Com.Test.SajuAlexander.Pages
{
    public class OrderPage
    {
        [FindsBy(How = How.XPath, Using = "(//a[@title='T-shirts'])[2]")]
        private IWebElement lnkTShirt;

        [FindsBy(How = How.XPath, Using = "//i[@class='icon-th-list']")]
        private IWebElement btnList;

        [FindsBy(How = How.XPath, Using = "//a[@title='Add to cart']")]
        private IWebElement btnaddtoCart;

        [FindsBy(How = How.XPath, Using = "//a[@title='Proceed to checkout']")]
        private IWebElement btnpopUpProceedCheckout;

        [FindsBy(How = How.XPath, Using = "//span[text()='Proceed to checkout']")]
        private IWebElement btnProceedCheckout;

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement cbTermsofservice;

        [FindsBy(How = How.XPath, Using = "//a[@title='Pay by bank wire']")]
        private IWebElement lnkpaybyBank;

        [FindsBy(How = How.XPath, Using = "//span[text()='I confirm my order']")]
        private IWebElement lnkorderConfirmation;

        [FindsBy(How = How.XPath, Using = "//a[@title='View my customer account']")]
        private IWebElement lnkCustomerAccount;

        [FindsBy(How = How.XPath, Using = "//span[text()='Order history and details']")]
        private IWebElement btnOrderHistory;
        

        [FindsBy(How = How.LinkText, Using = "FBSINLIVE")]
        private IWebElement orderReferenceNo;


        public bool addtoCart()
        {
            lnkTShirt.Click();
            btnList.Click();
            btnaddtoCart.Click();
            return true;
        }

        public bool confirmOrder()
        {
            btnpopUpProceedCheckout.Click();
            for(int i=0;i<3;i++)
            {
                btnProceedCheckout.Click();
            }

            cbTermsofservice.Click();
            btnProceedCheckout.Click();
            lnkpaybyBank.Click();
            lnkorderConfirmation.Click();
            return true;
        }

        public bool navigatetoOrderHistory()
        {
            lnkCustomerAccount.Click();
            btnOrderHistory.Click();

            return true;

        }
        public bool verifyorderisCreated(string orderReference)
        {

            Assert.AreEqual(orderReference, orderReferenceNo.Text);
            return true;
        }
    }
}
