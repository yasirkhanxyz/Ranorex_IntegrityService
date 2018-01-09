/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 5:26 AM
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
	[TestModule("FEBF6067-B528-4B14-8DB2-F06336A88994", ModuleType.UserCode, 1)]
	public class Tc_CloseBrowser: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		#endregion   

		#region Constructor		
		public Tc_CloseBrowser()
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
           		Helper.WaitTillPageIsLoaded();
				logout_Test();
				Helper.WaitTillPageIsLoaded();
				CloseBrowser_Test();
			
        }
        
        /// <summary>
		/// Actual Test Method
		/// </summary>
		public void CloseBrowser_Test()
		{
			//Close the Browser Instance
			Helper.CloseInstance();
			Helper.CloseBrowser();
		}
	
		public void logout_Test()
			
		{
			//Close the Hover on User and then  click on Log out.
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForElementVisible(loginPageObj.LogoutHover);
			Helper.FocusOnElement(loginPageObj.LogoutHover);
			Helper.WaitForTimeInMilliSeconds(5000);
			loginPageObj.ClickLogoutButton();
		}
       
        #endregion
	}
}
