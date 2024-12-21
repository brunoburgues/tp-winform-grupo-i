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
using System.Collections;
namespace tpwinfom_grupo_i
{
    public partial class Galeria : Form
    {
        public Galeria()
        {
            InitializeComponent();
            ModificarImagenes = false;
        }
        public Galeria(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            if (articulo.Imagenes.Count > 0 )
            {
                ModificarImagenes = true;
            }
        }
        public List<string> Imagenes { get; set;}
        public List<Imagen> ImagenesConId { get; set; }
        public bool Seleccionadas {  get; set;}
        public bool ModificarImagenes { get; set;}
        private List<string> imagenes = new List<string>();
        private List<Imagen> listaModificarImg;
        private int indiceListaRutas = 0;
        private Articulo articulo;
        //Métodos
        private int contadorElementos(List<Imagen> listaImagen, List<String> listaStrings)
        {
            if (ModificarImagenes)
            {
                return listaImagen.Count();

            }
            return listaStrings.Count();
        }
        private void cargarImagen(string url)
        {
            try
            {
                pictureBoxGaleria.Load(url);
            }
            catch (Exception ex)
            {
                pictureBoxGaleria.Load("https://www.pngkey.com/png/full/233-2332677_ega-png.png");
            }
        }
        private bool listarRutasLocales()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (ModificarImagenes)
                    {
                        ImagenDB imagenDB = new ImagenDB();
                        imagenes.AddRange(openFileDialog.FileNames);
                        foreach (string imagen in imagenes)
                        {
                            imagenDB.AgregarImagen(articulo.Id, imagen);
                        }

                        listaModificarImg = imagenDB.ListarImagenes(articulo.Id);
                    }
                    else
                    {
                        imagenes.AddRange(openFileDialog.FileNames);

                    }
                    return true;
                }
                return false;
            }
        }

        //Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Seleccionadas = false;
            Close();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            if (contadorElementos(listaModificarImg, imagenes) == 0)
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = contadorElementos(listaModificarImg, imagenes) > 1;
                btnEliminar.Enabled = contadorElementos(listaModificarImg, imagenes) >= 1;
            }

            if (listarRutasLocales())
            {
                indiceListaRutas = contadorElementos(listaModificarImg, imagenes) - 1;
                if (ModificarImagenes)
                {
                    cargarImagen(listaModificarImg[indiceListaRutas].Url);

                }
                else
                {
                    cargarImagen(imagenes[indiceListaRutas]);

                }
                if (contadorElementos(listaModificarImg, imagenes) > 1)
                {
                    btnAnterior.Enabled = contadorElementos(listaModificarImg, imagenes) > 1;
                    btnSiguiente.Enabled = false;
                    btnEliminar.Enabled = contadorElementos(listaModificarImg, imagenes) >= 1; 
                }
            }
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(indiceListaRutas < contadorElementos(listaModificarImg, imagenes) - 1)
            {
                indiceListaRutas++;
                if (ModificarImagenes)
                {
                    cargarImagen(listaModificarImg[indiceListaRutas].Url);

                }
                else
                {
                    cargarImagen(imagenes[indiceListaRutas]);

                }
                btnAnterior.Enabled = true;
                if (indiceListaRutas == contadorElementos(listaModificarImg, imagenes)- 1)
                {
                    btnSiguiente.Enabled = false;
                }
            }
            else if (indiceListaRutas == contadorElementos(listaModificarImg, imagenes) - 1)
            {
                btnEliminar.Enabled = contadorElementos(listaModificarImg, imagenes) > 0;
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = false;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceListaRutas > 0)
            {
                indiceListaRutas--;
                if (ModificarImagenes)
                {
                    cargarImagen(listaModificarImg[indiceListaRutas].Url);

                }
                else
                {
                    cargarImagen(imagenes[indiceListaRutas]);

                }
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;

                if (indiceListaRutas == 0)
                {
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = true;
                }
            }
        }

        private void Galeria_Load(object sender, EventArgs e)
        {
            if (ModificarImagenes)
            {
                ImagenDB imagenDB = new ImagenDB();
                listaModificarImg = imagenDB.ListarImagenes(articulo.Id);
                cargarImagen(listaModificarImg[indiceListaRutas].Url);
            }
            else
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                btnEliminar.Enabled = false;
                cargarImagen("");
            }
        }

        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {
            string nuevoUrl = txtUrl.Text;
            if (!string.IsNullOrEmpty(nuevoUrl))
            {
                if (contadorElementos(listaModificarImg, imagenes) > 0)
                {
                    if (ModificarImagenes)
                    {
                        ImagenDB imagenDB = new ImagenDB();
                        imagenDB.AgregarImagen(articulo.Id, nuevoUrl);
                        listaModificarImg = imagenDB.ListarImagenes(articulo.Id);
                        indiceListaRutas = contadorElementos(listaModificarImg, imagenes) - 1;
                        cargarImagen(listaModificarImg[indiceListaRutas].Url);
                    }
                    else
                    {
                        imagenes.Add(nuevoUrl);
                        indiceListaRutas = contadorElementos(listaModificarImg, imagenes) - 1;
                        cargarImagen(imagenes[indiceListaRutas]);
                    }
                    
                    txtUrl.Clear();
                    btnAnterior.Enabled= true;
                    btnSiguiente.Enabled = false;
                }
                else if (contadorElementos(listaModificarImg, imagenes) == 0)
                {
                    if (ModificarImagenes)
                    {
                        ImagenDB imagenDB = new ImagenDB();
                        imagenDB.AgregarImagen(articulo.Id, nuevoUrl);
                        listaModificarImg = imagenDB.ListarImagenes(articulo.Id);
                    }
                    else
                    {
                        imagenes.Add(nuevoUrl);
                    }
                    cargarImagen(imagenes[indiceListaRutas]);
                    txtUrl.Clear();
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = contadorElementos(listaModificarImg, imagenes) > 1;
                    btnEliminar.Enabled = contadorElementos(listaModificarImg, imagenes) >= 1;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese una URL válida.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (contadorElementos(listaModificarImg, imagenes) > 0)
                {
                    Seleccionadas = true;
                    Imagenes = imagenes;
                }
                else
                {
                    Seleccionadas = false;
                    MessageBox.Show("No se ha seleccionado ninguna imagen.", "Imágenes Seleccionadas...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { Close(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contadorElementos(listaModificarImg, imagenes) > 0)
            {
                if (ModificarImagenes)
                {
                    DialogResult resultado = MessageBox.Show("¿Deseas eliminar la imagen? IMPORTANTE: Se eliminará de forma permanente.", "Confirmación Eliminar...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        ImagenDB imagenDB = new ImagenDB();
                        imagenDB.EliminarImagen(listaModificarImg[indiceListaRutas].Id);
                        MessageBox.Show("Imagen eliminada de la BD", "Imagen Eliminada...");
                        listaModificarImg = imagenDB.ListarImagenes(articulo.Id);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    imagenes.RemoveAt(indiceListaRutas);
                }

                if (indiceListaRutas >= contadorElementos(listaModificarImg, imagenes))
                {
                    indiceListaRutas--; 
                }

                if (contadorElementos(listaModificarImg, imagenes) == 0)
                {
                    cargarImagen("");
                    btnEliminar.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    MessageBox.Show("No hay imágenes seleccionadas.", "Sin imágenes...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (ModificarImagenes)
                    {
                        cargarImagen(listaModificarImg[indiceListaRutas].Url);
                    }
                    else
                    {
                        cargarImagen(imagenes[indiceListaRutas]);
                    }

                    btnEliminar.Enabled = true;
                    btnAnterior.Enabled = indiceListaRutas > 0;
                    btnSiguiente.Enabled = indiceListaRutas < contadorElementos(listaModificarImg, imagenes) - 1;
                }
            }
            else
            {
                cargarImagen("");
                btnEliminar.Enabled = false;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                MessageBox.Show("No hay imágenes seleccionadas.", "Sin imágenes...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private void Galeria_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (contadorElementos(listaModificarImg, imagenes) == 0)
            {
                Seleccionadas = false;
            }
        }
    }
}
