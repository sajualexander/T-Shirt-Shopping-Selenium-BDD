using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Test.SajuAlexander.Pages
{
    public static class TestPages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            return page;
        }

        public static SignInPage SignIn
        {
            get { return GetPage<SignInPage>(); }
        }

        public static OrderPage Order
        {
            get { return GetPage<OrderPage>(); }
        }

        public static AccountsPage MyAccounts
        {
            get { return GetPage<AccountsPage>(); }
        }
    }
}
