 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstFinancialYear : IModel,INotifyPropertyChanged
    {
        private int     nFinancialYearId;
        public int     FinancialYearId
        {
            get { return nFinancialYearId; }
            set
            {
                nFinancialYearId = value;
                OnPropertyChanged("FinancialYearId");
            }
        }
        private string     sFinancialYear;
        public string     FinancialYear
        {
            get { return sFinancialYear; }
            set
            {
                sFinancialYear = value;
                OnPropertyChanged("FinancialYear");
            }
        }
        private DateTime     dtStartDate;
        public DateTime     StartDate
        {
            get { return dtStartDate; }
            set
            {
                dtStartDate = value;
                OnPropertyChanged("StartDate");
            }
        }
        private DateTime     dtEndDate;
        public DateTime     EndDate
        {
            get { return dtEndDate; }
            set
            {
                dtEndDate = value;
                OnPropertyChanged("EndDate");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FinancialYearId"))){
                    this.FinancialYearId = DBReader.GetInt32(DBReader.GetOrdinal("FinancialYearId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("FinancialYear"))){
                    this.FinancialYear = DBReader.GetString(DBReader.GetOrdinal("FinancialYear"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("StartDate"))){
                    this.StartDate = DBReader.GetDateTime(DBReader.GetOrdinal("StartDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("EndDate"))){
                    this.EndDate = DBReader.GetDateTime(DBReader.GetOrdinal("EndDate"));
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
            sXml.Append("<FinancialYearId>" + this.FinancialYearId + "</FinancialYearId>");
            sXml.Append("<FinancialYear>" + this.FinancialYear + "</FinancialYear>");
            sXml.Append("<StartDate>" + this.StartDate + "</StartDate>");
            sXml.Append("<EndDate>" + this.EndDate + "</EndDate>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstFinancialYear objdata = obj as T_MstFinancialYear;
            this.FinancialYearId = objdata.FinancialYearId;
            this.FinancialYear = objdata.FinancialYear;
            this.StartDate = objdata.StartDate;
            this.EndDate = objdata.EndDate;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstFinancialYear objdata = obj as T_MstFinancialYear;
            objdata.FinancialYearId = this.FinancialYearId;
            objdata.FinancialYear = this.FinancialYear;
            objdata.StartDate = this.StartDate;
            objdata.EndDate = this.EndDate;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.FinancialYearId = 0;
            this.FinancialYear = string.Empty;;
            this.StartDate = new DateTime();
            this.EndDate = new DateTime();
            this.LUT = new DateTime();
        }  

    }  
}
