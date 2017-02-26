 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using System.Data;
 using System.ComponentModel;
    
namespace TextileAppModel
{    
    public class T_TranSalesBill : IModel,INotifyPropertyChanged
    {
        private long     nTranSalesBillId;
        public long     TranSalesBillId
        {
            get { return nTranSalesBillId; }
            set
            {
                nTranSalesBillId = value;
                OnPropertyChanged("TranSalesBillId");
            }
        }
        private long     nSalesBillNo;
        public long     SalesBillNo
        {
            get { return nSalesBillNo; }
            set
            {
                nSalesBillNo = value;
                OnPropertyChanged("SalesBillNo");
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
        private DateTime     dtVoucherDate;
        public DateTime     VoucherDate
        {
            get { return dtVoucherDate; }
            set
            {
                dtVoucherDate = value;
                OnPropertyChanged("VoucherDate");
            }
        }
        private long     nToMSPartyId;
        public long     ToMSPartyId
        {
            get { return nToMSPartyId; }
            set
            {
                nToMSPartyId = value;
                OnPropertyChanged("ToMSPartyId");
            }
        }
        private int     nTransportId;
        public int     TransportId
        {
            get { return nTransportId; }
            set
            {
                nTransportId = value;
                OnPropertyChanged("TransportId");
            }
        }
        private int     nCheckerId;
        public int     CheckerId
        {
            get { return nCheckerId; }
            set
            {
                nCheckerId = value;
                OnPropertyChanged("CheckerId");
            }
        }
        private string     sLRNo;
        public string     LRNo
        {
            get { return sLRNo; }
            set
            {
                sLRNo = value;
                OnPropertyChanged("LRNo");
            }
        }
        private DateTime     dtLRDate;
        public DateTime     LRDate
        {
            get { return dtLRDate; }
            set
            {
                dtLRDate = value;
                OnPropertyChanged("LRDate");
            }
        }
        private int     nBrokerId;
        public int     BrokerId
        {
            get { return nBrokerId; }
            set
            {
                nBrokerId = value;
                OnPropertyChanged("BrokerId");
            }
        }
        private string     sStation;
        public string     Station
        {
            get { return sStation; }
            set
            {
                sStation = value;
                OnPropertyChanged("Station");
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
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TranSalesBillId"))){
                    this.TranSalesBillId = DBReader.GetInt64(DBReader.GetOrdinal("TranSalesBillId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("SalesBillNo"))){
                    this.SalesBillNo = DBReader.GetInt64(DBReader.GetOrdinal("SalesBillNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId"))){
                    this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("VoucherDate"))){
                    this.VoucherDate = DBReader.GetDateTime(DBReader.GetOrdinal("VoucherDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("ToMSPartyId"))){
                    this.ToMSPartyId = DBReader.GetInt64(DBReader.GetOrdinal("ToMSPartyId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("TransportId"))){
                    this.TransportId = DBReader.GetInt32(DBReader.GetOrdinal("TransportId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("CheckerId"))){
                    this.CheckerId = DBReader.GetInt32(DBReader.GetOrdinal("CheckerId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LRNo"))){
                    this.LRNo = DBReader.GetString(DBReader.GetOrdinal("LRNo"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("LRDate"))){
                    this.LRDate = DBReader.GetDateTime(DBReader.GetOrdinal("LRDate"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("BrokerId"))){
                    this.BrokerId = DBReader.GetInt32(DBReader.GetOrdinal("BrokerId"));
                }
                if (!DBReader.IsDBNull(DBReader.GetOrdinal("Station"))){
                    this.Station = DBReader.GetString(DBReader.GetOrdinal("Station"));
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
            sXml.Append("<TranSalesBillId>" + this.TranSalesBillId + "</TranSalesBillId>");
            sXml.Append("<SalesBillNo>" + this.SalesBillNo + "</SalesBillNo>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<VoucherDate>" + this.VoucherDate + "</VoucherDate>");
            sXml.Append("<ToMSPartyId>" + this.ToMSPartyId + "</ToMSPartyId>");
            sXml.Append("<TransportId>" + this.TransportId + "</TransportId>");
            sXml.Append("<CheckerId>" + this.CheckerId + "</CheckerId>");
            sXml.Append("<LRNo>" + this.LRNo + "</LRNo>");
            sXml.Append("<LRDate>" + this.LRDate + "</LRDate>");
            sXml.Append("<BrokerId>" + this.BrokerId + "</BrokerId>");
            sXml.Append("<Station>" + this.Station + "</Station>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();  
        }  

        public void Clone<T>(T obj) where T : class, IModel
        {  
            T_TranSalesBill objdata = obj as T_TranSalesBill;
            this.TranSalesBillId = objdata.TranSalesBillId;
            this.SalesBillNo = objdata.SalesBillNo;
            this.CompanyId = objdata.CompanyId;
            this.VoucherDate = objdata.VoucherDate;
            this.ToMSPartyId = objdata.ToMSPartyId;
            this.TransportId = objdata.TransportId;
            this.CheckerId = objdata.CheckerId;
            this.LRNo = objdata.LRNo;
            this.LRDate = objdata.LRDate;
            this.BrokerId = objdata.BrokerId;
            this.Station = objdata.Station;
            this.LUT = objdata.LUT;
        }  

        public T Copy<T>() where T : class, IModel, new()
        {  
            T obj = new T();
            T_TranSalesBill objdata = obj as T_TranSalesBill;
            objdata.TranSalesBillId = this.TranSalesBillId;
            objdata.SalesBillNo = this.SalesBillNo;
            objdata.CompanyId = this.CompanyId;
            objdata.VoucherDate = this.VoucherDate;
            objdata.ToMSPartyId = this.ToMSPartyId;
            objdata.TransportId = this.TransportId;
            objdata.CheckerId = this.CheckerId;
            objdata.LRNo = this.LRNo;
            objdata.LRDate = this.LRDate;
            objdata.BrokerId = this.BrokerId;
            objdata.Station = this.Station;
            objdata.LUT = this.LUT;
            return obj; 
        }  

        public void ResetData()
        {  
            this.TranSalesBillId = 0;
            this.SalesBillNo = 0;
            this.CompanyId = 0;
            this.VoucherDate = new DateTime();
            this.ToMSPartyId = 0;
            this.TransportId = 0;
            this.CheckerId = 0;
            this.LRNo = string.Empty;;
            this.LRDate = new DateTime();
            this.BrokerId = 0;
            this.Station = string.Empty;;
            this.LUT = new DateTime();
        }  

    }  
}
