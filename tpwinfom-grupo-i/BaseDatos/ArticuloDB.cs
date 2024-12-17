﻿using System;
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
                    Articulo auxA = new Articulo();
                    auxA.Id = (int)db.Reader["Id"];
                    auxA.Codigo = (string)db.Reader["Codigo"];
                    auxA.Nombre = (string)db.Reader["Nombre"];
                    auxA.Descripcion = (string)db.Reader["Descripcion"];
                    auxA.Marca = new Marca();
                    auxA.Marca.Id = (int)db.Reader["IdMarca"];
                    auxA.Marca.Nombre = (string)db.Reader["Marca"];
                    auxA.Categoria = new Categoria();
                    auxA.Categoria.Id = (int)db.Reader["IdCategoria"];
                    auxA.Categoria.Nombre = (string)db.Reader["Categoria"];
                    auxA.Precio = (decimal)db.Reader["Precio"];
                    ImagenDB listaImagen = new ImagenDB();
                    List<Imagen> listaImagenes = listaImagen.ListarImagenes(auxA.Id);
                    auxA.Imagenes = listaImagenes;
                    
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
