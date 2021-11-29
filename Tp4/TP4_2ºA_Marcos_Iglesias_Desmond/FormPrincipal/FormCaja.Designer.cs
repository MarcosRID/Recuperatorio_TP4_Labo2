
namespace Mercado
{
    partial class FormCaja
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
            this.dtgFilaDeClientes = new System.Windows.Forms.DataGridView();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.dtgProductosDelCliente = new System.Windows.Forms.DataGridView();
            this.lblFilaDeClientes = new System.Windows.Forms.Label();
            this.lblProductosDelCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFilaDeClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosDelCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgFilaDeClientes
            // 
            this.dtgFilaDeClientes.AllowUserToAddRows = false;
            this.dtgFilaDeClientes.AllowUserToDeleteRows = false;
            this.dtgFilaDeClientes.AllowUserToResizeColumns = false;
            this.dtgFilaDeClientes.AllowUserToResizeRows = false;
            this.dtgFilaDeClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFilaDeClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgFilaDeClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgFilaDeClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFilaDeClientes.Location = new System.Drawing.Point(371, 52);
            this.dtgFilaDeClientes.MultiSelect = false;
            this.dtgFilaDeClientes.Name = "dtgFilaDeClientes";
            this.dtgFilaDeClientes.ReadOnly = true;
            this.dtgFilaDeClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgFilaDeClientes.RowTemplate.Height = 25;
            this.dtgFilaDeClientes.Size = new System.Drawing.Size(174, 281);
            this.dtgFilaDeClientes.TabIndex = 0;
            this.dtgFilaDeClientes.DoubleClick += new System.EventHandler(this.dtgFilaDeClientes_DoubleClick);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCobrar.Location = new System.Drawing.Point(371, 359);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(174, 23);
            this.btnCobrar.TabIndex = 1;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // dtgProductosDelCliente
            // 
            this.dtgProductosDelCliente.AllowUserToAddRows = false;
            this.dtgProductosDelCliente.AllowUserToDeleteRows = false;
            this.dtgProductosDelCliente.AllowUserToResizeColumns = false;
            this.dtgProductosDelCliente.AllowUserToResizeRows = false;
            this.dtgProductosDelCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductosDelCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgProductosDelCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgProductosDelCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosDelCliente.Location = new System.Drawing.Point(12, 52);
            this.dtgProductosDelCliente.MultiSelect = false;
            this.dtgProductosDelCliente.Name = "dtgProductosDelCliente";
            this.dtgProductosDelCliente.ReadOnly = true;
            this.dtgProductosDelCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgProductosDelCliente.RowTemplate.Height = 25;
            this.dtgProductosDelCliente.Size = new System.Drawing.Size(254, 281);
            this.dtgProductosDelCliente.TabIndex = 2;
            this.dtgProductosDelCliente.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgProductosDelCliente_RowPostPaint);
            // 
            // lblFilaDeClientes
            // 
            this.lblFilaDeClientes.AutoSize = true;
            this.lblFilaDeClientes.Location = new System.Drawing.Point(371, 30);
            this.lblFilaDeClientes.Name = "lblFilaDeClientes";
            this.lblFilaDeClientes.Size = new System.Drawing.Size(84, 15);
            this.lblFilaDeClientes.TabIndex = 3;
            this.lblFilaDeClientes.Text = "Fila de clientes";
            // 
            // lblProductosDelCliente
            // 
            this.lblProductosDelCliente.AutoSize = true;
            this.lblProductosDelCliente.Location = new System.Drawing.Point(12, 30);
            this.lblProductosDelCliente.Name = "lblProductosDelCliente";
            this.lblProductosDelCliente.Size = new System.Drawing.Size(118, 15);
            this.lblProductosDelCliente.TabIndex = 4;
            this.lblProductosDelCliente.Text = "Productos del cliente";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(55, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(93, 359);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(173, 23);
            this.txtPrecioTotal.TabIndex = 21;
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 420);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lblProductosDelCliente);
            this.Controls.Add(this.lblFilaDeClientes);
            this.Controls.Add(this.dtgProductosDelCliente);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.dtgFilaDeClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FormCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFilaDeClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosDelCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFilaDeClientes;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.DataGridView dtgProductosDelCliente;
        private System.Windows.Forms.Label lblFilaDeClientes;
        private System.Windows.Forms.Label lblProductosDelCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPrecioTotal;
    }
}