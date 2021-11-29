using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Mercado
{


    public partial class FormPrincipal : Form
    {

        public Supermercado supermercado;
        public Queue<Cliente> listaClientes;
        public Distribuidor distribuidor;
        public Conexion conexion;

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            supermercado = new Supermercado(001, "Coto");
            listaClientes = new Queue<Cliente>();
            distribuidor = new Distribuidor();
            conexion = new Conexion();


            supermercado.MiInventario = conexion.ObtenerInventario();

            #region Lista Clente Harcodeada
            distribuidor.harcodearDatos();
            #endregion
        }

        private void btnAtenderCaja_Click(object sender, EventArgs e)
        {

            try
            {
                FormCaja formCaja = new FormCaja(this);

                formCaja.ShowDialog();
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }



        private void btnRenovarSotck_Click(object sender, EventArgs e)
        {
            try
            {
                formRenovarStock formRenovarStock = new formRenovarStock(this);

                formRenovarStock.ShowDialog();
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }


        private void btnCLiente_Click(object sender, EventArgs e)
        {
            try
            {
                Task tarea = new Task(CrearCliente);

                tarea.Start();
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }

        public void CrearCliente()
        {
            try
            {
                FormClienteRealizaCompra formClienteRealizaCompra = new FormClienteRealizaCompra(this);

                formClienteRealizaCompra.ShowDialog();

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

        private void btnBalanceDelMes_Click(object sender, EventArgs e)
        {
            try
            {
                FormHistorialVentas formHistorialVentas = new FormHistorialVentas();

                formHistorialVentas.ShowDialog();

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
    }
}
