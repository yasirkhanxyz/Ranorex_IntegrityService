/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/21/2017
 * Time: 5:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IntegrityService.Database
{
	/// <summary>
	/// Description of MappingPrivateScreenDB.
	/// </summary>
	public class MappingPrivateScreenDB
	{
		DBHelper dbData = null;
		
		public MappingPrivateScreenDB()
		{
			dbData = new DBHelper();
		}
	
		/// <summary>
		/// Common Query for fetching the data from FacilityClient for mapping.
		/// </summary>
		
		public dtoFacilityClient FacilityScreenData(string client_id,string Name)
		{
			string sql = "";
			   	sql = string.Format("Select [Fac_ID],[Location],[Province],[Name],[Status]" +
				                    ",[Fac_Type],[Field],[Oper_CD],[Oper],[Batt_CD],[Batt_Type]," +
				                    "[Licnsee_CD],[Licnsee],[License],[H2S],[Primemover],[Power]," +
				                    "[Install_NO],[Source_ID],[Lic_APR],[Permit_APR],[Permit_EXP] " +
				                    "from facilityClient WHERE client_id = '{0}' and Fac_id='{1}'",client_id,Name);
			    
			    var dt  = dbData.RunQuery(sql);
			    dtoFacilityClient obj2 = new dtoFacilityClient();
			    if(dt !=null && dt.Rows.Count>0)
			    {
			    	obj2.DataIntegrity_FacilityData_txtFacID = dt.Rows[0]["Fac_ID"].ToString();
				    obj2.DataIntegrity_FacilityData_txtLocationBlank=dt.Rows[0]["Location"].ToString();
					obj2.DataIntegrity_FacilityData_txtProvince=dt.Rows[0]["Province"].ToString();
			 		obj2.DataIntegrity_FacilityData_txtFacilityName=dt.Rows[0]["Name"].ToString();
			 		obj2.Dataintegrity_FacilityData_txtStatus=dt.Rows[0]["Status"].ToString();
			 		obj2.Dataintegrity_FacilityData_txtFacType=dt.Rows[0]["Fac_Type"].ToString();
			 	//	obj2.Dataintegrity_FacilityData_txtDistrict=dt.Rows[0]["Fac_ID"];
			 	//	obj2.Dataintegrity_FacilityData_txtArea=dt.Rows[0]["Fac_ID"];
			 		obj2.Dataintegrity_FacilityData_txtField=dt.Rows[0]["Field"].ToString();
			 		obj2.DataIntegrity_FacilityData_txtOperatorCode=dt.Rows[0]["Oper_CD"].ToString();
					obj2.DataIntegrity_FacilityData_txtOperator=dt.Rows[0]["Oper"].ToString();
					obj2.Dataintegrity_FacilityData_txtBattCD=dt.Rows[0]["Batt_CD"].ToString();
					obj2.Dataintegrity_FacilityData_txtBattType=dt.Rows[0]["Batt_Type"].ToString();
					obj2.DataIntegrity_FacilityData_txtLicenseeCode=dt.Rows[0]["Licnsee_CD"].ToString();
					obj2.DataIntegrity_FacilityData_txtLicensee=dt.Rows[0]["Licnsee"].ToString();
					obj2.Dataintegrity_FacilityData_txtLicense=dt.Rows[0]["License"].ToString();
					obj2.DataIntegrity_FacilityData_H2S=dt.Rows[0]["H2S"].ToString();
				//	obj2.DataIntegrity_FacilityData_txtPublicFieldName=dt.Rows[0]["Fac_ID"];
					obj2.DataIntegrity_FacilityData_txtPrimemover=dt.Rows[0]["Primemover"].ToString();
					obj2.DataIntegrity_FacilityData_txtPower=dt.Rows[0]["Power"].ToString();
					obj2.DataIntegrity_FacilityData_txtInstall_NO=dt.Rows[0]["Install_NO"].ToString();
					obj2.DataIntegrity_FacilityData_txtSource_ID=dt.Rows[0]["Source_ID"].ToString();
					obj2.DataIntegrity_FacilityData_Lic_APR=dt.Rows[0]["Lic_APR"].ToString();
					obj2.DataIntegrity_FacilityData_Permit_APR=dt.Rows[0]["Permit_APR"].ToString();
					obj2.DataIntegrity_FacilityData_Permit_EXP=dt.Rows[0]["Permit_EXP"].ToString();
			    }
					return obj2;
		

		}
	
	
		
		/// <summary>
		/// Common Query for fetching the data from WellClient for mapping.
		/// </summary>
		
		public dtoWellClient WellScreenData(string client_id,string UWI)
		{
			string sql = "";
			   	sql = string.Format("Select [UWI],[SH_Loc],[Province],[Well_Name],[Status]" +
				                    ",[Substance],[Field],[Oper_CD],[ReportingToFacID],[DispositionFromFacID],[Licnsee_CD]," +
				                    "[Licnsee],[License_No],[Lic_AGT],[Lic_DT],[Spud_DT],[FIN_DRL_DT]," +
				                    "[Status_DT],[IN_Prod_DT],[Oper]" +
				                    "from WellClient WHERE client_id = '{0}' and UWI='{1}'",client_id,UWI);
			    
			    var dt  = dbData.RunQuery(sql);
			    dtoWellClient obj2 = new dtoWellClient();
			    if(dt !=null && dt.Rows.Count>0)
			    {
			    	obj2.DataIntegrity_WellData_txtUWI = dt.Rows[0]["UWI"].ToString();
				    obj2.DataIntegrity_WellData_txtSurfaceLocationBlank=dt.Rows[0]["SH_Loc"].ToString();
					obj2.DataIntegrity_WellData_txtProvince=dt.Rows[0]["Province"].ToString();
			 		obj2.DataIntegrity_WellData_txtWellName=dt.Rows[0]["Well_Name"].ToString();
			 		obj2.Dataintegrity_WellData_txtStatus=dt.Rows[0]["Status"].ToString();
			 		obj2.DataIntegrity_WellData_txtWellSubstance=dt.Rows[0]["Substance"].ToString();
			 	//	obj2.DataIntegrity_WellData_txtDistrict=dt.Rows[0]["Field"].ToString();
			 	//	obj2.DataIntegrity_WellData_txtArea=dt.Rows[0]["Oper_CD"].ToString();
					obj2.DataIntegrity_WellData_txtField=dt.Rows[0]["Field"].ToString();
					obj2.DataIntegrity_WellData_txtOperatorCode=dt.Rows[0]["Oper_CD"].ToString();
					obj2.DataIntegrity_WellData_txtReportingTo=dt.Rows[0]["ReportingToFacID"].ToString();
					obj2.DataIntegrity_WellData_txtDispositionFrom=dt.Rows[0]["DispositionFromFacID"].ToString();
					obj2.DataIntegrity_WellData_txtLicenseeCode=dt.Rows[0]["Licnsee_CD"].ToString();
					obj2.DataIntegrity_WellData_txtLicensee=dt.Rows[0]["Licnsee"].ToString();
					obj2.DataIntegrity_WellData_txtLicenseNo=dt.Rows[0]["License_No"].ToString();
					obj2.DataIntegrity_WellData_txtLicAGT=dt.Rows[0]["Lic_AGT"].ToString();
				//	obj2.DataIntegrity_WellData_txtPublicField=dt.Rows[0]["Power"].ToString();
					obj2.DataIntegrity_WellData_txtLicenseDate=dt.Rows[0]["Lic_DT"].ToString();
					obj2.DataIntegrity_WellData_txtSpudDate=dt.Rows[0]["Spud_DT"].ToString();
					obj2.DataIntegrity_WellData_txtFinalDrillDate=dt.Rows[0]["FIN_DRL_DT"].ToString();
					obj2.DataIntegrity_WellData_txtStatusDate=dt.Rows[0]["Status_DT"].ToString();
					obj2.DataIntegrity_WellData_txtIN_Prod_DT=dt.Rows[0]["IN_Prod_DT"].ToString();
				//	obj2.DataIntegrity_WellData_txtPublicWellStatus=dt.Rows[0]["Permit_EXPT"].ToString();			   
					obj2.DataIntegrity_WellData_txtOperator=dt.Rows[0]["Oper"].ToString();
			    }
					return obj2;
		

		}
		
		
		/// <summary>
		/// Common Query for fetching the data from PipelineClient for mapping.
		/// </summary>
		
		public dtoPipelineClient PipelineScreenData(string client_id,string License,string line,string segment)
		{
			string sql = "";
			   	sql = string.Format("Select [Province],[Status],[Subst_A],[Mat]" +
				                    ",[Field],[Oper_CD],[Oper],[Lic_CD],[Licensee],[From_Loc]," +
				                    "[From_FC],[To_Loc],[To_FC],[ORIG_LIC],[ORIG_LINE],[ORIG_OWNER]," +
				                    "[Length],[CalculatedSegmentLength],[Diameter],[Wall_Thick],[Year_Built]," +
				                    "[Design_Pressure],[Test_Pressure],[Max_Operat],[Enviro],[Joint],[Int_Pro]," +
				                    "[Ex_Coat],[Stress_Lvl],[Lic_APR],[Permit_APR],[Permit_EXP],[Construction_Start_Date]," +
				                    "[Construction_End_Date],[Last_CHG]" +
				                    "from PipelineClient WHERE client_id = '{0}' and License='{1}' and line='{2}' and segment='{3}'",client_id,License,line,segment);
			    
			    var dt  = dbData.RunQuery(sql);
			    dtoPipelineClient obj2 = new dtoPipelineClient();
			    if(dt !=null && dt.Rows.Count>0)
			    {
			    //	obj2.DataIntegrity_PipelineData_txtLicenseLine  = dt.Rows[0]["License"].ToString();
				    obj2.DataIntegrity_PipelineData_txtProvince =dt.Rows[0]["Province"].ToString();
					obj2.DataIntegrity_PipelineData_txtStatus =dt.Rows[0]["Status"].ToString();
			 		obj2.DataIntegrity_PipelineData_txtSubstance =dt.Rows[0]["Subst_A"].ToString();
			 		obj2.DataIntegrity_PipelineData_txtMaterial =dt.Rows[0]["Mat"].ToString();
			 		obj2.DataIntegrity_PipelineData_txtField =dt.Rows[0]["Field"].ToString();
			 	//	obj2.DataIntegrity_PipelineData_txtNEB =dt.Rows[0]["Field"].ToString();
			 	//	obj2.DataIntegrity_PipelineData_txtAlias =dt.Rows[0]["Oper_CD"].ToString();
				//	obj2.DataIntegrity_PipelineData_txtOperatorRun =dt.Rows[0]["Field"].ToString();
					obj2.DataIntegrity_PipelineData_txtOperatorCode =dt.Rows[0]["Oper_CD"].ToString();
					obj2.DataIntegrity_PipelineData_txtOperator =dt.Rows[0]["Oper"].ToString();
					obj2.DataIntegrity_PipelineData_txtLicCD =dt.Rows[0]["Lic_CD"].ToString();
					obj2.DataIntegrity_PipelineData_txtLicensee =dt.Rows[0]["Licensee"].ToString();
					obj2.DataIntegrity_PipelineData_txtFromLocation =dt.Rows[0]["From_Loc"].ToString();
					obj2.DataIntegrity_PipelineData_FromType =dt.Rows[0]["From_FC"].ToString();
					obj2.DataIntegrity_PipelineData_txtToLocation =dt.Rows[0]["To_Loc"].ToString();
					obj2.DataIntegrity_PipelineData_ToType =dt.Rows[0]["To_FC"].ToString();
					obj2.DataIntegrity_PipelineData_txtORIGLIC =dt.Rows[0]["ORIG_LIC"].ToString();
					obj2.DataIntegrity_PipelineData_txtORIGLINE =dt.Rows[0]["ORIG_LINE"].ToString();
					obj2.DataIntegrit_PipelineData_txtOwner =dt.Rows[0]["ORIG_OWNER"].ToString();
					obj2.DataIntegrity_PipelineData_txtLength =dt.Rows[0]["Length"].ToString();
				//	obj2.DataIntegrity_PipelineData_txtCalLength =dt.Rows[0]["IN_Prod_DT"].ToString();
					obj2.DataIntegrity_PipelineData_txtSegmentLength =dt.Rows[0]["CalculatedSegmentLength"].ToString();			   
					obj2.DataIntegrity_PipelineData_txtDiameter =dt.Rows[0]["Diameter"].ToString();
					obj2.DataIntegrity_PipelineData_txtWallThickness =dt.Rows[0]["Wall_Thick"].ToString();
					obj2.DataIntegrity_PipelineData_txtYearBuilt =dt.Rows[0]["Year_Built"].ToString();
					obj2.DataIntegrity_PipelineData_txtDesignPressure =dt.Rows[0]["Design_Pressure"].ToString();
					obj2.DataIntegrity_PipelineData_txtTestPressure =dt.Rows[0]["Test_Pressure"].ToString();
					obj2.DataIntegrity_PipelineData_txtMaxOpPress =dt.Rows[0]["Max_Operat"].ToString();
					obj2.DataIntegrity_PipelineData_ddlEnviro =dt.Rows[0]["Enviro"].ToString();
					obj2.DataIntegrity_PipelineData_ddlJoinType =dt.Rows[0]["Joint"].ToString();			   
					obj2.DataIntegrity_PipelineData_ddlInterProtect =dt.Rows[0]["Int_Pro"].ToString();
					obj2.DataIntegrity_PipelineData_ddlExtCoating =dt.Rows[0]["Ex_Coat"].ToString();
					obj2.DataIntegrity_PipelineData_txtStress_Lvl =dt.Rows[0]["Stress_Lvl"].ToString();
					obj2.DataIntegrity_PipelineData_txtLicAPR =dt.Rows[0]["Lic_APR"].ToString();
					obj2.DataIntegrity_PipelineData_txrPermitAPR =dt.Rows[0]["Permit_APR"].ToString();
					obj2.DataIntegrity_PipelineData_txtPermitEXP =dt.Rows[0]["Permit_EXP"].ToString();
					obj2.DataIntegrity_PipelineData_txtConsStartDate =dt.Rows[0]["Construction_Start_Date"].ToString();
					obj2.DataIntegrity_PipelineData_txtConsEndDate =dt.Rows[0]["Construction_End_Date"].ToString();
					obj2.DataIntegrity_PipelineData_txtLastCHG =dt.Rows[0]["Last_CHG"].ToString();
				//	obj2.DataIntegrity_PipelineData_ddlPiggable =dt.Rows[0]["Licnsee"].ToString();
				//	obj2.DataIntegrity_PipelineData_txtLinerInstallationYear =dt.Rows[0]["Licnsee"].ToString();
				//	obj2.DataIntegrity_PipelineData_ddlAdjacent =dt.Rows[0]["DispositionFromFacID"].ToString();
				//	obj2.DataIntegrity_PipelineData_ddlEPZZone =dt.Rows[0]["Licnsee_CD"].ToString();
				//	obj2.DataIntegrity_PipelineData_ddlEPZCategory =dt.Rows[0]["Licnsee"].ToString();
			    }
					return obj2;
		

		}
				
		
		
	}
}
