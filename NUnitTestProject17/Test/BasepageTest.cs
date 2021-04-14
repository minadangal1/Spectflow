using NUnit.Framework;
using NUnitTestProject17.Helper;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject17.Test
{
   public class BasepageTest
    {
        public BasepageTest()
        {
            BeforeTestMethod();
        }
        [SetUp]
        public void BeforeTestMethod()

        {
           // _test = Reporter.CreateTest(TestContext.CurrentContext.Test.Name);
            // string path = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\driver");
            // FrameworkHelper.WebDriver = new ChromeDriver(path);
            FrameworkHelper.WebDriver = new ChromeDriver(@"C:\Driver\chromedriver_win32");
            FrameworkHelper.wait = new WebDriverWait(FrameworkHelper.WebDriver, TimeSpan.FromSeconds(30));


            NavigeteToUrl();

        }
        public void NavigeteToUrl()
        {
            FrameworkHelper.WebDriver.Url = "http://demo.guru99.com/test/newtours/";
        }
    }
}
