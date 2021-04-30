
namespace DiscotecaLaSantaDiabla
{
    partial class GUIBebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIBebida));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnModificarBebida = new System.Windows.Forms.Button();
            this.btnBuscarBebida = new System.Windows.Forms.Button();
            this.btnEliminarBebida = new System.Windows.Forms.Button();
            this.btnAgregarBebida = new System.Windows.Forms.Button();
            this.gridBebidas = new System.Windows.Forms.DataGridView();
            this.iterador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(647, 601);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(174, 33);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnModificarBebida
            // 
            this.btnModificarBebida.Location = new System.Drawing.Point(488, 601);
            this.btnModificarBebida.Name = "btnModificarBebida";
            this.btnModificarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnModificarBebida.TabIndex = 14;
            this.btnModificarBebida.Text = "Modificar Bebida";
            this.btnModificarBebida.UseVisualStyleBackColor = true;
            // 
            // btnBuscarBebida
            // 
            this.btnBuscarBebida.Location = new System.Drawing.Point(329, 601);
            this.btnBuscarBebida.Name = "btnBuscarBebida";
            this.btnBuscarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnBuscarBebida.TabIndex = 13;
            this.btnBuscarBebida.Text = "Buscar Bebida";
            this.btnBuscarBebida.UseVisualStyleBackColor = true;
            this.btnBuscarBebida.Click += new System.EventHandler(this.btnBuscarBebida_Click);
            // 
            // btnEliminarBebida
            // 
            this.btnEliminarBebida.Location = new System.Drawing.Point(170, 601);
            this.btnEliminarBebida.Name = "btnEliminarBebida";
            this.btnEliminarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnEliminarBebida.TabIndex = 12;
            this.btnEliminarBebida.Text = "Eliminar Bebida";
            this.btnEliminarBebida.UseVisualStyleBackColor = true;
            this.btnEliminarBebida.Click += new System.EventHandler(this.btnEliminarBebida_Click);
            // 
            // btnAgregarBebida
            // 
            this.btnAgregarBebida.Location = new System.Drawing.Point(11, 601);
            this.btnAgregarBebida.Name = "btnAgregarBebida";
            this.btnAgregarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnAgregarBebida.TabIndex = 10;
            this.btnAgregarBebida.Text = "Agregar Bebida";
            this.btnAgregarBebida.UseVisualStyleBackColor = true;
            this.btnAgregarBebida.Click += new System.EventHandler(this.btnAgregarBebida_Click);
            // 
            // gridBebidas
            // 
            this.gridBebidas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.gridBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterador,
            this.idGrid,
            this.nombre,
            this.precio,
            this.presentacion,
            this.cantidad});
            this.gridBebidas.Location = new System.Drawing.Point(11, 182);
            this.gridBebidas.Name = "gridBebidas";
            this.gridBebidas.RowTemplate.Height = 25;
            this.gridBebidas.Size = new System.Drawing.Size(811, 413);
            this.gridBebidas.TabIndex = 9;
            // 
            // iterador
            // 
            this.iterador.HeaderText = "";
            this.iterador.Name = "iterador";
            this.iterador.ReadOnly = true;
            this.iterador.Width = 30;
            // 
            // idGrid
            // 
            this.idGrid.HeaderText = "Identificación";
            this.idGrid.Name = "idGrid";
            this.idGrid.ReadOnly = true;
            this.idGrid.Width = 130;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 185;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 180;
            // 
            // presentacion
            // 
            this.presentacion.HeaderText = "Presentacion";
            this.presentacion.Name = "presentacion";
            this.presentacion.ReadOnly = true;
            this.presentacion.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 159);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GUIBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 640);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnModificarBebida);
            this.Controls.Add(this.btnBuscarBebida);
            this.Controls.Add(this.btnEliminarBebida);
            this.Controls.Add(this.btnAgregarBebida);
            this.Controls.Add(this.gridBebidas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUIBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebida";
            ((System.ComponentModel.ISupportInitialize)(this.gridBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnModificarBebida;
        private System.Windows.Forms.Button btnBuscarBebida;
        private System.Windows.Forms.Button btnEliminarBebida;
        private System.Windows.Forms.Button btnAgregarBebida;
        private System.Windows.Forms.DataGridView gridBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}