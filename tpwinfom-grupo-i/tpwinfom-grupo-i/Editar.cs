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
        List<Marca> marcas;
        List<Categoria> categorias;
        public Editar(int i)
        {
            InitializeComponent();
            if (i == 0)
            {
                lbObjeto.Text = "Marca";
                MarcaDB marcaDB = new MarcaDB();
                marcas = marcaDB.listarMarcas();
                dgv.DataSource = marcas;
            }else
            {
                lbObjeto.Text = "Categoria";
                CategoriaDB categoriaDB = new CategoriaDB();
                categorias = categoriaDB.listarCategoria(); 
                dgv.DataSource = categorias;
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

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (lbObjeto.Text == "Marca")
            {
                dgv.DataSource = marcas.FindAll(a => a.Nombre.IndexOf(tbBuscar.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }else
            {
                dgv.DataSource = categorias.FindAll(A => A.Nombre.IndexOf(tbBuscar.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
