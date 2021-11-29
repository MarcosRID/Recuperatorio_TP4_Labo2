using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoNoCongelado<T> : Producto , IProductosNoCongelados
    where T : Enum
    {
        #region Atributos/Propiedades

        T categoria;

        public override string Nombre
        {
            get
            { return this.nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    this.nombre = value;
                }
            }
        }
        public override double Precio
        {
            get
            { return this.precio; }
            set
            {
                if (!double.IsNaN(value))
                {
                    this.precio = value;
                }
            }
        }
        public override int Codigo
        {
            get
            { return this.codigo; }
            set
            {
                if (value > 0)
                {
                    this.codigo = value;
                }
            }
        }
        public override int Stock
        {
            get
            { return this.stock; }
            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }
            }
        }
        public override bool Stock_SI_NO
        {
            get
            { return this.stock_SI_NO; }
            set
            { this.stock_SI_NO = value; }
        }

        public T Categoria
        {
            get
            { return this.categoria; }
            set
            {
                if (value is not null)
                {
                    this.categoria = value;
                }
            }
        }
        #endregion



        #region Constructores


        public ProductoNoCongelado()
        { }

        public ProductoNoCongelado(string nombre, int codigo) : base(nombre, 0, codigo)
        { }

        public ProductoNoCongelado(string nombre, double precio, int codigo, int stock, bool stock_SI_NO, T categoria)
        : base(nombre, precio, codigo, stock, stock_SI_NO)
        {
            this.Categoria = categoria;
        }

        #endregion



        #region Metodos


        /// <summary>
        /// Filtra los productos de una lista generica de productos , en una lista especica de tipo T : Enum
        /// </summary>
        /// <param name="lProductos1"></param>
        /// <returns></returns>
        public static List<ProductoNoCongelado<T>> FiltrarLista(List<Producto> lProductos1)
        {
            List<ProductoNoCongelado<T>> listaGenericaT = new List<ProductoNoCongelado<T>>();

            try
            {
                if (lProductos1 is not null)
                {
                    foreach (Producto item in lProductos1)
                    {
                        if (item is ProductoNoCongelado<T>)
                        {
                            listaGenericaT.Add((ProductoNoCongelado<T>)item);
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e);
            }

            return listaGenericaT;
        }


        #endregion



        #region Interfaces
        public EFrutas ParceFrutas(string stg)
        {
            EFrutas rta = 0;

            if (stg is not null)
            {

                foreach (EFrutas item in Enum.GetValues(typeof(EFrutas)))
                {
                    if (item.ToString().Equals(stg))
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        public EVerduras ParceVerduras(string stg)
        {
            EVerduras rta = 0;

            if (stg is not null)
            {

                foreach (EVerduras item in Enum.GetValues(typeof(EVerduras)))
                {
                    if (item.ToString().Equals(stg))
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        public EHigiene ParceHigiene(string stg)
        {
            EHigiene rta = 0;
            if (stg is not null)
            {
                foreach (EHigiene item in Enum.GetValues(typeof(EHigiene)))
                {
                    if (item.ToString().Equals(stg))
                    {
                        rta = item;
                        break;
                    }
                }
            }
            return rta;
        }

        public ELimpieza ParceLimpieza(string stg)
        {
            ELimpieza rta = 0;

            if (stg is not null)
            {

                foreach (ELimpieza item in Enum.GetValues(typeof(ELimpieza)))
                {
                    if (item.ToString().Equals(stg))
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        public EGolocinas ParceGolocinas(string stg)
        {
            EGolocinas rta = 0;

            if (stg is not null)
            {

                foreach (EGolocinas item in Enum.GetValues(typeof(EGolocinas)))
                {
                    if (item.ToString().Equals(stg))
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        public EOtros ParceOtros(string stg)
        {
            EOtros rta = 0;

            if (stg is not null)
            {

                foreach (EOtros item in Enum.GetValues(typeof(EOtros)))
                {
                    if (item.ToString().Equals(stg))
                    {
                        rta = item;
                        break;
                    }
                }
            }

            return rta;
        }

        #endregion
    }
}
