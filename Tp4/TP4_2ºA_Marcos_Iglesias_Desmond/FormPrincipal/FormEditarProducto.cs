using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Mercado
{
    public partial class FormEditarProducto : Form
    {
        FormPrincipal formPrincipalPadre;
        int codigo;
        

        public FormEditarProducto(FormPrincipal formPrincipal,int codigo)
        {
            InitializeComponent();
            this.formPrincipalPadre = formPrincipal;
            this.codigo = codigo;
            
        }



        private void btnGuardarCambio_Click(object sender, EventArgs e)
        {
            foreach (Producto item in formPrincipalPadre.supermercado.MiInventario)
            {
                if (item == codigo)
                {
                    this.txtPrecioActual.Text = item.Precio.ToString();
                    item.Precio = (int)this.nup.Value;

                    this.btnCancelar_Click(sender, e);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarProducto_Load(object sender, EventArgs e)
        {
             this.txtNombre .Text = formPrincipalPadre.supermercado.MiInventario.Find((p) => p.Codigo == codigo).Nombre;
             this.txtCodigo.Text = codigo.ToString();
             this.txtPrecioActual.Text = formPrincipalPadre.supermercado.MiInventario.Find((p) => p.Codigo == codigo).Precio.ToString(); 
        }



    }
}
