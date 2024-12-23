namespace tpwinfom_grupo_i
{
    partial class menuPrincipalVentana
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.listaArticulo = new System.Windows.Forms.Label();
            this.dgwArticulos = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbSeleccionarFiltro = new System.Windows.Forms.ComboBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnEliminarFiltros = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVerArticulos,
            this.btnVerMarcas,
            this.btnVerCategorias});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 22);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // btnVerArticulos
            // 
            this.btnVerArticulos.Name = "btnVerArticulos";
            this.btnVerArticulos.Size = new System.Drawing.Size(130, 22);
            this.btnVerArticulos.Text = "Articulos";
            this.btnVerArticulos.Click += new System.EventHandler(this.btnVerArticulos_Click);
            // 
            // btnVerMarcas
            // 
            this.btnVerMarcas.Name = "btnVerMarcas";
            this.btnVerMarcas.Size = new System.Drawing.Size(130, 22);
            this.btnVerMarcas.Text = "Marcas";
            this.btnVerMarcas.Click += new System.EventHandler(this.btnVerMarcas_Click);
            // 
            // btnVerCategorias
            // 
            this.btnVerCategorias.Name = "btnVerCategorias";
            this.btnVerCategorias.Size = new System.Drawing.Size(130, 22);
            this.btnVerCategorias.Text = "Categorias";
            this.btnVerCategorias.Click += new System.EventHandler(this.btnVerCategorias_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarArticulo,
            this.modificarToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(125, 22);
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarMarca,
            this.btnEditarMarca});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(116, 22);
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(116, 22);
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarCategoria,
            this.btnEditarCategoria});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(116, 22);
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(116, 22);
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // listaArticulo
            // 
            this.listaArticulo.AutoSize = true;
            this.listaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaArticulo.Location = new System.Drawing.Point(27, 24);
            this.listaArticulo.Name = "listaArticulo";
            this.listaArticulo.Size = new System.Drawing.Size(211, 29);
            this.listaArticulo.TabIndex = 2;
            this.listaArticulo.Text = "Lista de artículos";
            // 
            // dgwArticulos
            // 
            this.dgwArticulos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgwArticulos.AllowUserToOrderColumns = true;
            this.dgwArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwArticulos.Location = new System.Drawing.Point(32, 124);
            this.dgwArticulos.MultiSelect = false;
            this.dgwArticulos.Name = "dgwArticulos";
            this.dgwArticulos.ReadOnly = true;
            this.dgwArticulos.RowHeadersWidth = 62;
            this.dgwArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwArticulos.Size = new System.Drawing.Size(444, 173);
            this.dgwArticulos.TabIndex = 3;
            this.dgwArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArticulos_CellDoubleClick);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.Color.White;
            this.btnBusqueda.Location = new System.Drawing.Point(255, 57);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(115, 20);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(32, 57);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(217, 20);
            this.tbBusqueda.TabIndex = 5;
            // 
            // cbSeleccionarFiltro
            // 
            this.cbSeleccionarFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccionarFiltro.FormattingEnabled = true;
            this.cbSeleccionarFiltro.Location = new System.Drawing.Point(32, 83);
            this.cbSeleccionarFiltro.Name = "cbSeleccionarFiltro";
            this.cbSeleccionarFiltro.Size = new System.Drawing.Size(106, 21);
            this.cbSeleccionarFiltro.TabIndex = 6;
            this.cbSeleccionarFiltro.SelectedIndexChanged += new System.EventHandler(this.cbSeleccionarFiltro_SelectedIndexChanged);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(144, 83);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(106, 21);
            this.cbFiltro.TabIndex = 7;
            // 
            // btnEliminarFiltros
            // 
            this.btnEliminarFiltros.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFiltros.Location = new System.Drawing.Point(255, 84);
            this.btnEliminarFiltros.Name = "btnEliminarFiltros";
            this.btnEliminarFiltros.Size = new System.Drawing.Size(115, 20);
            this.btnEliminarFiltros.TabIndex = 8;
            this.btnEliminarFiltros.Text = "Eliminar filtros";
            this.btnEliminarFiltros.UseVisualStyleBackColor = false;
            this.btnEliminarFiltros.Click += new System.EventHandler(this.btnEliminarFiltros_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(29, 304);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(254, 13);
            this.lblInformacion.TabIndex = 9;
            this.lblInformacion.Text = "*Para ver los detalles de un articulo haga doble click";
            // 
            // menuPrincipalVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 326);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnEliminarFiltros);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.cbSeleccionarFiltro);
            this.Controls.Add(this.tbBusqueda);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.dgwArticulos);
            this.Controls.Add(this.listaArticulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuPrincipalVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarArticulo;
        private System.Windows.Forms.Label listaArticulo;
        private System.Windows.Forms.DataGridView dgwArticulos;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem btnEditarMarca;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarCategoria;
        private System.Windows.Forms.ToolStripMenuItem btnEditarCategoria;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ComboBox cbSeleccionarFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnEliminarFiltros;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVerArticulos;
        private System.Windows.Forms.ToolStripMenuItem btnVerMarcas;
        private System.Windows.Forms.ToolStripMenuItem btnVerCategorias;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Label lblInformacion;
    }
}

