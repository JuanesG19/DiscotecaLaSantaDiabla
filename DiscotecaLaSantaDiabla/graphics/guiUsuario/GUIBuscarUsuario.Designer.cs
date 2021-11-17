
namespace DiscotecaLaSantaDiabla
{
    partial class GUIBuscarUsuario
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoDeCuenta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFechaN = new System.Windows.Forms.TextBox();
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(24, 397);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 25);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(158, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 25);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoDeCuenta
            // 
            this.lblTipoDeCuenta.AutoSize = true;
            this.lblTipoDeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDeCuenta.Location = new System.Drawing.Point(24, 210);
            this.lblTipoDeCuenta.Name = "lblTipoDeCuenta";
            this.lblTipoDeCuenta.Size = new System.Drawing.Size(108, 18);
            this.lblTipoDeCuenta.TabIndex = 40;
            this.lblTipoDeCuenta.Text = "Tipo de Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtTelefonos.Location = new System.Drawing.Point(24, 288);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.ReadOnly = true;
            this.txtTelefonos.Size = new System.Drawing.Size(253, 23);
            this.txtTelefonos.TabIndex = 37;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(24, 268);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(66, 18);
            this.lblTelefono.TabIndex = 36;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtApellidos.Location = new System.Drawing.Point(24, 170);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(253, 23);
            this.txtApellidos.TabIndex = 35;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidos.Location = new System.Drawing.Point(24, 150);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(67, 18);
            this.lblApellidos.TabIndex = 34;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtNombres.Location = new System.Drawing.Point(24, 109);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(253, 23);
            this.txtNombres.TabIndex = 33;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(24, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 18);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombres";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtIdentificacion.Location = new System.Drawing.Point(11, 28);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(253, 23);
            this.txtIdentificacion.TabIndex = 31;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentificacion.Location = new System.Drawing.Point(11, 10);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(195, 18);
            this.lblIdentificacion.TabIndex = 30;
            this.lblIdentificacion.Text = "Documento de Identificacion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.lblIdentificacion);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 69);
            this.panel1.TabIndex = 44;
            // 
            // txtFechaN
            // 
            this.txtFechaN.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtFechaN.Location = new System.Drawing.Point(24, 348);
            this.txtFechaN.Name = "txtFechaN";
            this.txtFechaN.ReadOnly = true;
            this.txtFechaN.Size = new System.Drawing.Size(253, 23);
            this.txtFechaN.TabIndex = 45;
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtTipoCuenta.Location = new System.Drawing.Point(24, 230);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.ReadOnly = true;
            this.txtTipoCuenta.Size = new System.Drawing.Size(253, 23);
            this.txtTipoCuenta.TabIndex = 46;
            this.txtTipoCuenta.TextChanged += new System.EventHandler(this.txtTipoCuenta_TextChanged);
            // 
            // GUIBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(299, 441);
            this.Controls.Add(this.txtTipoCuenta);
            this.Controls.Add(this.txtFechaN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
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
            this.Name = "GUIBuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuario";
            this.Load += new System.EventHandler(this.GUIBuscarUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoDeCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFechaN;
        private System.Windows.Forms.TextBox txtTipoCuenta;
    }
}