using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace BaseDatos
{
    public class ArticuloDB
    {
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoBaseDatos db = new AccesoBaseDatos();
            try
            {
                db.SetConsulta("Select A.Id, A.Codigo, Nombre, A.Descripcion, IdMarca, M.Descripcion Marca, IdCategoria, C.Descripcion Categoria, Precio from ARTICULOS A inner join MARCAS M on A.IdMarca = M.Id inner join CATEGORIAS C on A.IdCategoria = C.Id ");
                db.Lectura();
                while (db.Reader.Read())
                {
                    int id = (int)db.Reader["Id"];
                    string codigo = (string)db.Reader["Codigo"];
                    string nombre = (string)db.Reader["Nombre"];
                    string descripcion = (string)db.Reader["Descripcion"];
                    int idM = (int)db.Reader["IdMarca"];
                    string marca = (string)db.Reader["Marca"];
                    Marca auxM = new Marca(idM, marca);
                    int idC = (int)db.Reader["IdCategoria"];
                    string categoria = (string)db.Reader["Categoria"];
                    Categoria auxC = new Categoria(idC, categoria);
                    decimal precio = (decimal)db.Reader["Precio"];
                    ImagenDB listaImagen = new ImagenDB();
                    List<Imagen> listaImagenes = listaImagen.ListarImagenes(id);
                    Articulo auxA = new Articulo(id, codigo, nombre, descripcion, auxM, auxC, precio, listaImagenes);
                    lista.Add(auxA);
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
