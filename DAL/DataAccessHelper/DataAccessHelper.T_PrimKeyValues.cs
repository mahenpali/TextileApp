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
        public void GetListT_PrimKeyValues<T>(T objFilter, ref List<T> listData) where T : class, IModel, new()
        {
            string sQuery = "GetListT_PrimKeyValues";
            T_PrimKeyValues objData = objFilter as T_PrimKeyValues;
            List<DbParameter> list = new List<DbParameter>();
            list.Add(SqlConnManager.GetConnParameters("PrimKeyId", "PrimKeyId", 4, GenericDataType.Int, ParameterDirection.Input, objData.PrimKeyTable));
            SqlConnManager.GetList<T>(sQuery, CommandType.StoredProcedure, list.ToArray(), FillDataFromReader, ref  listData);
        }        
    }    
}
