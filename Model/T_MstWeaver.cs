 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstWeaver : IModel,INotifyPropertyChanged
    {
        public T_MstWeaver()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.Weaver;
        }

        private int     nWeaverCode;
        public int     WeaverCode
        {
            get { return nWeaverCode; }
            set
            {
                nWeaverCode = value;
                OnPropertyChanged("WeaverCode");
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
        private string     sWeaverName;
        public string     WeaverName
        {
            get { return sWeaverName; }
            set
            {
                sWeaverName = value;
                OnPropertyChanged("WeaverName");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("WeaverCode"))){
                    this.WeaverCode = DBReader.GetInt32(DBReader.GetOrdinal("WeaverCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId"))){
                    this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("WeaverName"))){
                    this.WeaverName = DBReader.GetString(DBReader.GetOrdinal("WeaverName"));
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
            sXml.Append("<WeaverCode>" + this.WeaverCode + "</WeaverCode>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<WeaverName>" + this.WeaverName + "</WeaverName>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstWeaver objdata = obj as T_MstWeaver;
            this.WeaverCode = objdata.WeaverCode;
            this.CompanyId = objdata.CompanyId;
            this.WeaverName = objdata.WeaverName;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstWeaver objdata = obj as T_MstWeaver;
            objdata.WeaverCode = this.WeaverCode;
            objdata.CompanyId = this.CompanyId;
            objdata.WeaverName = this.WeaverName;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.WeaverCode = 0;
            this.CompanyId = 0;
            this.WeaverName = string.Empty;;
            this.LUT = new DateTime();
        }  

    }  
}
