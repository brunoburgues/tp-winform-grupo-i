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

        List<Articulo> listA = new List<Articulo>();
        List<Marca> listM = new List<Marca>();
        List<Categoria> listC = new List<Categoria>();
        int posicion;

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtículoVentana ventanaArticulo = new ArtículoVentana();
            ventanaArticulo.ShowDialog();
            cargarArticulos();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string busqueda = tbBusqueda.Text;
            switch (posicion)
            {
                case 0: 
                    List<Articulo> listaFiltrada = listA.FindAll(a => a.Nombre.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0);
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
                    break;

                case 1: 
                    List<Marca> listaFiltradaM = listM.FindAll(a => a.Nombre.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0);
                    dgwArticulos.DataSource = listaFiltradaM;
                    break;

                case 2:
                    List<Categoria> listaFiltradaC = listC.FindAll(a => a.Nombre.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0);
                    dgwArticulos.DataSource = listaFiltradaC;
                    break;

                default:
                    break;
            }
        }

        private void dgwArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Sugerencia: usar para ver detalles de articulos
            Articulo seleccionado = (Articulo)dgwArticulos.Rows[e.RowIndex].DataBoundItem;
            ArtículoVentana detalles = new ArtículoVentana(seleccionado,1);
            detalles.ShowDialog();
            cargarArticulos();
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
            dgwArticulos.DataSource = listA;
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar(0);
            editar.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Editar editar1 = new Editar(1); 
            editar1.ShowDialog();
        }

        private void cargarArticulos()
        {
            ArticuloDB articuloDB = new ArticuloDB();
            listA = articuloDB.ListarArticulos();
            dgwArticulos.DataSource = listA;
            dgwArticulos.Columns["Id"].Visible = false;
            dgwArticulos.Columns["Codigo"].Visible = false;
            dgwArticulos.Columns["Descripcion"].Visible = false;
            cbSeleccionarFiltro.Enabled=true;
            cbFiltro.Enabled=true;
            btnEliminarFiltros.Enabled=true;
            cbSeleccionarFiltro.Items.Clear();
            cbSeleccionarFiltro.Items.Add("Categoria");
            cbSeleccionarFiltro.Items.Add("Marca");
            posicion = 0;
        }

        private void cargarMarcas()
        {
            MarcaDB marcaDB = new MarcaDB();
            listM = marcaDB.listarMarcas();
            dgwArticulos.DataSource= listM;
            dgwArticulos.Columns["Id"].Visible=false;
            cbSeleccionarFiltro.Enabled=false;
            cbFiltro.Enabled=false;
            btnEliminarFiltros.Enabled=false;
            posicion=1;
        }

        private void cargarCategorias()
        {
            CategoriaDB categoriaDB = new CategoriaDB();
            listC = categoriaDB.listarCategoria();
            dgwArticulos.DataSource= listC;
            dgwArticulos.Columns["Id"].Visible=false;
            cbSeleccionarFiltro.Enabled=false;
            cbFiltro.Enabled=false;
            btnEliminarFiltros.Enabled=false;
            posicion=2;
        }

        private void btnVerMarcas_Click(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void btnVerArticulos_Click(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void btnVerCategorias_Click(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgwArticulos.CurrentRow.DataBoundItem;
                ArtículoVentana modificar = new ArtículoVentana(seleccionado);
                modificar.ShowDialog();
                cargarArticulos();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el Artículo a modificar en la tabla.", "Artículo No Seleccionado...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
