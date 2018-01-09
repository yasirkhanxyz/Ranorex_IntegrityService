/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/15/2017
 * Time: 8:30 AM
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
	[TestModule("CF836AC4-B809-4A2B-8388-2014D0E87EFB", ModuleType.UserCode, 1)]
	public class Tc_PrivateWellSearch_Autopopulation: ITestModule
	{
		#region Module Variables
		
		string _WellStringcnq = "";
		[TestVariable("a1631581-637d-473f-be2f-4dfe7a39ad09")]
		public string WellStringcnq
		{
			get { return _WellStringcnq; }
			set { _WellStringcnq = value; }
		}
		
		string _WellStringcces = "";
		[TestVariable("b1dca895-751f-4b8c-b6ce-ee17818820f3")]
		public string WellStringcces
		{
			get { return _WellStringcces; }
			set { _WellStringcces = value; }
		}
				
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private PrivateWellData PrivateWellDataObj= null;
		
		
		#endregion   

		#region Constructor		
		public Tc_PrivateWellSearch_Autopopulation()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			PrivateWellDataObj=new PrivateWellData();
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
           		PrivateWellDataObj.OpeningPrivateWellScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(3000);
            	PrivateWellDataObj.LandingPrivateWellScreen_Validation();
           		PrivateWellDataObj.EnterSearchTextinAutoPrivateWell(WellStringcnq,WellStringcces);
            	Helper.WaitTillPageIsLoaded();
            	Helper.AutoPopulationVerification(PrivateWellDataObj.FirstsearchElementLi1);
        	
        }
        
       
        #endregion
	}
}
