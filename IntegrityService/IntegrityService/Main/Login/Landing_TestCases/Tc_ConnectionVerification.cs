/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 7:15 AM
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
	[TestModule("C036E8B8-B23D-4466-A9CA-6777866CB66D", ModuleType.UserCode, 1)]
	public class Tc_ConnectionVerification: ITestModule
	{
		#region Module Variables
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj=null;
		
		string _RelocationWellName = "";
		[TestVariable("80529fea-63f6-4495-ba2f-7fde41de0123")]
		public string RelocationWellName
		{
			get { return _RelocationWellName; }
			set { _RelocationWellName = value; }
		}
		
		#endregion   

		#region Constructor		
		public Tc_ConnectionVerification()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
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
            Helper.WaitForTimeInMilliSeconds(3000);
    		Connection_validation();
    		Relocating_CommonArea();
    		Helper.WaitForTimeInMilliSeconds(8000);
    		landingPageObj.ValidatingAssetOnMap();
        }
    
        public void Connection_validation()
        {
        
        	Helper.WaitForTimeInMilliSeconds(3000);
        	if(Helper.IsElementVisible(landingPageObj.LandingMapArea))
	 	{
	 		Report.Log(ReportLevel.Info,"Element is visible");
	 		}
	 	
	 	Helper.ClickElement(landingPageObj.LandingMapArea);
	 	landingPageObj.ZoomLevelTo13();	
		Helper.WaitForTimeInMilliSeconds(6000);
		        
        }
    
         // Created to Enter a Well Code in Quick search to land on Area having all Pipes.
    	public void EnterWellName(string RelocationWellName)
		{
			Helper.EnterText(landingPageObj.LandingQuickSearchBox, RelocationWellName);
		//	inputs.namedItem("userNameTxtBox").fireEvent("onblur");
			Report.Log(ReportLevel.Info,"Entered wellName '" + RelocationWellName + "'.");
		}
        
        
        // Created a Combination ofa ction to land on the common Area
        public void Relocating_CommonArea()
        {
        	Helper.WaitForTimeInMilliSeconds(3000);
        	Helper.ClickElement(landingPageObj.LandingQuickSearchBox);
        	EnterWellName(RelocationWellName);
        	Helper.WaitForTimeInMilliSeconds(3000);
        	Helper.ClickElement(landingPageObj.LandingSearchIcon);
        	Helper.WaitForTimeInMilliSeconds(9000);
        }
			  
        #endregion
	}
}
