using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.ComponentModel;

namespace TextileAppModel
{
    public class T_MstCompany : IModel, INotifyPropertyChanged
    {

        public T_MstCompany()
        {
            this.PrimKeyTableId = (int)PrimKeyTables.Company;
        }

        private long nCompanyId;
        public long CompanyId
        {
            get { return nCompanyId; }
            set
            {
                nCompanyId = value;
                OnPropertyChanged("CompanyId");
            }
        }
        private int nFinancialYearId;
        public int FinancialYearId
        {
            get { return nFinancialYearId; }
            set
            {
                nFinancialYearId = value;
                OnPropertyChanged("FinancialYearId");
            }
        }
        private string sCompanyName;
        public string CompanyName
        {
            get { return sCompanyName; }
            set
            {
                sCompanyName = value;
                OnPropertyChanged("CompanyName");
            }
        }
        private string sAdd1;
        public string Add1
        {
            get { return sAdd1; }
            set
            {
                sAdd1 = value;
                OnPropertyChanged("Add1");
            }
        }
        private string sAdd2;
        public string Add2
        {
            get { return sAdd2; }
            set
            {
                sAdd2 = value;
                OnPropertyChanged("Add2");
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
        private string sPhoneNo;
        public string PhoneNo
        {
            get { return sPhoneNo; }
            set
            {
                sPhoneNo = value;
                OnPropertyChanged("PhoneNo");
            }
        }
        private string sPhoneNo1;
        public string PhoneNo1
        {
            get { return sPhoneNo1; }
            set
            {
                sPhoneNo1 = value;
                OnPropertyChanged("PhoneNo1");
            }
        }
        private string sMobileNo;
        public string MobileNo
        {
            get { return sMobileNo; }
            set
            {
                sMobileNo = value;
                OnPropertyChanged("MobileNo");
            }
        }
        private string sPanNo;
        public string PanNo
        {
            get { return sPanNo; }
            set
            {
                sPanNo = value;
                OnPropertyChanged("PanNo");
            }
        }
        private string sECCNo;
        public string ECCNo
        {
            get { return sECCNo; }
            set
            {
                sECCNo = value;
                OnPropertyChanged("ECCNo");
            }
        }
        private string sTdsNo;
        public string TdsNo
        {
            get { return sTdsNo; }
            set
            {
                sTdsNo = value;
                OnPropertyChanged("TdsNo");
            }
        }
        private string sAccountNo;
        public string AccountNo
        {
            get { return sAccountNo; }
            set
            {
                sAccountNo = value;
                OnPropertyChanged("AccountNo");
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
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyId")))
            {
                this.CompanyId = DBReader.GetInt64(DBReader.GetOrdinal("CompanyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("FinancialYearId")))
            {
                this.FinancialYearId = DBReader.GetInt32(DBReader.GetOrdinal("FinancialYearId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CompanyName")))
            {
                this.CompanyName = DBReader.GetString(DBReader.GetOrdinal("CompanyName"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add1")))
            {
                this.Add1 = DBReader.GetString(DBReader.GetOrdinal("Add1"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Add2")))
            {
                this.Add2 = DBReader.GetString(DBReader.GetOrdinal("Add2"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Place")))
            {
                this.Place = DBReader.GetString(DBReader.GetOrdinal("Place"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PhoneNo")))
            {
                this.PhoneNo = DBReader.GetString(DBReader.GetOrdinal("PhoneNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PhoneNo1")))
            {
                this.PhoneNo1 = DBReader.GetString(DBReader.GetOrdinal("PhoneNo1"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("MobileNo")))
            {
                this.MobileNo = DBReader.GetString(DBReader.GetOrdinal("MobileNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PanNo")))
            {
                this.PanNo = DBReader.GetString(DBReader.GetOrdinal("PanNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("ECCNo")))
            {
                this.ECCNo = DBReader.GetString(DBReader.GetOrdinal("ECCNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("TdsNo")))
            {
                this.TdsNo = DBReader.GetString(DBReader.GetOrdinal("TdsNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountNo")))
            {
                this.AccountNo = DBReader.GetString(DBReader.GetOrdinal("AccountNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT")))
            {
                this.LUT = DBReader.GetDateTime(DBReader.GetOrdinal("LUT"));
            }
        }
        #endregion

        public string GetXmlString()
        {
            StringBuilder sXml = new StringBuilder();
            sXml.Append("<data>");
            sXml.Append("<CompanyId>" + this.CompanyId + "</CompanyId>");
            sXml.Append("<FinancialYearId>" + this.FinancialYearId + "</FinancialYearId>");
            sXml.Append("<CompanyName>" + this.CompanyName + "</CompanyName>");
            sXml.Append("<Add1>" + this.Add1 + "</Add1>");
            sXml.Append("<Add2>" + this.Add2 + "</Add2>");
            sXml.Append("<Place>" + this.Place + "</Place>");
            sXml.Append("<PhoneNo>" + this.PhoneNo + "</PhoneNo>");
            sXml.Append("<PhoneNo1>" + this.PhoneNo1 + "</PhoneNo1>");
            sXml.Append("<MobileNo>" + this.MobileNo + "</MobileNo>");
            sXml.Append("<PanNo>" + this.PanNo + "</PanNo>");
            sXml.Append("<ECCNo>" + this.ECCNo + "</ECCNo>");
            sXml.Append("<TdsNo>" + this.TdsNo + "</TdsNo>");
            sXml.Append("<AccountNo>" + this.AccountNo + "</AccountNo>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();
        }

        public void Clone<T>(T obj) where T : class, IModel
        {
            T_MstCompany objdata = obj as T_MstCompany;
            this.CompanyId = objdata.CompanyId;
            this.FinancialYearId = objdata.FinancialYearId;
            this.CompanyName = objdata.CompanyName;
            this.Add1 = objdata.Add1;
            this.Add2 = objdata.Add2;
            this.Place = objdata.Place;
            this.PhoneNo = objdata.PhoneNo;
            this.PhoneNo1 = objdata.PhoneNo1;
            this.MobileNo = objdata.MobileNo;
            this.PanNo = objdata.PanNo;
            this.ECCNo = objdata.ECCNo;
            this.TdsNo = objdata.TdsNo;
            this.AccountNo = objdata.AccountNo;
            this.LUT = objdata.LUT;
        }

        public T Copy<T>() where T : class, IModel, new()
        {
            T obj = new T();
            T_MstCompany objdata = obj as T_MstCompany;
            objdata.CompanyId = this.CompanyId;
            objdata.FinancialYearId = this.FinancialYearId;
            objdata.CompanyName = this.CompanyName;
            objdata.Add1 = this.Add1;
            objdata.Add2 = this.Add2;
            objdata.Place = this.Place;
            objdata.PhoneNo = this.PhoneNo;
            objdata.PhoneNo1 = this.PhoneNo1;
            objdata.MobileNo = this.MobileNo;
            objdata.PanNo = this.PanNo;
            objdata.ECCNo = this.ECCNo;
            objdata.TdsNo = this.TdsNo;
            objdata.AccountNo = this.AccountNo;
            objdata.LUT = this.LUT;
            return obj;
        }

        public void ResetData()
        {
            this.CompanyId = 0;
            this.FinancialYearId = 0;
            this.CompanyName = string.Empty; ;
            this.Add1 = string.Empty; ;
            this.Add2 = string.Empty; ;
            this.Place = string.Empty; ;
            this.PhoneNo = string.Empty; ;
            this.PhoneNo1 = string.Empty; ;
            this.MobileNo = string.Empty; ;
            this.PanNo = string.Empty; ;
            this.ECCNo = string.Empty; ;
            this.TdsNo = string.Empty; ;
            this.AccountNo = string.Empty; ;
            this.LUT = new DateTime();
        }

    }
}
