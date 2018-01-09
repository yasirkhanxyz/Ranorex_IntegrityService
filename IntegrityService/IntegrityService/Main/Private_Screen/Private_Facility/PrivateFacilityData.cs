/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/9/2017
 * Time: 8:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using WinForms = System.Windows.Forms;
using IntegrityService.Database;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;


namespace IntegrityService


{
	/// <summary>
	/// Description of PrivateFacilityData.
	/// </summary>
	public class PrivateFacilityData
	{
		
		#region Module Variables
		
		private static LoginPage loginPageObj= null;
		private static LandingPage landingPageObj= null;
		private HierarchyDB hierarchyDBobj=null; 
		#endregion
		
		#region Scenario Specific ELEMENTS XPATH
		public string AssetHover=".//div[#'menu']/ul/?/?/div/ul//span[@innertext~'Assets']";
		public string PrivateFacilityClk=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[6]/?/?/span[@innertext='Facility Data']";
	//	public string PrivateFacilitywindowwndtitle="./body/div[169]/?/?/span[@innertext~'Data Integrity - Facility Data' and @class='ui-dialog-title' and @id='ui-id-72']";
	//	public string PrivateFacilitywindowwndtitle="./body/div[163]/?/?/span[@innertext~'Data Integrity - Facility Data']";
		public string PrivateFacilitywindowwndtitle="./body/div[146]/?/?/span[@innertext~'Data Integrity - Facility Data']";
		public string PrivateFacilitySearchTextBox=".//input[#'DataIntegrity_FacilityData_Search']";
	//	public string FirstsearchElementLi="./body/div[163]/ul[6]/?/?/div[@class='ui-menu-item-wrapper' and @tabindex='-1']";								
		public string FirstsearchElementLi="./body/div[146]/ul[6]/li";
		public string publicwelldataclk=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[2]/?/?/span[@innertext='Public Well Data']";
		public string publicPipelinedataclk=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[1]/?/?/span[@innertext='Public Pipeline Data']";
		public string FacilityStatus_DataDic=".//select[#'Dataintegrity_FacilityData_txtStatus']/option";
		#endregion
	#region Consturtor
		public PrivateFacilityData()
		{
			loginPageObj = new LoginPage();
			landingPageObj = new LandingPage();
			hierarchyDBobj = new HierarchyDB();
		}
		#endregion

		#region Events
		
		
		public static void Click()
		{
			Mouse.Click(MouseButtons.Left);
		}
				
		public void OpeningPrivateFacilityScreen()
		
		{
			Helper.WaitTillPageIsLoaded();
		//	Helper.WaitForElementVisible(landingPageObj.LandingDataIntegrityMenu);
			Helper.FocusOnElement(landingPageObj.LandingDataIntegrityMenu);
		//	Helper.WaitForTimeInMilliSeconds(2000);
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForElementVisible(AssetHover);
			Helper.FocusOnElement(AssetHover);
			Helper.WaitForElementVisible(publicPipelinedataclk);
			Helper.FocusOnElement(publicPipelinedataclk);
			Helper.WaitForElementVisible(PrivateFacilityClk);
			Helper.ClickElement(PrivateFacilityClk);
			Helper.WaitTillPageIsLoaded();
		//	Helper.WaitForTimeInMilliSeconds(2000);
		}
    
		public void LandingPrivateScreen_Validation()
    	{
    	
    		Helper.WaitTillPageIsLoaded();
    		WebElement title=Helper.GetElement(PrivateFacilitywindowwndtitle);
    		 var pageelement= Helper.GetElementAndFocus(PrivateFacilitywindowwndtitle);
    		Report.Log(ReportLevel.Info, pageelement.Element.ToString());
    	if ( pageelement.Element.ToString()=="SpanTag:Data Integrity - Facility Data")
    	Report.Log(ReportLevel.Info, "Private facility screen screen is Open and validated");
    	     	
    	}
	
		/// <summary>
		/// Common Method is created to enter text in Hierarchy Screen search text Box.
		/// </summary>
    	
    	public void EnterSearchTextinPrivateFacility(string PrivateFacilityCNQName,string PrivateFacilityCCESName)
		{
    		string xpathElementLI = string.Empty;
		//	Helper.WaitTillPageIsLoaded();
		//	Helper.WaitForTimeInMilliSeconds(3000);
    		Helper.GetElement(PrivateFacilitySearchTextBox);
    		Helper.ClickElement(PrivateFacilitySearchTextBox);
    		if(Helper.GetClientId()=="CNQ")
    		{
    			Helper.EnterText(PrivateFacilitySearchTextBox, PrivateFacilityCNQName);
    			//xpathElementLI = FirstsearchElementLi + PrivateFacilityCNQName + "']";
    			//WebElement xyz=Helper.GetElement(xpathElementLI);
    			Helper.ClickElement(PrivateFacilitySearchTextBox);
    			Helper.GetElementAndFocus(FirstsearchElementLi);
    		//	Helper.GetElement(xpathElementLI);
    			Click();	
    		
    		//  Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
			//	Helper.ClickElement(FirstsearchElementLi);
    		}
    		else 
    		{
    			Helper.EnterText(PrivateFacilitySearchTextBox, PrivateFacilityCCESName);
    		//	xpathElementLI = FirstsearchElementLi + PrivateFacilityCCESName + "']";
    		//	WebElement xyz=Helper.GetElement(xpathElementLI);
    			Helper.ClickElement(PrivateFacilitySearchTextBox);
				Helper.GetElementAndFocus(FirstsearchElementLi);
  				Click();  		
			//	Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
			//	Helper.ClickElement(FirstsearchElementLi);
    		}
			
			
			
    	
    	//	xyz.moveto();
    	//	xyz.Click();
    		//	FirstsearchElementLi.moveto();
    	//		xyz.click();
    	//	Helper.ClickElement(FirstsearchElementLi);
			
    		}
	
    	/// <summary>
		/// Common Method is created to enter text in Private facilityScreen for autopopulation search text Box.
		/// </summary>
    	
    	public void EnterSearchTextinAutoPrivateFacility (string PrivateFacilityCNQName,string PrivateFacilityCCESName)
    	    	
    		{
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(3000);
    		Helper.GetElement(PrivateFacilitySearchTextBox);
    		Helper.ClickElement(PrivateFacilitySearchTextBox);
    		if(Helper.GetClientId()=="CNQ")
    		{
    			Helper.EnterText(PrivateFacilitySearchTextBox, PrivateFacilityCNQName);
    		}
    		else 
    		{
    			Helper.EnterText(PrivateFacilitySearchTextBox, PrivateFacilityCCESName);
    		}
			Helper.WaitForTimeInMilliSeconds(2000);
    		Helper.GetElement(FirstsearchElementLi);
			
    		}
	
		   	
    	
    	#endregion
	}
}