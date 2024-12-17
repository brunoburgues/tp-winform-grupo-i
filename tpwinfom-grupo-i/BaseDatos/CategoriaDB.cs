using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class CategoriaDB
    {
	    public List<Categoria> listarCategoria()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            AccesoBaseDatos datos = new AccesoBaseDatos();

            try
            {
                datos.SetConsulta("select Id, Descripcion from CATEGORIAS");
                datos.Lectura();
                while (datos.Reader.Read())
                {
                    Categoria c = new Categoria();
                    c.Id = (int)datos.Reader["Id"];
                    c.Nombre = (string)datos.Reader["Descripcion"];
                    listaCategorias.Add(c);
                }
                return listaCategorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CloseConexion(); }
        }	

    }
}
