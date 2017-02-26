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
            public void GetListT_MstFinancialYear<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstFinancialYear";
                T_MstFinancialYear objData = objFilter as T_MstFinancialYear;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("FinancialYearId", "FinancialYearId", 4, GenericDataType.Int, ParameterDirection.Input, objData.FinancialYearId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_MstFinancialYear<T>(T objData) where T : class, IModel, new()
            {
                T_MstFinancialYear obj = objData as T_MstFinancialYear;
                string sQuery = "sprocT_MstFinancialYearInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("FinancialYearId", "FinancialYearId", 4, GenericDataType.Int, ParameterDirection.Input, obj.FinancialYearId));
                list.Add(SqlConnManager.GetConnParameters("FinancialYear", "FinancialYear", 50, GenericDataType.String, ParameterDirection.Input, obj.FinancialYear));
                list.Add(SqlConnManager.GetConnParameters("StartDate", "StartDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.StartDate));
                list.Add(SqlConnManager.GetConnParameters("EndDate", "EndDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.EndDate));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
