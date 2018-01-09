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
	[TestModule("CF936AC1-B809-4A2B-8388-2014D0E87EFB", ModuleType.UserCode, 1)]
	public class Tc_PrivateFacilitySearch_Autopopulation: ITestModule
	{
		#region Module Variables
		
		string _FacilityStringcnq = "";
		[TestVariable("083a7f64-32f1-4c44-89fa-d3b52334b53a")]
		public string FacilityStringcnq
		{
			get { return _FacilityStringcnq; }
			set { _FacilityStringcnq = value; }
		}
		
		string _FacilityStringcces = "";
		[TestVariable("89be568e-2a4f-4d88-a3b8-69303d2653e0")]
		public string FacilityStringcces
		{
			get { return _FacilityStringcces; }
			set { _FacilityStringcces = value; }
		}
		
		
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private PrivateFacilityData PrivateFacilityDataObj= null;
		
		
		#endregion   

		#region Constructor		
		public Tc_PrivateFacilitySearch_Autopopulation()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			PrivateFacilityDataObj=new PrivateFacilityData();
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
           		PrivateFacilityDataObj.OpeningPrivateFacilityScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(3000);
            	PrivateFacilityDataObj.LandingPrivateScreen_Validation();
           		PrivateFacilityDataObj.EnterSearchTextinAutoPrivateFacility(FacilityStringcnq,FacilityStringcces);
            	Helper.WaitTillPageIsLoaded();
            	Helper.AutoPopulationVerification(PrivateFacilityDataObj.FirstsearchElementLi);
			
        }
        
       
        #endregion
	}
}
