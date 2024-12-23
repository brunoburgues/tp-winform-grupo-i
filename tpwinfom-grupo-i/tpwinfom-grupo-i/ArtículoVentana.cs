using BaseDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
        List<Imagen> imagenesExtraidasDB;
        int posicion = 0;

        public ArtículoVentana()
        {
            InitializeComponent();
        }
        public ArtículoVentana(Articulo articulo, int posicion)
        {
            InitializeComponent();
            this.posicion = posicion;
            switch (this.posicion)
            {
                case 0:
                    break;

                case 1:
                    this.Text = "Modificar Artículo";
                    agregar.Text = "Modificar";
                    this.articulo = articulo;
                    break;

                case 2:
                    this.Text = "Detalles Artículo";
                    this.articulo = articulo;
                    tbCodigo.Enabled = false;
                    btnEliminar.Enabled = false;
                    cajaNombre.Enabled = false;
                    cajaPrecio.Enabled = false;
                    cajaDescripcion.Enabled = false;
                    cbCategoria.Enabled = false;
                    cbMarca.Enabled =false;
                    agregar.Enabled = false;
                    break;

                default:
                    break;
            }         
        }
        //Métodos
        private void listarImagenes()
        {
            ImagenDB imagenesDB = new ImagenDB();
            imagenesExtraidasDB = imagenesDB.ListarImagenes(articulo.Id);
        }
        private List<string> extraerUrl()
        {
            int contador = 0;

            foreach (Imagen imagen in imagenesExtraidasDB)
            {
                listaImagenes.Add(imagenesExtraidasDB[contador].Url);
                contador++;
            }
            return listaImagenes;
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
            CategoriaDB categoriaDB = new CategoriaDB();
            MarcaDB marcaDB = new MarcaDB();
            try
            {
                cbCategoria.DataSource = categoriaDB.listarCategoria();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Nombre";
                cbMarca.DataSource = marcaDB.listarMarcas();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Nombre";
                if (articulo == null)
                {
                    pictureBoxImagenes.Load("https://www.pngkey.com/png/full/233-2332677_ega-png.png");
                    cbCategoria.SelectedIndex = -1;
                    cbMarca.SelectedIndex = -1;
                    imagenes.Visible = false;
                    btnEliminar.Visible = false;
                }
                else
                {
                    tbCodigo.Text = articulo.Codigo;
                    cajaNombre.Text = articulo.Nombre;
                    cajaPrecio.Text = $"{articulo.Precio}";
                    cajaDescripcion.Text = articulo.Descripcion;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    if (articulo.Imagenes.Count > 0)
                    {
                        listarImagenes();
                        listaImagenes = new List<string>();
                        extraerUrl();
                        cargarImagen(listaImagenes[0]);
                    }
                    btnEliminar.Visible = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }          
        }
        private void agregar_Click(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            ImagenDB imagenesDB = new ImagenDB();
            try
            {
                if (articulo != null)
                {
                    establecerArticulo();
                    articuloDB.modificar(articulo);
                    //Las imágenes se Eliminan y Agregan en la BD en la Ventana Galeria
                    MessageBox.Show("Se modifico exitosamente.");
                }
                else
                {
                    articulo = new Articulo();
                    establecerArticulo();
                    articuloDB.agregar(articulo);
                    DialogResult result = MessageBox.Show("Deseas agregar imagenes", "Agregar imagenes", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        articulo = articuloDB.TraerUltimoArticulo();
                        VisualizarImagenes visualizar = new VisualizarImagenes(articulo, false);
                        visualizar.ShowDialog();
                    }
                    MessageBox.Show("Se agrego exitosamente");
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
            VisualizarImagenes ventanaGaleria;

            if (articulo == null)
            {
                ventanaGaleria = new VisualizarImagenes();
            }
            else if (posicion == 1)
            {
                ventanaGaleria = new VisualizarImagenes(articulo, false);
            }else
            {
                ventanaGaleria = new VisualizarImagenes(articulo, true);
            }
            ventanaGaleria.ShowDialog();
        }
        private void eliminar_Click(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            try
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar este articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    articuloDB.eliminar(articulo.Id);
                    MessageBox.Show("Se ha eliminado el articulo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
        }
        private void establecerArticulo()
        {
            articulo.Codigo = tbCodigo.Text;
            articulo.Nombre = cajaNombre.Text;
            articulo.Precio = decimal.Parse(cajaPrecio.Text);
            articulo.Marca = (Marca)cbMarca.SelectedItem;
            articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
            articulo.Descripcion = cajaDescripcion.Text;
        }

        private void cajaPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; 
            }
        }
    }
}
