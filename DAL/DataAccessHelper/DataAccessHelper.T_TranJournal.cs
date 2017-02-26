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
            public void GetListT_TranJournal<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_TranJournal";
                T_TranJournal objData = objFilter as T_TranJournal;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranJournalId", "TranJournalId", 8, GenericDataType.Long, ParameterDirection.Input, objData.TranJournalId));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Long, ParameterDirection.Input, objData.CompanyId));
                SqlConnManager.GetList<T>(sQuery, CommandType.StoredProcedure, list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_TranJournal<T>(T objData) where T : class, IModel, new()
            {
                T_TranJournal obj = objData as T_TranJournal;
                string sQuery = "sprocT_TranJournalInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("TranJournalId", "TranJournalId", 8, GenericDataType.Long, ParameterDirection.Input, obj.TranJournalId));
                list.Add(SqlConnManager.GetConnParameters("JournalNo", "JournalNo", 8, GenericDataType.Long, ParameterDirection.Input, obj.JournalNo));
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("AmountType", "AmountType", 10, GenericDataType.String, ParameterDirection.Input, obj.AmountType));
                list.Add(SqlConnManager.GetConnParameters("VoucherDate", "VoucherDate", 8, GenericDataType.DateTime, ParameterDirection.Input, obj.VoucherDate));
                list.Add(SqlConnManager.GetConnParameters("RefNo", "RefNo", 50, GenericDataType.String, ParameterDirection.Input, obj.RefNo));
                list.Add(SqlConnManager.GetConnParameters("DebitPartyId", "DebitPartyId", 8, GenericDataType.Long, ParameterDirection.Input, obj.DebitPartyId));
                list.Add(SqlConnManager.GetConnParameters("CreditPartyId", "CreditPartyId", 8, GenericDataType.Long, ParameterDirection.Input, obj.CreditPartyId));
                list.Add(SqlConnManager.GetConnParameters("DebitNarration", "DebitNarration", 500, GenericDataType.String, ParameterDirection.Input, obj.DebitNarration));
                list.Add(SqlConnManager.GetConnParameters("CreditNarration", "CreditNarration", 500, GenericDataType.String, ParameterDirection.Input, obj.CreditNarration));
                list.Add(SqlConnManager.GetConnParameters("Amount", "Amount", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Amount));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("PrimKeyId", "PrimKeyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.PrimKeyTableId));
                list.Add(SqlConnManager.GetConnParameters("Message", "Message", 300, GenericDataType.String, ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
