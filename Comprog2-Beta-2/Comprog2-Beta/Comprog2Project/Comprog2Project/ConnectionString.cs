using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Comprog2Project
{

    /// <summary>
    /// this class will get the connection string from app config
    /// </summary>
    class ConnectionString
    {

        //get the connectionstring from app config
        internal static string ConnectionStrings { 
            get {

                var manager = ConfigurationManager.ConnectionStrings["My_Db_Credential"].ConnectionString.ToString();

                //check if null 
                if (manager == null)
                {
                    MessageBox.Show("Connection Has Not Establish");
                    return "";
                }
                return manager;
            }

        }

    }
}
