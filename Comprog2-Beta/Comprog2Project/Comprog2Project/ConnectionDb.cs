using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Comprog2Project
{
   public class ConnectionDb
    {
        public static SqlConnection Connection = new SqlConnection();
        public static SqlCommand Command = new SqlCommand();
        public static SqlDataAdapter Adapter = new SqlDataAdapter();
        public static DataSet dataSet = new DataSet();
        public static string QueryCommand;
    
    }
}
