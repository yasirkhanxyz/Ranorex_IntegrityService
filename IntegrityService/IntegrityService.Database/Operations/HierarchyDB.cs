/*
 * Created by Ranorex
 * User: ykhan
 * Date: 5/23/2017
 * Time: 6:17 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IntegrityService.Database
{
	/// <summary>
	/// Description of Hierarchy.
	/// </summary>
	public class HierarchyDB
	{
		DBHelper dbData = null;
		public HierarchyDB()
		{
			dbData = new DBHelper();
		}

		
		/// <summary>
		/// Common Query for Pipeline to be counted on basis of Hierarchy.
		/// </summary>
		
		public int PipelineCount(string client_id,string type,string hName)
		{
			string sql = "";
			int count = 0;
			if(hName.ToLower() =="master")
			   {
			   	sql = string.Format("Select Count(*) from PipelineClient WHERE client_id = '{0}'",client_id);
			   }
			   else
			   {
			sql = string.Format(@"Declare @ID uniqueidentifier

								SELECT Top 1 @ID = ID from Hierarchy
								WHERE Client_ID = '{0}' and Name = '{1}' and Type = '{2}'
								
								 ;WITH ExplodedHierarchy AS
								 (
								 SELECT CAST(@ID AS UNIQUEIDENTIFIER) as ID, h.Hierarchy_ID as ParentID, h.Type as Type,h.Name as Name
								 From  dbo.Hierarchy h Where ID = @ID
								 UNION ALL
								 SELECT H1.ID, H1.Hierarchy_ID as ParentID, H1.Type as Type, H1.Name as Name
								 FROM dbo.Hierarchy H1
								 JOIN ExplodedHierarchy EH ON EH.ID=H1.Hierarchy_ID
								 )
								
								Select Count(*) 
								From PipelineClient pc
								INNER JOIN PipelineClientHierarchy pch  on pc.NewID = pch.PipelineClientID
								INNER JOIN ExplodedHierarchy eh ON pch.ID = eh.ID",client_id,hName,type);
			   }
			   
			    var dt  = dbData.RunQuery(sql);
			    if(dt !=null)
			    	count = Convert.ToInt32(dt.Rows[0][0]);
			    
				return count;
		}

		/// <summary>
		/// Common Query for Well to be counted on basis of Hierarchy.
		/// </summary>

		public int WellCount(string client_id,string type,string hName)
		{
			string sql = "";
			int count = 0;
			if(hName.ToLower() =="master")
			   {
			   	sql = string.Format("Select Count(*) from WellClient WHERE client_id = '{0}'",client_id);
			   }
			   else
			   {
			sql = string.Format(@"Declare @ID uniqueidentifier

								SELECT Top 1 @ID = ID from Hierarchy
								WHERE Client_ID = '{0}' and Name = '{1}' and Type = '{2}'
								
								 ;WITH ExplodedHierarchy AS
								 (
								 SELECT CAST(@ID AS UNIQUEIDENTIFIER) as ID, h.Hierarchy_ID as ParentID, h.Type as Type,h.Name as Name
								 From  dbo.Hierarchy h Where ID = @ID
								 UNION ALL
								 SELECT H1.ID, H1.Hierarchy_ID as ParentID, H1.Type as Type, H1.Name as Name
								 FROM dbo.Hierarchy H1
								 JOIN ExplodedHierarchy EH ON EH.ID=H1.Hierarchy_ID
								 )
								
								Select Count(*) 
								From WellclientClient Wc
								INNER JOIN wellClientHierarchy Wch  on Wc.NewID = Wch.WellClientID
								INNER JOIN ExplodedHierarchy eh ON Wch.ID = eh.ID",client_id,hName,type);
			   }
			   
			    var dt  = dbData.RunQuery(sql);
			    if(dt !=null)
			    	count = Convert.ToInt32(dt.Rows[0][0]);
			    
				return count;
		}
		
		/// <summary>
		/// Common Query for Facility to be counted on basis of Hierarchy.
		/// </summary>
		
		public int FacilityCount(string client_id,string type,string hName)
		{
			string sql = "";
			int count = 0;
			if(hName.ToLower() =="master")
			   {
			   	sql = string.Format("Select Count(*) from FacilityClient WHERE client_id = '{0}'",client_id);
			   }
			   else
			   {
			sql = string.Format(@"Declare @ID uniqueidentifier

								SELECT Top 1 @ID = ID from Hierarchy
								WHERE Client_ID = '{0}' and Name = '{1}' and Type = '{2}'
								
								 ;WITH ExplodedHierarchy AS
								 (
								 SELECT CAST(@ID AS UNIQUEIDENTIFIER) as ID, h.Hierarchy_ID as ParentID, h.Type as Type,h.Name as Name
								 From  dbo.Hierarchy h Where ID = @ID
								 UNION ALL
								 SELECT H1.ID, H1.Hierarchy_ID as ParentID, H1.Type as Type, H1.Name as Name
								 FROM dbo.Hierarchy H1
								 JOIN ExplodedHierarchy EH ON EH.ID=H1.Hierarchy_ID
								 )
								
								Select Count(*) 
								From FacilityClient Fc
								INNER JOIN FacilityClientHierarchy Fch  on pc.NewID = Fch.FacilityClientID
								INNER JOIN ExplodedHierarchy eh ON Fch.ID = eh.ID",client_id,hName,type);
			   }
			   
			    var dt  = dbData.RunQuery(sql);
			    if(dt !=null)
			    	count = Convert.ToInt32(dt.Rows[0][0]);
			    
				return count;
		}
		
		
		
		/// <summary>
		/// Common Query for Connection to be counted on basis of Hierarchy.
		/// </summary>
		
		public int ConnectionCount(string client_id,string type,string hName)
		{
			string sql = "";
			int count = 0;
			if(hName.ToLower() =="master")
			   {
			   	sql = string.Format("Select Count(*) from Connection WHERE client_id = '{0}'",client_id);
			   }
			   else
			   {
			sql = string.Format(@"Declare @ID uniqueidentifier

								SELECT Top 1 @ID = ID from Hierarchy
								WHERE Client_ID = '{0}' and Name = '{1}' and Type = '{2}'
								
								 ;WITH ExplodedHierarchy AS
								 (
								 SELECT CAST(@ID AS UNIQUEIDENTIFIER) as ID, h.Hierarchy_ID as ParentID, h.Type as Type,h.Name as Name
								 From  dbo.Hierarchy h Where ID = @ID
								 UNION ALL
								 SELECT H1.ID, H1.Hierarchy_ID as ParentID, H1.Type as Type, H1.Name as Name
								 FROM dbo.Hierarchy H1
								 JOIN ExplodedHierarchy EH ON EH.ID=H1.Hierarchy_ID
								 )
								FCH AS
  								(SELECT FCH.FacilityClientID FROM dbo.FacilityClientHierarchy FCH
								      JOIN ExplodedHierarchy EH ON EH.ID=FCH.Hierarchy_ID
								  ),
								--
								  PCH AS
								  (SELECT PCH.PipelineClientID FROM dbo.PipelineClientHierarchy PCH
								      JOIN ExplodedHierarchy EH ON EH.ID=PCH.Hierarchy_ID
								  ),
								--
								  WCH AS
								  (SELECT WCH.WellClientID FROM dbo.WellClientHierarchy WCH
								      JOIN ExplodedHierarchy EH ON EH.ID=WCH.Hierarchy_ID
								  )
								Select Count(*) 
								From Connection C
								 -- decreasing probability
      							LEFT JOIN PCH PCH2 ON C.To_Type  ='Pipeline' AND PCH2.PipelineClientID=C.ToID
      							LEFT JOIN PCH      ON C.From_Type='Pipeline' AND PCH.PipelineClientID =C.FromID AND PCH2.PipelineClientID IS NULL
      							LEFT JOIN FCH FCH2 ON C.To_Type  ='Facility' AND FCH2.FacilityClientID=C.ToID   AND PCH.PipelineClientID IS NULL
      							LEFT JOIN WCH WCH2 ON C.To_Type  ='Well'     AND WCH2.WellClientID    =C.ToID   AND PCH.PipelineClientID IS NULL
      							LEFT JOIN WCH      ON C.From_Type='Well'     AND WCH.WellClientID     =C.FromID AND PCH2.PipelineClientID IS NULL AND WCH2.WellClientID IS NULL
      							LEFT JOIN FCH      ON C.From_Type='Facility' AND FCH.FacilityClientID =C.FromID AND PCH2.PipelineClientID IS NULL AND WCH2.WellClientID IS NULL AND FCH2.FacilityClientID IS NULL
   								WHERE C.CLient_ID=@ClientID
    							AND COALESCE(PCH2.PipelineClientID, PCH.PipelineClientID, FCH2.FacilityClientID,
                 				WCH2.WellClientID, WCH.WellClientID, FCH.FacilityClientID) IS NOT NULL",client_id,hName,type);
			   }
			   
			    var dt  = dbData.RunQuery(sql);
			    if(dt !=null)
			    	count = Convert.ToInt32(dt.Rows[0][0]);
			    
				return count;
		}	

		
		public int MeasureCount(string client_id,string type,string hName)
		{
			string sql = "";
			int count = 0;
			if(hName.ToLower() =="master")
			   {
			   	sql = string.Format("Select Count(*) from diagram WHERE client_id = '{0}'",client_id);
			   }
			   else
			   {
			sql = string.Format(@"Declare @ID uniqueidentifier

								SELECT Top 1 @ID = ID from Hierarchy
								WHERE Client_ID = '{0}' and Name = '{1}' and Type = '{2}'
								
								 ;WITH ExplodedHierarchy AS
								 (
								 SELECT CAST(@ID AS UNIQUEIDENTIFIER) as ID, h.Hierarchy_ID as ParentID, h.Type as Type,h.Name as Name
								 From  dbo.Hierarchy h WHERE ID =@ID
								 UNION ALL
								 SELECT H1.ID, H1.Hierarchy_ID as ParentID, H1.Type as Type, H1.Name as Name
								 FROM dbo.Hierarchy H1
								 JOIN ExplodedHierarchy EH ON EH.ID=H1.Hierarchy_ID
								 )
								 								 															
		      					SELECT ISNULL(SUM(IIF(D.Type='MeasurementDiagram',1,0)),0) as MeasurementDiagram,
//		            			ISNULL(SUM(IIF(D.Type='StickDiagram',1,0)),0) as StickDiagram,
//		            			ISNULL(SUM(IIF(D.Type='GISMap',1,0)),0) as GISMap,
//		            			ISNULL(SUM(IIF(D.Type='FieldFlowSchematic',1,0)),0) as FieldFlowSchematic
		      					FROM dbo.Diagram D
		       					JOIN ExplodedHierarchy EH ON EH.ID=D.Hierarchy_ID",client_id,hName,type);
					   }
			   
			    var dt  = dbData.RunQuery(sql);
			    if(dt !=null)
			    	count = Convert.ToInt32(dt.Rows[0][0]);
			    
				return count;
		}	
	
	
	
	
	}
		
}
