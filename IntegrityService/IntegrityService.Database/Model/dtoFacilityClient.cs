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
	public class dtoFacilityClient
	{
	public string DataIntegrity_FacilityData_txtFacID { get; set; }
	public string DataIntegrity_FacilityData_txtLocationBlank{ get; set; }
	public string DataIntegrity_FacilityData_txtProvince{ get; set; }
	public string DataIntegrity_FacilityData_txtFacilityName{ get; set; }
	public string Dataintegrity_FacilityData_txtStatus{ get; set; }
	public string Dataintegrity_FacilityData_txtFacType{ get; set; }
	public string Dataintegrity_FacilityData_txtDistrict{ get; set; }
	public string Dataintegrity_FacilityData_txtArea{ get; set; }
	public string Dataintegrity_FacilityData_txtField{ get; set; }
	public string DataIntegrity_FacilityData_txtOperatorCode{ get; set; }
	public string DataIntegrity_FacilityData_txtOperator{ get; set; }
	public string Dataintegrity_FacilityData_txtBattCD{ get; set; }
	public string Dataintegrity_FacilityData_txtBattType{ get; set; }
	public string DataIntegrity_FacilityData_txtLicenseeCode { get; set; }
	public string DataIntegrity_FacilityData_txtLicensee { get; set; }
	public string Dataintegrity_FacilityData_txtLicense { get; set; }
	public string DataIntegrity_FacilityData_H2S { get; set; }
	public string DataIntegrity_FacilityData_txtPublicFieldName { get; set; }
	public string DataIntegrity_FacilityData_txtPrimemover { get; set; }
	public string DataIntegrity_FacilityData_txtPower { get; set; }
	public string DataIntegrity_FacilityData_txtInstall_NO { get; set; }
	public string DataIntegrity_FacilityData_txtSource_ID { get; set; }
	public string DataIntegrity_FacilityData_Lic_APR { get; set; }
	public string DataIntegrity_FacilityData_Permit_APR { get; set; }
	public string DataIntegrity_FacilityData_Permit_EXP { get; set; }
	}

	
}