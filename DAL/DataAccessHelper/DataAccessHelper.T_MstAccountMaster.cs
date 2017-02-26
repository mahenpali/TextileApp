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
            public void GetListT_MstAccountMaster<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
            {
                string sQuery = "GetListT_MstAccountMaster";
                T_MstAccountMaster objData = objFilter as T_MstAccountMaster;
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, objData.AccountCode));
                SqlConnManager.GetList<T>(sQuery,CommandType.StoredProcedure,list.ToArray(), FillDataFromReader, ref  listData);
            }
            
            public DataBaseResultSet SaveT_MstAccountMaster<T>(T objData) where T : class, IModel, new()
            {
                T_MstAccountMaster obj = objData as T_MstAccountMaster;
                string sQuery = "sprocT_MstAccountMasterInsertUpdateSingleItem";
                List<DbParameter> list = new List<DbParameter>();
                list.Add(SqlConnManager.GetConnParameters("AccountCode", "AccountCode", 8, GenericDataType.Long, ParameterDirection.Input, obj.AccountCode));
                list.Add(SqlConnManager.GetConnParameters("AccountName", "AccountName", 100, GenericDataType.String, ParameterDirection.Input, obj.AccountName));
                list.Add(SqlConnManager.GetConnParameters("Address", "Address", 100, GenericDataType.String, ParameterDirection.Input, obj.Address));
                list.Add(SqlConnManager.GetConnParameters("Place", "Place", 100, GenericDataType.String, ParameterDirection.Input, obj.Place));
                list.Add(SqlConnManager.GetConnParameters("OpeningBalance", "OpeningBalance", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.OpeningBalance));
                list.Add(SqlConnManager.GetConnParameters("TypeDrCr", "TypeDrCr", 10, GenericDataType.String, ParameterDirection.Input, obj.TypeDrCr));
                list.Add(SqlConnManager.GetConnParameters("GroupId", "GroupId", 10, GenericDataType.String, ParameterDirection.Input, obj.GroupId));
                list.Add(SqlConnManager.GetConnParameters("GroupCode", "GroupCode", 20, GenericDataType.String, ParameterDirection.Input, obj.GroupCode));
                list.Add(SqlConnManager.GetConnParameters("PanCardNo", "PanCardNo", 10, GenericDataType.String, ParameterDirection.Input, obj.PanCardNo));
                list.Add(SqlConnManager.GetConnParameters("FCC", "FCC", 50, GenericDataType.String, ParameterDirection.Input, obj.FCC));
                list.Add(SqlConnManager.GetConnParameters("Range", "Range", 50, GenericDataType.String, ParameterDirection.Input, obj.Range));
                list.Add(SqlConnManager.GetConnParameters("DivI", "DivI", 50, GenericDataType.String, ParameterDirection.Input, obj.DivI));
                list.Add(SqlConnManager.GetConnParameters("CommI", "CommI", 50, GenericDataType.String, ParameterDirection.Input, obj.CommI));
                list.Add(SqlConnManager.GetConnParameters("BST", "BST", 50, GenericDataType.String, ParameterDirection.Input, obj.BST));
                list.Add(SqlConnManager.GetConnParameters("CST", "CST", 50, GenericDataType.String, ParameterDirection.Input, obj.CST));
                list.Add(SqlConnManager.GetConnParameters("Packing", "Packing", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Packing));
                list.Add(SqlConnManager.GetConnParameters("Checking", "Checking", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Checking));
                list.Add(SqlConnManager.GetConnParameters("Other", "Other", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Other));
                list.Add(SqlConnManager.GetConnParameters("Insurance", "Insurance", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.Insurance));
                list.Add(SqlConnManager.GetConnParameters("ADath", "ADath", 8, GenericDataType.Decimal, ParameterDirection.Input, obj.ADath));
                list.Add(SqlConnManager.GetConnParameters("LUT", "LUT", 10, GenericDataType.String, ParameterDirection.Input, DateTime.Now));
                list.Add(SqlConnManager.GetConnParameters("OperationFlag", "OperationFlag", 4, GenericDataType.Int          , ParameterDirection.Input, (short)obj.OperationFlag));
                list.Add(SqlConnManager.GetConnParameters("Message"      , "Message"      , 300, GenericDataType.String       , ParameterDirection.Output, null));
                list.Add(SqlConnManager.GetConnParameters("ErrorCode"      , "ErrorCode"      , 4, GenericDataType.Int       , ParameterDirection.Output, null));
                return SqlConnManager.Save(sQuery, CommandType.StoredProcedure, list.ToArray());
            }
     }    
}    
