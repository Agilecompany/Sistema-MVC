using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCM.Data.Data.Base
{
    public abstract class BaseData
    {
        protected bool IsNew(long id)
        {
            return id == 0;
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["TCMConn"].ConnectionString);
        }
    }
}
