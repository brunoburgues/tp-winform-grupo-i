namespace tpwinfom_grupo_i
{
    partial class categoría
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
            this.listMarca = new System.Windows.Forms.Label();
            this.marca1 = new System.Windows.Forms.Label();
            this.codigodeMarca = new System.Windows.Forms.Label();
            this.agregarMarca = new System.Windows.Forms.Button();
            this.eliminarMarca = new System.Windows.Forms.Button();
            this.listMarca1 = new System.Windows.Forms.TextBox();
            this.descripcionMarca = new System.Windows.Forms.TextBox();
            this.idMarca = new System.Windows.Forms.TextBox();
            this.tituloMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listMarca
            // 
            this.listMarca.AutoSize = true;
            this.listMarca.Location = new System.Drawing.Point(97, 54);
            this.listMarca.Name = "listMarca";
            this.listMarca.Size = new System.Drawing.Size(81, 13);
            this.listMarca.TabIndex = 0;
            this.listMarca.Text = "Lista de marcas";
            // 
            // marca1
            // 
            this.marca1.AutoSize = true;
            this.marca1.Location = new System.Drawing.Point(97, 80);
            this.marca1.Name = "marca1";
            this.marca1.Size = new System.Drawing.Size(37, 13);
            this.marca1.TabIndex = 1;
            this.marca1.Text = "Marca";
            // 
            // codigodeMarca
            // 
            this.codigodeMarca.AutoSize = true;
            this.codigodeMarca.Location = new System.Drawing.Point(97, 107);
            this.codigodeMarca.Name = "codigodeMarca";
            this.codigodeMarca.Size = new System.Drawing.Size(87, 13);
            this.codigodeMarca.TabIndex = 2;
            this.codigodeMarca.Text = "Código de marca";
            // 
            // agregarMarca
            // 
            this.agregarMarca.Location = new System.Drawing.Point(88, 191);
            this.agregarMarca.Name = "agregarMarca";
            this.agregarMarca.Size = new System.Drawing.Size(90, 33);
            this.agregarMarca.TabIndex = 3;
            this.agregarMarca.Text = "Agregar";
            this.agregarMarca.UseVisualStyleBackColor = true;
            this.agregarMarca.Click += new System.EventHandler(this.agregarMarca_Click);
            // 
            // eliminarMarca
            // 
            this.eliminarMarca.Location = new System.Drawing.Point(221, 191);
            this.eliminarMarca.Name = "eliminarMarca";
            this.eliminarMarca.Size = new System.Drawing.Size(90, 33);
            this.eliminarMarca.TabIndex = 4;
            this.eliminarMarca.Text = "Eliminar";
            this.eliminarMarca.UseVisualStyleBackColor = true;
            // 
            // listMarca1
            // 
            this.listMarca1.Location = new System.Drawing.Point(190, 54);
            this.listMarca1.Name = "listMarca1";
            this.listMarca1.Size = new System.Drawing.Size(100, 20);
            this.listMarca1.TabIndex = 5;
            // 
            // descripcionMarca
            // 
            this.descripcionMarca.Location = new System.Drawing.Point(190, 77);
            this.descripcionMarca.Name = "descripcionMarca";
            this.descripcionMarca.Size = new System.Drawing.Size(100, 20);
            this.descripcionMarca.TabIndex = 6;
            // 
            // idMarca
            // 
            this.idMarca.Location = new System.Drawing.Point(190, 103);
            this.idMarca.Name = "idMarca";
            this.idMarca.Size = new System.Drawing.Size(100, 20);
            this.idMarca.TabIndex = 7;
            // 
            // tituloMarca
            // 
            this.tituloMarca.AutoSize = true;
            this.tituloMarca.Location = new System.Drawing.Point(153, 18);
            this.tituloMarca.Name = "tituloMarca";
            this.tituloMarca.Size = new System.Drawing.Size(45, 13);
            this.tituloMarca.TabIndex = 8;
            this.tituloMarca.Text = "MARCA";
            // 
            // categoría
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 271);
            this.Controls.Add(this.tituloMarca);
            this.Controls.Add(this.idMarca);
            this.Controls.Add(this.descripcionMarca);
            this.Controls.Add(this.listMarca1);
            this.Controls.Add(this.eliminarMarca);
            this.Controls.Add(this.agregarMarca);
            this.Controls.Add(this.codigodeMarca);
            this.Controls.Add(this.marca1);
            this.Controls.Add(this.listMarca);
            this.MaximumSize = new System.Drawing.Size(430, 310);
            this.MinimumSize = new System.Drawing.Size(430, 310);
            this.Name = "categoría";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listMarca;
        private System.Windows.Forms.Label marca1;
        private System.Windows.Forms.Label codigodeMarca;
        private System.Windows.Forms.Button agregarMarca;
        private System.Windows.Forms.Button eliminarMarca;
        private System.Windows.Forms.TextBox listMarca1;
        private System.Windows.Forms.TextBox descripcionMarca;
        private System.Windows.Forms.TextBox idMarca;
        private System.Windows.Forms.Label tituloMarca;
    }
}