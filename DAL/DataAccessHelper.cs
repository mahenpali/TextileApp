 using System;                      
 using System.Collections.Generic;  
 using System.Linq;                 
 using System.Text;                 
 using Common;                      
 using System.Data.Common;          
 using TextileAppModel;                    
    
namespace DAL
{    
     public partial class DataAccessHelper
     {    
        SqlConnManager SqlConnManager = new SqlConnManager();
        
        private void FillDataFromReader<T>(DbDataReader DbReader, ref List<T> listData) where T : class, IModel, new()
        {    
            while (DbReader.Read())
            {
                T obj = new T();
                obj.FillDataFromDB(DbReader);
                listData.Add(obj);
            }
        }    
     }    
}    
