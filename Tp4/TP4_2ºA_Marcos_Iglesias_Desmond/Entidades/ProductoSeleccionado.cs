using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class ProductoSeleccionado : Producto
    {
        #region Propiedades / Atributos

        private int cantidad;

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
        public override string Nombre
        {
            get
            {
                return this.nombre;
            }
            set { }
        }
        public override double Precio
        {
            get
            {
                return this.precio;
            }
            set { }
        }
        public override int Codigo
        {
            get
            {
                return this.codigo;
            }
            set { }
        }

        public override int Stock
        {

            set
            {
                base.stock = value;
            }
        }

        #endregion


        #region Constructores

        public ProductoSeleccionado()
        { }

        public ProductoSeleccionado(Producto producto, int cantidad) : base(producto.Nombre, producto.Precio, producto.Codigo)
        {
            this.cantidad = cantidad;
        }

        #endregion


        #region Sobrecarga / Override

        public static List<Producto> operator -(ProductoSeleccionado ps, List<Producto> lp)
        {
            List<Producto> lp1 = lp;
            try
            {


                foreach (Producto item in lp1)
                {
                    if (item == ps)
                    {
                        if (item.Stock >= ps.cantidad)
                        {
                            item.Stock -= ps.cantidad;

                            if (item.Stock == 0)
                            {
                                item.Stock_SI_NO = false;
                            }
                        }
                        else
                        {
                            lp1 = null;
                        }
                    }
                }
            }
            catch (Exception e)
            {

                Archivos<Exception>.SerializarExceptionATexto(e);
            }

            return lp1;
        }

        public static List<Producto> operator +(List<Producto> lp, ProductoSeleccionado ps)
        {
            List<Producto> lp1 = lp;

            try
            {


            if (lp1 is not null && ps is not null)
            {

                foreach (Producto item in lp1)
                {
                    if (item == ps)
                    {
                        item.Stock += ps.cantidad;
                    }
                }
            }


            }
            catch (Exception e)
            {

                Archivos<Exception>.SerializarExceptionATexto(e);
            }

            return lp1;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Nombre,-25}{this.Cantidad} X ${this.Precio,-5}");
            sb.Append($"| ### {this.Codigo} ###\n");

            return sb.ToString();
        }

        #endregion

    }
}
