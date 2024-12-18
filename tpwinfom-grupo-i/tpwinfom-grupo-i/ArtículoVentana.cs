using BaseDatos;
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


namespace tpwinfom_grupo_i
{
    public partial class ArtículoVentana : Form
    {
        public ArtículoVentana()
        {
            InitializeComponent();
        }

        private void ArtículoVentana_Load(object sender, EventArgs e)
        {
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
        {Articulo nuevo = new Articulo();
            ArticuloDB nuevoDB = new ArticuloDB();


            try
            {
                nuevo.Codigo = cajaCódigo.Text;
                nuevo.Nombre = cajaNombre.Text;
                nuevo.Precio = decimal.Parse(cajaPrecio.Text);
               // nuevo.Marca = listaCategoría.SelectedItem();
               // nuevo.Categoria = listaCategoría.SelectedItem();
                nuevo.Descripcion = Descripción.Text;

                nuevoDB.agregar(nuevo);
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
    }
}
