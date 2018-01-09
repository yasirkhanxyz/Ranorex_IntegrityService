/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 4:19 AM
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
	/// Description of Tc_Login.
	/// </summary>
	[TestModule("02E2CDA5-F411-4382-A8B7-D965CCEE08EE", ModuleType.UserCode, 1)]
	
	public class Tc_Login: ITestModule
	{
		
	#region Module Variables
		
		 private LoginPage loginPageObj= null;
		 
		 string _varUserName = "";
		 [TestVariable("5d860179-b308-4b01-8d74-b188f0138f4c")]
		 public string varUserName
		 {
		 	get { return _varUserName; }
		 	set { _varUserName = value; }
		 }
		 

		
		string _varPassword = "";
		[TestVariable("5622af94-15ea-4598-8b56-7ce6d46862af")]
		public string varPassword
		{
			get { return _varPassword; }
			set { _varPassword = value; }
		}
		


#endregion	


#region Constructor	

public Tc_Login()
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
           	OpenLogin_Test();
        }
		
		public void OpenLogin_Test()
		{
			
			loginPageObj.EnterUserName(varUserName);
			Helper.WaitForTimeInMilliSeconds(2000);
			loginPageObj.EnterPassword(varPassword);
			Helper.WaitForTimeInMilliSeconds(2000);
			loginPageObj.ClickLoginPage();
			Helper.WaitForTimeInMilliSeconds(2000);
			loginPageObj.ClickLoginButton();
			Helper.WaitForTimeInMilliSeconds(2000);
						
		}
        #endregion
		
	}
}
