using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpwinfom_grupo_i
{
    public class Artículo
    {
        private int Id;
        private string Code;
        private string Name;
        private string Description;
        private float Price;
        private categoría Categoría;
        private marca Marca;
        private List<imágen> Imagens;
    }
}
