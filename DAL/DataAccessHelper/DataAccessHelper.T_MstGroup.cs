 using System;                        
 using System.Collections.Generic;    
 using System.Linq;                   
 using System.Text;                   
 using System.Data.Common;            
 using System.Data;                   
 using Common;                        
 using TextileAppModel;                      
 using System.Data.Common;              
 using System.Data;                     
                                
namespace DAL
{    
     public partial class DataAccessHelper
     {    
            public void GetListT_MstGroup<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstGroup";
                T_MstGroup objData = objFilter as T_MstGroup;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("GroupId", "GroupId", 4, GenericDataType.Int, ParameterDirection.Input, objData.GroupId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_MstGroup<T>(T objData) where T : class, IModel, new()
            {
                T_MstGroup obj = objData as T_MstGroup;
                string sQuery = "sprocT_MstGroupInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("GroupId", "GroupId", 4, GenericDataType.Int, ParameterDirection.Input, obj.GroupId));
                list.Add(SqlConnManager.GetConnParameters("GroupCode", "GroupCode", 10, GenericDataType.String, ParameterDirection.Input, obj.GroupCode));
                list.Add(SqlConnManager.GetConnParameters("Description", "Description", 200, GenericDataType.String, ParameterDirection.Input, obj.Description));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
