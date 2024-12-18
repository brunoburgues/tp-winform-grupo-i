namespace tpwinfom_grupo_i
{
    partial class Galeria
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
            this.pictureBoxGaleria = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnAgregarUrl = new System.Windows.Forms.Button();
            this.btnGaleria = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaleria)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGaleria
            // 
            this.pictureBoxGaleria.Location = new System.Drawing.Point(55, 32);
            this.pictureBoxGaleria.Name = "pictureBoxGaleria";
            this.pictureBoxGaleria.Size = new System.Drawing.Size(199, 177);
            this.pictureBoxGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGaleria.TabIndex = 0;
            this.pictureBoxGaleria.TabStop = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(55, 215);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(199, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // btnAgregarUrl
            // 
            this.btnAgregarUrl.Location = new System.Drawing.Point(260, 215);
            this.btnAgregarUrl.Name = "btnAgregarUrl";
            this.btnAgregarUrl.Size = new System.Drawing.Size(87, 23);
            this.btnAgregarUrl.TabIndex = 2;
            this.btnAgregarUrl.Text = "Agregar URL";
            this.btnAgregarUrl.UseVisualStyleBackColor = true;
            this.btnAgregarUrl.Click += new System.EventHandler(this.btnAgregarUrl_Click);
            // 
            // btnGaleria
            // 
            this.btnGaleria.Location = new System.Drawing.Point(260, 186);
            this.btnGaleria.Name = "btnGaleria";
            this.btnGaleria.Size = new System.Drawing.Size(87, 23);
            this.btnGaleria.TabIndex = 3;
            this.btnGaleria.Text = "Galeria";
            this.btnGaleria.UseVisualStyleBackColor = true;
            this.btnGaleria.Click += new System.EventHandler(this.btnGaleria_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(260, 32);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(87, 23);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(260, 61);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(87, 23);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(167, 267);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(260, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Galeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 316);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGaleria);
            this.Controls.Add(this.btnAgregarUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.pictureBoxGaleria);
            this.Name = "Galeria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeria";
            this.Load += new System.EventHandler(this.Galeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGaleria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGaleria;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnAgregarUrl;
        private System.Windows.Forms.Button btnGaleria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}