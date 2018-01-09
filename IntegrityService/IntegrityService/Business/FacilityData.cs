/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/22/2017
 * Time: 2:25 AM
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
	public class FacilityData
	{
		#region Scenario Specific ELEMENTS XPATH
		public string txtFacID=".//input[#'DataIntegrity_FacilityData_txtFacID']";
		public string txtLocationBlank=".//input[#'DataIntegrity_FacilityData_txtLocationBlank']";
		public string txtProvince=".//input[#'DataIntegrity_FacilityData_txtProvince']";
		public string txtFacilityName=".//input[#'DataIntegrity_FacilityData_txtFacilityName']";
		public string txtStatus=".//select[#'Dataintegrity_FacilityData_txtStatus']";
		public string txtFacType=".//select[#'Dataintegrity_FacilityData_txtFacType']";
		public string txtDistrict=".//input[#'Dataintegrity_FacilityData_txtDistrict']";
		public string txtArea=".//input[#'Dataintegrity_FacilityData_txtArea']";
		public string txtField=".//input[#'Dataintegrity_FacilityData_txtField']";
		public string txtOperatorCode=".//input[#'DataIntegrity_FacilityData_txtOperatorCode']";
		public string txtOperator=".//input[#'DataIntegrity_FacilityData_txtOperator']";
		public  string txtBattCD=".//input[#'Dataintegrity_FacilityData_txtBattCD']";
		public  string txtBattType=".//input[#'Dataintegrity_FacilityData_txtBattType']";
		public  string txtLicenseeCode=".//input[#'DataIntegrity_FacilityData_txtLicenseeCode']";
		public  string txtLicensee=".//input[#'DataIntegrity_FacilityData_txtLicensee']";
		public  string txtLicense=".//input[#'Dataintegrity_FacilityData_txtLicense']";
		public  string H2S=".//input[#'DataIntegrity_FacilityData_H2S']";
		public  string txtPublicFieldName=".//input[#'DataIntegrity_FacilityData_txtPublicFieldName']";
		public  string txtPrimemover=".//input[#'DataIntegrity_FacilityData_txtPrimemover']";
		public  string txtPower=".//input[#'DataIntegrity_FacilityData_txtPower']";
		public  string txtInstall_NO=".//input[#'DataIntegrity_FacilityData_txtInstall_NO']";
		public  string txtSource_ID=".//input[#'DataIntegrity_FacilityData_txtSource_ID']";
		public  string Lic_APR=".//input[#'DataIntegrity_FacilityData_Lic_APR']";
		public  string Permit_APR=".//input[#'DataIntegrity_FacilityData_Permit_APR']";
		public  string Permit_EXP=".//input[#'DataIntegrity_FacilityData_Permit_EXP']";
		public  string PrivatePipelinewindowwndtitle=".//span[#'DataIntegrity_PipelineData_Window_wnd_title']";
		
		#endregion
		public FacilityData()
		{
		}
		
		public dtoFacilityClient GetApplicationData()
		{
			dtoFacilityClient obj1 = new dtoFacilityClient()
			{
				DataIntegrity_FacilityData_txtFacID=Helper.GetValueTxtField(txtFacID),
				DataIntegrity_FacilityData_txtLocationBlank=Helper.GetValueTxtField(txtLocationBlank),
				DataIntegrity_FacilityData_txtProvince=Helper.GetValueTxtField(txtProvince),
		 		DataIntegrity_FacilityData_txtFacilityName=Helper.GetValueTxtField(txtFacilityName),
		 		Dataintegrity_FacilityData_txtStatus=Helper.GetValueTxtField(txtStatus),
		 		Dataintegrity_FacilityData_txtFacType=Helper.GetValueTxtField(txtFacType),
		 		Dataintegrity_FacilityData_txtDistrict=Helper.GetValueTxtField(txtDistrict),
		 		Dataintegrity_FacilityData_txtArea=Helper.GetValueTxtField(txtArea),
		 		Dataintegrity_FacilityData_txtField=Helper.GetValueTxtField(txtField),
		 		DataIntegrity_FacilityData_txtOperatorCode=Helper.GetValueTxtField(txtOperatorCode),
				DataIntegrity_FacilityData_txtOperator=Helper.GetValueTxtField(txtOperator),
				Dataintegrity_FacilityData_txtBattCD=Helper.GetValueTxtField(txtBattCD),
				Dataintegrity_FacilityData_txtBattType=Helper.GetValueTxtField(txtBattType),
				DataIntegrity_FacilityData_txtLicenseeCode=Helper.GetValueTxtField(txtLicenseeCode),
				DataIntegrity_FacilityData_txtLicensee=Helper.GetValueTxtField(txtLicensee),
				Dataintegrity_FacilityData_txtLicense=Helper.GetValueTxtField(txtLicense),
				DataIntegrity_FacilityData_H2S=Helper.GetValueTxtField(H2S),
				DataIntegrity_FacilityData_txtPublicFieldName=Helper.GetValueTxtField(txtPublicFieldName),
				DataIntegrity_FacilityData_txtPrimemover=Helper.GetValueTxtField(txtPrimemover),
				DataIntegrity_FacilityData_txtPower=Helper.GetValueTxtField(txtPower),
				DataIntegrity_FacilityData_txtInstall_NO=Helper.GetValueTxtField(txtInstall_NO),
				DataIntegrity_FacilityData_txtSource_ID=Helper.GetValueTxtField(txtSource_ID),
				DataIntegrity_FacilityData_Lic_APR=Helper.GetValueTxtField(Lic_APR),
				DataIntegrity_FacilityData_Permit_APR=Helper.GetValueTxtField(Permit_APR),
				DataIntegrity_FacilityData_Permit_EXP=Helper.GetValueTxtField(Permit_EXP)
			};
			
			return obj1;
}
		
		public bool MatchFacilityScreenData(string clientID, string Name)
		{
			bool flag = true;
			MappingPrivateScreenDB objDB = new MappingPrivateScreenDB();
			
			dtoFacilityClient obj1 = GetApplicationData();
			dtoFacilityClient obj2 = objDB.FacilityScreenData(clientID,Name);
			
			if(obj1.DataIntegrity_FacilityData_txtFacID != obj2.DataIntegrity_FacilityData_txtFacID)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Fac_Id matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtFacID );
			
			if(obj1.DataIntegrity_FacilityData_txtLocationBlank != obj2.DataIntegrity_FacilityData_txtLocationBlank)
			flag = false;
			else
			Helper.SetReportLog(ReportLevel.Info,"LocationBlank matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtLocationBlank );
			
			if(obj1.DataIntegrity_FacilityData_txtProvince != obj2.DataIntegrity_FacilityData_txtProvince)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Province matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtProvince);
			
			if(obj1.DataIntegrity_FacilityData_txtFacilityName != obj2.DataIntegrity_FacilityData_txtFacilityName)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"FacilityName matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtFacilityName);
			
			if(obj1.Dataintegrity_FacilityData_txtStatus != obj2.Dataintegrity_FacilityData_txtStatus)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Status matched to Data Base = " + obj1.Dataintegrity_FacilityData_txtStatus);
			
			if(obj1.Dataintegrity_FacilityData_txtFacType != obj2.Dataintegrity_FacilityData_txtFacType)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"FacType matched to Data Base = " + obj1.Dataintegrity_FacilityData_txtFacType);
			
			if(obj1.DataIntegrity_FacilityData_txtOperatorCode != obj2.DataIntegrity_FacilityData_txtOperatorCode)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"OperatorCode matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtOperatorCode);
			
			if(obj1.DataIntegrity_FacilityData_txtOperator != obj2.DataIntegrity_FacilityData_txtOperator)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Operator matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtOperator);
			
			if(obj1.Dataintegrity_FacilityData_txtBattType != obj2.Dataintegrity_FacilityData_txtBattType)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"BattType matched to Data Base = " + obj1.Dataintegrity_FacilityData_txtBattType);
			
			if(obj1.DataIntegrity_FacilityData_txtLicenseeCode != obj2.DataIntegrity_FacilityData_txtLicenseeCode)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicenseeCode matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtLicenseeCode);
			
			if(obj1.DataIntegrity_FacilityData_txtLicensee != obj2.DataIntegrity_FacilityData_txtLicensee)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Licensee matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtLicensee);
			
			if(obj1.DataIntegrity_FacilityData_H2S != obj2.DataIntegrity_FacilityData_H2S)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"H2S matched to Data Base = " + obj1.DataIntegrity_FacilityData_H2S);
			
			if(obj1.DataIntegrity_FacilityData_txtPrimemover != obj2.DataIntegrity_FacilityData_txtPrimemover)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Primemover matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtPrimemover);
			
			if(obj1.DataIntegrity_FacilityData_txtPower != obj2.DataIntegrity_FacilityData_txtPower)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Power matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtPower);
			
			if(obj1.DataIntegrity_FacilityData_txtInstall_NO != obj2.DataIntegrity_FacilityData_txtInstall_NO)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Install_NO matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtInstall_NO);
			
			if(obj1.DataIntegrity_FacilityData_txtSource_ID != obj2.DataIntegrity_FacilityData_txtSource_ID)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Source_ID matched to Data Base = " + obj1.DataIntegrity_FacilityData_txtSource_ID);
			
			if(obj1.DataIntegrity_FacilityData_Lic_APR != obj2.DataIntegrity_FacilityData_Lic_APR)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Lic_APR matched to Data Base = " + obj1.DataIntegrity_FacilityData_Lic_APR);
			
			if(obj1.DataIntegrity_FacilityData_Permit_APR != obj2.DataIntegrity_FacilityData_Permit_APR)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Permit_APR matched to Data Base = " + obj1.DataIntegrity_FacilityData_Permit_APR);
			
			if(obj1.DataIntegrity_FacilityData_Permit_EXP != obj2.DataIntegrity_FacilityData_Permit_EXP)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Permit_EXP matched to Data Base = " + obj1.DataIntegrity_FacilityData_Permit_EXP );
			
			
			return flag;
		
		}
	}
}
