using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Com.Test.SajuAlexander.Pages;
using NUnit.Framework;

namespace Com.Test.SajuAlexander.StepDefinitions
{
    [Binding]
    public class Steps
    {
        SignInPage _signinPage = TestPages.SignIn;
        OrderPage _orderPage = TestPages.Order;
        AccountsPage _accountsPage = TestPages.MyAccounts;

        [Given(@"I navigate to the shopping website")]
        public void GivenINavigateAndSigninToTheWebsite()
        {
            Assert.IsTrue(_signinPage.navigateURL());
        }

        [Given(@"I navigate to the signin page")]
        public void GivenINavigateToTheSigninPage()
        {

            Assert.IsTrue(_signinPage.clickSignIn());

        }

        [Given(@"I enter the emailid as ""(.*)"" and password as ""(.*)""")]
        public void GivenIEnterTheEmailidAsAndPasswordAs(string emailAddress, string passWord)
        {
            Assert.IsTrue(_signinPage.enterCredentials(emailAddress, passWord));
        }

        [Given(@"I add T\.Shirt in the cart")]
        public void GivenIAddT_ShirtInTheCart()
        {
            Assert.IsTrue(_orderPage.addtoCart());
        }

        [Given(@"I confirm my order")]
        public void GivenIConfirmMyOrder()
        {
            Assert.IsTrue(_orderPage.confirmOrder());
        }

        [Given(@"I navigate to Order History page")]
        public void GivenINavigateToOrderHistoryPage()
        {
            Assert.IsTrue(_orderPage.navigatetoOrderHistory());
        }


        [Then(@"I verify the order with reference number ""(.*)"" is placed in Order History page")]
        public void ThenIVerifyTheOrderWithReferenceNumberIsPlacedInOrderHistoryPage(string orderReference)
        {
            Assert.IsTrue(_orderPage.verifyorderisCreated(orderReference));
        }

        [Given(@"I navigate to Personal Information page")]
        public void GivenINavigateToPersonalInformationPage()
        {
            Assert.IsTrue(_accountsPage.navigatetopersonalInformation());
            
        }

        [Given(@"I update the firstname in My Accounts")]
        public void GivenIUpdateTheFirstnameInMyAccounts()
        {
            Assert.IsTrue(_accountsPage.updateFirstName()); 
        }

    }
}
