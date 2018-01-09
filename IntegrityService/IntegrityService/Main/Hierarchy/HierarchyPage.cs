/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 7:32 AM
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
	/// Description of HierarchyPage.
	/// </summary>
	public class HierarchyPage
	{
		#region Module Variables
		private static LoginPage loginPageObj= null;
		private static LandingPage landingPageObj= null;
		private HierarchyDB hierarchyDBobj=null; 
		#endregion
		
		
		#region ELEMENTS XPATH
		public string HierarchyHover = ".//div[#'menu']/ul/?/?/div/ul//span[@innertext='Hierarchy']";
		public string HierarchySearchHoverBtn = ".//div[#'menu']/ul/li[1]/?/?/ul/?/?/div/ul//span[@innertext='Search']";
		public string HierarchySearchAssetWithoutHoverBtn = ".//div[#'menu']/ul/li[1]/?/?/ul/?/?/div/ul//span[@innertext='Assets without Hierarchy']";
		public string Dataintegrityhierarchywindowwndtitle = "./body/div[167]/?/?/span[@id~'DataIntegrity_Hierarchy_Window_wnd_title' and @class='k-window-title']";
		public string HierarchySearchTextBox =".//input[#'DataIntegrity_Hierarchy_txtHierarchySearch']";
		public string HierarchySearchNextBtn =".//div[#'DataIntegrity_Hierarchy']/div[@id='Content-Block']//span[@innertext='Next' and @class='txt' and @tagname='span']";
		public string HierarchySearchPreviousBtn =".//div[#'DataIntegrity_Hierarchy']/div[@id='Content-Block']//span[@innertext='Back']";
		public string HierarchyIncludeAttachmentCheckBox =".//input[#'DataIntegrity_HierarchyData_IncludeAttachments']";
		public string HierarchyTypeTextBox =".//li[#'DataIntegrity_Hierarchy_GeneralInfo']//table/tbody/tr[1]/td[1]//span[@class='k-input']";
		public string HierarchyNameTextBox =".//input[#'DataIntegrity_Hierarchy_txtUWI']";
		public string HierarchyParentNameTextBox =".//input[#'DataIntegrity_HierarchyParent_autoComplete']";
		public string HierarchySpatialTextBox =".//input[#'DataIntegrity_Hierarchy_txtspatial']";
		public string HierarchyUploadSpatialBtn =".//table/tbody/tr[2]/td[2]/div[1]/div[@class~'k-button k-upload-button']";
		public string HieararchyAddBtn =".//div[#'DataIntegrity_Hierarchy_horizontal']/?/?/div[@title='Add a Hierarchy Node']/div[@class='k-button']";
		public string HieararchyDeleteBtn =".//div[#'DataIntegrity_Hierarchy_DeleteHierarchy']";
		public string HierarchySettingBtn =".//div[#'DataIntegrity_Hierarchy_horizontal']/?/?/div[@title~'Setting']/div[@class='k-button']";
		public string HierarchyNewBoundaryBtn =".//table/tbody/tr[3]/?/?/div/button[2]/span[@innertext~'New Boundary']";
		public string HierarchyEditBoundaryBtn =".//table/tbody/tr/?/?/div/button[3]/span[@innertext~'Edit Boundary']";
		public string HierarchyGeneralAccordion =".//li[#'DataIntegrity_Hierarchy_GeneralInfo']/span[@innertext~'General Information' and @class='k-link k-header k-state-selected']";
		public string HierarchyNumberofAsssetAccordion =".//li[#'DataIntegrity_Hierarchy_PhysicalAttr']/span[@innertext~'Number of Assets' and @class='k-link k-header']";
		public string HierarchyGenearlAttachmentAccordion =".//ul[#'DataIntegrity_Hierarchy_panelbar']/li[3]/span[@innertext~'General Attachments' and @class='k-link k-header']";
		public string HierarchyMasterExpand =".//li[#'DataIntegrity_Hierarchy_Tree_tv_active']/div/span[@class='k-icon k-minus']']";
		public string HierarchyMasterinTree =".//li[#'DataIntegrity_Hierarchy_Tree_tv_active']/div/span[@class~'k-in k-state-selected k-state-focused']";
		public string HierarchyMapBtn =".//div[@innertext='Map']";
		public string HierarchyRefreshBtn =".//div[@innertext='Refresh']";
		public string HierarchyUpdateBtn =".//div[#'DataIntegrity_Hierarchy_Update']/div[@innertext='Update']";
		public string HierarchyScreenCloseBtn ="./body/div[165]/div[1]//span[@innertext='Close']";
	  	
	


#region Scenario Specific ELEMENTS XPATH

		public string HierarchyAutopopulationABlist1 =".//ul[#'DataIntegrity_Hierarchy_txtHierarchySearch_listbox']/li";
		public string defaultHierarchychk =".//li[#'DataIntegrity_Hierarchy_GeneralInfo']//table/tbody/tr[1]/td[1]/span";
		public string PipelineGridData =".//div[#'DataIntegrity_Hierarchy_PanelCount']/div/table[1]/tbody/tr[1]/?/?/span";
		public string Clientname=".//div[#'Index_Header']/ul[3]/li[2]/span/span[1]";
		public string WellGridData =".//div[#'DataIntegrity_Hierarchy_PanelCount']/div/table[1]/tbody/tr[2]/?/?/span";
		public string FacilityGridData =".//div[#'DataIntegrity_Hierarchy_PanelCount']/div/table[1]/tbody/tr[3]/?/?/span";
		public string ConnectionGridData =".//div[#'DataIntegrity_Hierarchy_PanelCount']/div/table[1]/tbody/tr[4]/?/?/span";		
		public string MeasureGridData =".//tr[#'DataIntegrity_Hierarchy_DGMMeasure']/?/?/span";
#endregion

		#endregion
	
		
		#region Consturtor
		public HierarchyPage()
		{
			loginPageObj = new LoginPage();
			landingPageObj = new LandingPage();
			hierarchyDBobj = new HierarchyDB();
		}
		#endregion
		
		
		#region Events
		public void OpeningHiererachyScreen()
		
		{
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForElementVisible(landingPageObj.LandingDataIntegrityMenu);
			Helper.FocusOnElement(landingPageObj.LandingDataIntegrityMenu);
			Helper.WaitForTimeInMilliSeconds(2000);
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForElementVisible(HierarchyHover);
			Helper.FocusOnElement(HierarchyHover);
			Helper.WaitForElementVisible(HierarchySearchHoverBtn);
			Helper.ClickElement(HierarchySearchHoverBtn);
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(2000);
		
		}
    
    	public void LandingHiererachyScreen_Validation()
    	{
    	
    		Helper.WaitTillPageIsLoaded();
       		var pageelement= Helper.GetElementAndFocus(Dataintegrityhierarchywindowwndtitle);
    		Report.Log(ReportLevel.Info, pageelement.Element.ToString());
    	if ( pageelement.Element.ToString()=="SpanTag:DataIntegrity_Hierarchy_Window_wnd_title")
    	Report.Log(ReportLevel.Info, "Hiererchy screen is Open and validated");
    	     	
    	}
    	
 		
    	/// <summary>
		/// To Check Master is selected on First Landing Hlierarchy Screen.
		/// </summary>
    	
    	public void firsttime_HierarchyLanding_Test()
    		
		{
		Helper.WaitTillPageIsLoaded();
		Helper.WaitForTimeInMilliSeconds(7000);	
		var pageelement=Helper.GetElement(HierarchyMasterinTree);
		Helper.WaitForElementVisible(pageelement);
		Helper.FocusOnElement(pageelement);
		
			
    	var masterstatus= Helper.GetElement(HierarchyMasterinTree);
    	if(masterstatus.Class =="k-in k-state-selected k-state-focused") 
    	{
    		 		 
    			Report.Log(ReportLevel.Info, "Master was selected for the first time");
    		
    	}
    	else 
    	{
    			Report.Log(ReportLevel.Info, "Master was Not selected and you might have landed second time in the same session.");
    	
    	}
    	
    	
    	}
    	
    	/// <summary>
    	/// Common Method to Check Readonly Text box
    	/// </summary>
    	/// <param name="HierarchyName"></param>
    	
    	
    	public void MasterReadonly(string SearchText)
    	{
    		Helper.SetReportLog(ReportLevel.Info,"Checking if Hierarchy Type Master is Readonly Or Not");
    		if(Helper.VerifyInnerHtmlValue(SearchText,defaultHierarchychk))
    		   {
    		   	Helper.SetReportLog(ReportLevel.Info,"Master Hierarchy Type is Read-Only");
    		   	}
    		   else
    		   {
    		   	throw new ElementNotFoundException("Master Hierarchy Type is Editable -Please Fix");
    		   }
    	}
    	
    	/// <summary>
		/// Common Method is created to enter text in Hierarchy Screen search text Box.
		/// </summary>
    	
    	public void EnterSearchTextinHierarchy(string HierarchyName)
		{
			Helper.WaitTillPageIsLoaded();
			Helper.WaitForTimeInMilliSeconds(3000);
    		Helper.GetElement(HierarchySearchTextBox);
    		Helper.ClickElement(HierarchySearchTextBox);
    		Helper.EnterText(HierarchySearchTextBox, HierarchyName);
			Report.Log(ReportLevel.Info,"Entered Hierarchy Search string is'" + HierarchyName + "'.");
		}
    	
    	/// <summary>
		/// Common Method created to Match the DB Data with the Hierarchy Grid.
		/// </summary>
		
    	public void PipelineGridMasterCount()
    	{
    		Helper.WaitTillPageIsLoaded();
    		var client_Element =Helper.GetElement(Clientname);
    		var innerthtml = client_Element.GetInnerHtml();
    		var reg="<span style=\"background-color: #29ABE2\" data-bind=\"text: userInfo.Data_ID\">(?<Content>([^<]*))</span>";
    		var m=Regex.Match(innerthtml,reg);
    		string client=m.Groups[1].ToString();
    		var we = Helper.GetElement(HierarchyMasterinTree);
    		Helper.ClickElement(HierarchyMasterinTree);
    		Helper.WaitForElementVisible(we,3000);
    		var pipeline =Helper.GetElement(PipelineGridData);
    		var PipelineData=pipeline.GetInnerHtml();
    		int count = hierarchyDBobj.PipelineCount(client,"all","master");
    		if (Convert.ToInt32(PipelineData) == count)
    		{
    			Report.Log(ReportLevel.Info,"Master Hierarchy having pipeline : " + PipelineData +"'.");
    		}
    		else
    		{
    			Report.Log(ReportLevel.Info,"Data of Pipeline Seems to Be Inconsistent in Tool and DB.Please Check");
    		}
			
		}

    	/// <summary>
		/// Common Method created to Match the DB Data with the Hierarchy Grid.
		/// </summary>
		
    	public void WellGridMasterCount()
    	{
    		Helper.WaitTillPageIsLoaded();
    		var client_Element =Helper.GetElement(Clientname);
    		var innerthtml = client_Element.GetInnerHtml();
    		var reg="<span style=\"background-color: #29ABE2\" data-bind=\"text: userInfo.Data_ID\">(?<Content>([^<]*))</span>";
    		var m=Regex.Match(innerthtml,reg);
    		string client=m.Groups[1].ToString();
    		var we = Helper.GetElement(HierarchyMasterinTree);
    		Helper.ClickElement(HierarchyMasterinTree);
    		Helper.WaitForElementVisible(we,2000);
    		var Well =Helper.GetElement(WellGridData);
    		var WellData=Well.GetInnerHtml();
    		int count = hierarchyDBobj.WellCount(client,"all","master");
    		if (Convert.ToInt32(WellData) == count)
    		{
    			Report.Log(ReportLevel.Info,"Master Hierarchy having Well : " + WellData +"'.");
    		}
    		else
    		{
    			Report.Log(ReportLevel.Info,"Data of Well  Seems to Be Inconsistent in Tool and DB.Please Check");
    		}
			
		}
    	
    	
    	/// <summary>
		/// Common Method created to Match the DB Data with the Hierarchy Grid.
		/// </summary>
		
    	public void FacilityGridMasterCount()
    	{
    		Helper.WaitTillPageIsLoaded();
    		var client_Element =Helper.GetElement(Clientname);
    		var innerthtml = client_Element.GetInnerHtml();
    		var reg="<span style=\"background-color: #29ABE2\" data-bind=\"text: userInfo.Data_ID\">(?<Content>([^<]*))</span>";
    		var m=Regex.Match(innerthtml,reg);
    		string client=m.Groups[1].ToString();
    		var we = Helper.GetElement(HierarchyMasterinTree);
    		Helper.ClickElement(HierarchyMasterinTree);
    		Helper.WaitForElementVisible(we,2000);
    		var Facility =Helper.GetElement(FacilityGridData);
    		var FacilityData=Facility.GetInnerHtml();
    		int count = hierarchyDBobj.FacilityCount(client,"all","master");
    		if (Convert.ToInt32(FacilityData) == count)
    		{
    			Report.Log(ReportLevel.Info,"Master Hierarchy having Facility : " + FacilityData +"'.");
    		}
    		else
    		{
    			Report.Log(ReportLevel.Info,"Data of Facility Seems to Be Inconsistent in Tool and DB.Please Check");
    		}

    	}
    	
    	/// <summary>
		/// Common Method created to Match the DB Data with the Hierarchy Grid for Connection.
		/// </summary>
		
    	public void ConnectionGridMasterCount()
    	{
    		Helper.WaitTillPageIsLoaded();
    		var client_Element =Helper.GetElement(Clientname);
    		var innerthtml = client_Element.GetInnerHtml();
    		var reg="<span style=\"background-color: #29ABE2\" data-bind=\"text: userInfo.Data_ID\">(?<Content>([^<]*))</span>";
    		var m=Regex.Match(innerthtml,reg);
    		string client=m.Groups[1].ToString();
    		var we = Helper.GetElement(HierarchyMasterinTree);
    		Helper.ClickElement(HierarchyMasterinTree);
    		Helper.WaitForElementVisible(we,2000);
    		var Connection =Helper.GetElement(ConnectionGridData);
    		var ConnectionData=Connection.GetInnerHtml();
    		int count = hierarchyDBobj.ConnectionCount(client,"all","master");
    		if (Convert.ToInt32(ConnectionData) == count)
    		{
    			Report.Log(ReportLevel.Info,"Master Hierarchy having Connection : " + ConnectionData +"'.");
    		}
    		else
    		{
    			Report.Log(ReportLevel.Info,"Data of Connection Seems to Be Inconsistent in Tool and DB.Please Check");
    		}

    	}
    	
    	public void MeasureGridMasterCount()
    	{
    		Helper.WaitTillPageIsLoaded();
    		var client_Element =Helper.GetElement(Clientname);
    		var innerthtml = client_Element.GetInnerHtml();
    		var reg="<span style=\"background-color: #29ABE2\" data-bind=\"text: userInfo.Data_ID\">(?<Content>([^<]*))</span>";
    		var m=Regex.Match(innerthtml,reg);
    		string client=m.Groups[1].ToString();
    		var we = Helper.GetElement(HierarchyMasterinTree);
    		Helper.ClickElement(HierarchyMasterinTree);
    		Helper.WaitForElementVisible(we,2000);
    		var Measure =Helper.GetElement(MeasureGridData);
    		var MeasureData=Measure.GetInnerHtml();
    		int count = hierarchyDBobj.MeasureCount(client,"all","master");
    		if (Convert.ToInt32(MeasureData) == count)
    		{
    			Report.Log(ReportLevel.Info,"Master Hierarchy having Connection : " + MeasureData +"'.");
    		}
    		else
    		{
    			Report.Log(ReportLevel.Info,"Data of Connection Seems to Be Inconsistent in Tool and DB.Please Check");
    		}

    	}
    	
    	
    	
		#endregion
		
	}
}
