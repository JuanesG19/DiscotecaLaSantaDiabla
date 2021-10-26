
namespace DiscotecaLaSantaDiabla.graphics.guiUsuario
{
    partial class GUIFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIFacturacion));
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrarFacturas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.idGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioGRid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bebidaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFacturas
            // 
            this.gridFacturas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGrid,
            this.idUsuarioGRid,
            this.nombre,
            this.apellidoGrid,
            this.telefonoGrid,
            this.bebidaGrid,
            this.cantidadGrid,
            this.subtotalGrid,
            this.totalGrid,
            this.fechaGrid});
            this.gridFacturas.Location = new System.Drawing.Point(169, 174);
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.RowTemplate.Height = 25;
            this.gridFacturas.Size = new System.Drawing.Size(1071, 473);
            this.gridFacturas.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1266, 159);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnMostrarFacturas
            // 
            this.btnMostrarFacturas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrarFacturas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarFacturas.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarFacturas.Location = new System.Drawing.Point(12, 174);
            this.btnMostrarFacturas.Name = "btnMostrarFacturas";
            this.btnMostrarFacturas.Size = new System.Drawing.Size(140, 49);
            this.btnMostrarFacturas.TabIndex = 12;
            this.btnMostrarFacturas.Text = "Mostrar Facturas";
            this.btnMostrarFacturas.UseVisualStyleBackColor = false;
            this.btnMostrarFacturas.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(12, 284);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 49);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirFactura.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Allstar4", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirFactura.Location = new System.Drawing.Point(12, 229);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(140, 49);
            this.btnImprimirFactura.TabIndex = 14;
            this.btnImprimirFactura.Text = "Imprimir Factura";
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // idGrid
            // 
            this.idGrid.HeaderText = "# Factura";
            this.idGrid.Name = "idGrid";
            this.idGrid.ReadOnly = true;
            this.idGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idGrid.Width = 90;
            // 
            // idUsuarioGRid
            // 
            this.idUsuarioGRid.HeaderText = "Identificacion";
            this.idUsuarioGRid.Name = "idUsuarioGRid";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 150;
            // 
            // apellidoGrid
            // 
            this.apellidoGrid.HeaderText = "Apellido";
            this.apellidoGrid.Name = "apellidoGrid";
            this.apellidoGrid.ReadOnly = true;
            this.apellidoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellidoGrid.Width = 150;
            // 
            // telefonoGrid
            // 
            this.telefonoGrid.HeaderText = "Telefono";
            this.telefonoGrid.Name = "telefonoGrid";
            this.telefonoGrid.ReadOnly = true;
            this.telefonoGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.telefonoGrid.Width = 120;
            // 
            // bebidaGrid
            // 
            this.bebidaGrid.HeaderText = "Bebida";
            this.bebidaGrid.Name = "bebidaGrid";
            this.bebidaGrid.Width = 170;
            // 
            // cantidadGrid
            // 
            this.cantidadGrid.HeaderText = "Cant";
            this.cantidadGrid.Name = "cantidadGrid";
            this.cantidadGrid.ReadOnly = true;
            this.cantidadGrid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidadGrid.Width = 50;
            // 
            // subtotalGrid
            // 
            this.subtotalGrid.HeaderText = "Subtotal";
            this.subtotalGrid.Name = "subtotalGrid";
            // 
            // totalGrid
            // 
            this.totalGrid.HeaderText = "Total";
            this.totalGrid.Name = "totalGrid";
            // 
            // fechaGrid
            // 
            this.fechaGrid.HeaderText = "Fecha";
            this.fechaGrid.Name = "fechaGrid";
            // 
            // GUIFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1263, 660);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarFacturas);
            this.Controls.Add(this.gridFacturas);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUIFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresia VIP";
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMostrarFacturas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioGRid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bebidaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaGrid;
    }
}