/*
 * Created by Ranorex
 * User: ykhan
 * Date: 7/12/2017
 * Time: 5:20 AM
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
using IntegrityService.Database;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace IntegrityService
{
	/// <summary>
	/// Description of Tc_PipelineDataVerification.
	/// </summary>
	[TestModule("6B878AD7-736D-4779-836B-8889A9273E8B", ModuleType.UserCode, 1)]
	public class Tc_PipelineDataVerification: ITestModule
	{
		
		#region Module Variables
		
		string _PrivatePipelineCNQNameverif = "";
		[TestVariable("46e2af9b-d540-4e9d-b784-0c7d1f5b6be4")]
		public string PrivatePipelineCNQNameverif
		{
			get { return _PrivatePipelineCNQNameverif; }
			set { _PrivatePipelineCNQNameverif = value; }
		}
		
		
		string _PrivatePipelineCCESNameverif = "";
		[TestVariable("4afa3944-2169-4b36-8ab6-af0f5cb9bd97")]
		public string PrivatePipelineCCESNameverif
		{
			get { return _PrivatePipelineCCESNameverif; }
			set { _PrivatePipelineCCESNameverif = value; }
		}
		
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		private PrivatePipelineData PrivatePipelinePageObj =null;
		private dtoPipelineClient dtoPipelineclientObj =null;
		private PipelineData Pipelinedataobj=null;
		#endregion   

		
		#region Constructor
		public Tc_PipelineDataVerification()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			HierarchyPageObj=new HierarchyPage();
			PrivatePipelinePageObj=new PrivatePipelineData();
			dtoPipelineclientObj=new dtoPipelineClient();
			Pipelinedataobj=new PipelineData();

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
    			PrivatePipelinePageObj.EnterSearchTextinPrivatePipeline(PrivatePipelineCNQNameverif,PrivatePipelineCCESNameverif);
    	//		Helper.ScrollToVisibleElement(Pipelinedataobj.txtLicenseLine);
    			string Pipeline_Id =Helper.GetValueTxtField(Pipelinedataobj.txtLicenseLine);
    			string[] pipe= Pipeline_Id.Split('-');
    			string license =pipe[0];
    			string line =pipe[1];
    			string segment =pipe[2];
    			string client_id =Helper.GetClientId();
    			Pipelinedataobj.MatchPipelineScreenData(client_id,license,line,segment);           		
        }
       
        #endregion
	}
}

	
