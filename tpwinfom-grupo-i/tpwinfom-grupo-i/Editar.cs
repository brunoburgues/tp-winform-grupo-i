using BaseDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpwinfom_grupo_i
{
    public partial class Editar : Form
    {
        public Editar(int i)
        {
            InitializeComponent();
            if (i == 0)
            {
                lbObjeto.Text = "Marca";
                MarcaDB marcaDB = new MarcaDB();
                dgv.DataSource = marcaDB.listarMarcas();
            }else
            {
                lbObjeto.Text = "Categoria";
                CategoriaDB categoriaDB = new CategoriaDB();
                dgv.DataSource = categoriaDB.listarCategoria();
            }
            dgv.Columns["Id"].Visible = false;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (lbObjeto.Text == "Marca")
            {
                Marca marca = (Marca)dgv.CurrentRow.DataBoundItem;
                tbNombre.Text = marca.Nombre;
            }else
            {
                Categoria categoria = (Categoria)dgv.CurrentRow.DataBoundItem;
                tbNombre.Text = categoria.Nombre;
            }
        }
    }
}
