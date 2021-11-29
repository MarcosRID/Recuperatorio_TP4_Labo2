using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Mercado
{
    public partial class FormHistorialVentas : Form
    {

        public FormHistorialVentas()
        {
            InitializeComponent();
        }

        private void FormHistorialVentas_Load(object sender, EventArgs e)
        {
            Ticket ticket;
            List<Ticket> listaTicket = new List<Ticket>();
            string[] listaNombreTickts;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Historial1_Ventas");
            listaNombreTickts = Directory.GetFiles(path);

            foreach (string item in listaNombreTickts)
            {
                ticket = Archivos<Ticket>.Deserializar(Path.Combine(path,item));
                listaTicket.Add(ticket);
            }
            this.dtgHitorialVentas.DataSource = listaTicket;

        }
    }
}
