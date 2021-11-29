using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;
using System.Threading;

namespace Mercado
{
    public partial class FormTicket : Form
    {
        FormPrincipal formPrincipalPadre;

        public FormTicket(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalPadre = formPrincipal;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = formPrincipalPadre.listaClientes.Dequeue();

                Ticket ticket = new Ticket(cliente.ListaProducto, 'B');

                this.GuardarVenta(ticket);


                formPrincipalPadre.supermercado.Historial_de_venta.Add(ticket);

                this.lsbTicket.DataSource = (List<string>)ticket;
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }



        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            int indice = (formPrincipalPadre.supermercado.Historial_de_venta.Count - 1);
            this.formPrincipalPadre.conexion.InsertTicket(formPrincipalPadre.supermercado.Historial_de_venta[indice]);

            try
            {
                await Task.Run(() =>
                {
                    Conexion.UpDateInventario(formPrincipalPadre.supermercado.MiInventario);
                    Thread.Sleep(2000);
                });


                this.Close();

            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }



        private void GuardarVenta(Ticket ticket)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Historial1_Ventas");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = Path.Combine(path, $"Tiket_B_{DateTime.Today.Day}-{DateTime.Today.Month}-{DateTime.Today.Year}--{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}");

            Archivos<Ticket>.Serializar(ticket,path);


        }

    }
}
