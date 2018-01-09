/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/15/2017
 * Time: 6:37 AM
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
	/// Description of PrivatePipelineData.
	/// </summary>
	public class PrivatePipelineData
	{
		
		#region Module Variables
		
		private static LoginPage loginPageObj= null;
		private static LandingPage landingPageObj= null;
		private HierarchyDB hierarchyDBobj=null; 
		#endregion
		
		#region Scenario Specific ELEMENTS XPATH
		public string AssetHover2=".//div[#'menu']/ul/?/?/div/ul//span[@innertext~'Assets']";
		public string publicPipelinedataclk=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[1]/?/?/span[@innertext='Public Pipeline Data']";
	//	public string PrivatePipelinewindowwndtitle=".//span[#'DataIntegrity_PipelineData_Window_wnd_title']";
		public string PrivatePipelinewindowwndtitle ="./body/div[146]/?/?/span[@innertext~'Data Integrity - Private Data']";
		public string PrivatePipelineSearchTextBox=".//input[#'DataIntegrity_PipelineData_Search']";
		public string FirstsearchElementLi2="./body/div[146]/ul[1]/?/?/div[@class='ui-menu-item-wrapper']";
		public string publicwelldataclk=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[2]/?/?/span[@innertext='Public Well Data']";
		public string privatePipelineclk=".//div[#'menu']/ul/?/?/div/ul/li[3]/div/ul/li[4]/?/?/span[@innertext='Pipeline Data']";
		public string LicensedAttributePanel=".//div[#'DataIntegrity_PipelineData_panelbar_PhysicalAttributes']/h3[@innertext~'Licensed Physical Attributes']";
		public string PhysicalInfoPanel=".//div[#'DataIntegrity_PipelineData_panelbar_PhysicalAttributes']/h3[@innertext='General Information']";
	//	public string FirstsearchElementLi21=".//ul[#'DataIntegrity_PipelineData_Search_listbox']/li";
		#endregion
	
		public static void Click()
		{
			Mouse.Click(MouseButtons.Left);
		}
		
		
		#region Consturtor
		public PrivatePipelineData()
		{
			loginPageObj = new LoginPage();
			landingPageObj = new LandingPage();
			hierarchyDBobj = new HierarchyDB();
		}
		#endregion

		#region Events
		public void OpeningPrivatePipelineScreen()
		
		{
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForElementVisible(landingPageObj.LandingDataIntegrityMenu);
			Helper.FocusOnElement(landingPageObj.LandingDataIntegrityMenu);
			Helper.WaitForTimeInMilliSeconds(2000);
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForElementVisible(AssetHover2);
			Helper.FocusOnElement(AssetHover2);
			Helper.WaitForElementVisible(publicPipelinedataclk);
			Helper.FocusOnElement(publicPipelinedataclk);
			Helper.WaitForElementVisible(privatePipelineclk);
			Helper.ClickElement(privatePipelineclk);
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(2000);
		}
    
		public void LandingPrivatePipelineScreen_Validation()
    	{
    	
    		Helper.WaitTillPageIsLoaded();
    		WebElement title=Helper.GetElement(PrivatePipelinewindowwndtitle);
    		 var pageelement= Helper.GetElementAndFocus(PrivatePipelinewindowwndtitle);
    		Report.Log(ReportLevel.Info, pageelement.Element.ToString());
    	if ( pageelement.Element.ToString()=="SpanTag:Data Integrity - Pipeline Data")
    	Report.Log(ReportLevel.Info, "Private Pipeline screen screen is Open and validated");
    	     	
    	}
	
		/// <summary>
		/// Common Method is created to enter text in Pipeline Screen search text Box.
		/// </summary>
    	
    	public void EnterSearchTextinPrivatePipeline(string PrivatePipelineCNQName,string PrivatePipelineCCESName)
		{
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(3000);
			Helper.GetElement(LicensedAttributePanel);
			Helper.ClickElement(LicensedAttributePanel);
			Helper.GetElement(PhysicalInfoPanel);
			Helper.ClickElement(PhysicalInfoPanel);
			Helper.GetElement(PrivatePipelineSearchTextBox);
    		Helper.ClickElement(PrivatePipelineSearchTextBox);
    		if(Helper.GetClientId()=="CNQ")
    		{
    			Helper.EnterText(PrivatePipelineSearchTextBox, PrivatePipelineCNQName);
    			Helper.ClickElement(PrivatePipelineSearchTextBox);
    			Helper.GetElementAndFocus(FirstsearchElementLi2);
    			Click();
    		}
    		else 
    		{
    			Helper.EnterText(PrivatePipelineSearchTextBox, PrivatePipelineCCESName);
    			Helper.ClickElement(PrivatePipelineSearchTextBox);
    			Helper.GetElementAndFocus(FirstsearchElementLi2);
    			Click();
    		}
			
    		}
	
    	
    	public void EnterSearchTextinAutoPrivatePipeline(string PrivatePipelineCNQName,string PrivatePipelineCCESName)
		{
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(3000);
    		Helper.GetElement(PrivatePipelineSearchTextBox);
    		Helper.ClickElement(PrivatePipelineSearchTextBox);
    		if(Helper.GetClientId()=="CNQ")
    		{
    			Helper.EnterText(PrivatePipelineSearchTextBox, PrivatePipelineCNQName);
    		}
    		else 
    		{
    			Helper.EnterText(PrivatePipelineSearchTextBox, PrivatePipelineCCESName);
    		}
			Helper.WaitForTimeInMilliSeconds(2000);
    		Helper.GetElement(FirstsearchElementLi2);
			
    		}
    	
	#endregion
	}
}