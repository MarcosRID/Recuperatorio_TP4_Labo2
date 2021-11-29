
namespace Mercado
{
    partial class FormHistorialVentas
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
            this.dtgHitorialVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHitorialVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHitorialVentas
            // 
            this.dtgHitorialVentas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgHitorialVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHitorialVentas.Location = new System.Drawing.Point(59, 34);
            this.dtgHitorialVentas.Name = "dtgHitorialVentas";
            this.dtgHitorialVentas.RowTemplate.Height = 25;
            this.dtgHitorialVentas.Size = new System.Drawing.Size(685, 385);
            this.dtgHitorialVentas.TabIndex = 0;
            // 
            // FormHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgHitorialVentas);
            this.Name = "FormHistorialVentas";
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.FormHistorialVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHitorialVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHitorialVentas;
    }
}