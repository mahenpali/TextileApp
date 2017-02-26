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
            public void GetListT_ErrorDesc<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_ErrorDesc";
                T_ErrorDesc objData = objFilter as T_ErrorDesc;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("ErrorId", "ErrorId", 8, GenericDataType.Long, ParameterDirection.Input, objData.ErrorId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_ErrorDesc<T>(T objData) where T : class, IModel, new()
            {
                T_ErrorDesc obj = objData as T_ErrorDesc;
                string sQuery = "sprocT_ErrorDescInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("ErrorId", "ErrorId", 8, GenericDataType.Long, ParameterDirection.Input, obj.ErrorId));
                list.Add(SqlConnManager.GetConnParameters("CategoryId", "CategoryId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CategoryId));
                list.Add(SqlConnManager.GetConnParameters("PageCode", "PageCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.PageCode));
                list.Add(SqlConnManager.GetConnParameters("MethodCode", "MethodCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.MethodCode));
                list.Add(SqlConnManager.GetConnParameters("EventCode", "EventCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.EventCode));
                list.Add(SqlConnManager.GetConnParameters("ErrorLineNo", "ErrorLineNo", 4, GenericDataType.Int, ParameterDirection.Input, obj.ErrorLineNo));
                list.Add(SqlConnManager.GetConnParameters("MethodTrace", "MethodTrace", 100, GenericDataType.String, ParameterDirection.Input, obj.MethodTrace));
                list.Add(SqlConnManager.GetConnParameters("EmpNo", "EmpNo", 10, GenericDataType.String, ParameterDirection.Input, obj.EmpNo));
                list.Add(SqlConnManager.GetConnParameters("ClientIPAddress", "ClientIPAddress", 30, GenericDataType.String, ParameterDirection.Input, obj.ClientIPAddress));
                list.Add(SqlConnManager.GetConnParameters("PageName", "PageName", 50, GenericDataType.String, ParameterDirection.Input, obj.PageName));
                list.Add(SqlConnManager.GetConnParameters("MethodName", "MethodName", 50, GenericDataType.String, ParameterDirection.Input, obj.MethodName));
                list.Add(SqlConnManager.GetConnParameters("ErrorMsg", "ErrorMsg", 500, GenericDataType.String, ParameterDirection.Input, obj.ErrorMsg));
                list.Add(SqlConnManager.GetConnParameters("ErrorType", "ErrorType", 50, GenericDataType.String, ParameterDirection.Input, obj.ErrorType));
                list.Add(SqlConnManager.GetConnParameters("ErrorDate", "ErrorDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.ErrorDate));
                list.Add(SqlConnManager.GetConnParameters("ErrorData", "ErrorData", -1, GenericDataType.String, ParameterDirection.Input, obj.ErrorData));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
