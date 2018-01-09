/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/15/2017
 * Time: 8:21 AM
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
	[TestModule("816E3F07-0C64-43AA-A19B-1B35B9091834", ModuleType.UserCode, 1)]
	public class Tc_HierarchyLandingSearch: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		
		string _SearchText = "";
		[TestVariable("e8109f58-fcf7-4544-a57e-f46bc0f03f02")]
		public string SearchText
		{
			get { return _SearchText; }
			set { _SearchText = value; }
		}
		
				
		#endregion   

		#region Constructor		
		public Tc_HierarchyLandingSearch()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			HierarchyPageObj=new HierarchyPage();
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
            	HierarchyPageObj.OpeningHiererachyScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(3000);
            	HierarchyPageObj.LandingHiererachyScreen_Validation();
            	Helper.WaitTillPageIsLoaded();
    			HierarchyPageObj.firsttime_HierarchyLanding_Test();
    			HierarchyPageObj.MasterReadonly(SearchText);
			
        }
        
       
        #endregion
	}
}
