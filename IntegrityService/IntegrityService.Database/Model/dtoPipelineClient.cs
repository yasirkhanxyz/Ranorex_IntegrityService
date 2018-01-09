/*
 * Created by Ranorex
 * User: ykhan
 * Date: 7/12/2017
 * Time: 8:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using RanxForms = Ranorex.Form;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Controls;
using System.Diagnostics;

namespace IntegrityService.Database
{
	/// <summary>
	/// Description of PrivatePipelineMapping.
	/// </summary>
	public class dtoPipelineClient
	{
//	public string DataIntegrity_PipelineData_txtLicenseLine { get; set; }
	public string DataIntegrity_PipelineData_txtProvince { get; set; }
	public string DataIntegrity_PipelineData_txtStatus { get; set; }
	public string DataIntegrity_PipelineData_txtSubstance { get; set; }
	public string DataIntegrity_PipelineData_txtMaterial { get; set; }
	public string DataIntegrity_PipelineData_txtField { get; set; }
//	public string DataIntegrity_PipelineData_txtNEB { get; set; }
//	public string DataIntegrity_PipelineData_txtAlias { get; set; }
//	public string DataIntegrity_PipelineData_txtOperatorRun { get; set; }
	public string DataIntegrity_PipelineData_txtOperatorCode { get; set; }
	public string DataIntegrity_PipelineData_txtOperator { get; set; }
	public string DataIntegrity_PipelineData_txtLicCD { get; set; }
	public string DataIntegrity_PipelineData_txtLicensee { get; set; }
	public string DataIntegrity_PipelineData_txtFromLocation { get; set; }
	public string DataIntegrity_PipelineData_FromType { get; set; }
	public string DataIntegrity_PipelineData_txtToLocation { get; set; }
	public string DataIntegrity_PipelineData_ToType { get; set; }
	public string DataIntegrity_PipelineData_txtORIGLIC { get; set; }
	public string DataIntegrity_PipelineData_txtORIGLINE { get; set; }
	public string DataIntegrit_PipelineData_txtOwner { get; set; }
	public string DataIntegrity_PipelineData_txtLength { get; set; }
//	public string DataIntegrity_PipelineData_txtCalLength { get; set; }
	public string DataIntegrity_PipelineData_txtSegmentLength { get; set; }
	public string DataIntegrity_PipelineData_txtDiameter { get; set; }
	public string DataIntegrity_PipelineData_txtWallThickness { get; set; }
	public string DataIntegrity_PipelineData_txtYearBuilt { get; set; }
	public string DataIntegrity_PipelineData_txtDesignPressure { get; set; }
	public string DataIntegrity_PipelineData_txtTestPressure { get; set; }
	public string DataIntegrity_PipelineData_txtMaxOpPress { get; set; }
	public string DataIntegrity_PipelineData_ddlEnviro { get; set; }
	public string DataIntegrity_PipelineData_ddlJoinType { get; set; }
	public string DataIntegrity_PipelineData_ddlInterProtect { get; set; }
	public string DataIntegrity_PipelineData_ddlExtCoating { get; set; }
	public string DataIntegrity_PipelineData_txtStress_Lvl { get; set; }
	public string DataIntegrity_PipelineData_txtLicAPR { get; set; }
	public string DataIntegrity_PipelineData_txrPermitAPR { get; set; }
	public string DataIntegrity_PipelineData_txtPermitEXP { get; set; }
	public string DataIntegrity_PipelineData_txtConsStartDate { get; set; }
	public string DataIntegrity_PipelineData_txtConsEndDate { get; set; }
	public string DataIntegrity_PipelineData_txtLastCHG { get; set; }
//	public string DataIntegrity_PipelineData_ddlPiggable { get; set; }
//	public string DataIntegrity_PipelineData_txtLinerInstallationYear { get; set; }
//	public string DataIntegrity_PipelineData_ddlAdjacent { get; set; }
//	public string DataIntegrity_PipelineData_ddlEPZZone { get; set; }
//	public string DataIntegrity_PipelineData_ddlEPZCategory { get; set; }
	
	}

	
}