/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/9/2017
 * Time: 2:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;
using System.Configuration;
namespace IntegrityService.Database
{
	/// <summary>
	/// Description of MyConnection.
	/// </summary>
	public class Connection
	{
		public SqlConnection conn = null;
		private string server =  ConfigurationManager.AppSettings["Server"]; 
		private string database = ConfigurationManager.AppSettings["Database"]; 
		private int port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]); 
		private string uid = ConfigurationManager.AppSettings["DBLogin"]; 
		private string password = ConfigurationManager.AppSettings["DBPassword"];
		public Connection()
		{
			 string connectionString =
			"Server="+ server +";" +
			"Database="+ database +";" +
		//	"Port="+ port +";" +
			"Uid="+ uid +";" +
			"Pwd="+ password;
			
			 conn = new SqlConnection(connectionString);
		}
	}
}
