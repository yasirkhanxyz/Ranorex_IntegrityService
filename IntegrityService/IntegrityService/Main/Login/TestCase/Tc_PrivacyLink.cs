/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 5:36 AM
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
	/// Description of Tc_CantAccessAccount.
	/// </summary>
	[TestModule("10727707-7433-47CB-96C8-EEC7E925784E", ModuleType.UserCode, 1)]
	public class Tc_PrivacyLink: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		#endregion   

		#region Constructor		
		public Tc_PrivacyLink()
		{
			loginPageObj = new LoginPage();
		}
		#endregion
		
		#region Methods
		 /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
           	Preconditions.Init();
			Validate_Year();
			PrivacyLinkOpening_Test();
			Validate_Main();
			Helper.CloseTab();
        }
        
       public void PrivacyLinkOpening_Test()
			
		{
			//Click on PrivacyLink and then verify if Link is opening or not.
			Helper.WaitForElementVisible(loginPageObj.PrivacyLink);
			Helper.FocusOnElement(loginPageObj.PrivacyLink);
			Helper.WaitForTimeInMilliSeconds(2000);
			Helper.ClickElement(loginPageObj.PrivacyLink);
			Helper.WaitForTimeInMilliSeconds(2000);
			
		}
    
  	
		//validating the Version on the Login page -2013-2017.
		
		public void Validate_Year()
		{
           Report.Log(ReportLevel.Info, "Validation- Version Year");
           Validate.Exists(loginPageObj.CertYear);
       }
		
		// using Legal link  to verify.as it points the same page Pro stream.
	public void Validate_Main()
       {
           Report.Log(ReportLevel.Info, "Validation-Legal landingPage");
           Validate.Exists(loginPageObj.LegalLinkPage);
       }
        #endregion
	}
}
