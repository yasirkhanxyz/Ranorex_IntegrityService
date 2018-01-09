/*
 * Created by Ranorex
 * User: ykhan
 * Date: 7/11/2017
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
	/// Description of PipelineData.
	/// </summary>
	public class PipelineData
	{
		#region Scenario Specific ELEMENTS XPATH
		public string txtLicenseLine=".//input[#'DataIntegrity_PipelineData_txtLicenseLine']";
		public string txtProvince=".//input[#'DataIntegrity_PipelineData_txtProvince']";
		public string txtStatus=".//select[#'DataIntegrity_PipelineData_txtStatus']";
		public string txtSubstance=".//select[#'DataIntegrity_PipelineData_txtSubstance']";
		public string txtMaterial=".//select[#'DataIntegrity_PipelineData_txtMaterial']";
		public string txtField=".//input[#'DataIntegrity_PipelineData_txtField']";
		public string txtNEB=".//select[#'DataIntegrity_PipelineData_txtNEB']";
		public string txtAlias=".//input[#'DataIntegrity_PipelineData_txtAlias']";
		public string txtOperatorRun=".//input[#'DataIntegrity_PipelineData_txtOperatorRun']";
		public string txtOperatorCode=".//input[#'DataIntegrity_PipelineData_txtOperatorCode']";
		public string txtOperator=".//input[#'DataIntegrity_PipelineData_txtOperator']";
		public string txtLicCD=".//input[#'DataIntegrity_PipelineData_txtLicCD']";
		public string txtLicensee=".//input[#'DataIntegrity_PipelineData_txtLicensee']";
		public string txtFromLocation=".//input[#'DataIntegrity_PipelineData_txtFromLocation']";
		public string FromType=".//select[#'DataIntegrity_PipelineData_FromType']";
		public string txtToLocation=".//input[#'DataIntegrity_PipelineData_txtToLocation']";
		public string ToType=".//select[#'DataIntegrity_PipelineData_ToType']";
		public string txtORIGLIC=".//input[#'DataIntegrity_PipelineData_txtORIGLIC']";
		public string txtORIGLINE=".//input[#'DataIntegrity_PipelineData_txtORIGLINE']";
		public string txtOwner=".//input[#'DataIntegrit_PipelineData_txtOwner']";
		public string txtLength=".//input[#'DataIntegrity_PipelineData_txtLength']";
		public string txtCalLength=".//input[#'DataIntegrity_PipelineData_txtCalLength']";
		public string txtSegmentLength=".//input[#'DataIntegrity_PipelineData_txtSegmentLength']";
		public string txtDiameter=".//input[#'DataIntegrity_PipelineData_txtDiameter']";
		public string txtWallThickness=".//input[#'DataIntegrity_PipelineData_txtWallThickness']";
		public string txtYearBuilt=".//input[#'DataIntegrity_PipelineData_txtYearBuilt']";
		public string txtDesignPressure=".//input[#'DataIntegrity_PipelineData_txtDesignPressure']";
		public string txtTestPressure=".//input[#'DataIntegrity_PipelineData_txtTestPressure']";
		public string txtMaxOpPress=".//input[#'DataIntegrity_PipelineData_txtMaxOpPress']";
		public string ddlEnviro=".//select[#'DataIntegrity_PipelineData_ddlEnviro']";
		public string ddlJoinType=".//select[#'DataIntegrity_PipelineData_ddlJoinType']";
		public string ddlInterProtect=".//select[#'DataIntegrity_PipelineData_ddlInterProtect']";
		public string ddlExtCoating=".//select[#'DataIntegrity_PipelineData_ddlExtCoating']";
		public string txtStress_Lvl=".//input[#'DataIntegrity_PipelineData_txtStress_Lvl']";
		public string txtLicAPR=".//input[#'DataIntegrity_PipelineData_txtLicAPR']";
		public string txrPermitAPR=".//input[#'DataIntegrity_PipelineData_txrPermitAPR']";
		public string txtPermitEXP=".//input[#'DataIntegrity_PipelineData_txtPermitEXP']";
		public string txtConsStartDate=".//input[#'DataIntegrity_PipelineData_txtConsStartDate']";
		public string txtConsEndDate=".//input[#'DataIntegrity_PipelineData_txtConsEndDate']";
		public string txtLastCHG=".//input[#'DataIntegrity_PipelineData_txtLastCHG']";
		public string ddlPiggable=".//select[#'DataIntegrity_PipelineData_ddlPiggable']";
		public string txtLinerInstallationYear=".//input[#'DataIntegrity_PipelineData_txtLinerInstallationYear']";
		public string ddlAdjacent=".//select[#'DataIntegrity_PipelineData_ddlAdjacent']";
		public string ddlEPZZone=".//select[#'DataIntegrity_PipelineData_ddlEPZZone']";
		public string ddlEPZCategory=".//select[#'DataIntegrity_PipelineData_ddlEPZCategory']";
		
		
		#endregion
		public PipelineData()
		{
		}
		
		public dtoPipelineClient GetApplicationData()
		{
			dtoPipelineClient obj1 = new dtoPipelineClient()
			{
		//		DataIntegrity_PipelineData_txtLicenseLine=Helper.GetValueTxtField(txtLicenseLine),
				DataIntegrity_PipelineData_txtProvince=Helper.GetValueTxtField(txtProvince),
				DataIntegrity_PipelineData_txtStatus=Helper.GetValueTxtField(txtStatus),
		 		DataIntegrity_PipelineData_txtSubstance=Helper.GetValueTxtField(txtSubstance),
		 		DataIntegrity_PipelineData_txtMaterial=Helper.GetValueTxtField(txtMaterial),
		 		DataIntegrity_PipelineData_txtField=Helper.GetValueTxtField(txtField),
		// 		DataIntegrity_PipelineData_txtNEB=Helper.GetValueTxtField(txtNEB),
		// 		DataIntegrity_PipelineData_txtAlias=Helper.GetValueTxtField(txtAlias),
		// 		DataIntegrity_PipelineData_txtOperatorRun=Helper.GetValueTxtField(txtOperatorRun),
		 		DataIntegrity_PipelineData_txtOperatorCode=Helper.GetValueTxtField(txtOperatorCode),
				DataIntegrity_PipelineData_txtOperator=Helper.GetValueTxtField(txtOperator),
				DataIntegrity_PipelineData_txtLicCD=Helper.GetValueTxtField(txtLicCD),
				DataIntegrity_PipelineData_txtLicensee=Helper.GetValueTxtField(txtLicensee),
				DataIntegrity_PipelineData_txtFromLocation=Helper.GetValueTxtField(txtFromLocation),
				DataIntegrity_PipelineData_FromType=Helper.GetValueTxtField(FromType),
				DataIntegrity_PipelineData_txtToLocation=Helper.GetValueTxtField(txtToLocation),
				DataIntegrity_PipelineData_ToType=Helper.GetValueTxtField(ToType),
				DataIntegrity_PipelineData_txtORIGLIC=Helper.GetValueTxtField(txtORIGLIC),
				DataIntegrity_PipelineData_txtORIGLINE=Helper.GetValueTxtField(txtORIGLINE),
				DataIntegrit_PipelineData_txtOwner=Helper.GetValueTxtField(txtOwner),
				DataIntegrity_PipelineData_txtLength=Helper.GetValueTxtField(txtLength),
		//		DataIntegrity_PipelineData_txtCalLength=Helper.GetValueTxtField(txtCalLength),
				DataIntegrity_PipelineData_txtSegmentLength=Helper.GetValueTxtField(txtSegmentLength),
				DataIntegrity_PipelineData_txtDiameter=Helper.GetValueTxtField(txtDiameter),
				DataIntegrity_PipelineData_txtWallThickness=Helper.GetValueTxtField(txtWallThickness),
				DataIntegrity_PipelineData_txtYearBuilt=Helper.GetValueTxtField(txtYearBuilt),
				DataIntegrity_PipelineData_txtDesignPressure=Helper.GetValueTxtField(txtDesignPressure),
				DataIntegrity_PipelineData_txtTestPressure=Helper.GetValueTxtField(txtTestPressure),
				DataIntegrity_PipelineData_txtMaxOpPress=Helper.GetValueTxtField(txtMaxOpPress),
				DataIntegrity_PipelineData_ddlEnviro=Helper.GetValueTxtField(ddlEnviro),
				DataIntegrity_PipelineData_ddlJoinType=Helper.GetValueTxtField(ddlJoinType),
				DataIntegrity_PipelineData_ddlInterProtect=Helper.GetValueTxtField(ddlInterProtect),
				DataIntegrity_PipelineData_ddlExtCoating=Helper.GetValueTxtField(ddlExtCoating),
				DataIntegrity_PipelineData_txtStress_Lvl=Helper.GetValueTxtField(txtStress_Lvl),
				DataIntegrity_PipelineData_txtLicAPR=Helper.GetValueTxtField(txtLicAPR),
				DataIntegrity_PipelineData_txrPermitAPR=Helper.GetValueTxtField(txrPermitAPR),
				DataIntegrity_PipelineData_txtPermitEXP=Helper.GetValueTxtField(txtPermitEXP),
				DataIntegrity_PipelineData_txtConsStartDate=Helper.GetValueTxtField(txtConsStartDate),
				DataIntegrity_PipelineData_txtConsEndDate=Helper.GetValueTxtField(txtConsEndDate),
				DataIntegrity_PipelineData_txtLastCHG=Helper.GetValueTxtField(txtLastCHG),
		//		DataIntegrity_PipelineData_ddlPiggable=Helper.GetValueTxtField(ddlPiggable),
		//		DataIntegrity_PipelineData_txtLinerInstallationYear=Helper.GetValueTxtField(txtLinerInstallationYear),
		//		DataIntegrity_PipelineData_ddlAdjacent=Helper.GetValueTxtField(ddlAdjacent),
		//		DataIntegrity_PipelineData_ddlEPZZone=Helper.GetValueTxtField(ddlEPZZone),
		//		DataIntegrity_PipelineData_ddlEPZCategory=Helper.GetValueTxtField(ddlEPZCategory),
			
			};
			
			return obj1;
		}
		
		public bool MatchPipelineScreenData(string clientID, string license, string line,string segment)
		{
			
			bool flag = true;
			MappingPrivateScreenDB objDB = new MappingPrivateScreenDB();
			
			dtoPipelineClient obj1 = GetApplicationData();
			dtoPipelineClient obj2 = objDB.PipelineScreenData(clientID,license,line,segment);
			
//			if(obj1.DataIntegrity_PipelineData_txtLicenseLine != obj2.DataIntegrity_PipelineData_txtLicenseLine)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"LicenseLine matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtLicenseLine);
//			
			if(obj1.DataIntegrity_PipelineData_txtProvince != obj2.DataIntegrity_PipelineData_txtProvince)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Province matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtProvince);
			
			if(obj1.DataIntegrity_PipelineData_txtStatus != obj2.DataIntegrity_PipelineData_txtStatus)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Status matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtStatus);
			
			if(obj1.DataIntegrity_PipelineData_txtSubstance != obj2.DataIntegrity_PipelineData_txtSubstance)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Substance matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtSubstance);
			
			if(obj1.DataIntegrity_PipelineData_txtMaterial != obj2.DataIntegrity_PipelineData_txtMaterial)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Material  matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtMaterial);
			
			if(obj1.DataIntegrity_PipelineData_txtField != obj2.DataIntegrity_PipelineData_txtField)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Field matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtField);
			
//			if(obj1.DataIntegrity_PipelineData_txtNEB != obj2.DataIntegrity_PipelineData_txtNEB)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"NEB matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtNEB);
//			
//			if(obj1.DataIntegrity_PipelineData_txtAlias != obj2.DataIntegrity_PipelineData_txtAlias)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"Alias matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtAlias);
//			
//			if(obj1.DataIntegrity_PipelineData_txtOperatorRun != obj2.DataIntegrity_PipelineData_txtOperatorRun)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"OperatorRun matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtOperatorRun);
//			
			if(obj1.DataIntegrity_PipelineData_txtOperatorCode != obj2.DataIntegrity_PipelineData_txtOperatorCode)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"OperatorCode matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtOperatorCode);
			
			if(obj1.DataIntegrity_PipelineData_txtOperator != obj2.DataIntegrity_PipelineData_txtOperator)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Operator  matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtOperator);
			
			if(obj1.DataIntegrity_PipelineData_txtLicCD != obj2.DataIntegrity_PipelineData_txtLicCD)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicCD matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtLicCD);
			
			if(obj1.DataIntegrity_PipelineData_txtLicensee != obj2.DataIntegrity_PipelineData_txtLicensee)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Licensee matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtLicensee);
			
			if(obj1.DataIntegrity_PipelineData_txtFromLocation != obj2.DataIntegrity_PipelineData_txtFromLocation)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"FromLocation  matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtFromLocation);
			
			if(obj1.DataIntegrity_PipelineData_FromType != obj2.DataIntegrity_PipelineData_FromType)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicenseNo  matched to Data Base = " + obj1.DataIntegrity_PipelineData_FromType);
			
			if(obj1.DataIntegrity_PipelineData_txtToLocation != obj2.DataIntegrity_PipelineData_txtToLocation)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ToLocation matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtToLocation);
			
			if(obj1.DataIntegrity_PipelineData_ToType != obj2.DataIntegrity_PipelineData_ToType)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ToType matched to Data Base = " + obj1.DataIntegrity_PipelineData_ToType);
//			
			if(obj1.DataIntegrity_PipelineData_txtORIGLIC != obj2.DataIntegrity_PipelineData_txtORIGLIC)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ORIG LIC matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtORIGLIC);
			
			if(obj1.DataIntegrity_PipelineData_txtORIGLINE != obj2.DataIntegrity_PipelineData_txtORIGLINE)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ORIG LINE matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtORIGLINE);
			
			if(obj1.DataIntegrit_PipelineData_txtOwner != obj2.DataIntegrit_PipelineData_txtOwner)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Owner matched to Data Base = " + obj1.DataIntegrit_PipelineData_txtOwner);
			
			if(obj1.DataIntegrity_PipelineData_txtLength != obj2.DataIntegrity_PipelineData_txtLength)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Length matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtLength);
			
//			if(obj1.DataIntegrity_PipelineData_txtCalLength != obj2.DataIntegrity_PipelineData_txtCalLength)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"CalLength matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtCalLength);			
//			
			if(obj1.DataIntegrity_PipelineData_txtSegmentLength != obj2.DataIntegrity_PipelineData_txtSegmentLength)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"SegmentLength matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtSegmentLength);
			
			if(obj1.DataIntegrity_PipelineData_txtDiameter != obj2.DataIntegrity_PipelineData_txtDiameter)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Diameter matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtDiameter);
			
			if(obj1.DataIntegrity_PipelineData_txtWallThickness != obj2.DataIntegrity_PipelineData_txtWallThickness)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"WallThickness matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtWallThickness);
			
			if(obj1.DataIntegrity_PipelineData_txtYearBuilt != obj2.DataIntegrity_PipelineData_txtYearBuilt)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"YearBuilt matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtYearBuilt);
			
			if(obj1.DataIntegrity_PipelineData_txtDesignPressure != obj2.DataIntegrity_PipelineData_txtDesignPressure)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"DesignPressure matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtDesignPressure);
			
			if(obj1.DataIntegrity_PipelineData_txtTestPressure != obj2.DataIntegrity_PipelineData_txtTestPressure)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"TestPressure  matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtTestPressure);
			
			if(obj1.DataIntegrity_PipelineData_txtMaxOpPress != obj2.DataIntegrity_PipelineData_txtMaxOpPress)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"MaxOpPress matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtMaxOpPress);
			
			if(obj1.DataIntegrity_PipelineData_ddlEnviro != obj2.DataIntegrity_PipelineData_ddlEnviro)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ddlEnviro  matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlEnviro);
			
			if(obj1.DataIntegrity_PipelineData_ddlJoinType != obj2.DataIntegrity_PipelineData_ddlJoinType)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"JoinType matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlJoinType);
			
			if(obj1.DataIntegrity_PipelineData_ddlInterProtect != obj2.DataIntegrity_PipelineData_ddlInterProtect )
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"InterProtect matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlInterProtect);
			
			if(obj1.DataIntegrity_PipelineData_ddlExtCoating != obj2.DataIntegrity_PipelineData_ddlExtCoating)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ExtCoating  matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlExtCoating);
			
			if(obj1.DataIntegrity_PipelineData_txtStress_Lvl != obj2.DataIntegrity_PipelineData_txtStress_Lvl)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"Stress_Lvl matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtStress_Lvl);
			
			if(obj1.DataIntegrity_PipelineData_txtLicAPR != obj2.DataIntegrity_PipelineData_txtLicAPR)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LicAPR matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtLicAPR);
			
			if(obj1.DataIntegrity_PipelineData_txrPermitAPR != obj2.DataIntegrity_PipelineData_txrPermitAPR)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"PermitAPR matched to Data Base = " + obj1.DataIntegrity_PipelineData_txrPermitAPR);
			
			if(obj1.DataIntegrity_PipelineData_txtPermitEXP != obj2.DataIntegrity_PipelineData_txtPermitEXP)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"PermitEXP matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtPermitEXP);
			
			if(obj1.DataIntegrity_PipelineData_txtConsStartDate != obj2.DataIntegrity_PipelineData_txtConsStartDate)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ConsStartDate matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtConsStartDate);
			
			if(obj1.DataIntegrity_PipelineData_txtConsEndDate != obj2.DataIntegrity_PipelineData_txtConsEndDate)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"ConsEndDate matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtConsEndDate);
			
			if(obj1.DataIntegrity_PipelineData_txtLastCHG != obj2.DataIntegrity_PipelineData_txtLastCHG)
			flag = false;
			else
				Helper.SetReportLog(ReportLevel.Info,"LastCHG matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtLastCHG);
			
//			if(obj1.DataIntegrity_PipelineData_ddlPiggable != obj2.DataIntegrity_PipelineData_ddlPiggable)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"Piggable matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlPiggable);
//			
//			if(obj1.DataIntegrity_PipelineData_txtLinerInstallationYear != obj2.DataIntegrity_PipelineData_txtLinerInstallationYear)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"LinerInstallationYear matched to Data Base = " + obj1.DataIntegrity_PipelineData_txtLinerInstallationYear);
//			
//			if(obj1.DataIntegrity_PipelineData_ddlAdjacent != obj2.DataIntegrity_PipelineData_ddlAdjacent)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"Adjacent matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlAdjacent);
//			
//			if(obj1.DataIntegrity_PipelineData_ddlEPZZone != obj2.DataIntegrity_PipelineData_ddlEPZZone)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"EPZZone matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlEPZZone);
//			
//			if(obj1.DataIntegrity_PipelineData_ddlEPZCategory != obj2.DataIntegrity_PipelineData_ddlEPZCategory)
//			flag = false;
//			else
//				Helper.SetReportLog(ReportLevel.Info,"EPZCategory matched to Data Base = " + obj1.DataIntegrity_PipelineData_ddlEPZCategory);
//			
			return flag;
		
		}
	}
}
