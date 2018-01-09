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
	[TestModule("CF931AC1-B809-4A2B-8388-2014D0E87EFB", ModuleType.UserCode, 1)]
	public class Tc_HierarchySearch_Autopopulation: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		
		string _HierarchyName = "";
		[TestVariable("896763dd-77c9-4e16-bc35-3112c6f8fd79")]
		public string HierarchyName
		{
			get { return _HierarchyName; }
			set { _HierarchyName = value; }
		}
		
		#endregion   

		#region Constructor		
		public Tc_HierarchySearch_Autopopulation()
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
           		HierarchyPageObj.EnterSearchTextinHierarchy(HierarchyName);
            	Helper.WaitTillPageIsLoaded();
            	Helper.AutoPopulationVerification(HierarchyPageObj.HierarchyAutopopulationABlist1);
			
        }
        
       
        #endregion
	}
}
