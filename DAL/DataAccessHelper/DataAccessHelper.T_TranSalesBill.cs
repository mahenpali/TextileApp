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
            public void GetListT_TranSalesBill<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_TranSalesBill";
                T_TranSalesBill objData = objFilter as T_TranSalesBill;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranSalesBillId", "TranSalesBillId", 8, GenericDataType.Long, ParameterDirection.Input, objData.TranSalesBillId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_TranSalesBill<T>(T objData) where T : class, IModel, new()
            {
                T_TranSalesBill obj = objData as T_TranSalesBill;
                string sQuery = "sprocT_TranSalesBillInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranSalesBillId", "TranSalesBillId", 8, GenericDataType.Long, ParameterDirection.Input, obj.TranSalesBillId));
                list.Add(SqlConnManager.GetConnParameters("SalesBillNo", "SalesBillNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.SalesBillNo));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("VoucherDate", "VoucherDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.VoucherDate));
                list.Add(SqlConnManager.GetConnParameters("ToMSPartyId", "ToMSPartyId", 8, GenericDataType.Long, ParameterDirection.Input, obj.ToMSPartyId));
                list.Add(SqlConnManager.GetConnParameters("TransportId", "TransportId", 4, GenericDataType.Int, ParameterDirection.Input, obj.TransportId));
                list.Add(SqlConnManager.GetConnParameters("CheckerId", "CheckerId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CheckerId));
                list.Add(SqlConnManager.GetConnParameters("LRNo", "LRNo", 50, GenericDataType.String, ParameterDirection.Input, obj.LRNo));
                list.Add(SqlConnManager.GetConnParameters("LRDate", "LRDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.LRDate));
                list.Add(SqlConnManager.GetConnParameters("BrokerId", "BrokerId", 4, GenericDataType.Int, ParameterDirection.Input, obj.BrokerId));
                list.Add(SqlConnManager.GetConnParameters("Station", "Station", 50, GenericDataType.String, ParameterDirection.Input, obj.Station));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
