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

namespace tpwinfom_grupo_i
{
    public partial class Agregar : Form
    {
        public Agregar(int Id)
        {
            InitializeComponent();
            if (Id > 0)
            {
                lblObjeto.Text = "Categoria";
            }else
            {
                lblObjeto.Text = "Marca";
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "") 
            {
                 if (lblObjeto.Text == "Marca")
                 {
                    MarcaDB marcaDB = new MarcaDB();
                    marcaDB.agregar(tbNombre.Text);
                 }else
                 {
                    CategoriaDB categoriaDB = new CategoriaDB();
                    categoriaDB.agregar(tbNombre.Text);
                 }
                 this.Close();
            }else
            {
                lbNombre.ForeColor = Color.Red;
            }
        }
    }
}
