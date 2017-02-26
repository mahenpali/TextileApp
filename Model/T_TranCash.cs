using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.ComponentModel;

namespace TextileAppModel
{
    public class T_TranCash : IModel, INotifyPropertyChanged
    {
        private long nTranBankId;
        public long TranBankId
        {
            get { return nTranBankId; }
            set
            {
                nTranBankId = value;
                OnPropertyChanged("TranBankId");
            }
        }
        private long nVoucherNo;
        public long VoucherNo
        {
            get { return nVoucherNo; }
            set
            {
                nVoucherNo = value;
                OnPropertyChanged("VoucherNo");
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
        private string sChequeNo;
        public string ChequeNo
        {
            get { return sChequeNo; }
            set
            {
                sChequeNo = value;
                OnPropertyChanged("ChequeNo");
            }
        }
        private long nBankId;
        public long BankId
        {
            get { return nBankId; }
            set
            {
                nBankId = value;
                OnPropertyChanged("BankId");
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
        private int nNoOfDay;
        public int NoOfDay
        {
            get { return nNoOfDay; }
            set
            {
                nNoOfDay = value;
                OnPropertyChanged("NoOfDay");
            }
        }
        private string sPlace;
        public string Place
        {
            get { return sPlace; }
            set
            {
                sPlace = value;
                OnPropertyChanged("Place");
            }
        }
        private string sBankName;
        public string BankName
        {
            get { return sBankName; }
            set
            {
                sBankName = value;
                OnPropertyChanged("BankName");
            }
        }
        private string sDescription;
        public string Description
        {
            get { return sDescription; }
            set
            {
                sDescription = value;
                OnPropertyChanged("Description");
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
        private string sAccountName;
        public string AccountName
        {
            get { return sAccountName; }
            set
            {
                sAccountName = value;
                OnPropertyChanged("AccountName");
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
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("TranBankId")))
            {
                this.TranBankId = DBReader.GetInt64(DBReader.GetOrdinal("TranBankId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("VoucherNo")))
            {
                this.VoucherNo = DBReader.GetInt64(DBReader.GetOrdinal("VoucherNo"));
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
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("ChequeNo")))
            {
                this.ChequeNo = DBReader.GetString(DBReader.GetOrdinal("ChequeNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("BankId")))
            {
                this.BankId = DBReader.GetInt64(DBReader.GetOrdinal("BankId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PartyId")))
            {
                this.PartyId = DBReader.GetInt64(DBReader.GetOrdinal("PartyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("NoOfDay")))
            {
                this.NoOfDay = DBReader.GetInt32(DBReader.GetOrdinal("NoOfDay"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Place")))
            {
                this.Place = DBReader.GetString(DBReader.GetOrdinal("Place"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("BankName")))
            {
                this.BankName = DBReader.GetString(DBReader.GetOrdinal("BankName"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Description")))
            {
                this.Description = DBReader.GetString(DBReader.GetOrdinal("Description"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Amount")))
            {
                this.Amount = DBReader.GetDecimal(DBReader.GetOrdinal("Amount"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT")))
            {
                this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountName")))
            {
                this.AccountName = DBReader.GetString(DBReader.GetOrdinal("AccountName"));
            }
        }
        #endregion

        public string GetXmlString()
        {
            StringBuilder sXml = new StringBuilder();
            sXml.Append("<data>");
            sXml.Append("<TranBankId>" + this.TranBankId + "</TranBankId>");
            sXml.Append("<VoucherNo>" + this.VoucherNo + "</VoucherNo>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<AmountType>" + this.AmountType + "</AmountType>");
            sXml.Append("<VoucherDate>" + this.VoucherDate + "</VoucherDate>");
            sXml.Append("<ChequeNo>" + this.ChequeNo + "</ChequeNo>");
            sXml.Append("<BankId>" + this.BankId + "</BankId>");
            sXml.Append("<PartyId>" + this.PartyId + "</PartyId>");
            sXml.Append("<NoOfDay>" + this.NoOfDay + "</NoOfDay>");
            sXml.Append("<Place>" + this.Place + "</Place>");
            sXml.Append("<BankName>" + this.BankName + "</BankName>");
            sXml.Append("<Description>" + this.Description + "</Description>");
            sXml.Append("<Amount>" + this.Amount + "</Amount>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();
        }

        public void Clone<T>(T obj) where T : class, IModel
        {
            T_TranCash objdata = obj as T_TranCash;
            this.TranBankId = objdata.TranBankId;
            this.VoucherNo = objdata.VoucherNo;
            this.CompanyId = objdata.CompanyId;
            this.AmountType = objdata.AmountType;
            this.VoucherDate = objdata.VoucherDate;
            this.ChequeNo = objdata.ChequeNo;
            this.BankId = objdata.BankId;
            this.PartyId = objdata.PartyId;
            this.NoOfDay = objdata.NoOfDay;
            this.Place = objdata.Place;
            this.BankName = objdata.BankName;
            this.Description = objdata.Description;
            this.Amount = objdata.Amount;
            this.LUT = objdata.LUT;
            this.AccountName = objdata.AccountName;            
        }

        public T Copy<T>() where T : class, IModel, new()
        {
            T obj = new T();
            T_TranCash objdata = obj as T_TranCash;
            objdata.TranBankId = this.TranBankId;
            objdata.VoucherNo = this.VoucherNo;
            objdata.CompanyId = this.CompanyId;
            objdata.AmountType = this.AmountType;
            objdata.VoucherDate = this.VoucherDate;
            objdata.ChequeNo = this.ChequeNo;
            objdata.BankId = this.BankId;
            objdata.PartyId = this.PartyId;
            objdata.NoOfDay = this.NoOfDay;
            objdata.Place = this.Place;
            objdata.BankName = this.BankName;
            objdata.Description = this.Description;
            objdata.Amount = this.Amount;
            objdata.LUT = this.LUT;
            objdata.AccountName = this.AccountName;            
            return obj;
        }

        public void ResetData()
        {
            this.TranBankId = 0;
            this.VoucherNo = 0;
            this.CompanyId = 0;
            this.AmountType = string.Empty; ;
            this.VoucherDate = new DateTime();
            this.ChequeNo = string.Empty; ;
            this.BankId = 0;
            this.PartyId = 0;
            this.NoOfDay = 0;
            this.Place = string.Empty; ;
            this.BankName = string.Empty; ;
            this.Description = string.Empty; ;
            this.Amount = 0;
            this.LUT = new DateTime();
        }

    }
}
