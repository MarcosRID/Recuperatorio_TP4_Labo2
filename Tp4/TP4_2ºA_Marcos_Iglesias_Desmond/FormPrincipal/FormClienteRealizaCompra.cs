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
    public partial class FormClienteRealizaCompra : Form
    {
        FormPrincipal formPrincipalPadre;
        List<ProductoSeleccionado> listaCarrito;

        public FormClienteRealizaCompra(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            formPrincipalPadre = formPrincipal;
            listaCarrito = new List<ProductoSeleccionado>();
        }



        private void rbtnCarne_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoCongelado<ECarnes>> lista = ProductoCongelado<ECarnes>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;
        }

        private void rbtnLacteo_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoCongelado<ELacteos>> lista = ProductoCongelado<ELacteos>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;
        }

        private void rbtnVegetales_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoNoCongelado<EVerduras>> lista = ProductoNoCongelado<EVerduras>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;

        }

        private void rbtnFrutas_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoNoCongelado<EFrutas>> lista = ProductoNoCongelado<EFrutas>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;

        }

        private void rbtnHigiene_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoNoCongelado<EHigiene>> lista = ProductoNoCongelado<EHigiene>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;

        }

        private void rbtnLimpieza_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoNoCongelado<ELimpieza>> lista = ProductoNoCongelado<ELimpieza>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;

        }

        private void rbtnGolosina_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoNoCongelado<EGolocinas>> lista = ProductoNoCongelado<EGolocinas>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;

        }

        private void rbtnOtros_CheckedChanged(object sender, EventArgs e)
        {
            this.dtgGondola.DataSource = null;
            List<ProductoNoCongelado<EOtros>> lista = ProductoNoCongelado<EOtros>.FiltrarLista(formPrincipalPadre.supermercado.MiInventario);
            this.dtgGondola.DataSource = lista;

        }


        /// <summary>
        /// Añade productos al carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgGondola_DoubleClick(object sender, EventArgs e)
        {

            try
            {


                ProductoSeleccionado productoSeleccionado = new((Producto)this.dtgGondola.CurrentRow.DataBoundItem, 1);
                foreach (ProductoSeleccionado item in listaCarrito)
                {
                    if (productoSeleccionado == item)
                    {
                        productoSeleccionado = null;
                    }
                }

                if (productoSeleccionado is not null)
                {
                    this.formPrincipalPadre.supermercado.MiInventario = productoSeleccionado - this.formPrincipalPadre.supermercado.MiInventario;

                    listaCarrito.Add(productoSeleccionado);
                }

                this.dtgCarrito.DataSource = null;
                this.dtgCarrito.DataSource = listaCarrito;
                this.dtgCarrito.Columns["Stock_SI_NO"].Visible = false;
                this.dtgCarrito.Columns["Stock"].Visible = false;
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }

        private void nudCantidadDeUnidades_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (this.dtgCarrito.CurrentRow is not null)
                { 

                    if (this.nudCantidadDeUnidades.Value > 0) 
                    {

                        Producto productoActual = (Producto)this.dtgCarrito.CurrentRow.DataBoundItem;


                        foreach (Producto item in listaCarrito)
                        {
                            if (productoActual == item)
                            {

                                if ((int)this.nudCantidadDeUnidades.Value > ((ProductoSeleccionado)productoActual).Cantidad)
                                {
                                    int diferecia = (int)this.nudCantidadDeUnidades.Value - ((ProductoSeleccionado)productoActual).Cantidad;
                                    this.formPrincipalPadre.supermercado.MiInventario = (new ProductoSeleccionado(productoActual, diferecia) - this.formPrincipalPadre.supermercado.MiInventario);
                                }
                                else
                                {
                                    int diferecia = ((ProductoSeleccionado)productoActual).Cantidad - (int)this.nudCantidadDeUnidades.Value;
                                    this.formPrincipalPadre.supermercado.MiInventario += new ProductoSeleccionado(productoActual, diferecia);

                                }

                                ((ProductoSeleccionado)productoActual).Cantidad = (int)this.nudCantidadDeUnidades.Value;


                                break;
                            }
                        }

                        this.dtgCarrito.DataSource = null;
                        this.dtgCarrito.DataSource = listaCarrito;
                    }
                }
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Archivos<Exception>.SerializarExceptionATexto(aore);
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }

        private void btnEliminarProductoCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgCarrito.CurrentRow is not null)
                {

                    foreach (Producto item in listaCarrito)
                    {
                        if ((Producto)this.dtgCarrito.CurrentRow.DataBoundItem == item)
                        {
                            listaCarrito -= item;
                            break;
                        }
                    }

                    this.dtgCarrito.DataSource = null;
                    this.dtgCarrito.DataSource = listaCarrito;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtgCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtgCarrito.CurrentCell is not null)
                {
                    this.nudCantidadDeUnidades.Value = ((ProductoSeleccionado)this.dtgCarrito.CurrentRow.DataBoundItem).Cantidad;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnIrACaja_Click(object sender, EventArgs e)
        {

            if (listaCarrito is not null && this.dtgCarrito.CurrentCell is not null)
            {
                formPrincipalPadre.listaClientes.Enqueue(new Cliente(listaCarrito, $"Cliente Nº:{formPrincipalPadre.listaClientes.Count}"));

                this.Close();
            }
        }

        private void dtgGondola_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dtgGondola.Columns["Stock"].Visible = false;
            this.dtgGondola.Columns["Stock_SI_NO"].Visible = false;
            this.dtgGondola.Columns["Categoria"].Visible = false;
        }


    }
}
