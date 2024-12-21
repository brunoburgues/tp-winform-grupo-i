using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDatos;
using Dominio;

namespace tpwinfom_grupo_i
{
    public partial class VisualizarImagenes : Form
    {
        Articulo articulo = null;
        List<Imagen> list = new List<Imagen>();
        ImagenDB imagenDB = new ImagenDB();
        bool articuloNuevo = false;
        public VisualizarImagenes()
        {
            articuloNuevo=true;
            InitializeComponent();
        }

        public VisualizarImagenes(Articulo articulo)
        {
            this.articulo = articulo;
            ImagenDB imagenDB = new ImagenDB();
            list = imagenDB.ListarImagenes(articulo.Id);
            InitializeComponent();
        }

        private void VisualizarImagenes_Load(object sender, EventArgs e)
        {
            if (list != null)
            {
                dgvImagenes.DataSource = list;
                dgvImagenes.Columns["Id"].Visible = false;               
            }
        }

        public void CargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbImagen.Load("https://www.pngkey.com/png/full/233-2332677_ega-png.png");
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (list != null)
            {
                Imagen imagen = new Imagen();
                if (dgvImagenes.CurrentRow != null)
                {
                    imagen = dgvImagenes.CurrentRow.DataBoundItem as Imagen;
                    CargarImagen(imagen.Url);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow.DataBoundItem != null)
            {
                DialogResult result = MessageBox.Show("Seguro que quieres eliminar esta imagen?", "Eliminar imagen", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {      
                    Imagen imagen = dgvImagenes.CurrentRow.DataBoundItem as Imagen;
                    imagenDB.EliminarImagen(imagen.Id);
                    listaImagenes();
                }
            }
        }

        private void listaImagenes()
        {
            if (articulo != null )
            {
                 list = imagenDB.ListarImagenes(articulo.Id);
                 dgvImagenes.DataSource = list;
            }else
            {
                dgvImagenes.DataSource = null;
                dgvImagenes.DataSource = list;
                dgvImagenes.Columns["Id"].Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbUrl.Text.Length == 0)
            {
                MessageBox.Show("Debes agregar una url");
            }
            else
            {
                if (articuloNuevo)
                {
                    Imagen nueva = new Imagen();
                    nueva.Id = 999;
                    nueva.Url = tbUrl.Text;
                    list.Add(nueva);
                    listaImagenes();
                    tbUrl.Text = "";
                }
                else
                {
                    string url = tbUrl.Text;
                    imagenDB.AgregarImagen(articulo.Id, url);
                    listaImagenes();
                    tbUrl.Text = "";
                }
            }
        }
    }
}
