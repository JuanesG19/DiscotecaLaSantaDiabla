
namespace DiscotecaLaSantaDiabla
{
    partial class GUIAgregar
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoDeCuenta = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtTipoDeCuenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 376);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 25);
            this.btnConfirmar.TabIndex = 28;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 25);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoDeCuenta
            // 
            this.lblTipoDeCuenta.AutoSize = true;
            this.lblTipoDeCuenta.Location = new System.Drawing.Point(12, 193);
            this.lblTipoDeCuenta.Name = "lblTipoDeCuenta";
            this.lblTipoDeCuenta.Size = new System.Drawing.Size(87, 15);
            this.lblTipoDeCuenta.TabIndex = 25;
            this.lblTipoDeCuenta.Text = "Tipo de Cuenta";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(12, 327);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(253, 23);
            this.fechaNacimiento.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(12, 267);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(253, 23);
            this.txtTelefonos.TabIndex = 22;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(12, 249);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(12, 149);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(253, 23);
            this.txtApellidos.TabIndex = 20;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(12, 131);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(56, 15);
            this.lblApellidos.TabIndex = 19;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(12, 88);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(253, 23);
            this.txtNombres.TabIndex = 18;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombres";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(12, 32);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(253, 23);
            this.txtIdentificacion.TabIndex = 16;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 14);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(161, 15);
            this.lblIdentificacion.TabIndex = 15;
            this.lblIdentificacion.Text = "Documento de Identificación";
            // 
            // txtTipoDeCuenta
            // 
            this.txtTipoDeCuenta.FormattingEnabled = true;
            this.txtTipoDeCuenta.Items.AddRange(new object[] {
            "STANDAR",
            "VIP"});
            this.txtTipoDeCuenta.Location = new System.Drawing.Point(12, 211);
            this.txtTipoDeCuenta.Name = "txtTipoDeCuenta";
            this.txtTipoDeCuenta.Size = new System.Drawing.Size(253, 23);
            this.txtTipoDeCuenta.TabIndex = 29;
            // 
            // GUIAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 420);
            this.Controls.Add(this.txtTipoDeCuenta);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoDeCuenta);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefonos);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblIdentificacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUIAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoDeCuenta;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.ComboBox txtTipoDeCuenta;
    }
}