/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/9/2017
 * Time: 3:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
namespace IntegrityService.Database.Operations
{
	/// <summary>
	/// Description of Well.
	/// </summary>
	public class WellDB
	{
		DBHelper dbData = null;
		public WellDB()
		{
			dbData = new DBHelper();
		}
		
		public DataTable WellClientData(string clientID)
		{
			string sql =string.Format("Select NewID, UWI Where Client_ID = {0}",clientID);
			var dt  = dbData.RunQuery(sql);
			return dt;
		}
	}
}
