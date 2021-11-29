
namespace Mercado
{
    partial class FormClienteRealizaCompra
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
            this.dtgGondola = new System.Windows.Forms.DataGridView();
            this.rbtnOtros = new System.Windows.Forms.RadioButton();
            this.rbtnGolosina = new System.Windows.Forms.RadioButton();
            this.rbtnLacteo = new System.Windows.Forms.RadioButton();
            this.rbtnLimpieza = new System.Windows.Forms.RadioButton();
            this.rbtnHigiene = new System.Windows.Forms.RadioButton();
            this.rbtnFrutas = new System.Windows.Forms.RadioButton();
            this.rbtnVegetales = new System.Windows.Forms.RadioButton();
            this.rbtnCarne = new System.Windows.Forms.RadioButton();
            this.dtgCarrito = new System.Windows.Forms.DataGridView();
            this.btnEliminarProductoCarrito = new System.Windows.Forms.Button();
            this.btnIrACaja = new System.Windows.Forms.Button();
            this.nudCantidadDeUnidades = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadDeUnidades = new System.Windows.Forms.Label();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblGondola = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGondola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDeUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGondola
            // 
            this.dtgGondola.AllowUserToAddRows = false;
            this.dtgGondola.AllowUserToDeleteRows = false;
            this.dtgGondola.AllowUserToResizeColumns = false;
            this.dtgGondola.AllowUserToResizeRows = false;
            this.dtgGondola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGondola.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgGondola.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgGondola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgGondola.Location = new System.Drawing.Point(12, 48);
            this.dtgGondola.MultiSelect = false;
            this.dtgGondola.Name = "dtgGondola";
            this.dtgGondola.ReadOnly = true;
            this.dtgGondola.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgGondola.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgGondola.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgGondola.RowTemplate.Height = 25;
            this.dtgGondola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGondola.Size = new System.Drawing.Size(367, 345);
            this.dtgGondola.TabIndex = 17;
            this.dtgGondola.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgGondola_RowPostPaint);
            this.dtgGondola.DoubleClick += new System.EventHandler(this.dtgGondola_DoubleClick);
            // 
            // rbtnOtros
            // 
            this.rbtnOtros.AutoSize = true;
            this.rbtnOtros.Location = new System.Drawing.Point(385, 223);
            this.rbtnOtros.Name = "rbtnOtros";
            this.rbtnOtros.Size = new System.Drawing.Size(54, 19);
            this.rbtnOtros.TabIndex = 16;
            this.rbtnOtros.TabStop = true;
            this.rbtnOtros.Text = "Otros";
            this.rbtnOtros.UseVisualStyleBackColor = true;
            this.rbtnOtros.CheckedChanged += new System.EventHandler(this.rbtnOtros_CheckedChanged);
            // 
            // rbtnGolosina
            // 
            this.rbtnGolosina.AutoSize = true;
            this.rbtnGolosina.Location = new System.Drawing.Point(385, 198);
            this.rbtnGolosina.Name = "rbtnGolosina";
            this.rbtnGolosina.Size = new System.Drawing.Size(76, 19);
            this.rbtnGolosina.TabIndex = 15;
            this.rbtnGolosina.TabStop = true;
            this.rbtnGolosina.Text = "Golosinas";
            this.rbtnGolosina.UseVisualStyleBackColor = true;
            this.rbtnGolosina.CheckedChanged += new System.EventHandler(this.rbtnGolosina_CheckedChanged);
            // 
            // rbtnLacteo
            // 
            this.rbtnLacteo.AutoSize = true;
            this.rbtnLacteo.Location = new System.Drawing.Point(385, 173);
            this.rbtnLacteo.Name = "rbtnLacteo";
            this.rbtnLacteo.Size = new System.Drawing.Size(65, 19);
            this.rbtnLacteo.TabIndex = 14;
            this.rbtnLacteo.TabStop = true;
            this.rbtnLacteo.Text = "Lacteos";
            this.rbtnLacteo.UseVisualStyleBackColor = true;
            this.rbtnLacteo.CheckedChanged += new System.EventHandler(this.rbtnLacteo_CheckedChanged);
            // 
            // rbtnLimpieza
            // 
            this.rbtnLimpieza.AutoSize = true;
            this.rbtnLimpieza.Location = new System.Drawing.Point(385, 148);
            this.rbtnLimpieza.Name = "rbtnLimpieza";
            this.rbtnLimpieza.Size = new System.Drawing.Size(72, 19);
            this.rbtnLimpieza.TabIndex = 13;
            this.rbtnLimpieza.TabStop = true;
            this.rbtnLimpieza.Text = "Limpieza";
            this.rbtnLimpieza.UseVisualStyleBackColor = true;
            this.rbtnLimpieza.CheckedChanged += new System.EventHandler(this.rbtnLimpieza_CheckedChanged);
            // 
            // rbtnHigiene
            // 
            this.rbtnHigiene.AutoSize = true;
            this.rbtnHigiene.Location = new System.Drawing.Point(385, 123);
            this.rbtnHigiene.Name = "rbtnHigiene";
            this.rbtnHigiene.Size = new System.Drawing.Size(66, 19);
            this.rbtnHigiene.TabIndex = 12;
            this.rbtnHigiene.TabStop = true;
            this.rbtnHigiene.Text = "Higiene";
            this.rbtnHigiene.UseVisualStyleBackColor = true;
            this.rbtnHigiene.CheckedChanged += new System.EventHandler(this.rbtnHigiene_CheckedChanged);
            // 
            // rbtnFrutas
            // 
            this.rbtnFrutas.AutoSize = true;
            this.rbtnFrutas.Location = new System.Drawing.Point(385, 98);
            this.rbtnFrutas.Name = "rbtnFrutas";
            this.rbtnFrutas.Size = new System.Drawing.Size(57, 19);
            this.rbtnFrutas.TabIndex = 11;
            this.rbtnFrutas.TabStop = true;
            this.rbtnFrutas.Text = "Frutas";
            this.rbtnFrutas.UseVisualStyleBackColor = true;
            this.rbtnFrutas.CheckedChanged += new System.EventHandler(this.rbtnFrutas_CheckedChanged);
            // 
            // rbtnVegetales
            // 
            this.rbtnVegetales.AutoSize = true;
            this.rbtnVegetales.Location = new System.Drawing.Point(385, 73);
            this.rbtnVegetales.Name = "rbtnVegetales";
            this.rbtnVegetales.Size = new System.Drawing.Size(74, 19);
            this.rbtnVegetales.TabIndex = 10;
            this.rbtnVegetales.TabStop = true;
            this.rbtnVegetales.Text = "Vegetales";
            this.rbtnVegetales.UseVisualStyleBackColor = true;
            this.rbtnVegetales.CheckedChanged += new System.EventHandler(this.rbtnVegetales_CheckedChanged);
            // 
            // rbtnCarne
            // 
            this.rbtnCarne.AutoSize = true;
            this.rbtnCarne.Location = new System.Drawing.Point(385, 48);
            this.rbtnCarne.Name = "rbtnCarne";
            this.rbtnCarne.Size = new System.Drawing.Size(61, 19);
            this.rbtnCarne.TabIndex = 9;
            this.rbtnCarne.TabStop = true;
            this.rbtnCarne.Text = "Carnes";
            this.rbtnCarne.UseVisualStyleBackColor = true;
            this.rbtnCarne.CheckedChanged += new System.EventHandler(this.rbtnCarne_CheckedChanged);
            // 
            // dtgCarrito
            // 
            this.dtgCarrito.AllowUserToAddRows = false;
            this.dtgCarrito.AllowUserToDeleteRows = false;
            this.dtgCarrito.AllowUserToResizeColumns = false;
            this.dtgCarrito.AllowUserToResizeRows = false;
            this.dtgCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgCarrito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarrito.Location = new System.Drawing.Point(541, 48);
            this.dtgCarrito.MultiSelect = false;
            this.dtgCarrito.Name = "dtgCarrito";
            this.dtgCarrito.ReadOnly = true;
            this.dtgCarrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCarrito.RowTemplate.Height = 25;
            this.dtgCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCarrito.Size = new System.Drawing.Size(426, 194);
            this.dtgCarrito.TabIndex = 18;
            this.dtgCarrito.Click += new System.EventHandler(this.dtgCarrito_Click);
            // 
            // btnEliminarProductoCarrito
            // 
            this.btnEliminarProductoCarrito.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminarProductoCarrito.Location = new System.Drawing.Point(861, 370);
            this.btnEliminarProductoCarrito.Name = "btnEliminarProductoCarrito";
            this.btnEliminarProductoCarrito.Size = new System.Drawing.Size(106, 23);
            this.btnEliminarProductoCarrito.TabIndex = 19;
            this.btnEliminarProductoCarrito.Text = "Eliminar";
            this.btnEliminarProductoCarrito.UseVisualStyleBackColor = false;
            this.btnEliminarProductoCarrito.Click += new System.EventHandler(this.btnEliminarProductoCarrito_Click);
            // 
            // btnIrACaja
            // 
            this.btnIrACaja.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIrACaja.Location = new System.Drawing.Point(718, 370);
            this.btnIrACaja.Name = "btnIrACaja";
            this.btnIrACaja.Size = new System.Drawing.Size(106, 23);
            this.btnIrACaja.TabIndex = 20;
            this.btnIrACaja.Text = "Ir a caja";
            this.btnIrACaja.UseVisualStyleBackColor = false;
            this.btnIrACaja.Click += new System.EventHandler(this.btnIrACaja_Click);
            // 
            // nudCantidadDeUnidades
            // 
            this.nudCantidadDeUnidades.Location = new System.Drawing.Point(861, 274);
            this.nudCantidadDeUnidades.Name = "nudCantidadDeUnidades";
            this.nudCantidadDeUnidades.Size = new System.Drawing.Size(97, 23);
            this.nudCantidadDeUnidades.TabIndex = 21;
            this.nudCantidadDeUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCantidadDeUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadDeUnidades.ValueChanged += new System.EventHandler(this.nudCantidadDeUnidades_ValueChanged);
            // 
            // lblCantidadDeUnidades
            // 
            this.lblCantidadDeUnidades.AutoSize = true;
            this.lblCantidadDeUnidades.Location = new System.Drawing.Point(718, 282);
            this.lblCantidadDeUnidades.Name = "lblCantidadDeUnidades";
            this.lblCantidadDeUnidades.Size = new System.Drawing.Size(128, 15);
            this.lblCantidadDeUnidades.TabIndex = 22;
            this.lblCantidadDeUnidades.Text = "Cantidad de unidades :";
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Location = new System.Drawing.Point(744, 30);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(43, 15);
            this.lblCarrito.TabIndex = 23;
            this.lblCarrito.Text = "Carrito";
            // 
            // lblGondola
            // 
            this.lblGondola.AutoSize = true;
            this.lblGondola.Location = new System.Drawing.Point(169, 30);
            this.lblGondola.Name = "lblGondola";
            this.lblGondola.Size = new System.Drawing.Size(52, 15);
            this.lblGondola.TabIndex = 24;
            this.lblGondola.Text = "Gondola";
            // 
            // FormClienteRealizaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 405);
            this.Controls.Add(this.lblGondola);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lblCantidadDeUnidades);
            this.Controls.Add(this.nudCantidadDeUnidades);
            this.Controls.Add(this.btnIrACaja);
            this.Controls.Add(this.btnEliminarProductoCarrito);
            this.Controls.Add(this.dtgCarrito);
            this.Controls.Add(this.dtgGondola);
            this.Controls.Add(this.rbtnOtros);
            this.Controls.Add(this.rbtnGolosina);
            this.Controls.Add(this.rbtnLacteo);
            this.Controls.Add(this.rbtnLimpieza);
            this.Controls.Add(this.rbtnHigiene);
            this.Controls.Add(this.rbtnFrutas);
            this.Controls.Add(this.rbtnVegetales);
            this.Controls.Add(this.rbtnCarne);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClienteRealizaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gondolas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGondola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadDeUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGondola;
        private System.Windows.Forms.RadioButton rbtnOtros;
        private System.Windows.Forms.RadioButton rbtnGolosina;
        private System.Windows.Forms.RadioButton rbtnLacteo;
        private System.Windows.Forms.RadioButton rbtnLimpieza;
        private System.Windows.Forms.RadioButton rbtnHigiene;
        private System.Windows.Forms.RadioButton rbtnFrutas;
        private System.Windows.Forms.RadioButton rbtnVegetales;
        private System.Windows.Forms.RadioButton rbtnCarne;
        private System.Windows.Forms.DataGridView dtgCarrito;
        private System.Windows.Forms.Button btnEliminarProductoCarrito;
        private System.Windows.Forms.Button btnIrACaja;
        private System.Windows.Forms.NumericUpDown nudCantidadDeUnidades;
        private System.Windows.Forms.Label lblCantidadDeUnidades;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Label lblGondola;
    }
}