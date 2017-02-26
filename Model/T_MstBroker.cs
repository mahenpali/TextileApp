 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstBroker : IModel,INotifyPropertyChanged
    {

        public T_MstBroker()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.Broker;
        }

        private int     nBrokerCode;
        public int     BrokerCode
        {
            get { return nBrokerCode; }
            set
            {
                nBrokerCode = value;
                OnPropertyChanged("BrokerCode");
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
        private string     sBrokerName;
        public string     BrokerName
        {
            get { return sBrokerName; }
            set
            {
                sBrokerName = value;
                OnPropertyChanged("BrokerName");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BrokerCode"))){
                    this.BrokerCode = DBReader.GetInt32(DBReader.GetOrdinal("BrokerCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId"))){
                    this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BrokerName"))){
                    this.BrokerName = DBReader.GetString(DBReader.GetOrdinal("BrokerName"));
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
            sXml.Append("<BrokerCode>" + this.BrokerCode + "</BrokerCode>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<BrokerName>" + this.BrokerName + "</BrokerName>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstBroker objdata = obj as T_MstBroker;
            this.BrokerCode = objdata.BrokerCode;
            this.CompanyId = objdata.CompanyId;
            this.BrokerName = objdata.BrokerName;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstBroker objdata = obj as T_MstBroker;
            objdata.BrokerCode = this.BrokerCode;
            objdata.CompanyId = this.CompanyId;
            objdata.BrokerName = this.BrokerName;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.BrokerCode = 0;
            this.CompanyId = 0;
            this.BrokerName = string.Empty;;
            this.LUT = new DateTime();
        }  

    }  
}
