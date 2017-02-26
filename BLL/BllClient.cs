 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using Common;
 using DAL;
 using TextileAppModel;
    
namespace BLL
{    
    public class BllClient
    {
        private DataAccessHelper objDAL = new DataAccessHelper();
        public List<T> GetList<T>(DataSourceTypes DataSourceTypes, T objFilter) where T: class, IModel, new()
        {
            List<T> list = new List<T>();
            switch (DataSourceTypes)
            {
                case Common.DataSourceTypes.T_ErrorDescList :
                    objDAL.GetListT_ErrorDesc(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstAccountList :
                    objDAL.GetListT_MstAccount(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstAccountMasterList :
                    objDAL.GetListT_MstAccountMaster(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstBrokerList :
                    objDAL.GetListT_MstBroker(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstCheckerList :
                    objDAL.GetListT_MstChecker(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstCompanyList :
                    objDAL.GetListT_MstCompany(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstCompanyDropdownList:
                    objDAL.GetListT_MstCompanyForDropDown(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstFinancialYearList :
                    objDAL.GetListT_MstFinancialYear(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstGroupList :
                    objDAL.GetListT_MstGroup(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstQualityList :
                    objDAL.GetListT_MstQuality(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstRoleList :
                    objDAL.GetListT_MstRole(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstTransportList :
                    objDAL.GetListT_MstTransport(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_MstWeaverList :
                    objDAL.GetListT_MstWeaver(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_TranCashList :
                    objDAL.GetListT_TranCash(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_TranJournalList :
                    objDAL.GetListT_TranJournal(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_TranPurchaseOrderList :
                    objDAL.GetListT_TranPurchaseOrder(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_TranSalesBillList :
                    objDAL.GetListT_TranSalesBill(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_TranSalesOrderList :
                    objDAL.GetListT_TranSalesOrder(objFilter, ref list);
                    break;
                case Common.DataSourceTypes.T_PrimKeyValuesList:
                    objDAL.GetListT_PrimKeyValues(objFilter, ref list);
                    break;
            }
            return list;
        }
        public DataBaseResultSet Save<T>(DataSourceTypes DataSourceTypes, T objFilter) where T : class, IModel, new()
        {
            DataBaseResultSet nResult = new DataBaseResultSet();
            switch (DataSourceTypes)
            {
                case Common.DataSourceTypes.T_ErrorDescSave :
                    nResult = objDAL.SaveT_ErrorDesc(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstAccountSave :
                    nResult = objDAL.SaveT_MstAccount(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstAccountMasterSave :
                    nResult = objDAL.SaveT_MstAccountMaster(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstBrokerSave :
                    nResult = objDAL.SaveT_MstBroker(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstCheckerSave :
                    nResult = objDAL.SaveT_MstChecker(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstCompanySave :
                    nResult = objDAL.SaveT_MstCompany(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstFinancialYearSave :
                    nResult = objDAL.SaveT_MstFinancialYear(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstGroupSave :
                    nResult = objDAL.SaveT_MstGroup(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstQualitySave :
                    nResult = objDAL.SaveT_MstQuality(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstRoleSave :
                    nResult = objDAL.SaveT_MstRole(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstTransportSave :
                    nResult = objDAL.SaveT_MstTransport(objFilter);
                    break;
                case Common.DataSourceTypes.T_MstWeaverSave :
                    nResult = objDAL.SaveT_MstWeaver(objFilter);
                    break;
                case Common.DataSourceTypes.T_TranCashSave :
                    nResult = objDAL.SaveT_TranCash(objFilter);
                    break;
                case Common.DataSourceTypes.T_TranJournalSave :
                    nResult = objDAL.SaveT_TranJournal(objFilter);
                    break;
                case Common.DataSourceTypes.T_TranPurchaseOrderSave :
                    nResult = objDAL.SaveT_TranPurchaseOrder(objFilter);
                    break;
                case Common.DataSourceTypes.T_TranSalesBillSave :
                    nResult = objDAL.SaveT_TranSalesBill(objFilter);
                    break;
                case Common.DataSourceTypes.T_TranSalesOrderSave :
                    nResult = objDAL.SaveT_TranSalesOrder(objFilter);
                    break;
            }

            if (nResult.ErrorCode != 0)
            {
                checkAndWriteDatabaseException<T>(objFilter, nResult, DataSourceTypes);
            }

            return nResult;
        }

        private void checkAndWriteDatabaseException<T>(T objData, DataBaseResultSet DBSet, DataSourceTypes DST) where T : class, IModel, new()
        {
            T_ErrorDesc objErrorData = WriteServiceErrorLog.GetErrorLog(DBSet, DST, objData.GetXmlString());
            string sMsg = string.Empty;
            DataBaseResultSet DBSetSaveError = objDAL.SaveT_ErrorDesc(objData);
        }
        
        public static BllClient objBllClient = new BllClient();
    }
}
