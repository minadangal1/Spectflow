using NUnitTestProject17.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject17.View
{
   public class SigninPageView
    {
        #region
        string BankLinkText = "Bank Project";
        string BankXpath = "//*[@href='http://demo.guru99.com/V1/index.php']";
        string UseridName = "uid";
        string PasswordName = "password";
        string LoginName = "btnLogin";
        string LogoutXpath = "//*[@href='Logout.php']";
        string MessageBoxId = "//label[text()='Password must not be blank']";
        string Resetname = "btnReset";

        #endregion
        public void SetuserName(string ui )
        {
            //    if (c
            //    {
            //        FrameworkHelper.GetElement(UseridName, IdentifierType.Name).Clear();
            //    }
            
            FrameworkHelper.SetTeXt(ui, UseridName, IdentifierType.Name);
        }
        public void SetPassword(string password)
        {
            FrameworkHelper.SetTeXt(password, PasswordName, IdentifierType.Name);
        }
        public void ClickLoginButton()
        {
            FrameworkHelper.ClickElement(LoginName, IdentifierType.Name);
        }
        public void ClickLogout()
        {
            FrameworkHelper.ClickElement(LogoutXpath, IdentifierType.Xpath);
        }
        public bool GetMessage()
        {
         FrameworkHelper.GetText(MessageBoxId, IdentifierType.Xpath);

            return true;
        }
        public void ClickResetButton()
        {
             FrameworkHelper.ClickElement(Resetname, IdentifierType.Name);
        }
    }
}
