/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/9/2017
 * Time: 5:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace IntegrityService
{
	/// <summary>
	/// Description of LoginPage.
	/// </summary>
	public class LoginPage
	{
 		#region ELEMENTS XPATH
		
		public string userNameTxtBox = ".//input[#'Account_Landing_Email']";
		public string passwordTxtBox = ".//input[#'Account_Landing_Password']";
		public string loginarea =".//body[#'Account_Landing']";
		public string loginBtn = ".///body[#'Account_Landing']/div[2]/div/div[1]/div[3]/div[1]/button[@innertext='Sign in']";
		public string CantAcessLink = ".//body[#'Account_Landing']/div[2]/div/div[1]/div[3]/div[1]/a[@innertext~'Can''t access your account?']";
		public string PasswordRetrievelBox =".//span[#'ForgotPasswordHolder_wnd_title']";
		public string PasswordRetrieveCancelBtn=".//div[#'ForgotPasswordPartial']/table/tbody/tr[4]/td[3]/input[@type='button']";
		public string LegalLink = ".//body[#'Account_Landing']/div[3]/*/a[@innertext~'Legal']";
		public string LegalLinkPage ="./dom[@domain='www.prostream.com']//div[#'main']";
		public string PrivacyLink = ".//body[#'Account_Landing']/div[3]/*/a[@innertext~'Privacy']";
		public string CertYear = ".//body[#'Account_Landing']/div[3]/div[@innertext~'2013 - 2017']";
		public string GdmLogo = ".//body[#'Account_Landing']/div[2]/div/div[2]/div[1]";
		public string DashboardLabel = ".//div[#'Index_Dashboard']/a/span[@innertext='Dashboard']";
		public string logOutBtn = ".//ul[#'Index_Menu_Items']/?/?/span[@innertext~'Log Out' and @class='k-link']";
		public string loggedInAsDiv = ".//div[#'loggedInAs']";
		public string logoImg=".//img[@src='https://isstgweb2.promonitor.ca/Images/Landing/Logo_Critical%20Control_Blue_White_dark-outline.png']";
		public string LogoutHover=".//div[#'Index_Header']/ul[4]/li[1]/span/span[@class='k-icon k-i-arrow-s']";
		
		#endregion
	
		#region Consturtor
		public LoginPage()
		{
		}
		#endregion
	
		#region Events
	
		/// <summary>
		/// Enter User Name
		/// </summary>
		public void EnterUserName(string UName)
		{
				Helper.EnterText(userNameTxtBox, UName);
				Helper.SetReportLog(Ranorex.ReportLevel.Info, "Entered username '" + UName + "'.");
		}
		
		public void EnterPassword(string UPassword)
		{
			Helper.EnterText(passwordTxtBox, UPassword);
			Helper.SetReportLog(ReportLevel.Info,"Entered password '" + UPassword);
		}
		
		//Click on Login button
		public void ClickLoginButton()
		{
			Helper.ClickElement(loginBtn);
			Helper.SetReportLog(ReportLevel.Info,"Clicked on Login button.");
		}     
   
		//Click on Login Page
		public void ClickLoginPage()
		{
			Helper.ClickElement(loginarea);
			Helper.SetReportLog(ReportLevel.Info,"Clicked on Login Area.");
		}     
   
   		//Click on Logout button
		public void ClickLogoutButton()
		{
			Helper.ClickElement(logOutBtn);
			Helper.SetReportLog(ReportLevel.Info,"Clicked on Logout button.");
		}
   
   		//Check Is User Already Logged In
		public void CheckIsUserAlreadyLoggedIn()
		{
			if(Helper.IsUserAlreadyLoggedIn(logOutBtn))
			{
				Helper.ClickElement(logOutBtn);
			}
		}
		
		public void ClickLogo()
		{
			Helper.ClickElement(logoImg);
			Helper.SetReportLog(ReportLevel.Info,"Clicked on Logout button.");
		}
   
   		//Check After user is logged in
		public void VerifyIsUserLoggedIn(string UserName)
		{
			Helper.SetReportLog(ReportLevel.Info,"Checking if User logged in.");
			if(Helper.IsElementVisible(logOutBtn))
			{
				if(Helper.VerifyInnerHtmlValue(UserName, loggedInAsDiv))
				{
					Helper.HighlightElement(loggedInAsDiv);
					Helper.SetReportLog(ReportLevel.Info,"User logged in successfully.");
				}
			}
			else
			{
				throw new ElementNotFoundException("User is not logged in.");
			}
		}
		
		#endregion
	}
}
