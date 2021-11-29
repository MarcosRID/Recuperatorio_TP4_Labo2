
namespace Mercado
{
    partial class FormPrincipal
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
            this.lbBalanceDelMes = new System.Windows.Forms.Label();
            this.btnHistorialDeVentas = new System.Windows.Forms.Button();
            this.lbRenovarStock = new System.Windows.Forms.Label();
            this.btnRenovarSotck = new System.Windows.Forms.Button();
            this.lbAtenderCaja = new System.Windows.Forms.Label();
            this.btnAtenderCaja = new System.Windows.Forms.Button();
            this.lbRealizarCompraCliente = new System.Windows.Forms.Label();
            this.btnCLiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBalanceDelMes
            // 
            this.lbBalanceDelMes.AutoSize = true;
            this.lbBalanceDelMes.Location = new System.Drawing.Point(166, 185);
            this.lbBalanceDelMes.Name = "lbBalanceDelMes";
            this.lbBalanceDelMes.Size = new System.Drawing.Size(99, 15);
            this.lbBalanceDelMes.TabIndex = 11;
            this.lbBalanceDelMes.Text = "Historial de Venta";
            // 
            // btnHistorialDeVentas
            // 
            this.btnHistorialDeVentas.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHistorialDeVentas.Location = new System.Drawing.Point(281, 181);
            this.btnHistorialDeVentas.Name = "btnHistorialDeVentas";
            this.btnHistorialDeVentas.Size = new System.Drawing.Size(169, 23);
            this.btnHistorialDeVentas.TabIndex = 10;
            this.btnHistorialDeVentas.Text = "Opcion 4";
            this.btnHistorialDeVentas.UseVisualStyleBackColor = false;
            this.btnHistorialDeVentas.Click += new System.EventHandler(this.btnBalanceDelMes_Click);
            // 
            // lbRenovarStock
            // 
            this.lbRenovarStock.AutoSize = true;
            this.lbRenovarStock.Location = new System.Drawing.Point(176, 132);
            this.lbRenovarStock.Name = "lbRenovarStock";
            this.lbRenovarStock.Size = new System.Drawing.Size(82, 15);
            this.lbRenovarStock.TabIndex = 9;
            this.lbRenovarStock.Text = "Renovar Stock";
            // 
            // btnRenovarSotck
            // 
            this.btnRenovarSotck.Location = new System.Drawing.Point(287, 124);
            this.btnRenovarSotck.Name = "btnRenovarSotck";
            this.btnRenovarSotck.Size = new System.Drawing.Size(163, 23);
            this.btnRenovarSotck.TabIndex = 8;
            this.btnRenovarSotck.Text = "Opcion 3";
            this.btnRenovarSotck.UseVisualStyleBackColor = true;
            this.btnRenovarSotck.Click += new System.EventHandler(this.btnRenovarSotck_Click);
            // 
            // lbAtenderCaja
            // 
            this.lbAtenderCaja.AutoSize = true;
            this.lbAtenderCaja.Location = new System.Drawing.Point(185, 28);
            this.lbAtenderCaja.Name = "lbAtenderCaja";
            this.lbAtenderCaja.Size = new System.Drawing.Size(73, 15);
            this.lbAtenderCaja.TabIndex = 7;
            this.lbAtenderCaja.Text = "Atender caja";
            // 
            // btnAtenderCaja
            // 
            this.btnAtenderCaja.Location = new System.Drawing.Point(287, 20);
            this.btnAtenderCaja.Name = "btnAtenderCaja";
            this.btnAtenderCaja.Size = new System.Drawing.Size(163, 23);
            this.btnAtenderCaja.TabIndex = 6;
            this.btnAtenderCaja.Text = "Opcion 1";
            this.btnAtenderCaja.UseVisualStyleBackColor = true;
            this.btnAtenderCaja.Click += new System.EventHandler(this.btnAtenderCaja_Click);
            // 
            // lbRealizarCompraCliente
            // 
            this.lbRealizarCompraCliente.AutoSize = true;
            this.lbRealizarCompraCliente.Location = new System.Drawing.Point(95, 81);
            this.lbRealizarCompraCliente.Name = "lbRealizarCompraCliente";
            this.lbRealizarCompraCliente.Size = new System.Drawing.Size(163, 15);
            this.lbRealizarCompraCliente.TabIndex = 13;
            this.lbRealizarCompraCliente.Text = "Realizar compra como cliente";
            // 
            // btnCLiente
            // 
            this.btnCLiente.Location = new System.Drawing.Point(287, 73);
            this.btnCLiente.Name = "btnCLiente";
            this.btnCLiente.Size = new System.Drawing.Size(163, 23);
            this.btnCLiente.TabIndex = 12;
            this.btnCLiente.Text = "Opcion 2";
            this.btnCLiente.UseVisualStyleBackColor = true;
            this.btnCLiente.Click += new System.EventHandler(this.btnCLiente_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(462, 237);
            this.Controls.Add(this.lbRealizarCompraCliente);
            this.Controls.Add(this.btnCLiente);
            this.Controls.Add(this.lbBalanceDelMes);
            this.Controls.Add(this.btnHistorialDeVentas);
            this.Controls.Add(this.lbRenovarStock);
            this.Controls.Add(this.btnRenovarSotck);
            this.Controls.Add(this.lbAtenderCaja);
            this.Controls.Add(this.btnAtenderCaja);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercado";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBalanceDelMes;
        private System.Windows.Forms.Button btnHistorialDeVentas;
        private System.Windows.Forms.Label lbRenovarStock;
        private System.Windows.Forms.Button btnRenovarSotck;
        private System.Windows.Forms.Label lbAtenderCaja;
        private System.Windows.Forms.Button btnAtenderCaja;
        private System.Windows.Forms.Label lbRealizarCompraCliente;
        private System.Windows.Forms.Button btnCLiente;
    }
}