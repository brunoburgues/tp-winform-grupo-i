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
    public partial class Galeria : Form
    {
        public Galeria()
        {
            InitializeComponent();
        }
        public List<string> Imagenes { get; set;}
        public bool Seleccionadas {  get; set;}

        List<string> imagenes = new List<string>();
        private int indiceListaRutas = 0;
        //Métodos
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
                    imagenes.AddRange(openFileDialog.FileNames);
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
            if (imagenes.Count == 0)
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = imagenes.Count > 1;
                btnEliminar.Enabled = imagenes.Count >= 1;
            }

            if (listarRutasLocales())
            {
                indiceListaRutas = imagenes.Count - 1;
                cargarImagen(imagenes[indiceListaRutas]);
                if (imagenes.Count > 1)
                {
                    btnAnterior.Enabled = imagenes.Count > 1;
                    btnSiguiente.Enabled = false;
                    btnEliminar.Enabled = imagenes.Count >= 1; 
                }
            }
            
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(indiceListaRutas < imagenes.Count - 1)
            {
                indiceListaRutas++;
               cargarImagen(imagenes[indiceListaRutas]);
                btnAnterior.Enabled = true;
                if (indiceListaRutas == imagenes.Count - 1)
                {
                    btnSiguiente.Enabled = false;
                }
            }
            else if (indiceListaRutas == imagenes.Count - 1)
            {
                btnEliminar.Enabled = imagenes.Count > 0;
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = false;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceListaRutas > 0)
            {
                indiceListaRutas--;
                cargarImagen(imagenes[indiceListaRutas]);
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
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnEliminar.Enabled = false;
            cargarImagen("https://www.pngkey.com/png/full/233-2332677_ega-png.png");
        }

        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {
            string nuevoUrl = txtUrl.Text;
            if (!string.IsNullOrEmpty(nuevoUrl))
            {
                if (imagenes.Count > 0)
                {
                    imagenes.Add(nuevoUrl);
                    indiceListaRutas = imagenes.Count - 1;
                    cargarImagen(imagenes[indiceListaRutas]);
                    txtUrl.Clear();
                    btnAnterior.Enabled= true;
                    btnSiguiente.Enabled = false;
                }
                else if (imagenes.Count == 0)
                {
                    imagenes.Add(nuevoUrl);
                    cargarImagen(imagenes[indiceListaRutas]);
                    txtUrl.Clear();
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = imagenes.Count > 1;
                    btnEliminar.Enabled = imagenes.Count >= 1;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese una URL válida.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (imagenes.Count > 0)
            {
                Seleccionadas = true;
                Imagenes = imagenes;
                Close();
            }
            else
            {
                Seleccionadas = false;
                MessageBox.Show("No se ha seleccionado ninguna imagen.", "Imágenes Seleccionadas...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (imagenes.Count > 0)
            {
                imagenes.RemoveAt(indiceListaRutas);
                
                if (imagenes.Count == 0)
                {
                    cargarImagen("");
                    btnEliminar.Enabled = false;
                    MessageBox.Show("No hay imágenes seleccionadas.", "Sin imágenes...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if(imagenes.Count == 1)
                {
                    cargarImagen(imagenes[indiceListaRutas - 1]);
                    btnEliminar.Enabled = true;
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    

                }
                else
                {
                    cargarImagen(imagenes[indiceListaRutas - 1]);
                    btnEliminar.Enabled = true;
                    if (indiceListaRutas == imagenes.Count -1)
                    {
                        btnAnterior.Enabled = true;
                        btnSiguiente.Enabled = false;
                    }
                    else
                    {
                        btnSiguiente.Enabled=true;
                    }
                }

                if (indiceListaRutas > 0)
                {
                    indiceListaRutas--;
                }
            }
            else
            {
                cargarImagen("");
                btnEliminar.Enabled = false;
                MessageBox.Show("No hay imágenes seleccionadas.", "Sin imágenes...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Galeria_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (imagenes.Count == 0)
            {
                Seleccionadas = false;
            }
        }
    }
}
