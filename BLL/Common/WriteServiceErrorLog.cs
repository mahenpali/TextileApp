using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TextileAppModel;
using Common;
namespace BLL
{
    public class WriteServiceErrorLog
    {
        public static T_ErrorDesc GetErrorLog(DataBaseResultSet DBSet,DataSourceTypes DST,string sXmlData)
        {
            T_ErrorDesc objData = new T_ErrorDesc();
            objData.CategoryId      = 0;
            objData.ClientIPAddress = string.Empty;
            objData.EmpNo           = string.Empty;
            objData.ErrorData       = sXmlData;
            objData.ErrorDate       = DateTime.Now;
            objData.ErrorId         = DBSet.ErrorCode;
            objData.ErrorLineNo     = 0;
            objData.ErrorMsg        = DBSet.ErrorMessage;
            objData.ErrorType       = "Database Error";
            objData.EventCode       = 0;
            objData.MethodCode      = (int)DST;
            objData.MethodName      = DST.ToString();
            objData.MethodTrace     = string.Empty;
            objData.PageCode        = 0;
            objData.PageName        = string.Empty;

            return objData;
        }
    }
}
