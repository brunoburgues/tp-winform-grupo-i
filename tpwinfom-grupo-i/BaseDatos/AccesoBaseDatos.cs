using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaseDatos
{
    public class AccesoBaseDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader reader;

        public AccesoBaseDatos() {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }

    }
}
