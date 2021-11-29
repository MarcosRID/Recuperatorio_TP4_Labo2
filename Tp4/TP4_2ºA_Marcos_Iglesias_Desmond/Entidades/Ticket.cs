using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Ticket
    {

        #region Atributo/Propiedades
        private List<ProductoSeleccionado> lista_compra;
        private string fecha;
        private int id_ticket;
        private static int ultimo_id_ticket;
        private char tipo_de_ticket; // A , B ó C
        private double totalAPagar;

        [XmlIgnore]
        internal string FechaDate
        {
            get { return this.fecha; }
            set
            {
                this.fecha = DateTime.Now.ToString();
            }
        }

        public string Fecha
        {
            get { return this.fecha; }
            set
            {
                this.fecha = value;
            }
        }

        public int Id_ticket
        {
            get { return this.id_ticket; }
            set
            {
                this.id_ticket = value;
            }
        }

        private int Ultimo_id_ticket
        {
            get
            {
                ultimo_id_ticket++;
                return ultimo_id_ticket;
            }
        }
        public char Tipo_de_ticket
        {
            get { return this.tipo_de_ticket; }
            set
            {
                this.tipo_de_ticket = value;
            }
        }


        public double TotalAPagar
        {
            get
            {
                double total = this.totalAPagar;
                if (this.lista_compra is not null)
                {
                    foreach (ProductoSeleccionado item in lista_compra)
                    {
                        total += item.Precio * item.Cantidad;
                    }
                }

                return total;
            }
            set
            {
                this.totalAPagar = value;
            }

        }

        [XmlIgnore]
        public List<ProductoSeleccionado> Lista_compra
        {
            get { return this.lista_compra; }
        }
        #endregion



        #region Constructores

        static Ticket()
        {
            ultimo_id_ticket = 10000;
        }

        public Ticket()
        { }

        public Ticket(List<ProductoSeleccionado> lista, char tipo_ticket)
        {
            this.lista_compra = lista;
            this.id_ticket = ultimo_id_ticket;
            this.tipo_de_ticket = tipo_ticket;
            this.FechaDate = string.Empty;
        }
        public Ticket(double total, char tipo_ticket) : this(null, tipo_ticket)
        {
            this.totalAPagar = total;
            this.id_ticket = ultimo_id_ticket;
            this.FechaDate = string.Empty;
        }
        #endregion



        #region Sobrecarga / Override

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string item in (List<string>)this)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }

        #endregion



        #region Metodos


        /// <summary>
        /// Calcula el monto Final de una compra.
        /// </summary>
        /// <param name="lc"></param>
        /// <returns></returns>
        public static double CalcularMontoTotal(List<ProductoSeleccionado> lc)
        {
            double precioTotal = 0;
            foreach (ProductoSeleccionado item in lc)
            {
                if (item is not null)
                {
                    precioTotal += (item.Precio * item.Cantidad);
                }
            }
            return precioTotal;
        }

        #endregion



        #region Explicit / Implicit

        /// <summary>
        /// Retorna StringBulder (orientado para listbox)
        /// </summary>
        /// <param name="ticket"></param>
        public static explicit operator List<string>(Ticket ticket)
        {
            List<string> lista = new List<string>();

            lista.Add($"ID :{ticket.Id_ticket}");
            lista.Add($"Fecha :{ticket.FechaDate}");
            lista.Add($"********************* Productos *********************");
            lista.Add($"-------------------------------------------------");

            foreach (ProductoSeleccionado item in ticket.lista_compra)
            {
                lista.Add($"{item.ToString()}");
            }

            lista.Add($"-------------------------------------------------");

            return lista;
        }

        #endregion
    }
}
