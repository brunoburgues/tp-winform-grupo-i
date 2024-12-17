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

        public int GetId() { return Id; }
        public string GetCodigo() { return Codigo; }
        public void SetCodigo(string codigo) { Codigo = codigo; }
        public string GetNombre() { return Nombre; }
        public void SetNombre(string nombre) { Nombre = nombre; }
        public string GetDescripcion() { return Descripcion; }
        public void SetDescripcion(string descripcion) { Descripcion = descripcion; }
        public Marca GetMarca() { return Marca; } 
        public void SetMarca(Marca marca) { Marca = marca; }
        public Categoria GetCategoria() { return Categoria; }
        public void SetCategoria(Categoria categoria) { Categoria = categoria; }
        public List<Imagen> GetImagenes() { return Imagenes; }
        public void SetImagenes(List<Imagen> Imagenes) { Imagenes.Clear(); }
    }
}
