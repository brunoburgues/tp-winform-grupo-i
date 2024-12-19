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
//using Dominio;


namespace tpwinfom_grupo_i
{
    public partial class ArtículoVentana : Form
    {
        public ArtículoVentana()
        {
            InitializeComponent();
        }
        Articulo nuevoArticulo;

        //
        List<string> listaImagenes;
        //Métodos

        //Eventos
        private void ArtículoVentana_Load(object sender, EventArgs e)
        {
            pictureBoxImagenes.Load("https://www.pngkey.com/png/full/233-2332677_ega-png.png");
            CategoriaDB categoriaDB = new CategoriaDB();
            listaCategoría.DataSource = categoriaDB.listarCategoria();
            listaCategoría.DisplayMember = "Nombre";
            listaCategoría.ValueMember = "Id";
            MarcaDB marcaDB = new MarcaDB();
            listaMarca.DataSource = marcaDB.listarMarcas();
            listaMarca.DisplayMember = "Nombre";
            listaMarca.ValueMember = "Id";


            listaCategoría.SelectedIndex = -1;
            listaMarca.SelectedIndex = -1;

            
        }

        private void agregar_Click(object sender, EventArgs e)
        {   
            Articulo nuevo = new Articulo();
            ArticuloDB nuevoDB = new ArticuloDB();
            ImagenDB imagenesDB = new ImagenDB();
            try
            {
                nuevo.Codigo = cajaCódigo.Text;
                nuevo.Nombre = cajaNombre.Text;
                nuevo.Precio = decimal.Parse(cajaPrecio.Text);
                nuevo.Marca = (Marca)listaMarca.SelectedItem;
                nuevo.Categoria = (Categoria)listaCategoría.SelectedItem;
                nuevo.Descripcion = cajaDescripcion.Text;

                nuevoDB.agregar(nuevo);

                nuevo = nuevoDB.TraerUltimoArticulo();
                //Guarda una imagen por vez
                foreach (string imagen in listaImagenes)
                {
                    imagenesDB.AgregarImagen(nuevo.Id, imagen);
                }
                
                MessageBox.Show("Agregado exitoso");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void galeria_Click(object sender, EventArgs e)
        {
            Galeria ventanaGaleria = new Galeria();
            ventanaGaleria.ShowDialog();

            if (ventanaGaleria.Seleccionadas)
            {
                listaImagenes = ventanaGaleria.Imagenes;
                pictureBoxImagenes.Load(listaImagenes[0]);
            }
            
        }

        private void listaMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listaMarca.SelectedIndex;

            if (selectedIndex != -1)
            {
                listaMarca.SelectedItem = listaMarca.Items[selectedIndex];
            }
        }

        private void listaCategoría_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listaCategoría.SelectedIndex;

            if (selectedIndex != -1)
            {
                listaCategoría.SelectedItem = listaCategoría.Items[selectedIndex];
            }
        }
        private void eliminar_Click(object sender, EventArgs e)
        {
            ArticuloDB nuevo = new ArticuloDB();
            Articulo seleccionado;
            try
            {
               /* seleccionado = (Articulo)dgwArticulos.CurrentRow.DataBound;
                nuevo.eliminar(seleccionado.id);*/
                
            }
            catch (Exception)
            {
               
                throw;
            }
        }
    }
}
