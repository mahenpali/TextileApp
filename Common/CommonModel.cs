using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using TextileAppModel;

namespace TextileApp
{
    public class CommonModel
    {
        public const string ErrorMessage    = "Please contact system adminstrator.";
        public const string SaveMsg         = "Data Inserted Sucessfully.";
        public const string UpdateMsg       = "Data Updated Sucessfully.";
        public const string DeleteMsg       = "Data Deleted Sucessfully.";

        public static bool ShowDataBaseMsg = false;

        public static string GetOperationMessage<T>(DataBaseResultSet DBRS,T objData) where T : IModel, new()
        {
            if (ShowDataBaseMsg)
            {
                return DBRS.ErrorMessage;
            }
            else
            {
                if (DBRS.ErrorCode == 0)
                {
                    return (objData.OperationFlag == DataBaseOperation.Save) ? SaveMsg
                                    : ((objData.OperationFlag == DataBaseOperation.Update) ? UpdateMsg : DeleteMsg);                   
                }
                else
                {
                    return ErrorMessage;
                }
            }
            return string.Empty;
        }

        public static long GetPrimkeyValue(PrimKeyTables PrimKey)
        {
            long nPrimKeyValue = 0;
            List<T_PrimKeyValues> ListPrimKey = BLL.BllClient.objBllClient.GetList<T_PrimKeyValues>(Common.DataSourceTypes.T_PrimKeyValuesList, new T_PrimKeyValues() { PrimKeyTable = (short)PrimKey });
            if (ListPrimKey.Count > 0){
                nPrimKeyValue = ListPrimKey[0].PrimKeyValue;
            }
            return nPrimKeyValue;
        }
    }
}
