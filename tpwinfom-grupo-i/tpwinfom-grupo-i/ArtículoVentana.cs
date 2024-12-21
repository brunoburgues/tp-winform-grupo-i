using BaseDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Dominio;


namespace tpwinfom_grupo_i
{
    public partial class ArtículoVentana : Form
    {
        //Variables Globales
        Articulo articulo = null;
        List<string> listaImagenes;

        public ArtículoVentana()
        {
            InitializeComponent();
        }
        public ArtículoVentana(Articulo modificarArt)
        {
            InitializeComponent();
            this.Text = "Modificar Artículo";
            agregar.Text = "Modificar";
            articulo = modificarArt;
        }
        
        //Métodos
        private bool modificarArticulo()
        {
            if (articulo == null)
            {
                return false;
            }
            return true;
        }
        private void cargarImagen(string url)
        {
            try
            {
                pictureBoxImagenes.Load(url);
            }
            catch (Exception ex)
            {
                pictureBoxImagenes.Load("https://www.pngkey.com/png/full/233-2332677_ega-png.png");
            }
        }
        //Eventos
        private void ArtículoVentana_Load(object sender, EventArgs e)
        {
            if (articulo == null)
            {
                pictureBoxImagenes.Load("");
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
            else
            {
                cajaCódigo.Text = articulo.Codigo;
                cajaNombre.Text = articulo.Nombre;
                cajaPrecio.Text = $"{articulo.Precio}";
                cajaDescripcion.Text = articulo.Descripcion;
                listaCategoría.SelectedItem = articulo.Categoria.Id;
                listaMarca.SelectedItem = articulo.Marca.Id;
                ImagenDB imagenesDB = new ImagenDB();
                List<Imagen> imagenes = imagenesDB.ListarImagenes(articulo.Id);
                listaImagenes = new List<string>();
                int contador = 0;

                foreach (Imagen imagen in imagenes)
                {
                    listaImagenes.Add(imagenes[contador].Url);
                    contador++;
                }
                //Muestra la primera imágen como previsualizacion.
                cargarImagen(listaImagenes[0]);
            }           
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            ImagenDB imagenesDB = new ImagenDB();
            
            try
            {
                articulo.Codigo = cajaCódigo.Text;
                articulo.Nombre = cajaNombre.Text;
                articulo.Precio = decimal.Parse(cajaPrecio.Text);
                articulo.Marca = (Marca)listaMarca.SelectedItem;
                articulo.Categoria = (Categoria)listaCategoría.SelectedItem;
                articulo.Descripcion = cajaDescripcion.Text;

                if (modificarArticulo())
                {
                    articuloDB.modificar(articulo);
                    //Las imágenes se Eliminan y Agregan en la BD en la Ventana Galeria
                    MessageBox.Show("Modificación Exitosa.");
                }
                else
                {
                    articuloDB.agregar(articulo);

                    articulo = articuloDB.TraerUltimoArticulo();
                    //Guarda una imagen por vez
                    foreach (string imagen in listaImagenes)
                    {
                        imagenesDB.AgregarImagen(articulo.Id, imagen);
                    }

                    MessageBox.Show("Agregado exitoso");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally { Close(); }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void galeria_Click(object sender, EventArgs e)
        {
            Galeria ventanaGaleria;
            if (modificarArticulo())
            {
                ventanaGaleria = new Galeria(articulo.Id);
            }
            else
            {
                ventanaGaleria = new Galeria();
            }

            ventanaGaleria.ShowDialog();

            if (ventanaGaleria.Seleccionadas)
            {
                listaImagenes = ventanaGaleria.Imagenes;
                pictureBoxImagenes.Load(listaImagenes[0]);
            }

        }

        private void listaMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marca selectedItem = (Marca)listaMarca.SelectedItem;

            if (selectedItem != null)
            {
                listaMarca.SelectedItem = listaMarca.Items[selectedItem.Id];
            }
        }

        private void listaCategoría_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria selectedItem = (Categoria)listaCategoría.SelectedItem;

            if (selectedItem != null)
            {
                listaCategoría.SelectedItem = listaCategoría.Items[selectedItem.Id];
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
