using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.ComponentModel;

namespace TextileAppModel
{
    public class T_TranPurchaseOrder : IModel, INotifyPropertyChanged
    {
        public T_TranPurchaseOrder()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.TranPurchaseOrder;
        }
        private long sTranPurchaseOrderId;
        public long TranPurchaseOrderId
        {
            get { return sTranPurchaseOrderId; }
            set
            {
                sTranPurchaseOrderId = value;
                OnPropertyChanged("TranPurchaseOrderId");
            }
        }
        private long nConfirmationNo;
        public long ConfirmationNo
        {
            get { return nConfirmationNo; }
            set
            {
                nConfirmationNo = value;
                OnPropertyChanged("ConfirmationNo");
            }
        }
        private int nCompanyId;
        public int CompanyId
        {
            get { return nCompanyId; }
            set
            {
                nCompanyId = value;
                OnPropertyChanged("CompanyId");
            }
        }
        private DateTime dtCurrDate;
        public DateTime CurrDate
        {
            get { return dtCurrDate; }
            set
            {
                dtCurrDate = value;
                OnPropertyChanged("CurrDate");
            }
        }
        private long nPartyId;
        public long PartyId
        {
            get { return nPartyId; }
            set
            {
                nPartyId = value;
                OnPropertyChanged("PartyId");
            }
        }
        private int nWeaverCode;
        public int WeaverCode
        {
            get { return nWeaverCode; }
            set
            {
                nWeaverCode = value;
                OnPropertyChanged("WeaverCode");
            }
        }
        private int nQualityCode;
        public int QualityCode
        {
            get { return nQualityCode; }
            set
            {
                nQualityCode = value;
                OnPropertyChanged("QualityCode");
            }
        }
        private int nBrokerCode;
        public int BrokerCode
        {
            get { return nBrokerCode; }
            set
            {
                nBrokerCode = value;
                OnPropertyChanged("BrokerCode");
            }
        }
        private int nThanCount;
        public int ThanCount
        {
            get { return nThanCount; }
            set
            {
                nThanCount = value;
                OnPropertyChanged("ThanCount");
            }
        }
        private decimal nRate;
        public decimal Rate
        {
            get { return nRate; }
            set
            {
                nRate = value;
                OnPropertyChanged("Rate");
            }
        }
        private string sCD;
        public string CD
        {
            get { return sCD; }
            set
            {
                sCD = value;
                OnPropertyChanged("CD");
            }
        }
        private string sSide;
        public string Side
        {
            get { return sSide; }
            set
            {
                sSide = value;
                OnPropertyChanged("Side");
            }
        }
        private decimal nPacking;
        public decimal Packing
        {
            get { return nPacking; }
            set
            {
                nPacking = value;
                OnPropertyChanged("Packing");
            }
        }
        private int nPendingThan;
        public int PendingThan
        {
            get { return nPendingThan; }
            set
            {
                nPendingThan = value;
                OnPropertyChanged("PendingThan");
            }
        }
        private DateTime dtLUT;
        public DateTime LUT
        {
            get { return dtLUT; }
            set
            {
                dtLUT = value;
                OnPropertyChanged("LUT");
            }
        }

        private string sWeaverName;
        public string WeaverName
        {
            get { return sWeaverName; }
            set
            {
                sWeaverName = value;
                OnPropertyChanged("WeaverName");
            }
        }

        private string sQualityName;
        public string QualityName
        {
            get { return sQualityName; }
            set
            {
                sQualityName = value;
                OnPropertyChanged("QualityName");
            }
        }

        private string sBrokerName;
        public string BrokerName
        {
            get { return sBrokerName; }
            set
            {
                sBrokerName = value;
                OnPropertyChanged("BrokerName");
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
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("TranPurchaseOrderId")))
            {
                this.TranPurchaseOrderId = DBReader.GetInt64(DBReader.GetOrdinal("TranPurchaseOrderId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("ConfirmationNo")))
            {
                this.ConfirmationNo = DBReader.GetInt64(DBReader.GetOrdinal("ConfirmationNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId")))
            {
                this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CurrDate")))
            {
                this.CurrDate = DBReader.GetDateTime(DBReader.GetOrdinal("CurrDate"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PartyId")))
            {
                this.PartyId = DBReader.GetInt64(DBReader.GetOrdinal("PartyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("WeaverCode")))
            {
                this.WeaverCode = DBReader.GetInt32(DBReader.GetOrdinal("WeaverCode"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("QualityCode")))
            {
                this.QualityCode = DBReader.GetInt32(DBReader.GetOrdinal("QualityCode"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("BrokerCode")))
            {
                this.BrokerCode = DBReader.GetInt32(DBReader.GetOrdinal("BrokerCode"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("ThanCount")))
            {
                this.ThanCount = DBReader.GetInt32(DBReader.GetOrdinal("ThanCount"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Rate")))
            {
                this.Rate = DBReader.GetDecimal(DBReader.GetOrdinal("Rate"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CD")))
            {
                this.CD = DBReader.GetString(DBReader.GetOrdinal("CD"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Side")))
            {
                this.Side = DBReader.GetString(DBReader.GetOrdinal("Side"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Packing")))
            {
                this.Packing = DBReader.GetDecimal(DBReader.GetOrdinal("Packing"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PendingThan")))
            {
                this.PendingThan = DBReader.GetInt32(DBReader.GetOrdinal("PendingThan"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT")))
            {
                this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("WeaverName")))
            {
                this.WeaverName = DBReader.GetString(DBReader.GetOrdinal("WeaverName"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("BrokerName")))
            {
                this.BrokerName = DBReader.GetString(DBReader.GetOrdinal("BrokerName"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("QualityName")))
            {
                this.QualityName = DBReader.GetString(DBReader.GetOrdinal("QualityName"));
            }
        }
        #endregion

        public string GetXmlString()
        {
            StringBuilder sXml = new StringBuilder();
            sXml.Append("<data>");
            sXml.Append("<TranPurchaseOrderId>" + this.TranPurchaseOrderId + "</TranPurchaseOrderId>");
            sXml.Append("<ConfirmationNo>" + this.ConfirmationNo + "</ConfirmationNo>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<CurrDate>" + this.CurrDate + "</CurrDate>");
            sXml.Append("<PartyId>" + this.PartyId + "</PartyId>");
            sXml.Append("<WeaverCode>" + this.WeaverCode + "</WeaverCode>");
            sXml.Append("<QualityCode>" + this.QualityCode + "</QualityCode>");
            sXml.Append("<BrokerCode>" + this.BrokerCode + "</BrokerCode>");
            sXml.Append("<ThanCount>" + this.ThanCount + "</ThanCount>");
            sXml.Append("<Rate>" + this.Rate + "</Rate>");
            sXml.Append("<CD>" + this.CD + "</CD>");
            sXml.Append("<Side>" + this.Side + "</Side>");
            sXml.Append("<Packing>" + this.Packing + "</Packing>");
            sXml.Append("<PendingThan>" + this.PendingThan + "</PendingThan>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();
        }

        public void Clone<T>(T obj) where T : class, IModel
        {
            T_TranPurchaseOrder objdata = obj as T_TranPurchaseOrder;
            this.TranPurchaseOrderId = objdata.TranPurchaseOrderId;
            this.ConfirmationNo = objdata.ConfirmationNo;
            this.CompanyId = objdata.CompanyId;
            this.CurrDate = objdata.CurrDate;
            this.PartyId = objdata.PartyId;
            this.WeaverCode = objdata.WeaverCode;
            this.QualityCode = objdata.QualityCode;
            this.BrokerCode = objdata.BrokerCode;
            this.ThanCount = objdata.ThanCount;
            this.Rate = objdata.Rate;
            this.CD = objdata.CD;
            this.Side = objdata.Side;
            this.Packing = objdata.Packing;
            this.PendingThan = objdata.PendingThan;
            this.LUT = objdata.LUT;
            this.BrokerName = objdata.BrokerName;
            this.QualityName = objdata.QualityName;
            this.WeaverName = objdata.WeaverName;
        }

        public T Copy<T>() where T : class, IModel, new()
        {
            T obj = new T();
            T_TranPurchaseOrder objdata = obj as T_TranPurchaseOrder;
            objdata.TranPurchaseOrderId = this.TranPurchaseOrderId;
            objdata.ConfirmationNo = this.ConfirmationNo;
            objdata.CompanyId = this.CompanyId;
            objdata.CurrDate = this.CurrDate;
            objdata.PartyId = this.PartyId;
            objdata.WeaverCode = this.WeaverCode;
            objdata.QualityCode = this.QualityCode;
            objdata.BrokerCode = this.BrokerCode;
            objdata.ThanCount = this.ThanCount;
            objdata.Rate = this.Rate;
            objdata.CD = this.CD;
            objdata.Side = this.Side;
            objdata.Packing = this.Packing;
            objdata.PendingThan = this.PendingThan;
            objdata.LUT = this.LUT;
            objdata.BrokerName = this.BrokerName;
            objdata.QualityName = this.QualityName;
            objdata.WeaverName = this.WeaverName;
            return obj;
        }

        public void ResetData()
        {
            this.TranPurchaseOrderId = 0 ;
            this.ConfirmationNo = 0;
            this.CompanyId = 0;
            this.CurrDate = new DateTime();
            this.PartyId = 0;
            this.WeaverCode = 0;
            this.QualityCode = 0;
            this.BrokerCode = 0;
            this.ThanCount = 0;
            this.Rate = 0;
            this.CD = string.Empty; ;
            this.Side = string.Empty; ;
            this.Packing = 0;
            this.PendingThan = 0;
            this.LUT = new DateTime();
        }

    }
}
