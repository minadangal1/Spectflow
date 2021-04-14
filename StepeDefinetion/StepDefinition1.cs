using NUnitTestProject17.Helper;
using NUnitTestProject17.Test;
using NUnitTestProject17.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject1.StepeDefinetion
{
    [Binding]
    public sealed class StepDefinition1:BasepageTest
    {
        public StepDefinition1() : base()
        {

        }
        [Given(@"I am Navigate to the Url ""(.*)"";")]
        public void GivenIAmNavigateToTheUrl(string p0)
        {
            FrameworkHelper.WebDriver.Url = p0;
        }

        [Given(@"I enter the Login information")]
        public void GivenIEnterTheLoginInformation(Table table)
        {
            var tebleData = table.CreateDynamicSet();
            foreach (var item in tebleData)
            {
                //  for (int i = 0; i < table.RowCount; i++)
                //  {

                SigninPageView signinPageView = new SigninPageView();

                signinPageView.SetuserName(item.UserId);
                signinPageView.SetPassword(item.Password);
                signinPageView.ClickLoginButton();
                Console.WriteLine(item.Password);

                

                if (FrameworkHelper.IfAlertIsPresent() == true)
                {
                    FrameworkHelper.WebDriver.SwitchTo().Alert().Accept();
                    FrameworkHelper.WebDriver.SwitchTo().DefaultContent();
                }
               
                else
                {

                    
                    signinPageView.ClickLogout();
                    FrameworkHelper.WebDriver.SwitchTo().Alert().Accept();
                    FrameworkHelper.WebDriver.SwitchTo().DefaultContent();

                }
               



            }
        }

        [Then(@"the click the login button")]
        public void ThenTheClickTheLoginButton()
        {
            SigninPageView signinPageView = new SigninPageView();
            signinPageView.SetuserName("mngr318486");
            signinPageView.SetPassword("UrYgYpA");
            signinPageView.ClickLoginButton();
            string a = "mina";
        }


    }
}
