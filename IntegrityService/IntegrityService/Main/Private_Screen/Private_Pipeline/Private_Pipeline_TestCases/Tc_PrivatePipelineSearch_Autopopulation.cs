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
	[TestModule("CF866AC7-B809-4A2B-8388-2014D0E87EFB", ModuleType.UserCode, 1)]
	public class Tc_PrivatePipelineSearch_Autopopulation: ITestModule
	{
		#region Module Variables
		
		string _PipelineStringcnq = "";
		[TestVariable("3a22e337-2b62-4209-b871-6433c8016098")]
		public string PipelineStringcnq
		{
			get { return _PipelineStringcnq; }
			set { _PipelineStringcnq = value; }
		}
		
		string _PipelineStringcces = "";
		[TestVariable("181c2bb4-e4dc-48f5-a439-f3ef893d3d4a")]
		public string PipelineStringcces
		{
			get { return _PipelineStringcces; }
			set { _PipelineStringcces = value; }
		}
				
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private PrivatePipelineData PrivatePipelineDataObj= null;
		
		
		#endregion   

		#region Constructor		
		public Tc_PrivatePipelineSearch_Autopopulation()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			PrivatePipelineDataObj=new PrivatePipelineData();
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
           		PrivatePipelineDataObj.OpeningPrivatePipelineScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(3000);
            	PrivatePipelineDataObj.LandingPrivatePipelineScreen_Validation();
           		PrivatePipelineDataObj.EnterSearchTextinAutoPrivatePipeline(PipelineStringcnq,PipelineStringcces);
            	Helper.WaitTillPageIsLoaded();
            	Helper.AutoPopulationVerification(PrivatePipelineDataObj.FirstsearchElementLi2);
        }
        #endregion
	}
}
