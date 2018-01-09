/*
 * Created by Ranorex
 * User: skawatra
 * Date: 5/6/2017
 * Time: 4:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Ranorex;

namespace IntegrityService.Database
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class DBHelper : Connection
	{
		private SqlCommand command = null;
		private SqlDataReader reader = null;
		public DBHelper()
		{
			if(conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
			command = conn.CreateCommand();
		}
		
		/// <summary>
		/// Returns a datatable containing the data the query retrieved.  Use this when you need data returned.
		/// </summary>
		/// <param name="SQL"></param>
		/// <returns></returns>
		public DataTable RunQuery(string SQL)
		{
			
			DataTable dt = new DataTable();
			try{
				if(conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				command.CommandText = SQL;
				reader = command.ExecuteReader();
				//load the sql reader into a databable - this allows the connection to the db to be closed while still
				//having access to the data that the query returned
				dt.Load(reader);
			}catch(Exception e){
				Console.WriteLine("Exception is SQLConnector::RunQuery - " + e.ToString());
				Report.Log(ReportLevel.Info, "Exception is SQLConnector::RunQuery - " + e.ToString());
			}finally{
				reader.Close();
				conn.Close();
			}
			return dt;
		}
		
		/// <summary>
		/// Returns the count of records found for a count query.  Example SELECT COUNT(*) FROM hdlogin.
		/// Use this when you just was a count and don't need any data returned.
		/// </summary>
		/// <param name="SQL"></param>
		/// <returns></returns>
		public int CountQuery(string SQL)
		{
			int count=0;
			try
			{
				command.CommandText = SQL;
				count = Convert.ToInt32(command.ExecuteScalar());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception is SQLConnector::CountQuery - " + e.ToString());
				Report.Log(ReportLevel.Info, "Exception is SQLConnector::CountQuery - " + e.ToString());
			}
			finally
			{
				conn.Close();
			}
			return count;
		}
		
		/// <summary>
		/// Returns the number of rows affected by the supplied query.  Use this if you need to run an UPDATE, DELETE or INSERT query.
		/// </summary>
		/// <param name="SQL"></param>
		/// <returns></returns>
		public int UpdateQuery(string SQL)
		{
			int rowsAffected=0;
			try
			{
				command.CommandText = SQL;
				rowsAffected = Convert.ToInt32(command.ExecuteNonQuery());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception is MySQLConnector::UpdateQuery - " + e.ToString());
			}
			finally
			{
				conn.Close();
			}
			return rowsAffected;
		}
		
		// Write DB DataTable details to report.
		public void writeDatatable(DataTable datatable)
		{
			for ( int i = 0; i < datatable.Rows.Count; i++)
			{
				for ( int c = 0; c < datatable.Columns.Count; c++)
				{
					Report.Log(ReportLevel.Info, "item ["+i+"]["+datatable.Columns[c]+"]: " + datatable.Rows[i][c]);
					//Console.WriteLine("item ["+i+"]["+c+"]: " + datatable.Rows[i][c]);
				}
			}
		}
	}
	
	
}