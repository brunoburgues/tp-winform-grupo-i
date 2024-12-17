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
    public partial class menuPrincipalVentana : Form
    {
        public menuPrincipalVentana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloDB articuloDB = new ArticuloDB();
            List<Articulo> list = articuloDB.ListarArticulos();
            dataGridView1.DataSource = list;
        }
    }
}
