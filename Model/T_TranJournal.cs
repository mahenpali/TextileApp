using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.ComponentModel;

namespace TextileAppModel
{
    public class T_TranJournal : IModel, INotifyPropertyChanged
    {
        public T_TranJournal()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.TranJouranl;
        }
        private long nTranJournalId;
        public long TranJournalId
        {
            get { return nTranJournalId; }
            set
            {
                nTranJournalId = value;
                OnPropertyChanged("TranJournalId");
            }
        }
        private long nJournalNo;
        public long JournalNo
        {
            get { return nJournalNo; }
            set
            {
                nJournalNo = value;
                OnPropertyChanged("JournalNo");
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
        private string sAmountType;
        public string AmountType
        {
            get { return sAmountType; }
            set
            {
                sAmountType = value;
                OnPropertyChanged("AmountType");
            }
        }
        private DateTime dtVoucherDate;
        public DateTime VoucherDate
        {
            get { return dtVoucherDate; }
            set
            {
                dtVoucherDate = value;
                OnPropertyChanged("VoucherDate");
            }
        }
        private string sRefNo;
        public string RefNo
        {
            get { return sRefNo; }
            set
            {
                sRefNo = value;
                OnPropertyChanged("RefNo");
            }
        }
        private long nDebitPartyId;
        public long DebitPartyId
        {
            get { return nDebitPartyId; }
            set
            {
                nDebitPartyId = value;
                OnPropertyChanged("DebitPartyId");
            }
        }
        private long nCreditPartyId;
        public long CreditPartyId
        {
            get { return nCreditPartyId; }
            set
            {
                nCreditPartyId = value;
                OnPropertyChanged("CreditPartyId");
            }
        }
        private string sDebitNarration;
        public string DebitNarration
        {
            get { return sDebitNarration; }
            set
            {
                sDebitNarration = value;
                OnPropertyChanged("DebitNarration");
            }
        }
        private string sCreditNarration;
        public string CreditNarration
        {
            get { return sCreditNarration; }
            set
            {
                sCreditNarration = value;
                OnPropertyChanged("CreditNarration");
            }
        }
        private decimal nAmount;
        public decimal Amount
        {
            get { return nAmount; }
            set
            {
                nAmount = value;
                OnPropertyChanged("Amount");
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

        private string sCreditAccountName;
        public string CreditAccountName
        {
            get { return sCreditAccountName; }
            set
            {
                sCreditAccountName = value;
                OnPropertyChanged("CreditAccountName");
            }
        }

        private string sDebitAccountName;
        public string DebitAccountName
        {
            get { return sDebitAccountName; }
            set
            {
                sDebitAccountName = value;
                OnPropertyChanged("DebitAccountName");
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
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("TranJournalId")))
            {
                this.TranJournalId = DBReader.GetInt64(DBReader.GetOrdinal("TranJournalId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("JournalNo")))
            {
                this.JournalNo = DBReader.GetInt64(DBReader.GetOrdinal("JournalNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId")))
            {
                this.CompanyId = DBReader.GetInt32(DBReader.GetOrdinal("CompanyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("AmountType")))
            {
                this.AmountType = DBReader.GetString(DBReader.GetOrdinal("AmountType"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("VoucherDate")))
            {
                this.VoucherDate = DBReader.GetDateTime(DBReader.GetOrdinal("VoucherDate"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("RefNo")))
            {
                this.RefNo = DBReader.GetString(DBReader.GetOrdinal("RefNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("DebitPartyId")))
            {
                this.DebitPartyId = DBReader.GetInt64(DBReader.GetOrdinal("DebitPartyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CreditPartyId")))
            {
                this.CreditPartyId = DBReader.GetInt64(DBReader.GetOrdinal("CreditPartyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("DebitNarration")))
            {
                this.DebitNarration = DBReader.GetString(DBReader.GetOrdinal("DebitNarration"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CreditNarration")))
            {
                this.CreditNarration = DBReader.GetString(DBReader.GetOrdinal("CreditNarration"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Amount")))
            {
                this.Amount = DBReader.GetDecimal(DBReader.GetOrdinal("Amount"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT")))
            {
                this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
            }

            if (!DBReader.IsDBNull(DBReader.GetOrdinal("DebitAccountName")))
            {
                this.DebitAccountName = DBReader.GetString(DBReader.GetOrdinal("DebitAccountName"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CreditAccountName")))
            {
                this.CreditAccountName = DBReader.GetString(DBReader.GetOrdinal("CreditAccountName"));
            }
        }
        #endregion

        public string GetXmlString()
        {
            StringBuilder sXml = new StringBuilder();
            sXml.Append("<data>");
            sXml.Append("<TranJournalId>" + this.TranJournalId + "</TranJournalId>");
            sXml.Append("<JournalNo>" + this.JournalNo + "</JournalNo>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<AmountType>" + this.AmountType + "</AmountType>");
            sXml.Append("<VoucherDate>" + this.VoucherDate + "</VoucherDate>");
            sXml.Append("<RefNo>" + this.RefNo + "</RefNo>");
            sXml.Append("<DebitPartyId>" + this.DebitPartyId + "</DebitPartyId>");
            sXml.Append("<CreditPartyId>" + this.CreditPartyId + "</CreditPartyId>");
            sXml.Append("<DebitNarration>" + this.DebitNarration + "</DebitNarration>");
            sXml.Append("<CreditNarration>" + this.CreditNarration + "</CreditNarration>");
            sXml.Append("<Amount>" + this.Amount + "</Amount>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();
        }

        public void Clone<T>(T obj) where T : class, IModel
        {
            T_TranJournal objdata = obj as T_TranJournal;
            this.TranJournalId = objdata.TranJournalId;
            this.JournalNo = objdata.JournalNo;
            this.CompanyId = objdata.CompanyId;
            this.AmountType = objdata.AmountType;
            this.VoucherDate = objdata.VoucherDate;
            this.RefNo = objdata.RefNo;
            this.DebitPartyId = objdata.DebitPartyId;
            this.CreditPartyId = objdata.CreditPartyId;
            this.DebitNarration = objdata.DebitNarration;
            this.CreditNarration = objdata.CreditNarration;
            this.Amount = objdata.Amount;
            this.LUT = objdata.LUT;
            this.CreditAccountName = objdata.CreditAccountName;
            this.DebitAccountName = objdata.DebitAccountName;
        }

        public T Copy<T>() where T : class, IModel, new()
        {
            T obj = new T();
            T_TranJournal objdata = obj as T_TranJournal;
            objdata.TranJournalId = this.TranJournalId;
            objdata.JournalNo = this.JournalNo;
            objdata.CompanyId = this.CompanyId;
            objdata.AmountType = this.AmountType;
            objdata.VoucherDate = this.VoucherDate;
            objdata.RefNo = this.RefNo;
            objdata.DebitPartyId = this.DebitPartyId;
            objdata.CreditPartyId = this.CreditPartyId;
            objdata.DebitNarration = this.DebitNarration;
            objdata.CreditNarration = this.CreditNarration;
            objdata.Amount = this.Amount;
            objdata.LUT = this.LUT;
            objdata.CreditAccountName = this.CreditAccountName;
            objdata.DebitAccountName = this.DebitAccountName;
            return obj;
        }

        public void ResetData()
        {
            this.TranJournalId = 0;
            this.JournalNo = 0;
            this.CompanyId = 0;
            this.AmountType = string.Empty; ;
            this.VoucherDate = DateTime.Now;
            this.RefNo = string.Empty; ;
            this.DebitPartyId = 0;
            this.CreditPartyId = 0;
            this.DebitNarration = string.Empty; ;
            this.CreditNarration = string.Empty; ;
            this.Amount = 0;
            this.LUT = DateTime.Now;
            this.CreditAccountName = string.Empty;
            this.DebitAccountName = string.Empty;
        }

    }
}
