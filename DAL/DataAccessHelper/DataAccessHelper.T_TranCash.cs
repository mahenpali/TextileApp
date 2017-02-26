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
            public void GetListT_TranCash<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_TranCash";
                T_TranCash objData = objFilter as T_TranCash;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranBankId", "TranBankId", 8, GenericDataType.Long, ParameterDirection.Input, objData.TranBankId));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Long, ParameterDirection.Input, objData.CompanyId));
                SqlConnManager.GetList<T>(sQuery, CommandType.StoredProcedure, list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_TranCash<T>(T objData) where T : class, IModel, new()
            {
                T_TranCash obj = objData as T_TranCash;
                string sQuery = "sprocT_TranCashInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranBankId", "TranBankId", 8, GenericDataType.Long, ParameterDirection.Input, obj.TranBankId));
                list.Add(SqlConnManager.GetConnParameters("VoucherNo", "VoucherNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.VoucherNo));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("AmountType", "AmountType", 10, GenericDataType.String, ParameterDirection.Input, obj.AmountType));
                list.Add(SqlConnManager.GetConnParameters("VoucherDate", "VoucherDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.VoucherDate));
                list.Add(SqlConnManager.GetConnParameters("ChequeNo", "ChequeNo", 50, GenericDataType.String, ParameterDirection.Input, obj.ChequeNo));
                list.Add(SqlConnManager.GetConnParameters("BankId", "BankId", 8, GenericDataType.Long, ParameterDirection.Input, obj.BankId));
                list.Add(SqlConnManager.GetConnParameters("PartyId", "PartyId", 8, GenericDataType.Long, ParameterDirection.Input, obj.PartyId));
                list.Add(SqlConnManager.GetConnParameters("NoOfDay", "NoOfDay", 4, GenericDataType.Int, ParameterDirection.Input, obj.NoOfDay));
                list.Add(SqlConnManager.GetConnParameters("Place", "Place", 50, GenericDataType.String, ParameterDirection.Input, obj.Place));
                list.Add(SqlConnManager.GetConnParameters("BankName", "BankName", 100, GenericDataType.String, ParameterDirection.Input, obj.BankName));
                list.Add(SqlConnManager.GetConnParameters("Description", "Description", 500, GenericDataType.String, ParameterDirection.Input, obj.Description));
                list.Add(SqlConnManager.GetConnParameters("Amount", "Amount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Amount));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
