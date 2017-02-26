using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.ComponentModel;
namespace TextileAppModel
{
    public class T_PrimKeyValues : IModel
    {
        public int PrimKeyTable { get; set; }
        public long PrimKeyValue { get; set; }
        public DataBaseOperation OperationFlag { get; set; }

        public void FillDataFromDB(IDataRecord DBReader)
        {
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PrimKeyId")))
            {
                this.PrimKeyTable = DBReader.GetInt32(DBReader.GetOrdinal("PrimKeyId"));
            }
            if (!DBReader.IsDBNull(DBReader.GetOrdinal("PrimKeyValue")))
            {
                this.PrimKeyValue = DBReader.GetInt64(DBReader.GetOrdinal("PrimKeyValue"));
            }
        }

        public string GetXmlString()
        {
            return string.Empty;
        }

        public void Clone<T>(T obj) where T : class, IModel
        { }

        public T Copy<T>() where T : class, IModel, new()
        {
            return null;
        }

        public void ResetData()
        {
            this.PrimKeyTable = 0;
            this.PrimKeyValue = 0;
        }
    }
}
