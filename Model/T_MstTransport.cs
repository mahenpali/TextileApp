 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstTransport : IModel,INotifyPropertyChanged
    {
        public T_MstTransport()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.Transport;
        }

        private int     nTransportCode;
        public int     TransportCode
        {
            get { return nTransportCode; }
            set
            {
                nTransportCode = value;
                OnPropertyChanged("TransportCode");
            }
        }
        private string     sTransportName;
        public string     TransportName
        {
            get { return sTransportName; }
            set
            {
                sTransportName = value;
                OnPropertyChanged("TransportName");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TransportCode"))){
                    this.TransportCode = DBReader.GetInt32(DBReader.GetOrdinal("TransportCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TransportName"))){
                    this.TransportName = DBReader.GetString(DBReader.GetOrdinal("TransportName"));
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
            sXml.Append("<TransportCode>" + this.TransportCode + "</TransportCode>");
            sXml.Append("<TransportName>" + this.TransportName + "</TransportName>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstTransport objdata = obj as T_MstTransport;
            this.TransportCode = objdata.TransportCode;
            this.TransportName = objdata.TransportName;
            this.LUT = objdata.LUT;
            this.CompanyId = objdata.CompanyId;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstTransport objdata = obj as T_MstTransport;
            objdata.TransportCode = this.TransportCode;
            objdata.TransportName = this.TransportName;
            objdata.LUT = this.LUT;
            objdata.CompanyId = this.CompanyId;
            return obj; 
        }  

        public void ResetData()
        {  
            this.TransportCode = 0;
            this.TransportName = string.Empty;;
            this.LUT = new DateTime();
            this.CompanyId = 0;
        }  

    }  
}
