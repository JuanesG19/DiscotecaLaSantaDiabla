
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIBebida));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnModificarBebida = new System.Windows.Forms.Button();
            this.btnBuscarBebida = new System.Windows.Forms.Button();
            this.btnEliminarBebida = new System.Windows.Forms.Button();
            this.btnAgregarBebida = new System.Windows.Forms.Button();
            this.gridBebidas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iterador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Location = new System.Drawing.Point(658, 595);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(174, 33);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnModificarBebida
            // 
            this.btnModificarBebida.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarBebida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarBebida.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarBebida.Location = new System.Drawing.Point(499, 595);
            this.btnModificarBebida.Name = "btnModificarBebida";
            this.btnModificarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnModificarBebida.TabIndex = 14;
            this.btnModificarBebida.Text = "Modificar Bebida";
            this.btnModificarBebida.UseVisualStyleBackColor = false;
            this.btnModificarBebida.Click += new System.EventHandler(this.btnModificarBebida_Click);
            // 
            // btnBuscarBebida
            // 
            this.btnBuscarBebida.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarBebida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBebida.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarBebida.Location = new System.Drawing.Point(340, 595);
            this.btnBuscarBebida.Name = "btnBuscarBebida";
            this.btnBuscarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnBuscarBebida.TabIndex = 13;
            this.btnBuscarBebida.Text = "Buscar Bebida";
            this.btnBuscarBebida.UseVisualStyleBackColor = false;
            this.btnBuscarBebida.Click += new System.EventHandler(this.btnBuscarBebida_Click);
            // 
            // btnEliminarBebida
            // 
            this.btnEliminarBebida.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarBebida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBebida.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarBebida.Location = new System.Drawing.Point(181, 595);
            this.btnEliminarBebida.Name = "btnEliminarBebida";
            this.btnEliminarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnEliminarBebida.TabIndex = 12;
            this.btnEliminarBebida.Text = "Eliminar Bebida";
            this.btnEliminarBebida.UseVisualStyleBackColor = false;
            this.btnEliminarBebida.Click += new System.EventHandler(this.btnEliminarBebida_Click);
            // 
            // btnAgregarBebida
            // 
            this.btnAgregarBebida.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarBebida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarBebida.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarBebida.Location = new System.Drawing.Point(22, 595);
            this.btnAgregarBebida.Name = "btnAgregarBebida";
            this.btnAgregarBebida.Size = new System.Drawing.Size(153, 33);
            this.btnAgregarBebida.TabIndex = 10;
            this.btnAgregarBebida.Text = "Agregar Bebida";
            this.btnAgregarBebida.UseVisualStyleBackColor = false;
            this.btnAgregarBebida.Click += new System.EventHandler(this.btnAgregarBebida_Click);
            // 
            // gridBebidas
            // 
            this.gridBebidas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Allstar4", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBebidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterador,
            this.idGrid,
            this.nombre,
            this.precio,
            this.presentacion,
            this.cantidad,
            this.TipoBebida});
            this.gridBebidas.Location = new System.Drawing.Point(12, 173);
            this.gridBebidas.Name = "gridBebidas";
            this.gridBebidas.RowTemplate.Height = 25;
            this.gridBebidas.Size = new System.Drawing.Size(825, 413);
            this.gridBebidas.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 159);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // iterador
            // 
            this.iterador.HeaderText = "";
            this.iterador.Name = "iterador";
            this.iterador.ReadOnly = true;
            this.iterador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iterador.Width = 30;
            // 
            // idGrid
            // 
            this.idGrid.HeaderText = "Identificacion";
            this.idGrid.Name = "idGrid";
            this.idGrid.ReadOnly = true;
            this.idGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idGrid.Width = 130;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 185;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio.Width = 120;
            // 
            // presentacion
            // 
            this.presentacion.HeaderText = "Presentacion";
            this.presentacion.Name = "presentacion";
            this.presentacion.ReadOnly = true;
            this.presentacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.presentacion.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad.Width = 80;
            // 
            // TipoBebida
            // 
            this.TipoBebida.HeaderText = "Tipo Bebida";
            this.TipoBebida.Name = "TipoBebida";
            this.TipoBebida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TipoBebida.Width = 120;
            // 
            // GUIBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(848, 636);
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
            this.Text = "Bebida La Santa Diabla";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBebida;
    }
}