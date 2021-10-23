﻿
namespace DiscotecaLaSantaDiabla
{
    partial class GUIUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.iterador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodeCuentaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnContarUsuario = new System.Windows.Forms.Button();
            this.btnModificarMembresia = new System.Windows.Forms.Button();
            this.btnMembresia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1321, 212);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterador,
            this.idGrid,
            this.nombre,
            this.apellidoGrid,
            this.tipodeCuentaGrid,
            this.telefonoGrid,
            this.fechaNacimientoGrid});
            this.gridUsuarios.Location = new System.Drawing.Point(208, 235);
            this.gridUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.RowHeadersWidth = 51;
            this.gridUsuarios.RowTemplate.Height = 25;
            this.gridUsuarios.Size = new System.Drawing.Size(1101, 652);
            this.gridUsuarios.TabIndex = 1;
            // 
            // iterador
            // 
            this.iterador.HeaderText = "";
            this.iterador.MinimumWidth = 6;
            this.iterador.Name = "iterador";
            this.iterador.ReadOnly = true;
            this.iterador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iterador.Width = 30;
            // 
            // idGrid
            // 
            this.idGrid.HeaderText = "Identificacion";
            this.idGrid.MinimumWidth = 6;
            this.idGrid.Name = "idGrid";
            this.idGrid.ReadOnly = true;
            this.idGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idGrid.Width = 130;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 185;
            // 
            // apellidoGrid
            // 
            this.apellidoGrid.HeaderText = "Apellido";
            this.apellidoGrid.MinimumWidth = 6;
            this.apellidoGrid.Name = "apellidoGrid";
            this.apellidoGrid.ReadOnly = true;
            this.apellidoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellidoGrid.Width = 180;
            // 
            // tipodeCuentaGrid
            // 
            this.tipodeCuentaGrid.HeaderText = "Tipo De Cuenta";
            this.tipodeCuentaGrid.MinimumWidth = 6;
            this.tipodeCuentaGrid.Name = "tipodeCuentaGrid";
            this.tipodeCuentaGrid.ReadOnly = true;
            this.tipodeCuentaGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipodeCuentaGrid.Width = 125;
            // 
            // telefonoGrid
            // 
            this.telefonoGrid.HeaderText = "Telefono";
            this.telefonoGrid.MinimumWidth = 6;
            this.telefonoGrid.Name = "telefonoGrid";
            this.telefonoGrid.ReadOnly = true;
            this.telefonoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telefonoGrid.Width = 120;
            // 
            // fechaNacimientoGrid
            // 
            this.fechaNacimientoGrid.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoGrid.MinimumWidth = 6;
            this.fechaNacimientoGrid.Name = "fechaNacimientoGrid";
            this.fechaNacimientoGrid.ReadOnly = true;
            this.fechaNacimientoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fechaNacimientoGrid.Width = 150;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarUsuario.Location = new System.Drawing.Point(30, 235);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(160, 65);
            this.btnAgregarUsuario.TabIndex = 2;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.Location = new System.Drawing.Point(30, 748);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(160, 65);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Usuarios";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarUsuario.Location = new System.Drawing.Point(30, 308);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(160, 65);
            this.btnEliminarUsuario.TabIndex = 4;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarUsuario.Location = new System.Drawing.Point(30, 381);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(160, 65);
            this.btnBuscarUsuario.TabIndex = 5;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarUsuario.Location = new System.Drawing.Point(30, 455);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(160, 65);
            this.btnModificarUsuario.TabIndex = 6;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnContarUsuario
            // 
            this.btnContarUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnContarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContarUsuario.Location = new System.Drawing.Point(30, 675);
            this.btnContarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnContarUsuario.Name = "btnContarUsuario";
            this.btnContarUsuario.Size = new System.Drawing.Size(160, 65);
            this.btnContarUsuario.TabIndex = 7;
            this.btnContarUsuario.Text = "Contar Usuarios";
            this.btnContarUsuario.UseVisualStyleBackColor = false;
            this.btnContarUsuario.Click += new System.EventHandler(this.btnContarUsuario_Click);
            // 
            // btnModificarMembresia
            // 
            this.btnModificarMembresia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarMembresia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificarMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificarMembresia.Location = new System.Drawing.Point(30, 528);
            this.btnModificarMembresia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificarMembresia.Name = "btnModificarMembresia";
            this.btnModificarMembresia.Size = new System.Drawing.Size(160, 65);
            this.btnModificarMembresia.TabIndex = 8;
            this.btnModificarMembresia.Text = "Modificar Membresia";
            this.btnModificarMembresia.UseVisualStyleBackColor = false;
            this.btnModificarMembresia.Click += new System.EventHandler(this.btnModificarMembresia_Click);
            // 
            // btnMembresia
            // 
            this.btnMembresia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMembresia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMembresia.Location = new System.Drawing.Point(30, 601);
            this.btnMembresia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMembresia.Name = "btnMembresia";
            this.btnMembresia.Size = new System.Drawing.Size(160, 65);
            this.btnMembresia.TabIndex = 9;
            this.btnMembresia.Text = "Membresia VIP";
            this.btnMembresia.UseVisualStyleBackColor = false;
            this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(30, 821);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 65);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // GUIUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1927, 1058);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMembresia);
            this.Controls.Add(this.btnModificarMembresia);
            this.Controls.Add(this.btnContarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUIUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios La Santa Diabla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnContarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodeCuentaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoGrid;
        private System.Windows.Forms.Button btnModificarMembresia;
        private System.Windows.Forms.Button btnMembresia;
        private System.Windows.Forms.Button btnSalir;
    }
}