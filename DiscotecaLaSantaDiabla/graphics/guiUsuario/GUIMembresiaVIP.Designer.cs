
namespace DiscotecaLaSantaDiabla.graphics.guiUsuario
{
    partial class GUIMembresiaVIP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIMembresiaVIP));
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.iterador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InicioMembresiaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoMembresiaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterador,
            this.idGrid,
            this.nombre,
            this.apellidoGrid,
            this.telefonoGrid,
            this.InicioMembresiaGrid,
            this.fechaVencimientoMembresiaGrid});
            this.gridUsuarios.Location = new System.Drawing.Point(169, 174);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.RowTemplate.Height = 25;
            this.gridUsuarios.Size = new System.Drawing.Size(1001, 473);
            this.gridUsuarios.TabIndex = 11;
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
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 185;
            // 
            // apellidoGrid
            // 
            this.apellidoGrid.HeaderText = "Apellido";
            this.apellidoGrid.Name = "apellidoGrid";
            this.apellidoGrid.ReadOnly = true;
            this.apellidoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellidoGrid.Width = 180;
            // 
            // telefonoGrid
            // 
            this.telefonoGrid.HeaderText = "Telefono";
            this.telefonoGrid.Name = "telefonoGrid";
            this.telefonoGrid.ReadOnly = true;
            this.telefonoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telefonoGrid.Width = 120;
            // 
            // InicioMembresiaGrid
            // 
            this.InicioMembresiaGrid.HeaderText = "Fecha Membresia";
            this.InicioMembresiaGrid.Name = "InicioMembresiaGrid";
            this.InicioMembresiaGrid.Width = 170;
            // 
            // fechaVencimientoMembresiaGrid
            // 
            this.fechaVencimientoMembresiaGrid.HeaderText = "Fecha Vencimiento";
            this.fechaVencimientoMembresiaGrid.Name = "fechaVencimientoMembresiaGrid";
            this.fechaVencimientoMembresiaGrid.ReadOnly = true;
            this.fechaVencimientoMembresiaGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaVencimientoMembresiaGrid.Width = 170;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1156, 159);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Location = new System.Drawing.Point(12, 229);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(140, 49);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar Usuarios";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(12, 174);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 49);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // GUIMembresiaVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 691);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUIMembresiaVIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresia VIP";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioMembresiaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoMembresiaGrid;
        private System.Windows.Forms.Button btnSalir;
    }
}