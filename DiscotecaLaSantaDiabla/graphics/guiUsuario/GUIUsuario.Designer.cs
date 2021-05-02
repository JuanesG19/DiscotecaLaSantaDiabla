
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(986, 159);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iterador,
            this.idGrid,
            this.nombre,
            this.apellidoGrid,
            this.tipodeCuentaGrid,
            this.telefonoGrid,
            this.fechaNacimientoGrid});
            this.gridUsuarios.Location = new System.Drawing.Point(12, 176);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.RowTemplate.Height = 25;
            this.gridUsuarios.Size = new System.Drawing.Size(960, 413);
            this.gridUsuarios.TabIndex = 1;
            this.gridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuarios_CellContentClick);
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
            // apellidoGrid
            // 
            this.apellidoGrid.HeaderText = "Apellido";
            this.apellidoGrid.Name = "apellidoGrid";
            this.apellidoGrid.ReadOnly = true;
            this.apellidoGrid.Width = 180;
            // 
            // tipodeCuentaGrid
            // 
            this.tipodeCuentaGrid.HeaderText = "Tipo De Cuenta";
            this.tipodeCuentaGrid.Name = "tipodeCuentaGrid";
            this.tipodeCuentaGrid.ReadOnly = true;
            this.tipodeCuentaGrid.Width = 120;
            // 
            // telefonoGrid
            // 
            this.telefonoGrid.HeaderText = "Telefono";
            this.telefonoGrid.Name = "telefonoGrid";
            this.telefonoGrid.ReadOnly = true;
            this.telefonoGrid.Width = 120;
            // 
            // fechaNacimientoGrid
            // 
            this.fechaNacimientoGrid.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoGrid.Name = "fechaNacimientoGrid";
            this.fechaNacimientoGrid.ReadOnly = true;
            this.fechaNacimientoGrid.Width = 150;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(12, 595);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(153, 33);
            this.btnAgregarUsuario.TabIndex = 2;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(819, 595);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(153, 33);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(171, 595);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(153, 33);
            this.btnEliminarUsuario.TabIndex = 4;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(330, 595);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(153, 33);
            this.btnBuscarUsuario.TabIndex = 5;
            this.btnBuscarUsuario.Text = "Buscar Usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(489, 595);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(153, 33);
            this.btnModificarUsuario.TabIndex = 6;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnContarUsuario
            // 
            this.btnContarUsuario.Location = new System.Drawing.Point(648, 595);
            this.btnContarUsuario.Name = "btnContarUsuario";
            this.btnContarUsuario.Size = new System.Drawing.Size(165, 33);
            this.btnContarUsuario.TabIndex = 7;
            this.btnContarUsuario.Text = "Contar Usuarios";
            this.btnContarUsuario.UseVisualStyleBackColor = true;
            this.btnContarUsuario.Click += new System.EventHandler(this.btnContarUsuario_Click);
            // 
            // GUIUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 640);
            this.Controls.Add(this.btnContarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUIUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios La Santa Diabla";
            this.Load += new System.EventHandler(this.GUIUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn iterador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodeCuentaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoGrid;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnContarUsuario;
    }
}