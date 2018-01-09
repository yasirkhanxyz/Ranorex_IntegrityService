/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/9/2017
 * Time: 6:20 AM
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
	[TestModule("6B848AD7-736D-4719-878B-8889A9273E8B", ModuleType.UserCode, 1)]
	public class Tc_CantAccessAccount: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		#endregion   

		#region Constructor		
		public Tc_CantAccessAccount()
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
			CantAccessAccount_Test();
        }
        
        public void CantAccessAccount_Test()
			
		{
			//Click on CantAccessAccount Link and then verify if element is opening or not.
			Helper.WaitForElementVisible(loginPageObj.CantAcessLink);
			Helper.FocusOnElement(loginPageObj.CantAcessLink);
			Helper.WaitForTimeInMilliSeconds(2000);
			Helper.ClickElement(loginPageObj.CantAcessLink);
			Helper.WaitForTimeInMilliSeconds(2000);
			Helper.IsElementVisible(loginPageObj.PasswordRetrievelBox);
			Helper.WaitForTimeInMilliSeconds(2000);
			Helper.ClickElement(loginPageObj.PasswordRetrieveCancelBtn);
			Helper.WaitForTimeInMilliSeconds(2000);
		}
        #endregion
	}
}
