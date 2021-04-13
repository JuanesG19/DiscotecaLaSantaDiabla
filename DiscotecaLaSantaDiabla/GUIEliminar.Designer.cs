
namespace DiscotecaLaSantaDiabla
{
    partial class GUIEliminar
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
            this.txtFechaN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtTipoDeCuenta = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoDeCuenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFechaN
            // 
            this.txtFechaN.Enabled = false;
            this.txtFechaN.Location = new System.Drawing.Point(12, 351);
            this.txtFechaN.Name = "txtFechaN";
            this.txtFechaN.Size = new System.Drawing.Size(279, 23);
            this.txtFechaN.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.lblIdentificacion);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 69);
            this.panel1.TabIndex = 57;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(11, 28);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(253, 23);
            this.txtIdentificacion.TabIndex = 31;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(11, 10);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(161, 15);
            this.lblIdentificacion.TabIndex = 30;
            this.lblIdentificacion.Text = "Documento de Identificación";
            // 
            // txtTipoDeCuenta
            // 
            this.txtTipoDeCuenta.Enabled = false;
            this.txtTipoDeCuenta.FormattingEnabled = true;
            this.txtTipoDeCuenta.Items.AddRange(new object[] {
            "STANDAR",
            "VIP"});
            this.txtTipoDeCuenta.Location = new System.Drawing.Point(12, 235);
            this.txtTipoDeCuenta.Name = "txtTipoDeCuenta";
            this.txtTipoDeCuenta.Size = new System.Drawing.Size(279, 23);
            this.txtTipoDeCuenta.TabIndex = 56;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(24, 404);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 25);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(158, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 25);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoDeCuenta
            // 
            this.lblTipoDeCuenta.AutoSize = true;
            this.lblTipoDeCuenta.Location = new System.Drawing.Point(12, 217);
            this.lblTipoDeCuenta.Name = "lblTipoDeCuenta";
            this.lblTipoDeCuenta.Size = new System.Drawing.Size(87, 15);
            this.lblTipoDeCuenta.TabIndex = 53;
            this.lblTipoDeCuenta.Text = "Tipo de Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Enabled = false;
            this.txtTelefonos.Location = new System.Drawing.Point(12, 291);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(279, 23);
            this.txtTelefonos.TabIndex = 51;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 273);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 50;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(12, 173);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(279, 23);
            this.txtApellidos.TabIndex = 49;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(12, 155);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(56, 15);
            this.lblApellidos.TabIndex = 48;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(12, 112);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(279, 23);
            this.txtNombres.TabIndex = 47;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 46;
            this.lblNombre.Text = "Nombres";
            // 
            // GUIEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 441);
            this.Controls.Add(this.txtFechaN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTipoDeCuenta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoDeCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefonos);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUIEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFechaN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.ComboBox txtTipoDeCuenta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoDeCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
    }
}