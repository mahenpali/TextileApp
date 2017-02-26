 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
    
namespace TextileAppModel
{
    public class T_ErrorDesc : IModel
    {
        public long ErrorId { get; set; }
        public int CategoryId { get; set; }
        public int PageCode { get; set; }
        public int MethodCode { get; set; }
        public int EventCode { get; set; }
        public int ErrorLineNo { get; set; }
        public string MethodTrace { get; set; }
        public string EmpNo { get; set; }
        public string ClientIPAddress { get; set; }
        public string PageName { get; set; }
        public string MethodName { get; set; }
        public string ErrorMsg { get; set; }
        public string ErrorType { get; set; }
        public DateTime ErrorDate { get; set; }
        public string ErrorData { get; set; }
        public DataBaseOperation OperationFlag { get; set; }

        #region IViewDetail Members
        public void FillDataFromDB(IDataRecord DBReader)
        {
            this.ErrorId = DBReader.GetInt64(DBReader.GetOrdinal("ErrorId"));
            this.CategoryId = DBReader.GetInt32(DBReader.GetOrdinal("CategoryId"));
            this.PageCode = DBReader.GetInt32(DBReader.GetOrdinal("PageCode"));
            this.MethodCode = DBReader.GetInt32(DBReader.GetOrdinal("MethodCode"));
            this.EventCode = DBReader.GetInt32(DBReader.GetOrdinal("EventCode"));
            this.ErrorLineNo = DBReader.GetInt32(DBReader.GetOrdinal("ErrorLineNo"));
            this.MethodTrace = DBReader.GetString(DBReader.GetOrdinal("MethodTrace"));
            this.EmpNo = DBReader.GetString(DBReader.GetOrdinal("EmpNo"));
            this.ClientIPAddress = DBReader.GetString(DBReader.GetOrdinal("ClientIPAddress"));
            this.PageName = DBReader.GetString(DBReader.GetOrdinal("PageName"));
            this.MethodName = DBReader.GetString(DBReader.GetOrdinal("MethodName"));
            this.ErrorMsg = DBReader.GetString(DBReader.GetOrdinal("ErrorMsg"));
            this.ErrorType = DBReader.GetString(DBReader.GetOrdinal("ErrorType"));
            this.ErrorDate = DBReader.GetDateTime(DBReader.GetOrdinal("ErrorDate"));
            this.ErrorData = DBReader.GetString(DBReader.GetOrdinal("ErrorData"));
        }
        #endregion

        public string GetXmlString()
        {
            StringBuilder sXml = new StringBuilder();
            sXml.Append("<data>");
            sXml.Append("<ErrorId>" + this.ErrorId + "</ErrorId>");
            sXml.Append("<CategoryId>" + this.CategoryId + "</CategoryId>");
            sXml.Append("<PageCode>" + this.PageCode + "</PageCode>");
            sXml.Append("<MethodCode>" + this.MethodCode + "</MethodCode>");
            sXml.Append("<EventCode>" + this.EventCode + "</EventCode>");
            sXml.Append("<ErrorLineNo>" + this.ErrorLineNo + "</ErrorLineNo>");
            sXml.Append("<MethodTrace>" + this.MethodTrace + "</MethodTrace>");
            sXml.Append("<EmpNo>" + this.EmpNo + "</EmpNo>");
            sXml.Append("<ClientIPAddress>" + this.ClientIPAddress + "</ClientIPAddress>");
            sXml.Append("<PageName>" + this.PageName + "</PageName>");
            sXml.Append("<MethodName>" + this.MethodName + "</MethodName>");
            sXml.Append("<ErrorMsg>" + this.ErrorMsg + "</ErrorMsg>");
            sXml.Append("<ErrorType>" + this.ErrorType + "</ErrorType>");
            sXml.Append("<ErrorDate>" + this.ErrorDate + "</ErrorDate>");
            sXml.Append("<ErrorData>" + this.ErrorData + "</ErrorData>");
            sXml.Append("</data>");
            return sXml.ToString();
        }

        public void Clone<T>(T obj) where T : class, IModel
        {
            T_ErrorDesc objdata = obj as T_ErrorDesc;
            this.ErrorId = objdata.ErrorId;
            this.CategoryId = objdata.CategoryId;
            this.PageCode = objdata.PageCode;
            this.MethodCode = objdata.MethodCode;
            this.EventCode = objdata.EventCode;
            this.ErrorLineNo = objdata.ErrorLineNo;
            this.MethodTrace = objdata.MethodTrace;
            this.EmpNo = objdata.EmpNo;
            this.ClientIPAddress = objdata.ClientIPAddress;
            this.PageName = objdata.PageName;
            this.MethodName = objdata.MethodName;
            this.ErrorMsg = objdata.ErrorMsg;
            this.ErrorType = objdata.ErrorType;
            this.ErrorDate = objdata.ErrorDate;
            this.ErrorData = objdata.ErrorData;
        }

        public T Copy<T>() where T : class, IModel, new()
        {
            T obj = new T();
            T_ErrorDesc objdata = obj as T_ErrorDesc;
            objdata.ErrorId = this.ErrorId;
            objdata.CategoryId = this.CategoryId;
            objdata.PageCode = this.PageCode;
            objdata.MethodCode = this.MethodCode;
            objdata.EventCode = this.EventCode;
            objdata.ErrorLineNo = this.ErrorLineNo;
            objdata.MethodTrace = this.MethodTrace;
            objdata.EmpNo = this.EmpNo;
            objdata.ClientIPAddress = this.ClientIPAddress;
            objdata.PageName = this.PageName;
            objdata.MethodName = this.MethodName;
            objdata.ErrorMsg = this.ErrorMsg;
            objdata.ErrorType = this.ErrorType;
            objdata.ErrorDate = this.ErrorDate;
            objdata.ErrorData = this.ErrorData;
            return obj;
        }

        public void ResetData()
        {
            this.ErrorId = 0;
            this.CategoryId = 0;
            this.PageCode = 0;
            this.MethodCode = 0;
            this.EventCode = 0;
            this.ErrorLineNo = 0;
            this.MethodTrace = string.Empty; ;
            this.EmpNo = string.Empty; ;
            this.ClientIPAddress = string.Empty; ;
            this.PageName = string.Empty; ;
            this.MethodName = string.Empty; ;
            this.ErrorMsg = string.Empty; ;
            this.ErrorType = string.Empty; ;
            this.ErrorDate = new DateTime();
            this.ErrorData = string.Empty; ;
        }

    }  
}
