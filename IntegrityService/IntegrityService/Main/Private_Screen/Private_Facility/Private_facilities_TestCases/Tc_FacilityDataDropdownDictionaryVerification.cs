/*
 * Created by Ranorex
 * User: ykhan
 * Date: 7/14/2017
 * Time: 7:50 AM
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
	/// Description of Tc_FacilityDataDropdownDictionaryVerification.
	/// </summary>
	
	[TestModule("816E3F07-0C74-41AA-A29B-1B36B9091834", ModuleType.UserCode, 1)]
	public class Tc_FacilityDataDropdownDictionaryVerification : ITestModule
		
	{
	
		#region Module Variables
		
		string _PrivateFacilityCNQName = "";
		[TestVariable("12a29f27-b431-4ee5-9fef-428e17f7b82a")]
		public string PrivateFacilityCNQName
		{
			get { return _PrivateFacilityCNQName; }
			set { _PrivateFacilityCNQName = value; }
		}
		
		
		string _PrivateFacilityCCESName = "";
		[TestVariable("9f58d2d7-77b3-43af-b6c9-6d080ba51f8e")]
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
		public Tc_FacilityDataDropdownDictionaryVerification()
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
    		var innervalx=Helper.GetDropdownvalue(PrivateFacilityPageObj.FacilityStatus_DataDic);
                Report.Log(ReportLevel.Info,"Entered FacilityCode '" + innervalx + "'.");
         }
        
       
        #endregion
        
}
}
