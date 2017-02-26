using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

using TextileAppModel;
namespace DAL
{
    public delegate void TGenerateListFormReader<T>(DbDataReader objReader,ref List<T> listdata);
    public class SqlConnManager
    {
        #region :Variable
            SqlConnection objConnection;
            SqlConnectionStringBuilder objConnStringBuilder = new SqlConnectionStringBuilder();
        #endregion

        #region :Constructure
            public SqlConnManager()
            {
                DbConnParms = new DBConnctionParms { ConnectionString = Common.ConnctionSetting.ConStr };                   
            }

            public SqlConnManager(string ConStr)
            {
                //DbConnParms = new DBConnctionParms { ConnectionString = "Data Source=103.1.115.192;Initial Catalog=rajpuroh_water;User ID=rajpuroh_jcw;Password=Sakshi2011" };
                DbConnParms = new DBConnctionParms { ConnectionString = ConStr };
            }
        #endregion

        #region :Parameter
            public DBConnctionParms DbConnParms
            {
                set
                {
                    objConnStringBuilder.ConnectionString = value.ConnectionString;
                }
            }
        #endregion

        #region :Methods       
            #region :Private
                private DbCommand GetDbCommand(string sQuery)
                {
                    if (getConnected()){
                        return new SqlCommand(sQuery,objConnection);
                    }
                    else
                    {
                        return null;
                    }            
                }

                private DbType convertDatatype(GenericDataType dbType)
                {
                    DbType objDbType = DbType.String;
                    switch (dbType)
                    {
                        case GenericDataType.String :
                            objDbType = DbType.String;
                            break;
                        case GenericDataType.Int:
                            objDbType = DbType.Int32;
                            break;
                        case GenericDataType.Long:
                            objDbType = DbType.Int64;
                            break;
                        case GenericDataType.DateTime:
                            objDbType = DbType.DateTime;
                            break;
                        case GenericDataType.Bool:
                            objDbType = DbType.Boolean;
                            break;
                        case GenericDataType.Decimal:
                            objDbType = DbType.Decimal;
                            break;                       
                    }
                    return objDbType;
                }
            #endregion

            #region :Public
                private bool getConnected()
                {
                    bool bResult = false;
                    try
                    {
                        if (objConnection == null){
                            //objConnection = new SqlConnection(objConnStringBuilder.ConnectionString);
                            objConnection = new SqlConnection(Common.ConnctionSetting.ConStr);
                        }
                        switch (objConnection.State)
                        {
                            case ConnectionState.Broken:
                            case ConnectionState.Closed:
                                objConnection = null;
                                //objConnection = new SqlConnection(objConnStringBuilder.ConnectionString);
                                objConnection = new SqlConnection(Common.ConnctionSetting.ConStr);
                                objConnection.Open();
                                bResult = true;
                                break;
                            case ConnectionState.Connecting:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    return bResult;
                }
         
                public DbParameter GetConnParameters(string sParmId, string sSourceColumn , int nParmSize,GenericDataType DbTypeEnum, 
                                                     ParameterDirection ParmDirectionEnum , object objValue)
                {
                    SqlParameter objParm    = new SqlParameter();
                    objParm.ParameterName   = sParmId;
                    objParm.SourceColumn    = sSourceColumn;

                    if (nParmSize > 0){
                        objParm.Size = nParmSize;
                    }
                    objParm.DbType      = convertDatatype(DbTypeEnum);
                    objParm.Direction   = ParmDirectionEnum;
                    if (objParm != null){
                        objParm.Value = objValue;
                    }
                    return objParm;
                }

                public void GetList<T>(string sQuery, TGenerateListFormReader<T> hnd, ref List<T> listData)
                {
                    DbCommand objCommand;
                    try
                    {
                        objCommand = GetDbCommand(sQuery);
                        if (objCommand == null)
                        {
                            return;
                        }
                        objCommand.CommandType = CommandType.Text;
                        DbDataReader objReader = objCommand.ExecuteReader();
                        hnd(objReader, ref listData);
                        objReader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {                        
                        objConnection.Close();
                    }
                }

                public void GetList<T>(string sQuery, CommandType cmdtype, DbParameter[] parms, TGenerateListFormReader<T> hnd, ref List<T> listData)
                {
                    DbCommand objCommand;
                    try
                    {
                        objCommand = GetDbCommand(sQuery);
                        if (objCommand == null)
                        {
                            return;
                        }
                        objCommand.CommandType = cmdtype;
                        objCommand.Parameters.AddRange(parms);
                        DbDataReader objReader = objCommand.ExecuteReader();
                        hnd(objReader, ref listData);
                        objReader.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        objConnection.Close();
                    }
                }

                public int Save(string sQuery, CommandType cmdtype, DbParameter[] parms,out string sMessage)
                {
                    DbCommand objCommand = GetDbCommand(sQuery);
                    sMessage             = string.Empty;
                    if (objCommand == null)
                    {
                        return -1;
                    }
                    objCommand.CommandType  = cmdtype;
                    objCommand.Parameters.AddRange(parms);
                    objCommand.ExecuteNonQuery();
                    if (objCommand.Parameters["Message"].Value != null)
                    {
                        sMessage = objCommand.Parameters["Message"].Value.ToString();
                    }
                    objConnection.Close();
                    return 1;
                }

                public DataBaseResultSet Save(string sQuery, CommandType cmdtype, DbParameter[] parms)
                {
                    DbCommand objCommand    = GetDbCommand(sQuery);
                    DataBaseResultSet DBSet = new DataBaseResultSet();                    
                    if (objCommand == null)
                    {
                        return DBSet;
                    }
                    objCommand.CommandType = cmdtype;
                    objCommand.Parameters.AddRange(parms);
                    objCommand.ExecuteNonQuery();
                    if (objCommand.Parameters["Message"].Value != null)
                    {
                        DBSet.ErrorMessage = objCommand.Parameters["Message"].Value.ToString();
                    }
                    if (objCommand.Parameters["ErrorCode"].Value != null)
                    {
                        DBSet.ErrorCode = Convert.ToInt32(objCommand.Parameters["ErrorCode"].Value);
                    }
                    objConnection.Close();
                    return DBSet;
                }

            #endregion
        #endregion
    }

    public enum GenericDataType : short
    {
        String,
        Int,
        DateTime,
        Long,
        Bool,
        Decimal
    }

    public class DBConnctionParms
    {
        public string ConnectionString { get; set; }
    }
}
