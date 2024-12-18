using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using BaseDatos;

namespace tpwinfom_grupo_i
{
    public partial class categoría : Form
    {
        public categoría()
        {
            InitializeComponent();
        }

        private void agregarMarca_Click(object sender, EventArgs e)
        {
            Marca nuevo = new Marca();
            MarcaDB nuevoDB = new MarcaDB();
            try
            {
                nuevo.Id = int.Parse(idMarca.Text);
                nuevo.Nombre = descripcionMarca.Text;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
