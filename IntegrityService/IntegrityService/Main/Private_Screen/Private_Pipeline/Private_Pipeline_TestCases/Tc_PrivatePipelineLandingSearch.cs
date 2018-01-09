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
	[TestModule("816E3F07-0C74-43AA-A79B-1B36B9091834", ModuleType.UserCode, 1)]
	public class Tc_privatePipelineLandingSearch : ITestModule
	{
		#region Module Variables
	
	string _PrivatePipelineCNQName = "";
	[TestVariable("3eecd8c3-491f-45ce-9bc6-a73cf755b44d")]
	public string PrivatePipelineCNQName
	{
		get { return _PrivatePipelineCNQName; }
		set { _PrivatePipelineCNQName = value; }
	}
	
	
	string _PrivatePipelineCCESName = "";
	[TestVariable("e689d942-6b70-4695-80ab-6c02294f590d")]
	public string PrivatePipelineCCESName
	{
		get { return _PrivatePipelineCCESName; }
		set { _PrivatePipelineCCESName = value; }
	}
	
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		private PrivatePipelineData PrivatePipelinePageObj =null;
		#endregion   

		#region Constructor		
		public Tc_privatePipelineLandingSearch()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			HierarchyPageObj=new HierarchyPage();
			PrivatePipelinePageObj=new PrivatePipelineData();
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
           		PrivatePipelinePageObj.OpeningPrivatePipelineScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(3000);
            	PrivatePipelinePageObj.LandingPrivatePipelineScreen_Validation();
            	Helper.WaitTillPageIsLoaded();
    			PrivatePipelinePageObj.EnterSearchTextinPrivatePipeline(PrivatePipelineCNQName,PrivatePipelineCCESName);
    						
        }
        
       
        #endregion
	}
}
