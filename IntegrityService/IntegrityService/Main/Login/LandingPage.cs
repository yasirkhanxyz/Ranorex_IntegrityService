/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/12/2017
 * Time: 5:45 AM
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
	/// Description of LandingPage.
	/// </summary>
	public class LandingPage
	{
		#region ELEMENTS XPATH
		public string Landingmaparea =".//div[#'Index_Map']/div/div/div[1]/div[3]";
		public string LandingSelectionIcon =".//div[#'Index_hand']/div/img[@tagname='img']";
		public string LandingAccountName = ".//div[#'Index_Header']/ul[4]/li[1]/span/span[@innertext='Yasir']";
		public string LandingBulkEditorIcon = ".//div[#'Index_BulkEditor']/div/img[@src~'/Images/side_bar/Bulk-Editor.png']";
		public string LandingDeleteshapeIcon = ".//div[#'Index_DeleteShape']/div/img[@src~'/Images/side_bar/Delete-Shape.png']";
		public string LandingMeasurementToolIcon = ".//div[#'Index_Measurement']/div/img[@src~'/Images/side_bar/MeasurementTool.png']";
		public string LandingQueryAssetToolIcon = ".//div[#'Index_QueryAssetTool']/div/img[@src~'/Images/side_bar/querySelector.png']";
		public string LandinglayersIcon = ".//div[#'Index_SideBar']/div/div/img[@src~'/Images/side_bar/layers.png']";
		public string LandingLegendIcon = ".//div[#'Index_SideBar']/div/div/img[@src~'/Images/side_bar/legand.png']";
		public string LandingZoomArea = ".//div[#'Index_SideBar']/div[9]/div[@innertext~'Zoom:']";
		public string LandingZoomLevel9 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='9']";
		public string LandingZoomLevel10 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='10']";
		public string LandingZoomLevel11 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='11']";
		public string LandingZoomLevel12 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='12']";
		public string LandingZoomLevel13 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='13']";
		public string LandingZoomLevel14 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='14']";
		public string LandingZoomLevel15 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='15']";
		public string LandingZoomLevel16 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='16']";
		public string LandingZoomLevel17 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='17']";
		public string LandingZoomLevel18 = ".//div[#'Index_SideBar']/div[9]/div/div/span[@innertext='18']";
		public string LandingQuickSearchBox = ".//input[#'txtSearchString']";
		public string LandingsearchReset = ".//div[#'Index_Header']/div[2]/span[@class='k-icon k-i-refresh']";
		public string LandingSearchIcon = ".//div[#'Index_Header']/div[2]/span[@class='k-icon k-i-search']";
		public string LandingDashboardIcon = ".//div[#'Index_Dashboard']/?/?/span[@innertext='Dashboard']";
		public string LandingLatLongSearchBox = ".//input[#'Index_Footer_txtSearchString']";
	//	public string LandingDataIntegrityMenu = ".//div[#'Index_Header']/ul[3]//span[@innertext='Data Integrity']";
		public string LandingDataIntegrityMenu = ".//div[#'menu']/ul//span[@innertext='Data Integrity']";
		public string LandingReportMenu = ".//div[#'menu']/ul//span[@innertext='Reports']";
		public string LandingDiagramMenu = ".//div[#'menu']/ul//span[@innertext='Diagram']";
		public string LandingOneCallManagerMenu = ".//div[#'menu']/ul//span[@innertext='OneCall Manager']";
		public string LandingHelpMenu = ".//div[#'Index_Header']/ul[3]/li[5]/span/span[@innertext='Help']";
		public string LandingReportQueueStatus = ".//div[#'Index_Footer']/div[2]/div/span[@tagname='span']";
		public string LandingMapArea = ".//div[#'Index_Map']/div/div/div[1]/div[3]";
		public string ActiveWellIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[44]/img[@src~'https://isstgweb2.promonitor.ca/Images/G_AU.png']";
		public string AbandonedWellIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[12]/img[@src='/Images/G_IS.png']";
		public string PendingWellIcon = "  .//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[7]/img[@src='/Images/G_IU.png']";
		public string SuspendedWellIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[15]/img[@src='/Images/G_IS.png']";
		public string UnkownWellIcon = "   .//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[11]/img[@src='/Images/G_IS.png']";
		public string BatteryOperatingIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[1]/img[@src='/Images/BT_AU.png']";
		public string BatteryAbondonedIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[4]/img[@src='/Images/BT_IU.png']";
		public string InjectionPlantOperatingIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[5]/img[@src='/Images/IP_AU.png']";
		public string MeterStationOperatingIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[70]/img[@src='/Images/MS_AU.png']";
		public string CompressorStationOperatingIcon = ".//div[#'Index_Map']/div/div/div[1]/div[4]/div[3]/div[71]/img[@src='/Images/CS_AU.png']";
		
		#endregion
		
		
		#region Module Variables
		private static LoginPage loginPageObj= null;
		
		#endregion
		
		
		#region Consturtor
		public LandingPage()
		{
			loginPageObj = new LoginPage();
		}
		#endregion
	
		
		#region Events
		
		//Enter facility code in Quicksearch
		public void EnterFacityCode(string FCode)
			
		{
			Helper.EnterText(LandingQuickSearchBox, FCode);
			Report.Log(ReportLevel.Info,"Entered FacilityCode '" + FCode + "'.");
		}
		
				
		//validate Selection Icon
		public void SelectionIconValidation_Test()
		{
			Helper.WaitForTimeInMilliSeconds(3000);
			Helper.WaitForElementVisible(LandingSelectionIcon);
			Report.Log(ReportLevel.Info, "Validation-landingPage Selection Icon");
			Validate.Exists(LandingSelectionIcon);
		}
		
		
		//validate Measurement Icon
		public void MeasurementIconValidation_Test()
		{
			Helper.WaitForTimeInMilliSeconds(3000);
			Helper.WaitForElementVisible(LandingMeasurementToolIcon);
			Report.Log(ReportLevel.Info, "Validation-landingPage Measurement Icon");
			Validate.Exists(LandingMeasurementToolIcon);
		}
		
		//validate Layer Icon
		public void LayerIconValidation_Test()
		{
			Helper.WaitForTimeInMilliSeconds(3000);
			Helper.WaitForElementVisible(LandinglayersIcon);
			Report.Log(ReportLevel.Info, "Validation-landingPage Layer Icon");
			Validate.Exists(LandinglayersIcon);
		}
		
		//validate Legend Icon
		public void LegendIconValidation_Test()
		{
			Helper.WaitForTimeInMilliSeconds(3000);
			Helper.WaitForElementVisible(LandingLegendIcon);
			Report.Log(ReportLevel.Info, "Validation-landingPage Legend Icon");
			Validate.Exists(LandingLegendIcon);
		}
		
		
		//validate Map Area
		public void MapAreaValidation_Test()
		{
			Helper.WaitForTimeInMilliSeconds(3000);
			Helper.WaitForElementVisible(Landingmaparea);
			Report.Log(ReportLevel.Info, "Validation-landingPage map Area");
			Validate.Exists(Landingmaparea);
		}
		
		// Validating All Types of Well & Facility present on screen.
		
		public void ValidatingAssetOnMap ()
		{
			
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(ActiveWellIcon))
			{
				Report.Log(ReportLevel.Info,"Element is ActiveWellIcon visible");
			}
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(AbandonedWellIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Abandoned Well Icon visible");
			}
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(PendingWellIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Pending Well Icon visible");
			}
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(SuspendedWellIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Suspended Well  Icon visible");
			}
			
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(UnkownWellIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Unkown Well Icon visible");
			}
			
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(BatteryOperatingIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Battery Operating Icon visible");
			}
			
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(BatteryAbondonedIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Battery Abondoned Icon visible");
			}
			
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(MeterStationOperatingIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Meter Station Operating Icon visible");
			}
			
			Helper.WaitForTimeInMilliSeconds(3000);
			if(Helper.IsElementVisible(CompressorStationOperatingIcon))
			{
				Report.Log(ReportLevel.Info,"Element is Compressor Station Operating Icon visible");
			}
			
		}
		
		
		
		// Set Zoom Level to 13 PX
		
		public void ZoomLevelTo13()
			
		{
			
			var divArea = Helper.GetElement(LandingZoomArea);
			var innerHtml = divArea.GetInnerHtml();
			string CustomParamId=null;
			// Here we call Regex.Match.
			Match match = Regex.Match(innerHtml, @"<span data-bind=""text: zoomLevel"">(?:.*#|.*/)?([0-9]+)</span>",RegexOptions.IgnoreCase);
			
			// Here we check the Match instance.
			if (match.Success)
			{
				// Finally, we get the Group value and display it.
				CustomParamId = match.Groups[1].Value;
				Report.Log(ReportLevel.Info,CustomParamId);
			}
			//		int delta=Int32.Parse(CustomParamId)-13;
			
			int delta=13-Int32.Parse(CustomParamId);
			Mouse.ScrollWheel(delta);
			Report.Log(ReportLevel.Info,delta.ToString());
			Helper.WaitForTimeInMilliSeconds(6000);
		}
		
				
		#endregion
		
	}
}
