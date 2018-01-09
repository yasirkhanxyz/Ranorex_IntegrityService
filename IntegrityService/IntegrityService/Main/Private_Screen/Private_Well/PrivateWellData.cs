/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/14/2017
 * Time: 4:47 AM
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
	/// Description of PrivateWellData.
	/// </summary>
	public class PrivateWellData
	{
		
		#region Module Variables
		
		private static LoginPage loginPageObj= null;
		private static LandingPage landingPageObj= null;
		private HierarchyDB hierarchyDBobj=null; 
		#endregion
		
		#region Scenario Specific ELEMENTS XPATH
		public string AssetHover1=".//div[#'menu']/ul/?/?/div/ul//span[@innertext~'Assets']";
		public string PrivateWellClk=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[5]/?/?/span[@innertext='Well Data']";
		public string PrivateWellwindowwndtitle="./body/div[147]/?/?/span[@innertext~'Data Integrity - Well Data' and @class='ui-dialog-title']";
		public string PrivateWellSearchTextBox=".//input[#'DataIntegrity_WellData_Search']";
		public string FirstsearchElementLi1="./body/div[147]/ul[5]/?/?/div[@class='ui-menu-item-wrapper' and @tabindex='-1']";
		public string publicwelldataclk1=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[2]/?/?/span[@innertext='Public Well Data']";
		public string publicPipelinedataclk1=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[1]/?/?/span[@innertext='Public Pipeline Data']";
		
		#endregion
		#region Consturtor
		public PrivateWellData()
		{
			loginPageObj = new LoginPage();
			landingPageObj = new LandingPage();
			hierarchyDBobj = new HierarchyDB();
			
		}
		#endregion
		
		public static void Click()
		{
			Mouse.Click(MouseButtons.Left);
		}
		
	#region Event
	public void OpeningPrivateWellScreen()
		
		{
			Helper.WaitTillPageIsLoaded();
	//		Helper.WaitForElementVisible(landingPageObj.LandingDataIntegrityMenu);
			Helper.FocusOnElement(landingPageObj.LandingDataIntegrityMenu);
	//		Helper.WaitForTimeInMilliSeconds(2000);
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForElementVisible(AssetHover1);
			Helper.FocusOnElement(AssetHover1);
			Helper.WaitForElementVisible(publicPipelinedataclk1);
			Helper.FocusOnElement(publicPipelinedataclk1);
			Helper.WaitForElementVisible(PrivateWellClk);
			Helper.ClickElement(PrivateWellClk);
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(2000);
		}
    
		public void LandingPrivateWellScreen_Validation()
    	{
    	
    		Helper.WaitTillPageIsLoaded();
    		WebElement title=Helper.GetElement(PrivateWellwindowwndtitle);
    		 var pageelement= Helper.GetElementAndFocus(PrivateWellwindowwndtitle);
    		Report.Log(ReportLevel.Info, pageelement.Element.ToString());
    	if ( pageelement.Element.ToString()=="SpanTag:Data Integrity - Well Data")
    	Report.Log(ReportLevel.Info, "Private Well screen is Open and validated");
    	     	
    	}
	
		/// <summary>
		/// Common Method is created to enter text in Well Screen search text Box.
		/// </summary>
    	
    	public void EnterSearchTextinPrivateWell(string PrivateWellCNQName,string PrivateWellCCESName)
		{
		//	Helper.WaitTillPageIsLoaded();
		//	Helper.WaitForTimeInMilliSeconds(3000);
    		Helper.GetElement(PrivateWellSearchTextBox);
    		Helper.ClickElement(PrivateWellSearchTextBox);
    		if(Helper.GetClientId()=="CNQ")
    		{
    			Helper.EnterText(PrivateWellSearchTextBox, PrivateWellCNQName);
    			Helper.ClickElement(PrivateWellSearchTextBox);
    			Helper.GetElementAndFocus(FirstsearchElementLi1);
    			Click();
    		}
    		else 
    		{
    			Helper.EnterText(PrivateWellSearchTextBox, PrivateWellCCESName);
    			Helper.ClickElement(PrivateWellSearchTextBox);
    			Helper.GetElementAndFocus(FirstsearchElementLi1);
    			Click();
    		}
			Helper.WaitForTimeInMilliSeconds(2000);
    	//	Helper.GetElement(FirstsearchElementLi1);
    	//	Helper.ClickElement(FirstsearchElementLi1);
			
    		}
	
	public void EnterSearchTextinAutoPrivateWell(string PrivateWellCNQName,string PrivateWellCCESName)
		{
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(3000);
    		Helper.GetElement(PrivateWellSearchTextBox);
    		Helper.ClickElement(PrivateWellSearchTextBox);
    		if(Helper.GetClientId()=="CNQ")
    		{
    			Helper.EnterText(PrivateWellSearchTextBox, PrivateWellCNQName);
    		}
    		else 
    		{
    			Helper.EnterText(PrivateWellSearchTextBox, PrivateWellCCESName);
    		}
			Helper.WaitForTimeInMilliSeconds(2000);
    		Helper.GetElement(FirstsearchElementLi1);		
    		}
    	
    	#endregion
	}
}