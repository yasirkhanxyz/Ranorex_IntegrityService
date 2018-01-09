/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/14/2017
 * Time: 6:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using WinForms = System.Windows.Forms;
using IntegrityService.Database;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace IntegrityService
{
	/// <summary>
	/// Description of Tc_PrivateFacilityLandingSearch.
	/// </summary>
	[TestModule("A3A36359-A075-4E15-AB4A-EB812C6394E0", ModuleType.UserCode, 1)]
	public class Tc_privateWellLandingSearch : ITestModule
	{
		#region Module Variables
	
	
	
	string _PrivateWellCNQName = "";
	[TestVariable("d5d9ad61-0549-4c64-8e96-5dedee69efa8")]
	public string PrivateWellCNQName
	{
		get { return _PrivateWellCNQName; }
		set { _PrivateWellCNQName = value; }
	}
	
		
		string _PrivateWellCCESName = "";
		[TestVariable("fbc08c4d-292d-4168-92a4-a06ba09bbef1")]
		public string PrivateWellCCESName
		{
			get { return _PrivateWellCCESName; }
			set { _PrivateWellCCESName = value; }
		}
		
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		private PrivateWellData PrivateWellPageObj =null;
		#endregion   

		#region Constructor		
		public Tc_privateWellLandingSearch()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			HierarchyPageObj=new HierarchyPage();
			PrivateWellPageObj=new PrivateWellData();
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
           		PrivateWellPageObj.OpeningPrivateWellScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(3000);
            	PrivateWellPageObj.LandingPrivateWellScreen_Validation();
            	Helper.WaitTillPageIsLoaded();
    			PrivateWellPageObj.EnterSearchTextinPrivateWell(PrivateWellCNQName,PrivateWellCCESName);
    						
        }
        
       
        #endregion
	}
}
