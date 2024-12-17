using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        private int Id;
        private string Nombre;

        public Categoria(int id, string nombre)
        {
            Id=id;
            Nombre=nombre;
        }
    }
}
