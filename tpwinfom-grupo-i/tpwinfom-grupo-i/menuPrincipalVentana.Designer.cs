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
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaArticulo = new System.Windows.Forms.Label();
            this.dgwArticulos = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.cbSeleccionarFiltro = new System.Windows.Forms.ComboBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnEliminarFiltros = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.editarToolStripMenuItem});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.editarToolStripMenuItem1});
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
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
            this.dgwArticulos.AllowUserToOrderColumns = true;
            this.dgwArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwArticulos.Location = new System.Drawing.Point(32, 124);
            this.dgwArticulos.MultiSelect = false;
            this.dgwArticulos.Name = "dgwArticulos";
            this.dgwArticulos.ReadOnly = true;
            this.dgwArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwArticulos.Size = new System.Drawing.Size(444, 173);
            this.dgwArticulos.TabIndex = 3;
            this.dgwArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwArticulos_CellDoubleClick);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.btnEliminarFiltros.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarFiltros.Location = new System.Drawing.Point(255, 84);
            this.btnEliminarFiltros.Name = "btnEliminarFiltros";
            this.btnEliminarFiltros.Size = new System.Drawing.Size(115, 20);
            this.btnEliminarFiltros.TabIndex = 8;
            this.btnEliminarFiltros.Text = "Eliminar filtros";
            this.btnEliminarFiltros.UseVisualStyleBackColor = false;
            this.btnEliminarFiltros.Click += new System.EventHandler(this.btnEliminarFiltros_Click);
            // 
            // menuPrincipalVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 326);
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
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Label listaArticulo;
        private System.Windows.Forms.DataGridView dgwArticulos;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.ComboBox cbSeleccionarFiltro;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnEliminarFiltros;
    }
}

