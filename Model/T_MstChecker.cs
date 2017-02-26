 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstChecker : IModel,INotifyPropertyChanged
    {

        public T_MstChecker()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.Checker;
        }

        private int     nCheckerCode;
        public int     CheckerCode
        {
            get { return nCheckerCode; }
            set
            {
                nCheckerCode = value;
                OnPropertyChanged("CheckerCode");
            }
        }
        private int     nCompanyId;
        public int     CompanyId
        {
            get { return nCompanyId; }
            set
            {
                nCompanyId = value;
                OnPropertyChanged("CompanyId");
            }
        }
        private string     sCheckerName;
        public string     CheckerName
        {
            get { return sCheckerName; }
            set
            {
                sCheckerName = value;
                OnPropertyChanged("CheckerName");
            }
        }
        private string     sMobileNo;
        public string     MobileNo
        {
            get { return sMobileNo; }
            set
            {
                sMobileNo = value;
                OnPropertyChanged("MobileNo");
            }
        }
        private string     sTelNo;
        public string     TelNo
        {
            get { return sTelNo; }
            set
            {
                sTelNo = value;
                OnPropertyChanged("TelNo");
            }
        }
        private DateTime     dtLUT;
        public DateTime     LUT
        {
            get { return dtLUT; }
            set
            {
                dtLUT = value;
                OnPropertyChanged("LUT");
            }
        }
        public DataBaseOperation OperationFlag { get; set; }
        public int PrimKeyTableId { get; set; }

        #region INotifyPropertyChanged Members
            /// <summary>
            /// Event to which the view's controls will subscribe.
            /// This will enable them to refresh themselves when the binded property changes provided you fire this event.
            /// </summary>
            public event PropertyChangedEventHandler PropertyChanged;
        
            /// <summary>
            /// When property is changed call this method to fire the PropertyChanged Event
            /// </summary>
            /// <param name="propertyName"></param>
            public void OnPropertyChanged(string propertyName)
            {
                //Fire the PropertyChanged event in case somebody subscribed to it
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        
        #endregion
    
        #region IViewDetail Members
            public void FillDataFromDB(IDataRecord DBReader)
            {
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CheckerCode"))){
                    this.CheckerCode = DBReader.GetInt32(DBReader.GetOrdinal("CheckerCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId"))){
                    this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CheckerName"))){
                    this.CheckerName = DBReader.GetString(DBReader.GetOrdinal("CheckerName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("MobileNo"))){
                    this.MobileNo = DBReader.GetString(DBReader.GetOrdinal("MobileNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TelNo"))){
                    this.TelNo = DBReader.GetString(DBReader.GetOrdinal("TelNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT"))){
                    this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
                }
            }
        #endregion
  
        public string GetXmlString()
        {  
            StringBuilder sXml = new StringBuilder();  
            sXml.Append("<data>");
            sXml.Append("<CheckerCode>" + this.CheckerCode + "</CheckerCode>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<CheckerName>" + this.CheckerName + "</CheckerName>");
            sXml.Append("<MobileNo>" + this.MobileNo + "</MobileNo>");
            sXml.Append("<TelNo>" + this.TelNo + "</TelNo>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstChecker objdata = obj as T_MstChecker;
            this.CheckerCode = objdata.CheckerCode;
            this.CompanyId = objdata.CompanyId;
            this.CheckerName = objdata.CheckerName;
            this.MobileNo = objdata.MobileNo;
            this.TelNo = objdata.TelNo;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstChecker objdata = obj as T_MstChecker;
            objdata.CheckerCode = this.CheckerCode;
            objdata.CompanyId = this.CompanyId;
            objdata.CheckerName = this.CheckerName;
            objdata.MobileNo = this.MobileNo;
            objdata.TelNo = this.TelNo;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.CheckerCode = 0;
            this.CompanyId = 0;
            this.CheckerName = string.Empty;;
            this.MobileNo = string.Empty;;
            this.TelNo = string.Empty;;
            this.LUT = new DateTime();
        }  

    }  
}
