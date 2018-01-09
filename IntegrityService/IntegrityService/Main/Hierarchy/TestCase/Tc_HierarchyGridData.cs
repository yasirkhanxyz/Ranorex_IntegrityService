/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/23/2017
 * Time: 6:48 AM
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
	/// Description of Tc_Hierarchy Grid data.
	/// </summary>
	[TestModule("6B878AD7-736D-4719-878B-8889A9273E8B", ModuleType.UserCode, 1)]
	public class Tc_HierarchyGridData: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		private HierarchyPage HierarchyPageObj =null;
		#endregion   

		#region Constructor		
		public Tc_HierarchyGridData()
		{
			loginPageObj = new LoginPage();
			HierarchyPageObj = new HierarchyPage();
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
           		HierarchyPageObj.PipelineGridMasterCount();
           		HierarchyPageObj.WellGridMasterCount();
           		HierarchyPageObj.FacilityGridMasterCount();
           		HierarchyPageObj.ConnectionGridMasterCount();
           		HierarchyPageObj.MeasureGridMasterCount();
			
        }
        
       
        #endregion
	}
}

	
