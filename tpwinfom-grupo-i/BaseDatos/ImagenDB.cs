using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    internal class ImagenDB
    {
        public List<Imagen> ListarImagenes(int id)
        {
			List<Imagen> lista = new List<Imagen>();
			AccesoBaseDatos db = new AccesoBaseDatos();
			try
			{
				db.SetConsulta("Select Id, ImagenUrl AS Imagen from IMAGENES where IdArticulo = " + id);
				db.Lectura();
				while(db.Reader.Read())
				{
                    Imagen auxI = new Imagen();

                    auxI.Id = (int)db.Reader["Id"];
                    auxI.Url = (string)db.Reader["Imagen"];
                    lista.Add(auxI);
                }
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				db.CloseConexion();
			}
        }
    }
}
