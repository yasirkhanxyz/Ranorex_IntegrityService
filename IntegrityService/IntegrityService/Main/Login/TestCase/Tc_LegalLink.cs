/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 5:15 AM
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
	/// Description of Tc_LegalLink.
	/// </summary>
	
	[TestModule("9781DE30-6292-4F51-8A81-4E96F996148D", ModuleType.UserCode, 1)]
	public class Tc_LegalLink:ITestModule
	{
		
		#region Module Variables
		
		private static LoginPage loginPageObj= null;
	
		#endregion
		
		
		#region Constructor
		
		public Tc_LegalLink()
		{
			loginPageObj = new LoginPage();
		}
	
		#endregion	
	
	#region Methods
	void ITestModule.Run()
		{
			Preconditions.Init();
			LegalLinkOpening_Test();
			Validate_Main();
			Helper.CloseTab();
						
		}
		/// <summary>
		/// Use ClassInitialize to run code before running the first test in the class
		/// </summary>
		
		public void LegalLinkOpening_Test()
			
		{
			//Click on LegalLink and then verify if Link is opening or not.
			Helper.WaitForElementVisible(loginPageObj.LegalLink);
			Helper.FocusOnElement(loginPageObj.LegalLink);
			Helper.WaitForTimeInMilliSeconds(2000);
			Helper.ClickElement(loginPageObj.LegalLink);
			Helper.WaitForTimeInMilliSeconds(2000);
			
			
		}
		
		public void Validate_Main()
		{
			Report.Log(ReportLevel.Info, "Validation-Legal landingPage");
			Validate.Exists(loginPageObj.LegalLinkPage);
			
		}
		
	#endregion
	
	
	
	}
	
	
	
	
}
