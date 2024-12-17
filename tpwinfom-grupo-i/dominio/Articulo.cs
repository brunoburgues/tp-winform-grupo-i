using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        private int Id;
        private string Codigo;    
        private string Nombre;
        private string Descripcion;
        private List<Imagen> Imagenes;
        private Marca Marca;
        private Categoria Categoria;

        public Articulo(int id, string codigo, string nombre, string descripcion, Marca marca, Categoria categoria)
        {
            Id=id;
            Codigo=codigo;
            Nombre=nombre;
            Descripcion=descripcion;
            Marca=marca;
            Categoria=categoria;
        }
    }
}
