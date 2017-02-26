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
            public void GetListT_MstAccount<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstAccount";
                T_MstAccount objData = objFilter as T_MstAccount;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("", "", 0, GenericDataType.Int, ParameterDirection.Input, objData.AccountId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_MstAccount<T>(T objData) where T : class, IModel, new()
            {
                T_MstAccount obj = objData as T_MstAccount;
                string sQuery = "sprocT_MstAccountInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("AccountId", "AccountId", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountId));
                list.Add(SqlConnManager.GetConnParameters("AccountName", "AccountName", 200, GenericDataType.String, ParameterDirection.Input, obj.AccountName));
                list.Add(SqlConnManager.GetConnParameters("Password", "Password", 50, GenericDataType.String, ParameterDirection.Input, obj.Password));
                list.Add(SqlConnManager.GetConnParameters("RoleId", "RoleId", 4, GenericDataType.Int, ParameterDirection.Input, obj.RoleId));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
