/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/13/2017
 * Time: 6:44 AM
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
	/// Description of Tc_PrivateFacilityLandingSearch.
	/// </summary>
	[TestModule("816E3F07-0C74-43AA-A29B-1B36B9091834", ModuleType.UserCode, 1)]
	public class Tc_privateFacilityLandingSearch : ITestModule
	{
		#region Module Variables
	
	string _PrivateFacilityCNQName = "";
	[TestVariable("940ca432-f7a2-4708-8dc1-65cf7cf0a847")]
	public string PrivateFacilityCNQName
	{
		get { return _PrivateFacilityCNQName; }
		set { _PrivateFacilityCNQName = value; }
	}
	
	
	string _PrivateFacilityCCESName = "";
	[TestVariable("5c0acc9a-0d36-4e74-b084-76f1324dba35")]
	public string PrivateFacilityCCESName
	{
		get { return _PrivateFacilityCCESName; }
		set { _PrivateFacilityCCESName = value; }
	}
		
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		private PrivateFacilityData PrivateFacilityPageObj =null;
		#endregion   

		#region Constructor		
		public Tc_privateFacilityLandingSearch()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			HierarchyPageObj=new HierarchyPage();
			PrivateFacilityPageObj=new PrivateFacilityData();
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
           		PrivateFacilityPageObj.OpeningPrivateFacilityScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(3000);
            	PrivateFacilityPageObj.LandingPrivateScreen_Validation();
            	Helper.WaitTillPageIsLoaded();
    			PrivateFacilityPageObj.EnterSearchTextinPrivateFacility(PrivateFacilityCNQName,PrivateFacilityCCESName);
    						
        }
        
       
        #endregion
	}
}
