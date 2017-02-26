 using System;                        
 using System.Collections.Generic;    
 using System.Linq;                   
 using System.Text;                   
 using System.Data.Common;            
 using System.Data;                   
 using Common;
using TextileAppModel;                      
                                
namespace DAL
{    
     public partial class DataAccessHelper
     {    
            public void GetListT_MstCompany<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstCompany";
                T_MstCompany objData = objFilter as T_MstCompany;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 8, GenericDataType.Long, ParameterDirection.Input, objData.CompanyId));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }

            public void GetListT_MstCompanyForDropDown<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstCompanyDropDown";
                T_MstCompany objData = objFilter as T_MstCompany;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 4, GenericDataType.Int, ParameterDirection.Input, objData.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("FinancialYearId", "FinancialYearId", 4, GenericDataType.Int, ParameterDirection.Input, objData.FinancialYearId));
                SqlConnManager.GetList<T>(sQuery, CommandType.StoredProcedure, list.ToArray(), FillMstCompanyDropDownDataFromReader, ref  listData);
            }

            private void FillMstCompanyDropDownDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
            {
                while (DbReader.Read())
                {
                    T obj = new T();
                    T_MstCompany objData = obj as T_MstCompany;

                    objData.CompanyId = Convert.ToInt64(DbReader["CompanyId"]);
                    objData.CompanyName = DbReader["CompanyName"].ToString();
                    objData.FinancialYearId = Convert.ToInt32(DbReader["FinancialYearId"]);

                    listData.Add(obj);
                }
            } 
                        
            public DataBaseResultSet SaveT_MstCompany<T>(T objData) where T : class, IModel, new()
            {
                T_MstCompany obj = objData as T_MstCompany;
                string sQuery = "sprocT_MstCompanyInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("CompanyId", "CompanyId", 8, GenericDataType.Long, ParameterDirection.Input, obj.CompanyId));
                list.Add(SqlConnManager.GetConnParameters("FinancialYearId", "FinancialYearId", 4, GenericDataType.Int, ParameterDirection.Input, obj.FinancialYearId));
                list.Add(SqlConnManager.GetConnParameters("CompanyName", "CompanyName", 100, GenericDataType.String, ParameterDirection.Input, obj.CompanyName));
                list.Add(SqlConnManager.GetConnParameters("Add1", "Add1", 100, GenericDataType.String, ParameterDirection.Input, obj.Add1));
                list.Add(SqlConnManager.GetConnParameters("Add2", "Add2", 100, GenericDataType.String, ParameterDirection.Input, obj.Add2));
                list.Add(SqlConnManager.GetConnParameters("Place", "Place", 50, GenericDataType.String, ParameterDirection.Input, obj.Place));
                list.Add(SqlConnManager.GetConnParameters("PhoneNo", "PhoneNo", 50, GenericDataType.String, ParameterDirection.Input, obj.PhoneNo));
                list.Add(SqlConnManager.GetConnParameters("PhoneNo1", "PhoneNo1", 50, GenericDataType.String, ParameterDirection.Input, obj.PhoneNo1));
                list.Add(SqlConnManager.GetConnParameters("MobileNo", "MobileNo", 50, GenericDataType.String, ParameterDirection.Input, obj.MobileNo));
                list.Add(SqlConnManager.GetConnParameters("PanNo", "PanNo", 15, GenericDataType.String, ParameterDirection.Input, obj.PanNo));
                list.Add(SqlConnManager.GetConnParameters("ECCNo", "ECCNo", 50, GenericDataType.String, ParameterDirection.Input, obj.ECCNo));
                list.Add(SqlConnManager.GetConnParameters("TdsNo", "TdsNo", 50, GenericDataType.String, ParameterDirection.Input, obj.TdsNo));
                list.Add(SqlConnManager.GetConnParameters("AccountNo", "AccountNo", 50, GenericDataType.String, ParameterDirection.Input, obj.AccountNo));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 8, GenericDataType.DateTime, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("PrimKeyId", "PrimKeyId", 4, GenericDataType.Int, ParameterDirection.Input, obj.PrimKeyTableId));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    

