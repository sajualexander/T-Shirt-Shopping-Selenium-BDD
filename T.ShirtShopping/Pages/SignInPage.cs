using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace Com.Test.SajuAlexander.Pages
{
    public class SignInPage
    {
      
        [FindsBy(How = How.XPath, Using = "//div/a[@title='Log in to your customer account']")]
        private IWebElement lnksignIn;

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        private IWebElement txtemailAddress;

        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        private IWebElement txtpassWord;

        [FindsBy(How = How.XPath, Using = "//button[@id='SubmitLogin']")]
        private IWebElement btnSignIn;
        public bool navigateURL()

        {
            ChromeDriver.DriverInitialize();
            ChromeDriver.GoToURL("http://automationpractice.com");
            //ChromeDriver.GetDriver.Url = ConfigurationManager.AppSettings["ApplicationUrl"].ToString();
            return true;
        }

        public bool clickSignIn()

        {
            
            //lnksignIn.Click();

            return true;
        }

        public bool enterCredentials(string emailAddress, string passWord)
        {
            txtemailAddress.SendKeys(emailAddress);
            txtpassWord.SendKeys(passWord);
            btnSignIn.Click();
            return true;
        }
    }
}
