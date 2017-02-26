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
            public void GetListT_MstBroker<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstBroker";
                T_MstBroker objData = objFilter as T_MstBroker;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("BrokerCode", "BrokerCode", 4, GenericDataType.Int, ParameterDirection.Input, objData.BrokerCode));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Long, ParameterDirection.Input, objData.CompanyId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_MstBroker<T>(T objData) where T : class, IModel, new()
            {
                T_MstBroker obj = objData as T_MstBroker;
                string sQuery = "sprocT_MstBrokerInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("BrokerCode", "BrokerCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.BrokerCode));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("BrokerName", "BrokerName", 100, GenericDataType.String, ParameterDirection.Input, obj.BrokerName));                
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("PrimKeyId", "PrimKeyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.PrimKeyTableId));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
