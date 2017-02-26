 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstGroup : IModel,INotifyPropertyChanged
    {
        private int     nGroupId;
        public int     GroupId
        {
            get { return nGroupId; }
            set
            {
                nGroupId = value;
                OnPropertyChanged("GroupId");
            }
        }
        private string     sGroupCode;
        public string     GroupCode
        {
            get { return sGroupCode; }
            set
            {
                sGroupCode = value;
                OnPropertyChanged("GroupCode");
            }
        }
        private string     sDescription;
        public string     Description
        {
            get { return sDescription; }
            set
            {
                sDescription = value;
                OnPropertyChanged("Description");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("GroupId"))){
                    this.GroupId = DBReader.GetInt32(DBReader.GetOrdinal("GroupId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("GroupCode"))){
                    this.GroupCode = DBReader.GetString(DBReader.GetOrdinal("GroupCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Description"))){
                    this.Description = DBReader.GetString(DBReader.GetOrdinal("Description"));
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
            sXml.Append("<GroupId>" + this.GroupId + "</GroupId>");
            sXml.Append("<GroupCode>" + this.GroupCode + "</GroupCode>");
            sXml.Append("<Description>" + this.Description + "</Description>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstGroup objdata = obj as T_MstGroup;
            this.GroupId = objdata.GroupId;
            this.GroupCode = objdata.GroupCode;
            this.Description = objdata.Description;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstGroup objdata = obj as T_MstGroup;
            objdata.GroupId = this.GroupId;
            objdata.GroupCode = this.GroupCode;
            objdata.Description = this.Description;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.GroupId = 0;
            this.GroupCode = string.Empty;;
            this.Description = string.Empty;;
            this.LUT = new DateTime();
        }  

    }  
}
