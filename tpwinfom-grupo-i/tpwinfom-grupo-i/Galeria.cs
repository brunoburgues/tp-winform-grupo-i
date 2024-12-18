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
    public partial class Galeria : Form
    {
        public Galeria()
        {
            InitializeComponent();
        }
        List<string> rutas = new List<string>();
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
                else { return false; }
            }
        }

        //Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            if (listarRutasLocales())
            {
                cargarImagen(imagenes[indiceListaRutas]);
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = imagenes.Count > 1;
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
            }
            else
            {
                MessageBox.Show("Por favor ingrese una URL válida.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
