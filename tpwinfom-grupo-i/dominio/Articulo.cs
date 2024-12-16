using dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpwinfom_grupo_i
{
    public class Articulo
    {
        private int Id;
        private string Code;
        private string Name;
        private string Description;
        private float Price;
        private categoría Categoría;
        private marca Marca;
        private List<Imagen> Imagens;
    }

    public Articulo(int id, string name, string code, string description, float price, Marca marca, Categoría categoría, List<Imagen> lista)
    {
        this.Id = id;
        this.Code = code;
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Marca = marca;
        this.Categoría = categoría;
        this.Imagens = lista;
    }

   public int GetId()
    {
        return Id;
    }

    
}
