/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 7:01 AM
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
	[TestModule("0DCB9262-4A08-453A-A4B2-135709657D49", ModuleType.UserCode, 1)]
	public class Tc_Landing_Validation: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj=null;
		#endregion   

		#region Constructor		
		public Tc_Landing_Validation()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
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
            	Helper.WaitForTimeInMilliSeconds(3000);
    		 	LandingValidation_Test();
        }
    
	
	
	 public void LandingValidation_Test()
		{
			Helper.WaitForTimeInMilliSeconds(3000);	
	 		Report.Log(ReportLevel.Info, "Validation-Map landingPage");
	 	
	 	if(Helper.IsElementVisible(landingPageObj.LandingMapArea))
	 	{
	 		Report.Log(ReportLevel.Info,"Element is visible");
	 		}
	 	
	 	Helper.ClickElement(landingPageObj.LandingMapArea);
	 	landingPageObj.ZoomLevelTo13();	
		Helper.WaitForTimeInMilliSeconds(6000);
	 		
		}
        
         #endregion
	}
}
