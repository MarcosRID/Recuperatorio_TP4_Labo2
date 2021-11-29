using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoCongelado<T> : Producto ,IProductosCongelados
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

        public ProductoCongelado()
        { }

        public ProductoCongelado(string nombre, int codigo) : base(nombre, 0, codigo)
        { }

        public ProductoCongelado(string nombre, double precio, int codigo, int stock, bool stock_SI_NO, T categoria)
        : base(nombre, precio, codigo, stock, stock_SI_NO)
        {
            this.categoria = categoria;
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Filtra los productos de una lista generica de productos , en una lista especica de tipo T : Enum
        /// </summary>
        /// <param name="lProductos1"></param>
        /// <returns></returns>
        public static List<ProductoCongelado<T>> FiltrarLista(List<Producto> lProductos1)
        {
            List<ProductoCongelado<T>> listaGenericaT = new List<ProductoCongelado<T>>();

            try
            {
                if (lProductos1 is not null)
                {
                    foreach (Producto item in lProductos1)
                    {
                        if (item is ProductoCongelado<T>)
                        {
                            listaGenericaT.Add((ProductoCongelado<T>)item);
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

        public ECarnes ParceCarne(string stg)
        {
            ECarnes rta = 0;

            if (stg is not null)
            {

                foreach (ECarnes item  in Enum.GetValues(typeof(ECarnes)))
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


        public ELacteos ParceLacteo(string stg)
        {
            ELacteos rta =0;

            if (stg is not null)
            {

                foreach (ELacteos item in Enum.GetValues(typeof(ELacteos)))
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
