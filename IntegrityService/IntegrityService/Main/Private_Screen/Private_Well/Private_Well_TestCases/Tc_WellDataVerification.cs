/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/22/2017
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
	/// Description of Tc_FacilityDataVerification.
	/// </summary>
	[TestModule("6B878AD7-716D-4719-836B-8889A9273E8B", ModuleType.UserCode, 1)]
	public class Tc_WellDataVerification: ITestModule
	{
		
		#region Module Variables
		
		string _PrivateWellCNQNameverif = "";
		[TestVariable("9ad2c0b7-dc61-40aa-a88f-e82cd1dd5d1b")]
		public string PrivateWellCNQNameverif
		{
			get { return _PrivateWellCNQNameverif; }
			set { _PrivateWellCNQNameverif = value; }
		}
		
		string _PrivateWellCCESNameverif = "";
		[TestVariable("998e2368-4944-472d-bef5-b6fd00295531")]
		public string PrivateWellCCESNameverif
		{
			get { return _PrivateWellCCESNameverif; }
			set { _PrivateWellCCESNameverif = value; }
		}
		
		
		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		private PrivateWellData PrivateWellPageObj =null;
		private dtoWellClient dtoWellclientObj =null;
		private WellData Welldataobj=null;
		#endregion   

		
		#region Constructor
		public Tc_WellDataVerification()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			HierarchyPageObj=new HierarchyPage();
			PrivateWellPageObj=new PrivateWellData();
			dtoWellclientObj=new dtoWellClient();
			Welldataobj=new WellData();

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
           		Helper.WaitForTimeInMilliSeconds(5000);
           		PrivateWellPageObj.OpeningPrivateWellScreen();
            	Helper.WaitTillPageIsLoaded();
            	Helper.WaitForTimeInMilliSeconds(5000);
            	PrivateWellPageObj.LandingPrivateWellScreen_Validation();
            	Helper.WaitTillPageIsLoaded();
    			PrivateWellPageObj.EnterSearchTextinPrivateWell(PrivateWellCNQNameverif,PrivateWellCCESNameverif);
    			string Well_Id =Helper.GetValueTxtField(Welldataobj.txtUWI);
    			string client_id =Helper.GetClientId();
    			Welldataobj.MatchWellScreenData(client_id,Well_Id);           		

        }
       
        #endregion
	}
}

	
