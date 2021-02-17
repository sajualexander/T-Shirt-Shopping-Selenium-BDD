using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Test.SajuAlexander
{
    public class ChromeDriver
    {
        private static OpenQA.Selenium.Chrome.ChromeDriver _driver;


        public static void DriverInitialize()
        {
           
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();

            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(30);
        }

       
        public static void GoToURL(string url)
        {
            ChromeDriver._driver.Url = url;
        }

       
        public static void QuitDriver()
        {
            ChromeDriver._driver.Quit();
        }

    
        public static OpenQA.Selenium.Chrome.ChromeDriver GetDriver
        {
            get => ChromeDriver._driver;
        }
    }

}

