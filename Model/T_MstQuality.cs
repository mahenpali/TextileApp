 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_MstQuality : IModel,INotifyPropertyChanged
    {
        public T_MstQuality()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.Quality;
        }

        private int     nQualityCode;
        public int     QualityCode
        {
            get { return nQualityCode; }
            set
            {
                nQualityCode = value;
                OnPropertyChanged("QualityCode");
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
        private string     sQualityName;
        public string     QualityName
        {
            get { return sQualityName; }
            set
            {
                sQualityName = value;
                OnPropertyChanged("QualityName");
            }
        }
        private int     nOpeningStockMtrs;
        public int     OpeningStockMtrs
        {
            get { return nOpeningStockMtrs; }
            set
            {
                nOpeningStockMtrs = value;
                OnPropertyChanged("OpeningStockMtrs");
            }
        }
        private int     nOpeningStockTaga;
        public int     OpeningStockTaga
        {
            get { return nOpeningStockTaga; }
            set
            {
                nOpeningStockTaga = value;
                OnPropertyChanged("OpeningStockTaga");
            }
        }
        private int     nOpeningStockBales;
        public int     OpeningStockBales
        {
            get { return nOpeningStockBales; }
            set
            {
                nOpeningStockBales = value;
                OnPropertyChanged("OpeningStockBales");
            }
        }
        private string     sCommodity;
        public string     Commodity
        {
            get { return sCommodity; }
            set
            {
                sCommodity = value;
                OnPropertyChanged("Commodity");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("QualityCode"))){
                    this.QualityCode = DBReader.GetInt32(DBReader.GetOrdinal("QualityCode"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId"))){
                    this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("QualityName"))){
                    this.QualityName = DBReader.GetString(DBReader.GetOrdinal("QualityName"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpeningStockMtrs"))){
                    this.OpeningStockMtrs = DBReader.GetInt32(DBReader.GetOrdinal("OpeningStockMtrs"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpeningStockTaga"))){
                    this.OpeningStockTaga = DBReader.GetInt32(DBReader.GetOrdinal("OpeningStockTaga"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpeningStockBales"))){
                    this.OpeningStockBales = DBReader.GetInt32(DBReader.GetOrdinal("OpeningStockBales"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Commodity"))){
                    this.Commodity = DBReader.GetString(DBReader.GetOrdinal("Commodity"));
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
            sXml.Append("<QualityCode>" + this.QualityCode + "</QualityCode>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<QualityName>" + this.QualityName + "</QualityName>");
            sXml.Append("<OpeningStockMtrs>" + this.OpeningStockMtrs + "</OpeningStockMtrs>");
            sXml.Append("<OpeningStockTaga>" + this.OpeningStockTaga + "</OpeningStockTaga>");
            sXml.Append("<OpeningStockBales>" + this.OpeningStockBales + "</OpeningStockBales>");
            sXml.Append("<Commodity>" + this.Commodity + "</Commodity>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_MstQuality objdata = obj as T_MstQuality;
            this.QualityCode = objdata.QualityCode;
            this.CompanyId = objdata.CompanyId;
            this.QualityName = objdata.QualityName;
            this.OpeningStockMtrs = objdata.OpeningStockMtrs;
            this.OpeningStockTaga = objdata.OpeningStockTaga;
            this.OpeningStockBales = objdata.OpeningStockBales;
            this.Commodity = objdata.Commodity;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_MstQuality objdata = obj as T_MstQuality;
            objdata.QualityCode = this.QualityCode;
            objdata.CompanyId = this.CompanyId;
            objdata.QualityName = this.QualityName;
            objdata.OpeningStockMtrs = this.OpeningStockMtrs;
            objdata.OpeningStockTaga = this.OpeningStockTaga;
            objdata.OpeningStockBales = this.OpeningStockBales;
            objdata.Commodity = this.Commodity;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.QualityCode = 0;
            this.CompanyId = 0;
            this.QualityName = string.Empty;;
            this.OpeningStockMtrs = 0;
            this.OpeningStockTaga = 0;
            this.OpeningStockBales = 0;
            this.Commodity = string.Empty;;
            this.LUT = new DateTime();
        }  

    }  
}
