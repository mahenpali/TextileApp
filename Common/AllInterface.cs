using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Common
{    
    public interface IModel
    {
        DataBaseOperation OperationFlag { get; set; }

        string GetXmlString();
        void FillDataFromDB(IDataRecord DBReader);

        void Clone<T>(T obj) where T : class, IModel;
        T Copy<T>() where T : class, IModel, new();
        void ResetData();
        
        
    }

    public interface IViewDetail
    {
        //void AddData<T>(T obj) where T : class, IModel;
    }   

    public enum LogMode : short
    {
        DEBUG = 1,
        High = 2,
        Medium = 4,
        Low = 8,
        NoLog = 16
    }

    public enum DataSourceTypes : short
    {
        T_ErrorDescList = 1,
        T_ErrorDescSave,
        T_MstAccountList,
        T_MstAccountSave,
        T_MstAccountMasterList,
        T_MstAccountMasterSave,
        T_MstBrokerList,
        T_MstBrokerSave,
        T_MstCheckerList,
        T_MstCheckerSave,
        T_MstCompanyList,
        T_MstCompanyDropdownList,
        T_MstCompanySave,
        T_MstFinancialYearList,
        T_MstFinancialYearSave,
        T_MstGroupList,
        T_MstGroupSave,
        T_MstQualityList,
        T_MstQualitySave,
        T_MstRoleList,
        T_MstRoleSave,
        T_MstTransportList,
        T_MstTransportSave,
        T_MstWeaverList,
        T_MstWeaverSave,
        T_TranCashList,
        T_TranCashSave,
        T_TranJournalList,
        T_TranJournalSave,
        T_TranPurchaseOrderList,
        T_TranPurchaseOrderSave,
        T_TranSalesBillList,
        T_TranSalesBillSave,
        T_TranSalesOrderList,
        T_TranSalesOrderSave,
        T_PrimKeyValuesList        
    }

    public enum DateTimeFormat : short
    {
        None,
        ShortDate,
        DateTime12Hr,
        Time12Hr,
        Time24Hr,
        LongDate
    }

    public enum DataBaseOperation : short
    {
        Save = 0,
        Update,
        Delete
    }

    public enum PrimKeyTables : short
    {
        Broker      = 1,
        Transport   = 2,
        Quality     = 3,
        Weaver      = 4,
        Checker     = 5,
        TranCash    = 6,
        TranJouranl = 7,
        TranPurchaseOrder = 8,
        TranSalesOrder = 9,
        Company     = 10
    }
}
