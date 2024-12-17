using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Imagen(int id, string url)
        {
            Id = id;
            Url = url;
        }
        public int GetId() { return Id; }
        public string GetUrl() { return Url; }
        public void SetUrl(string url) { Url = url; }
    }
}
