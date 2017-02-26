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
            public void GetListT_MstQuality<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstQuality";
                T_MstQuality objData = objFilter as T_MstQuality;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("QualityCode", "QualityCode", 4, GenericDataType.Int, ParameterDirection.Input, objData.QualityCode));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Long, ParameterDirection.Input, objData.CompanyId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_MstQuality<T>(T objData) where T : class, IModel, new()
            {
                T_MstQuality obj = objData as T_MstQuality;
                string sQuery = "sprocT_MstQualityInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("QualityCode", "QualityCode", 4, GenericDataType.Int, ParameterDirection.Input, obj.QualityCode));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("QualityName", "QualityName", 100, GenericDataType.String, ParameterDirection.Input, obj.QualityName));
                list.Add(SqlConnManager.GetConnParameters("OpeningStockMtrs", "OpeningStockMtrs", 4, GenericDataType.Int, ParameterDirection.Input, obj.OpeningStockMtrs));
                list.Add(SqlConnManager.GetConnParameters("OpeningStockTaga", "OpeningStockTaga", 4, GenericDataType.Int, ParameterDirection.Input, obj.OpeningStockTaga));
                list.Add(SqlConnManager.GetConnParameters("OpeningStockBales", "OpeningStockBales", 4, GenericDataType.Int, ParameterDirection.Input, obj.OpeningStockBales));
                list.Add(SqlConnManager.GetConnParameters("Commodity", "Commodity", 200, GenericDataType.String, ParameterDirection.Input, obj.Commodity));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("PrimKeyId", "PrimKeyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.PrimKeyTableId));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
