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
            dgwArticulos.DataSource = list.FindAll(a => a.Nombre.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0);
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
    }
}
