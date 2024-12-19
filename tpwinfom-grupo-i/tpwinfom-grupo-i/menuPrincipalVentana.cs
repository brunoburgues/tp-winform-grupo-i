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
    public partial class menuPrincipalVentana : Form
    {
        public menuPrincipalVentana()
        {
            InitializeComponent();
        }

        List<Articulo> list = new List<Articulo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            list = articuloDB.ListarArticulos();
            dgwArticulos.DataSource = list;
            dgwArticulos.Columns["Id"].Visible = false;
            dgwArticulos.Columns["Codigo"].Visible = false;
            dgwArticulos.Columns["Descripcion"].Visible = false;

            cbSeleccionarFiltro.Items.Add("Categoria");
            cbSeleccionarFiltro.Items.Add("Marca");
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtículoVentana ventanaArticulo = new ArtículoVentana();
            ventanaArticulo.ShowDialog();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string busqueda = tbBusqueda.Text;
            List<Articulo> listaFiltrada = list.FindAll(a => a.Nombre.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0);
            if (cbSeleccionarFiltro.SelectedIndex == 0)
            {
                Categoria categoria = (Categoria)cbFiltro.SelectedItem;
                listaFiltrada = listaFiltrada.FindAll(A => A.Categoria.Id == categoria.Id);
            }
            if (cbSeleccionarFiltro.SelectedIndex == 1)
            {
                Marca marca = (Marca)cbFiltro.SelectedItem;
                listaFiltrada = listaFiltrada.FindAll(A => A.Marca.Id == marca.Id);
            }
            dgwArticulos.DataSource = listaFiltrada;
        }

        private void dgwArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo seleccionado = (Articulo)dgwArticulos.Rows[e.RowIndex].DataBoundItem; 
        }

        private void cbSeleccionarFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeleccionarFiltro.SelectedIndex == 0)
            {
                CategoriaDB categoriaDB = new CategoriaDB();
                cbFiltro.DataSource = categoriaDB.listarCategoria();
            }

            if (cbSeleccionarFiltro.SelectedIndex == 1)
            {
                MarcaDB marcaDB = new MarcaDB();
                cbFiltro.DataSource = marcaDB.listarMarcas();
            }
        }

        private void btnEliminarFiltros_Click(object sender, EventArgs e)
        {
            if (cbSeleccionarFiltro.SelectedIndex >= 0)
            {
                cbSeleccionarFiltro.SelectedIndex = -1;
                cbFiltro.DataSource = null;
            }
            tbBusqueda.Text = "";
            dgwArticulos.DataSource = list;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar(0);
            agregar.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar(1);
            agregar.ShowDialog();
        }
    }
}
