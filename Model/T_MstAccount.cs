 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstAccount : IModel,INotifyPropertyChanged
    {
        private long     nAccountId;
        public long     AccountId
        {
            get { return nAccountId; }
            set
            {
                nAccountId = value;
                OnPropertyChanged("AccountId");
            }
        }
        private string     sAccountName;
        public string     AccountName
        {
            get { return sAccountName; }
            set
            {
                sAccountName = value;
                OnPropertyChanged("AccountName");
            }
        }
        private string     sPassword;
        public string     Password
        {
            get { return sPassword; }
            set
            {
                sPassword = value;
                OnPropertyChanged("Password");
            }
        }
        private int     nRoleId;
        public int     RoleId
        {
            get { return nRoleId; }
            set
            {
                nRoleId = value;
                OnPropertyChanged("RoleId");
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
        private long     nCompanyId;
        public long     CompanyId
        {
            get { return nCompanyId; }
            set
            {
                nCompanyId = value;
                OnPropertyChanged("CompanyId");
            }
        }
        private int nFinancialYearId;
        public int FinancialYearId
        {
            get { return nFinancialYearId; }
            set
            {
                nFinancialYearId = value;
                OnPropertyChanged("FinancialYearId");
            }
        }
        public DataBaseOperation OperationFlag { get; set; }

        
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountId"))){
                    this.AccountId = DBReader.GetInt64(DBReader.GetOrdinal("AccountId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountName"))){
                    this.AccountName = DBReader.GetString(DBReader.GetOrdinal("AccountName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Password"))){
                    this.Password = DBReader.GetString(DBReader.GetOrdinal("Password"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RoleId"))){
                    this.RoleId = DBReader.GetInt32(DBReader.GetOrdinal("RoleId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT"))){
                    this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId"))){
                    this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
                }
            }
        #endregion
  
        public string GetXmlString()
        {  
            StringBuilder sXml = new StringBuilder();  
            sXml.Append("<data>");
            sXml.Append("<AccountId>" + this.AccountId + "</AccountId>");
            sXml.Append("<AccountName>" + this.AccountName + "</AccountName>");
            sXml.Append("<Password>" + this.Password + "</Password>");
            sXml.Append("<RoleId>" + this.RoleId + "</RoleId>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstAccount objdata = obj as T_MstAccount;
            this.AccountId = objdata.AccountId;
            this.AccountName = objdata.AccountName;
            this.Password = objdata.Password;
            this.RoleId = objdata.RoleId;
            this.LUT = objdata.LUT;
            this.CompanyId = objdata.CompanyId;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstAccount objdata = obj as T_MstAccount;
            objdata.AccountId = this.AccountId;
            objdata.AccountName = this.AccountName;
            objdata.Password = this.Password;
            objdata.RoleId = this.RoleId;
            objdata.LUT = this.LUT;
            objdata.CompanyId = this.CompanyId;
            return obj; 
        }  

        public void ResetData()
        {  
            this.AccountId = 0;
            this.AccountName = string.Empty;;
            this.Password = string.Empty;;
            this.RoleId = 0;
            this.LUT = new DateTime();
            this.CompanyId = 0;
        }  

    }  
}
