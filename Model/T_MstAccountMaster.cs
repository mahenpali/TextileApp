using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.ComponentModel;

namespace TextileAppModel
{
    public class T_MstAccountMaster : IModel, INotifyPropertyChanged
    {
        private long nAccountCode;
        public long AccountCode
        {
            get { return nAccountCode; }
            set
            {
                nAccountCode = value;
                OnPropertyChanged("AccountCode");
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
        private string sAddress;
        public string Address
        {
            get { return sAddress; }
            set
            {
                sAddress = value;
                OnPropertyChanged("Address");
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
        private decimal nOpeningBalance;
        public decimal OpeningBalance
        {
            get { return nOpeningBalance; }
            set
            {
                nOpeningBalance = value;
                OnPropertyChanged("OpeningBalance");
            }
        }
        private string sTypeDrCr;
        public string TypeDrCr
        {
            get { return sTypeDrCr; }
            set
            {
                sTypeDrCr = value;
                OnPropertyChanged("TypeDrCr");
            }
        }
        private string sGroupId;
        public string GroupId
        {
            get { return sGroupId; }
            set
            {
                sGroupId = value;
                OnPropertyChanged("GroupId");
            }
        }
        private string sGroupCode;
        public string GroupCode
        {
            get { return sGroupCode; }
            set
            {
                sGroupCode = value;
                OnPropertyChanged("GroupCode");
            }
        }
        private string sPanCardNo;
        public string PanCardNo
        {
            get { return sPanCardNo; }
            set
            {
                sPanCardNo = value;
                OnPropertyChanged("PanCardNo");
            }
        }
        private string sFCC;
        public string FCC
        {
            get { return sFCC; }
            set
            {
                sFCC = value;
                OnPropertyChanged("FCC");
            }
        }
        private string sRange;
        public string Range
        {
            get { return sRange; }
            set
            {
                sRange = value;
                OnPropertyChanged("Range");
            }
        }
        private string sDivI;
        public string DivI
        {
            get { return sDivI; }
            set
            {
                sDivI = value;
                OnPropertyChanged("DivI");
            }
        }
        private string sCommI;
        public string CommI
        {
            get { return sCommI; }
            set
            {
                sCommI = value;
                OnPropertyChanged("CommI");
            }
        }
        private string sBST;
        public string BST
        {
            get { return sBST; }
            set
            {
                sBST = value;
                OnPropertyChanged("BST");
            }
        }
        private string sCST;
        public string CST
        {
            get { return sCST; }
            set
            {
                sCST = value;
                OnPropertyChanged("CST");
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
        private decimal nChecking;
        public decimal Checking
        {
            get { return nChecking; }
            set
            {
                nChecking = value;
                OnPropertyChanged("Checking");
            }
        }
        private decimal nOther;
        public decimal Other
        {
            get { return nOther; }
            set
            {
                nOther = value;
                OnPropertyChanged("Other");
            }
        }
        private decimal nInsurance;
        public decimal Insurance
        {
            get { return nInsurance; }
            set
            {
                nInsurance = value;
                OnPropertyChanged("Insurance");
            }
        }
        private decimal nADath;
        public decimal ADath
        {
            get { return nADath; }
            set
            {
                nADath = value;
                OnPropertyChanged("ADath");
            }
        }
        private string sLUT;
        public string LUT
        {
            get { return sLUT; }
            set
            {
                sLUT = value;
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
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountCode")))
            {
                this.AccountCode = DBReader.GetInt64(DBReader.GetOrdinal("AccountCode"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("AccountName")))
            {
                this.AccountName = DBReader.GetString(DBReader.GetOrdinal("AccountName"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Address")))
            {
                this.Address = DBReader.GetString(DBReader.GetOrdinal("Address"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Place")))
            {
                this.Place = DBReader.GetString(DBReader.GetOrdinal("Place"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("OpeningBalance")))
            {
                this.OpeningBalance = DBReader.GetDecimal(DBReader.GetOrdinal("OpeningBalance"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("TypeDrCr")))
            {
                this.TypeDrCr = DBReader.GetString(DBReader.GetOrdinal("TypeDrCr"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("GroupId")))
            {
                this.GroupId = DBReader.GetString(DBReader.GetOrdinal("GroupId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("GroupCode")))
            {
                this.GroupCode = DBReader.GetString(DBReader.GetOrdinal("GroupCode"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PanCardNo")))
            {
                this.PanCardNo = DBReader.GetString(DBReader.GetOrdinal("PanCardNo"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("FCC")))
            {
                this.FCC = DBReader.GetString(DBReader.GetOrdinal("FCC"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Range")))
            {
                this.Range = DBReader.GetString(DBReader.GetOrdinal("Range"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("DivI")))
            {
                this.DivI = DBReader.GetString(DBReader.GetOrdinal("DivI"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CommI")))
            {
                this.CommI = DBReader.GetString(DBReader.GetOrdinal("CommI"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("BST")))
            {
                this.BST = DBReader.GetString(DBReader.GetOrdinal("BST"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("CST")))
            {
                this.CST = DBReader.GetString(DBReader.GetOrdinal("CST"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Packing")))
            {
                this.Packing = DBReader.GetDecimal(DBReader.GetOrdinal("Packing"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Checking")))
            {
                this.Checking = DBReader.GetDecimal(DBReader.GetOrdinal("Checking"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Other")))
            {
                this.Other = DBReader.GetDecimal(DBReader.GetOrdinal("Other"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("Insurance")))
            {
                this.Insurance = DBReader.GetDecimal(DBReader.GetOrdinal("Insurance"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("ADath")))
            {
                this.ADath = DBReader.GetDecimal(DBReader.GetOrdinal("ADath"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("LUT")))
            {
                this.LUT = DBReader.GetString(DBReader.GetOrdinal("LUT"));
            }
        }
        #endregion

        public string GetXmlString()
        {
            StringBuilder sXml = new StringBuilder();
            sXml.Append("<data>");
            sXml.Append("<AccountCode>" + this.AccountCode + "</AccountCode>");
            sXml.Append("<AccountName>" + this.AccountName + "</AccountName>");
            sXml.Append("<Address>" + this.Address + "</Address>");
            sXml.Append("<Place>" + this.Place + "</Place>");
            sXml.Append("<OpeningBalance>" + this.OpeningBalance + "</OpeningBalance>");
            sXml.Append("<TypeDrCr>" + this.TypeDrCr + "</TypeDrCr>");
            sXml.Append("<GroupId>" + this.GroupId + "</GroupId>");
            sXml.Append("<GroupCode>" + this.GroupCode + "</GroupCode>");
            sXml.Append("<PanCardNo>" + this.PanCardNo + "</PanCardNo>");
            sXml.Append("<FCC>" + this.FCC + "</FCC>");
            sXml.Append("<Range>" + this.Range + "</Range>");
            sXml.Append("<DivI>" + this.DivI + "</DivI>");
            sXml.Append("<CommI>" + this.CommI + "</CommI>");
            sXml.Append("<BST>" + this.BST + "</BST>");
            sXml.Append("<CST>" + this.CST + "</CST>");
            sXml.Append("<Packing>" + this.Packing + "</Packing>");
            sXml.Append("<Checking>" + this.Checking + "</Checking>");
            sXml.Append("<Other>" + this.Other + "</Other>");
            sXml.Append("<Insurance>" + this.Insurance + "</Insurance>");
            sXml.Append("<ADath>" + this.ADath + "</ADath>");
            sXml.Append("<LUT>" + this.LUT + "</LUT>");
            sXml.Append("</data>");
            return sXml.ToString();
        }

        public void Clone<T>(T obj) where T : class, IModel
        {
            T_MstAccountMaster objdata = obj as T_MstAccountMaster;
            this.AccountCode = objdata.AccountCode;
            this.AccountName = objdata.AccountName;
            this.Address = objdata.Address;
            this.Place = objdata.Place;
            this.OpeningBalance = objdata.OpeningBalance;
            this.TypeDrCr = objdata.TypeDrCr;
            this.GroupId = objdata.GroupId;
            this.GroupCode = objdata.GroupCode;
            this.PanCardNo = objdata.PanCardNo;
            this.FCC = objdata.FCC;
            this.Range = objdata.Range;
            this.DivI = objdata.DivI;
            this.CommI = objdata.CommI;
            this.BST = objdata.BST;
            this.CST = objdata.CST;
            this.Packing = objdata.Packing;
            this.Checking = objdata.Checking;
            this.Other = objdata.Other;
            this.Insurance = objdata.Insurance;
            this.ADath = objdata.ADath;
            this.LUT = objdata.LUT;
        }

        public T Copy<T>() where T : class, IModel, new()
        {
            T obj = new T();
            T_MstAccountMaster objdata = obj as T_MstAccountMaster;
            objdata.AccountCode = this.AccountCode;
            objdata.AccountName = this.AccountName;
            objdata.Address = this.Address;
            objdata.Place = this.Place;
            objdata.OpeningBalance = this.OpeningBalance;
            objdata.TypeDrCr = this.TypeDrCr;
            objdata.GroupId = this.GroupId;
            objdata.GroupCode = this.GroupCode;
            objdata.PanCardNo = this.PanCardNo;
            objdata.FCC = this.FCC;
            objdata.Range = this.Range;
            objdata.DivI = this.DivI;
            objdata.CommI = this.CommI;
            objdata.BST = this.BST;
            objdata.CST = this.CST;
            objdata.Packing = this.Packing;
            objdata.Checking = this.Checking;
            objdata.Other = this.Other;
            objdata.Insurance = this.Insurance;
            objdata.ADath = this.ADath;
            objdata.LUT = this.LUT;
            return obj;
        }

        public void ResetData()
        {
            this.AccountCode = 0;
            this.AccountName = string.Empty; ;
            this.Address = string.Empty; ;
            this.Place = string.Empty; ;
            this.OpeningBalance = 0;
            this.TypeDrCr = string.Empty; ;
            this.GroupId = string.Empty; ;
            this.GroupCode = string.Empty; ;
            this.PanCardNo = string.Empty; ;
            this.FCC = string.Empty; ;
            this.Range = string.Empty; ;
            this.DivI = string.Empty; ;
            this.CommI = string.Empty; ;
            this.BST = string.Empty; ;
            this.CST = string.Empty; ;
            this.Packing = 0;
            this.Checking = 0;
            this.Other = 0;
            this.Insurance = 0;
            this.ADath = 0;
            this.LUT = string.Empty; ;
        }

    }
}
