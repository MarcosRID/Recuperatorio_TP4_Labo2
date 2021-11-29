using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Mercado
{
    

    public partial class FormCaja : Form
    {
        FormPrincipal formPrincipalPadre;


        public FormCaja(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalPadre = formPrincipal;
            
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            this.dtgFilaDeClientes.DataSource = formPrincipalPadre.listaClientes.ToList();


        }


        private void dtgFilaDeClientes_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgFilaDeClientes.CurrentRow is not null)
            {
                Cliente cliente = ((Cliente)this.dtgFilaDeClientes.CurrentRow.DataBoundItem);
                this.dtgProductosDelCliente.DataSource = (cliente).ListaProducto;
                this.txtPrecioTotal.Text = Ticket.CalcularMontoTotal(cliente.ListaProducto).ToString();
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                FormTicket formTicket = new FormTicket(formPrincipalPadre);

                formTicket.ShowDialog();

                this.dtgFilaDeClientes.DataSource = formPrincipalPadre.listaClientes.ToList();
                this.dtgProductosDelCliente.DataSource = null;
            }
            catch (ArgumentException ae)
            {
                Archivos<Exception>.SerializarExceptionATexto(ae);
            }
            catch (InvalidOperationException ioe)
            {
                Archivos<Exception>.SerializarExceptionATexto(ioe);
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }

        private void dtgProductosDelCliente_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            this.dtgProductosDelCliente.Columns["Stock"].Visible = false;
            this.dtgProductosDelCliente.Columns["Stock_SI_NO"].Visible = false;
        }

        


    }
}
