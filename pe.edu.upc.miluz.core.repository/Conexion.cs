using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace pe.edu.upc.miluz.core.repository
{
    public class Conexion
    {
        public SqlConnection GetConexion()
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager
                .ConnectionStrings["cn"]
                .ConnectionString
                );
            return cn;
        }
    }
}
