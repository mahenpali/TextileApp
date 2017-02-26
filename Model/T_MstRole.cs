 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstRole : IModel,INotifyPropertyChanged
    {
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
        private string     sRoleName;
        public string     RoleName
        {
            get { return sRoleName; }
            set
            {
                sRoleName = value;
                OnPropertyChanged("RoleName");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RoleId"))){
                    this.RoleId = DBReader.GetInt32(DBReader.GetOrdinal("RoleId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("RoleName"))){
                    this.RoleName = DBReader.GetString(DBReader.GetOrdinal("RoleName"));
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
            sXml.Append("<RoleId>" + this.RoleId + "</RoleId>");
            sXml.Append("<RoleName>" + this.RoleName + "</RoleName>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstRole objdata = obj as T_MstRole;
            this.RoleId = objdata.RoleId;
            this.RoleName = objdata.RoleName;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstRole objdata = obj as T_MstRole;
            objdata.RoleId = this.RoleId;
            objdata.RoleName = this.RoleName;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.RoleId = 0;
            this.RoleName = string.Empty;;
            this.LUT = new DateTime();
        }  

    }  
}
