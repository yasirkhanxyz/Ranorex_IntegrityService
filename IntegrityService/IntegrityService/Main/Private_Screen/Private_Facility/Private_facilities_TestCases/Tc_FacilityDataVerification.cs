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
	[TestModule("6B878AD7-736D-4719-836B-8889A9273E8B", ModuleType.UserCode, 1)]
	public class Tc_FacilityDataVerification: ITestModule
	{
		
		#region Module Variables
		
		string _PrivateFacilityCNQNameverif = "";
		[TestVariable("a493836a-5658-4582-ab4b-56ca1717718d")]
		public string PrivateFacilityCNQNameverif
		{
			get { return _PrivateFacilityCNQNameverif; }
			set { _PrivateFacilityCNQNameverif = value; }
		}
		
		string _PrivateFacilityCCESNameverif = "";
		[TestVariable("32852fb7-db08-4df4-a2f6-dcb380cfb106")]
		public string PrivateFacilityCCESNameverif
		{
			get { return _PrivateFacilityCCESNameverif; }
			set { _PrivateFacilityCCESNameverif = value; }
		}
		

		private LoginPage loginPageObj= null;
		private LandingPage landingPageObj= null;
		private HierarchyPage HierarchyPageObj= null;
		private PrivateFacilityData PrivateFacilityPageObj =null;
		private dtoFacilityClient dtofacilityclientObj =null;
		private FacilityData facilitydataobj=null;
		#endregion   

		
		#region Constructor
		public Tc_FacilityDataVerification()
		{
			loginPageObj = new LoginPage();
			landingPageObj=new LandingPage();
			HierarchyPageObj=new HierarchyPage();
			PrivateFacilityPageObj=new PrivateFacilityData();
			dtofacilityclientObj=new dtoFacilityClient();
			facilitydataobj=new FacilityData();

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
    			PrivateFacilityPageObj.EnterSearchTextinPrivateFacility(PrivateFacilityCNQNameverif,PrivateFacilityCCESNameverif);
    			string Facility_Id =Helper.GetValueTxtField(facilitydataobj.txtFacID);
    			string client_id =Helper.GetClientId();
    			facilitydataobj.MatchFacilityScreenData(client_id,Facility_Id);           		

        }
       
        #endregion
	}
}

	
