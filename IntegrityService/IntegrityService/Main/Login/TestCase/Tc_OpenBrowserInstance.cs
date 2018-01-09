/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/9/2017
 * Time: 6:28 AM
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
	/// Description of Tc_OpenBrowserInstance.
	/// </summary>
	 [TestModule("A3A36359-A075-4E15-AB4A-EB812C6194E0", ModuleType.UserCode, 1)]
	public class Tc_OpenBrowserInstance : ITestModule
	{
		#region Module Variables
		
		private LoginPage loginPageObj= null;	
		
		string _varURL = "";
		[TestVariable("a0d73c97-ffb0-45f0-ba58-fe697ce4feab")]
		public string varURL
		{
			get { return _varURL; }
			set { _varURL = value; }
		}
		
		string _varDomain = "";
		[TestVariable("bd0eebf7-a389-446f-bbd2-0728b1f9f381")]
		public string varDomain
		{
			get { return _varDomain; }
			set { _varDomain = value; }
		}
		
		string _varBrowser = "";
		[TestVariable("f97f2408-da2d-4f45-9f56-57e370da8a7f")]
		public string varBrowser
		{
			get { return _varBrowser; }
			set { _varBrowser = value; }
		}
		
		#endregion
		
		#region Contructor
		public Tc_OpenBrowserInstance()
		{
			loginPageObj = new LoginPage();
		}
		#endregion
		
		#region Method
		/// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Preconditions.Init();
			Helper.LoadSettings(varBrowser, varDomain);
			OpenBrowser_Test();
         }
       
       public void OpenBrowser_Test()
		{
			Helper.OpenLoginPage(varURL);
			Helper.WaitForTimeInMilliSeconds(8000);
		}
		#endregion
	}
}
