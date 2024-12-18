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
    public partial class ArtículoVentana : Form
    {
        public ArtículoVentana()
        {
            InitializeComponent();
        }
        Articulo nuevoArticulo;
        //Métodos
        
        //Eventos
        private void ArtículoVentana_Load(object sender, EventArgs e)
        {
            pictureBoxImagenes.Load("https://www.pngkey.com/png/full/233-2332677_ega-png.png");
            CategoriaDB categoriaDB = new CategoriaDB();
            listaCategoría.DataSource = categoriaDB.listarCategoria();
            listaCategoría.ValueMember = "Id";
            listaCategoría.DisplayMember = "Nombre";
            MarcaDB marcaDB = new MarcaDB();
            listaMarca.DataSource = marcaDB.listarMarcas();
            listaMarca.ValueMember = "Id";
            listaMarca.DisplayMember = "Nombre";


            listaCategoría.SelectedIndex = -1;
            listaMarca.SelectedIndex = -1;

            
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            nuevoArticulo = new Articulo();
            nuevoArticulo.Codigo = cajaCódigo.Text;
            nuevoArticulo.Nombre = cajaNombre.Text;
            nuevoArticulo.Marca.Id = listaMarca.SelectedIndex;
            nuevoArticulo.Categoria.Id = listaCategoría.SelectedIndex;
            nuevoArticulo.Descripcion = cajaDescripcion.Text;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void galeria_Click(object sender, EventArgs e)
        {
            Galeria ventanaGaleria = new Galeria();
            ventanaGaleria.ShowDialog();
        }
    }
}
