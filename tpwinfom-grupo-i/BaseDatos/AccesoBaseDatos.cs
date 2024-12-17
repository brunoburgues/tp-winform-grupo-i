﻿using System;
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

        public SqlDataReader Reader { get { return reader; } }

        public AccesoBaseDatos() 
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void SetConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void Lectura()
        {
            comando.Connection =  conexion;
            try
            {
                conexion.Open();
                reader = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void CloseConexion()
        {
            if (reader != null) 
                reader.Close();
            conexion.Close();
        }
    }
}