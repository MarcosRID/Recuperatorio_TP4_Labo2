
namespace Mercado
{
    partial class FormEditarProducto
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
            this.btnGuardarCambio = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nup = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioNuevo = new System.Windows.Forms.Label();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.lblPrecioActual = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarCambio
            // 
            this.btnGuardarCambio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarCambio.Location = new System.Drawing.Point(12, 169);
            this.btnGuardarCambio.Name = "btnGuardarCambio";
            this.btnGuardarCambio.Size = new System.Drawing.Size(110, 35);
            this.btnGuardarCambio.TabIndex = 12;
            this.btnGuardarCambio.Text = "Guardar Cambio";
            this.btnGuardarCambio.UseVisualStyleBackColor = false;
            this.btnGuardarCambio.Click += new System.EventHandler(this.btnGuardarCambio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Location = new System.Drawing.Point(171, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nup
            // 
            this.nup.Location = new System.Drawing.Point(171, 128);
            this.nup.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup.Name = "nup";
            this.nup.Size = new System.Drawing.Size(110, 23);
            this.nup.TabIndex = 15;
            this.nup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrecioNuevo
            // 
            this.lblPrecioNuevo.AutoSize = true;
            this.lblPrecioNuevo.Location = new System.Drawing.Point(171, 110);
            this.lblPrecioNuevo.Name = "lblPrecioNuevo";
            this.lblPrecioNuevo.Size = new System.Drawing.Size(88, 15);
            this.lblPrecioNuevo.TabIndex = 16;
            this.lblPrecioNuevo.Text = "Cambiar precio";
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Location = new System.Drawing.Point(12, 128);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioActual.TabIndex = 17;
            // 
            // lblPrecioActual
            // 
            this.lblPrecioActual.AutoSize = true;
            this.lblPrecioActual.Location = new System.Drawing.Point(12, 110);
            this.lblPrecioActual.Name = "lblPrecioActual";
            this.lblPrecioActual.Size = new System.Drawing.Size(77, 15);
            this.lblPrecioActual.TabIndex = 18;
            this.lblPrecioActual.Text = "Precio Actual";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 57);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(101, 15);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Codigo :Producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 15);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre :Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 21;
            // 
            // FormEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 216);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecioActual);
            this.Controls.Add(this.txtPrecioActual);
            this.Controls.Add(this.lblPrecioNuevo);
            this.Controls.Add(this.nup);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCambio);
            this.Name = "FormEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control de precios";
            this.Load += new System.EventHandler(this.FormEditarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCambio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nup;
        private System.Windows.Forms.Label lblPrecioNuevo;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.Label lblPrecioActual;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}