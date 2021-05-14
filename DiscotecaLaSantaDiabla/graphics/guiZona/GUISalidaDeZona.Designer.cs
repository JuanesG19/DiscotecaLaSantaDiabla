
namespace DiscotecaLaSantaDiabla
{
    partial class GUISalidaDeZona
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
            this.lblZona = new System.Windows.Forms.Label();
            this.comboZonas = new System.Windows.Forms.ComboBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZona.Location = new System.Drawing.Point(12, 18);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(42, 18);
            this.lblZona.TabIndex = 0;
            this.lblZona.Text = "Zona";
            // 
            // comboZonas
            // 
            this.comboZonas.BackColor = System.Drawing.Color.DodgerBlue;
            this.comboZonas.FormattingEnabled = true;
            this.comboZonas.Items.AddRange(new object[] {
            "ZONA ESPECIAL",
            "ZONA A",
            "ZONA B",
            "ZONA C",
            "ZONA D",
            "ZONA VIP"});
            this.comboZonas.Location = new System.Drawing.Point(117, 14);
            this.comboZonas.Name = "comboZonas";
            this.comboZonas.Size = new System.Drawing.Size(226, 23);
            this.comboZonas.TabIndex = 1;
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersonas.Location = new System.Drawing.Point(12, 60);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(72, 18);
            this.lblPersonas.TabIndex = 2;
            this.lblPersonas.Text = "Personas";
            // 
            // txtPersonas
            // 
            this.txtPersonas.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtPersonas.Location = new System.Drawing.Point(117, 56);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(226, 23);
            this.txtPersonas.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(100, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 26);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Salida";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // GUISalidaDeZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(357, 137);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtPersonas);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.comboZonas);
            this.Controls.Add(this.lblZona);
            this.Name = "GUISalidaDeZona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida De Zona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox comboZonas;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.Button btnEliminar;
    }
}