namespace tpwinfom_grupo_i
{
    partial class ArtículoVentana
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxImagenes = new System.Windows.Forms.PictureBox();
            this.cajaDescripcion = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.Label();
            this.Categoría = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imagenes = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.cajaPrecio = new System.Windows.Forms.TextBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARTICULO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código de artículo:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // pictureBoxImagenes
            // 
            this.pictureBoxImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagenes.Location = new System.Drawing.Point(203, 13);
            this.pictureBoxImagenes.Name = "pictureBoxImagenes";
            this.pictureBoxImagenes.Size = new System.Drawing.Size(186, 171);
            this.pictureBoxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenes.TabIndex = 3;
            this.pictureBoxImagenes.TabStop = false;
            // 
            // cajaDescripcion
            // 
            this.cajaDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cajaDescripcion.ForeColor = System.Drawing.Color.Black;
            this.cajaDescripcion.Location = new System.Drawing.Point(25, 191);
            this.cajaDescripcion.Multiline = true;
            this.cajaDescripcion.Name = "cajaDescripcion";
            this.cajaDescripcion.Size = new System.Drawing.Size(165, 70);
            this.cajaDescripcion.TabIndex = 4;
            // 
            // marca
            // 
            this.marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marca.AutoSize = true;
            this.marca.Location = new System.Drawing.Point(22, 103);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(40, 13);
            this.marca.TabIndex = 5;
            this.marca.Text = "Marca:";
            // 
            // Categoría
            // 
            this.Categoría.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Categoría.AutoSize = true;
            this.Categoría.Location = new System.Drawing.Point(22, 125);
            this.Categoría.Name = "Categoría";
            this.Categoría.Size = new System.Drawing.Size(57, 13);
            this.Categoría.TabIndex = 6;
            this.Categoría.Text = "Categoría:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio:";
            // 
            // imagenes
            // 
            this.imagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imagenes.Location = new System.Drawing.Point(203, 197);
            this.imagenes.Name = "imagenes";
            this.imagenes.Size = new System.Drawing.Size(90, 23);
            this.imagenes.TabIndex = 8;
            this.imagenes.Text = "Imágenes";
            this.imagenes.UseVisualStyleBackColor = true;
            this.imagenes.Click += new System.EventHandler(this.galeria_Click);
            // 
            // agregar
            // 
            this.agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.agregar.Location = new System.Drawing.Point(299, 197);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(90, 23);
            this.agregar.TabIndex = 9;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelar.BackColor = System.Drawing.Color.Brown;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cancelar.Location = new System.Drawing.Point(299, 235);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(90, 23);
            this.cancelar.TabIndex = 10;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(82, 70);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(108, 20);
            this.cajaNombre.TabIndex = 14;
            // 
            // cajaPrecio
            // 
            this.cajaPrecio.Location = new System.Drawing.Point(82, 149);
            this.cajaPrecio.Name = "cajaPrecio";
            this.cajaPrecio.Size = new System.Drawing.Size(108, 20);
            this.cajaPrecio.TabIndex = 15;
            // 
            // eliminar
            // 
            this.eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eliminar.Location = new System.Drawing.Point(203, 235);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(90, 23);
            this.eliminar.TabIndex = 16;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Visible = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(76, 98);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 17;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(76, 122);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 18;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 175);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(125, 44);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(65, 20);
            this.tbCodigo.TabIndex = 20;
            // 
            // ArtículoVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 271);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.cajaPrecio);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.imagenes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Categoría);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.cajaDescripcion);
            this.Controls.Add(this.pictureBoxImagenes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(428, 304);
            this.Name = "ArtículoVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.ArtículoVentana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxImagenes;
        private System.Windows.Forms.TextBox cajaDescripcion;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.Label Categoría;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button imagenes;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.TextBox cajaPrecio;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tbCodigo;
    }
}