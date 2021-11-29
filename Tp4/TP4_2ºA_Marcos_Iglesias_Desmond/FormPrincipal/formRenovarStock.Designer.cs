
namespace Mercado
{
    partial class formRenovarStock
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
            this.cmbFiltroInventario = new System.Windows.Forms.ComboBox();
            this.dtgMiInventaro = new System.Windows.Forms.DataGridView();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.lblMiInventario = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbListaTiposProductos = new System.Windows.Forms.ComboBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.nudCantidadAComprar = new System.Windows.Forms.NumericUpDown();
            this.nudColocarPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.txtSeleccionarProducto = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMiInventaro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAComprar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColocarPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltroInventario
            // 
            this.cmbFiltroInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroInventario.FormattingEnabled = true;
            this.cmbFiltroInventario.Location = new System.Drawing.Point(534, 39);
            this.cmbFiltroInventario.Name = "cmbFiltroInventario";
            this.cmbFiltroInventario.Size = new System.Drawing.Size(186, 23);
            this.cmbFiltroInventario.TabIndex = 0;
            this.cmbFiltroInventario.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroInventario_SelectedIndexChanged);
            // 
            // dtgMiInventaro
            // 
            this.dtgMiInventaro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMiInventaro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgMiInventaro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMiInventaro.Location = new System.Drawing.Point(12, 39);
            this.dtgMiInventaro.MultiSelect = false;
            this.dtgMiInventaro.Name = "dtgMiInventaro";
            this.dtgMiInventaro.ReadOnly = true;
            this.dtgMiInventaro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgMiInventaro.RowTemplate.Height = 25;
            this.dtgMiInventaro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMiInventaro.Size = new System.Drawing.Size(516, 399);
            this.dtgMiInventaro.TabIndex = 1;
            this.dtgMiInventaro.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgMiInventaro_RowPostPaint);
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.AllowUserToAddRows = false;
            this.dtgProveedor.AllowUserToDeleteRows = false;
            this.dtgProveedor.AllowUserToResizeColumns = false;
            this.dtgProveedor.AllowUserToResizeRows = false;
            this.dtgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(956, 39);
            this.dtgProveedor.MultiSelect = false;
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.ReadOnly = true;
            this.dtgProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgProveedor.RowTemplate.Height = 25;
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(277, 399);
            this.dtgProveedor.TabIndex = 2;
            this.dtgProveedor.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgProveedor_RowPostPaint);
            this.dtgProveedor.Click += new System.EventHandler(this.dtgProveedor_Click);
            // 
            // lblMiInventario
            // 
            this.lblMiInventario.AutoSize = true;
            this.lblMiInventario.Location = new System.Drawing.Point(12, 15);
            this.lblMiInventario.Name = "lblMiInventario";
            this.lblMiInventario.Size = new System.Drawing.Size(60, 15);
            this.lblMiInventario.TabIndex = 3;
            this.lblMiInventario.Text = "Inventario";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(956, 15);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 15);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cmbListaTiposProductos
            // 
            this.cmbListaTiposProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaTiposProductos.FormattingEnabled = true;
            this.cmbListaTiposProductos.Location = new System.Drawing.Point(764, 39);
            this.cmbListaTiposProductos.Name = "cmbListaTiposProductos";
            this.cmbListaTiposProductos.Size = new System.Drawing.Size(186, 23);
            this.cmbListaTiposProductos.TabIndex = 5;
            this.cmbListaTiposProductos.SelectedIndexChanged += new System.EventHandler(this.cmbListaTiposProductos_SelectedIndexChanged);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnComprar.Location = new System.Drawing.Point(818, 400);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(132, 38);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // nudCantidadAComprar
            // 
            this.nudCantidadAComprar.Location = new System.Drawing.Point(818, 352);
            this.nudCantidadAComprar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidadAComprar.Name = "nudCantidadAComprar";
            this.nudCantidadAComprar.Size = new System.Drawing.Size(132, 23);
            this.nudCantidadAComprar.TabIndex = 7;
            this.nudCantidadAComprar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudColocarPrecio
            // 
            this.nudColocarPrecio.Location = new System.Drawing.Point(818, 298);
            this.nudColocarPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudColocarPrecio.Name = "nudColocarPrecio";
            this.nudColocarPrecio.Size = new System.Drawing.Size(132, 23);
            this.nudColocarPrecio.TabIndex = 8;
            this.nudColocarPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(818, 280);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(132, 15);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Colocar precio de venta";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(818, 334);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(112, 15);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad a comprar";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditarProducto.Location = new System.Drawing.Point(534, 337);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(132, 38);
            this.btnEditarProducto.TabIndex = 11;
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // txtSeleccionarProducto
            // 
            this.txtSeleccionarProducto.AutoSize = true;
            this.txtSeleccionarProducto.Location = new System.Drawing.Point(534, 319);
            this.txtSeleccionarProducto.Name = "txtSeleccionarProducto";
            this.txtSeleccionarProducto.Size = new System.Drawing.Size(119, 15);
            this.txtSeleccionarProducto.TabIndex = 12;
            this.txtSeleccionarProducto.Text = "Seleccionar producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEliminar.Location = new System.Drawing.Point(534, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // formRenovarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1245, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtSeleccionarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nudColocarPrecio);
            this.Controls.Add(this.nudCantidadAComprar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.cmbListaTiposProductos);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblMiInventario);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.dtgMiInventaro);
            this.Controls.Add(this.cmbFiltroInventario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRenovarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depocito";
            this.Load += new System.EventHandler(this.formRenovarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMiInventaro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAComprar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColocarPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltroInventario;
        private System.Windows.Forms.DataGridView dtgMiInventaro;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Label lblMiInventario;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbListaTiposProductos;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.NumericUpDown nudCantidadAComprar;
        private System.Windows.Forms.NumericUpDown nudColocarPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Label txtSeleccionarProducto;
        private System.Windows.Forms.Button btnEliminar;
    }
}