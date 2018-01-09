/*
 * Created by Ranorex
 * User: ykhan
 * Date: 6/19/2017
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
	/// Description of PrivateFacilityMapping.
	/// </summary>
	public class dtoWellClient
	{
	public string DataIntegrity_WellData_txtUWI { get; set; }
	public string DataIntegrity_WellData_txtSurfaceLocationBlank{ get; set; }
	public string DataIntegrity_WellData_txtProvince{ get; set; }
	public string DataIntegrity_WellData_txtWellName{ get; set; }
	public string Dataintegrity_WellData_txtStatus{ get; set; }
	public string DataIntegrity_WellData_txtWellSubstance{ get; set; }
//	public string DataIntegrity_WellData_txtDistrict{ get; set; }
//	public string DataIntegrity_WellData_txtArea{ get; set; }
	public string DataIntegrity_WellData_txtField{ get; set; }
	public string DataIntegrity_WellData_txtOperatorCode{ get; set; }
	public string DataIntegrity_WellData_txtOperator{ get; set; }
	public string DataIntegrity_WellData_txtReportingTo{ get; set; }
	public string DataIntegrity_WellData_txtDispositionFrom{ get; set; }
	public string DataIntegrity_WellData_txtLicenseeCode{ get; set; }
	public string DataIntegrity_WellData_txtLicensee { get; set; }
	public string DataIntegrity_WellData_txtLicenseNo { get; set; }
	public string DataIntegrity_WellData_txtLicAGT { get; set; }
//	public string DataIntegrity_WellData_txtPublicField { get; set; }
	public string DataIntegrity_WellData_txtLicenseDate { get; set; }
	public string DataIntegrity_WellData_txtSpudDate { get; set; }
	public string DataIntegrity_WellData_txtFinalDrillDate { get; set; }
	public string DataIntegrity_WellData_txtStatusDate { get; set; }
	public string DataIntegrity_WellData_txtIN_Prod_DT { get; set; }
//	public string DataIntegrity_WellData_txtPublicWellStatus{ get; set; }
	}

	
}