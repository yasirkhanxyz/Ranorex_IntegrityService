/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/22/2017
 * Time: 7:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using IntegrityService.Database;
using Ranorex;

namespace IntegrityService
{
	/// <summary>
	/// Description of FacilityData.
	/// </summary>
	public class WellData
	{
		#region Scenario Specific ELEMENTS XPATH
		public string txtUWI=".//input[#'DataIntegrity_WellData_txtUWI']";
		public string txtSurfaceLocationBlank=".//input[#'DataIntegrity_WellData_txtSurfaceLocationBlank']";
		public string txtProvince=".//input[#'DataIntegrity_WellData_txtProvince']";
		public string txtWellName=".//input[#'DataIntegrity_WellData_txtWellName']";
		public string txtPublicWellStatus=".//input[#'DataIntegrity_WellData_txtPublicWellStatus']";
		public string txtStatus=".//select[#'Dataintegrity_WellData_txtStatus']";
		public string txtWellSubstance=".]//select[#'DataIntegrity_WellData_txtWellSubstance']";
		public string txtDistrict=".//input[#'DataIntegrity_WellData_txtDistrict']";
		public string txtArea=".//input[#'DataIntegrity_WellData_txtArea']";
		public string txtField=".//input[#'DataIntegrity_WellData_txtField']";
		public string txtOperatorCode=".//input[#'DataIntegrity_WellData_txtOperatorCode']";
		public string txtOperator=".//input[#'DataIntegrity_WellData_txtOperator']";
		public string txtReportingTo=".//input[#'DataIntegrity_WellData_txtReportingTo']";
		public string txtDispositionFrom=".//input[#'DataIntegrity_WellData_txtDispositionFrom']";
		public string txtLicenseeCode=".//input[#'DataIntegrity_WellData_txtLicenseeCode']";
		public string txtLicensee=".//input[#'DataIntegrity_WellData_txtLicensee']";
		public string txtLicenseNo=".//input[#'DataIntegrity_WellData_txtLicenseNo']";
		public string txtLicAGT=".//input[#'DataIntegrity_WellData_txtLicAGT']";
		public string txtPublicField=".//input[#'DataIntegrity_WellData_txtPublicField']";
		public string txtLicenseDate=".//input[#'DataIntegrity_WellData_txtLicenseDate']";
		public string txtSpudDate=".//input[#'DataIntegrity_WellData_txtSpudDate']";
		public string txtFinalDrillDate=".//input[#'DataIntegrity_WellData_txtFinalDrillDate']";
		public string txtStatusDate=".//input[#'DataIntegrity_WellData_txtStatusDate']";
		public string txtIN_Prod_DT=".//input[#'DataIntegrity_WellData_txtIN_Prod_DT']";
		
		#endregion
		public WellData()
		{
		}
		
		public dtoWellClient GetApplicationData()
		{
			dtoWellClient obj1 = new dtoWellClient()
			{
				DataIntegrity_WellData_txtUWI=Helper.GetValueTxtField(txtUWI),
				DataIntegrity_WellData_txtSurfaceLocationBlank=Helper.GetValueTxtField(txtSurfaceLocationBlank),
				DataIntegrity_WellData_txtProvince=Helper.GetValueTxtField(txtProvince),
		 		DataIntegrity_WellData_txtWellName=Helper.GetValueTxtField(txtWellName),
		 //		DataIntegrity_WellData_txtPublicWellStatus=Helper.GetValueTxtField(txtPublicWellStatus),
		 		Dataintegrity_WellData_txtStatus=Helper.GetValueTxtField(txtStatus),
		 		DataIntegrity_WellData_txtWellSubstance=Helper.GetValueTxtField(txtWellSubstance),
		 //		DataIntegrity_WellData_txtDistrict=Helper.GetValueTxtField(txtDistrict),
		 //		DataIntegrity_WellData_txtArea=Helper.GetValueTxtField(txtArea),
		 		DataIntegrity_WellData_txtField=Helper.GetValueTxtField(txtField),
				DataIntegrity_WellData_txtOperatorCode=Helper.GetValueTxtField(txtOperatorCode),
				DataIntegrity_WellData_txtOperator=Helper.GetValueTxtField(txtOperator),
				DataIntegrity_WellData_txtReportingTo=Helper.GetValueTxtField(txtReportingTo),
				DataIntegrity_WellData_txtDispositionFrom=Helper.GetValueTxtField(txtDispositionFrom),
				DataIntegrity_WellData_txtLicenseeCode=Helper.GetValueTxtField(txtLicenseeCode),
				DataIntegrity_WellData_txtLicensee=Helper.GetValueTxtField(txtLicensee),
				DataIntegrity_WellData_txtLicenseNo=Helper.GetValueTxtField(txtLicenseNo),
				DataIntegrity_WellData_txtLicAGT=Helper.GetValueTxtField(txtLicAGT),
		//		DataIntegrity_WellData_txtPublicField=Helper.GetValueTxtField(txtPublicField),
				DataIntegrity_WellData_txtLicenseDate=Helper.GetValueTxtField(txtLicenseDate),
				DataIntegrity_WellData_txtSpudDate=Helper.GetValueTxtField(txtSpudDate),
				DataIntegrity_WellData_txtFinalDrillDate=Helper.GetValueTxtField(txtFinalDrillDate),
				DataIntegrity_WellData_txtStatusDate=Helper.GetValueTxtField(txtStatusDate),
				DataIntegrity_WellData_txtIN_Prod_DT=Helper.GetValueTxtField(txtIN_Prod_DT),
			
			};
			
			return obj1;
}
		
		public bool MatchWellScreenData(string clientID, string Name)
		{
			
			bool flag = true;
			MappingPrivateScreenDB objDB = new MappingPrivateScreenDB();
			
			dtoWellClient obj1 = GetApplicationData();
			dtoWellClient obj2 = objDB.WellScreenData(clientID,Name);
			
			if(obj1.DataIntegrity_WellData_txtUWI != obj2.DataIntegrity_WellData_txtUWI)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"UWI matched to Data Base = " + obj1.DataIntegrity_WellData_txtUWI );
			
			if(obj1.DataIntegrity_WellData_txtSurfaceLocationBlank != obj2.DataIntegrity_WellData_txtSurfaceLocationBlank)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"SurfaceLocation matched to Data Base = " + obj1.DataIntegrity_WellData_txtSurfaceLocationBlank );
			
			if(obj1.DataIntegrity_WellData_txtProvince != obj2.DataIntegrity_WellData_txtProvince)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Province matched to Data Base = " + obj1.DataIntegrity_WellData_txtProvince );
			
			if(obj1.DataIntegrity_WellData_txtWellName != obj2.DataIntegrity_WellData_txtWellName)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"WellName matched to Data Base = " + obj1.DataIntegrity_WellData_txtWellName );
			
			if(obj1.Dataintegrity_WellData_txtStatus != obj2.Dataintegrity_WellData_txtStatus)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Status matched to Data Base = " + obj1.Dataintegrity_WellData_txtStatus );
			
			if(obj1.DataIntegrity_WellData_txtWellSubstance != obj2.DataIntegrity_WellData_txtWellSubstance)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"WellSubstance matched to Data Base = " + obj1.DataIntegrity_WellData_txtWellSubstance );
			
//			if(obj1.DataIntegrity_WellData_txtDistrict != obj2.DataIntegrity_WellData_txtDistrict)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"District matched to Data Base = " + obj1.DataIntegrity_WellData_txtDistrict );
//			
//			if(obj1.DataIntegrity_WellData_txtArea != obj2.DataIntegrity_WellData_txtArea)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"Area matched to Data Base = " + obj1.DataIntegrity_WellData_txtArea );
//			
			if(obj1.DataIntegrity_WellData_txtField != obj2.DataIntegrity_WellData_txtField)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Field matched to Data Base = " + obj1.DataIntegrity_WellData_txtField );
			
			if(obj1.DataIntegrity_WellData_txtOperatorCode != obj2.DataIntegrity_WellData_txtOperatorCode)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"OperatorCode matched to Data Base = " + obj1.DataIntegrity_WellData_txtOperatorCode );
			
			if(obj1.DataIntegrity_WellData_txtReportingTo != obj2.DataIntegrity_WellData_txtReportingTo)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ReportingTo matched to Data Base = " + obj1.DataIntegrity_WellData_txtReportingTo );
			
			if(obj1.DataIntegrity_WellData_txtDispositionFrom != obj2.DataIntegrity_WellData_txtDispositionFrom)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"DispositionFrom matched to Data Base = " + obj1.DataIntegrity_WellData_txtDispositionFrom );
			
			if(obj1.DataIntegrity_WellData_txtLicenseeCode != obj2.DataIntegrity_WellData_txtLicenseeCode)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicenseeCod matched to Data Base = " + obj1.DataIntegrity_WellData_txtLicenseeCode );
			
			if(obj1.DataIntegrity_WellData_txtLicensee != obj2.DataIntegrity_WellData_txtLicensee)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Licensee  matched to Data Base = " + obj1.DataIntegrity_WellData_txtLicensee );
			
			if(obj1.DataIntegrity_WellData_txtLicenseNo != obj2.DataIntegrity_WellData_txtLicenseNo)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicenseNo  matched to Data Base = " + obj1.DataIntegrity_WellData_txtLicenseNo );
			
			if(obj1.DataIntegrity_WellData_txtLicAGT != obj2.DataIntegrity_WellData_txtLicAGT)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicAGT matched to Data Base = " + obj1.DataIntegrity_WellData_txtLicAGT );
			
//			if(obj1.DataIntegrity_WellData_txtPublicField != obj2.DataIntegrity_WellData_txtPublicField)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"PublicField matched to Data Base = " + obj1.DataIntegrity_WellData_txtPublicField );
//			
			if(obj1.DataIntegrity_WellData_txtLicenseDate != obj2.DataIntegrity_WellData_txtLicenseDate)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicenseDate matched to Data Base = " + obj1.DataIntegrity_WellData_txtLicenseDate );
			
			if(obj1.DataIntegrity_WellData_txtSpudDate != obj2.DataIntegrity_WellData_txtSpudDate)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"SpudDate matched to Data Base = " + obj1.DataIntegrity_WellData_txtSpudDate );
			
			if(obj1.DataIntegrity_WellData_txtFinalDrillDate != obj2.DataIntegrity_WellData_txtFinalDrillDate)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"FinalDrillDate matched to Data Base = " + obj1.DataIntegrity_WellData_txtFinalDrillDate );
			
			if(obj1.DataIntegrity_WellData_txtStatusDate != obj2.DataIntegrity_WellData_txtStatusDate)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"StatusDate matched to Data Base = " + obj1.DataIntegrity_WellData_txtStatusDate );
			
			if(obj1.DataIntegrity_WellData_txtIN_Prod_DT != obj2.DataIntegrity_WellData_txtIN_Prod_DT)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Prod_DT matched to Data Base = " + obj1.DataIntegrity_WellData_txtIN_Prod_DT );			
			return flag;
		
		}
	}
}
