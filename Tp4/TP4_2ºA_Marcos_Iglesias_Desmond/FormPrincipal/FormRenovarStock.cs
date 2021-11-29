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
    public delegate void Refrescar(List<Producto> listaProducto);

    public partial class formRenovarStock : Form
    {

        FormPrincipal formPrincipalPadre;
        event Refrescar refrescar;


        public formRenovarStock(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipalPadre = formPrincipal;
            this.refrescar = Actualizar;
        }

        private void formRenovarStock_Load(object sender, EventArgs e)
        {

            #region ComboBox filtroInventario
            this.cmbFiltroInventario.Items.Add("Listar inventario");
            this.cmbFiltroInventario.Items.Add("Unidades/Poco stock");
            this.cmbFiltroInventario.Items.Add("unidades/sin stock");
            this.cmbFiltroInventario.SelectedIndex = 0;
            #endregion

            #region ComboBox tipoProductos del proveedor
            this.cmbListaTiposProductos.Items.Add("Carnes");
            this.cmbListaTiposProductos.Items.Add("Lacteos");
            this.cmbListaTiposProductos.Items.Add("Frutas");
            this.cmbListaTiposProductos.Items.Add("Golocinas");
            this.cmbListaTiposProductos.Items.Add("Higiene");
            this.cmbListaTiposProductos.Items.Add("Limpieza");
            this.cmbListaTiposProductos.Items.Add("Verduras");
            this.cmbListaTiposProductos.Items.Add("Otros");
            this.cmbListaTiposProductos.SelectedIndex = 0;

            #endregion


            this.dtgMiInventaro.DataSource = formPrincipalPadre.supermercado.MiInventario;
            this.dtgMiInventaro.Columns["Stock_SI_NO"].Visible = false;
            this.dtgMiInventaro.AllowUserToResizeColumns = false;
            this.dtgMiInventaro.AllowUserToResizeRows = false;

            this.dtgProveedor.AllowUserToResizeColumns = false;
            this.dtgProveedor.AllowUserToResizeRows = false;
        }


        private void cmbFiltroInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.cmbFiltroInventario.SelectedIndex;

            switch (indice)
            {
                case 0:
                    this.dtgMiInventaro.DataSource = formPrincipalPadre.supermercado.MiInventario;
                    break;
                case 1:
                    this.dtgMiInventaro.DataSource = formPrincipalPadre.supermercado.ProductosEscasos();
                    break;
                case 2:
                    this.dtgMiInventaro.DataSource = formPrincipalPadre.supermercado.ProductosNulos();
                    break;
            }
        }


        private void cmbListaTiposProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = this.cmbListaTiposProductos.SelectedIndex;

            switch (indice)
            {
                case 0:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosCongelado<ECarnes>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
                case 1:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosCongelado<ELacteos>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
                case 2:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosNoCongelado<EFrutas>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
                case 3:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosNoCongelado<EGolocinas>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
                case 4:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosNoCongelado<EHigiene>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
                case 5:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosNoCongelado<ELimpieza>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
                case 6:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosNoCongelado<EVerduras>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
                case 7:
                    this.dtgProveedor.DataSource = Distribuidor.listarProductosNoCongelado<EOtros>(formPrincipalPadre.distribuidor.Lista_de_productos);
                    break;
            }
        }


        private void dtgProveedor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dtgProveedor.Columns["Stock"].Visible = false;
            this.dtgProveedor.Columns["Stock_SI_NO"].Visible = false;
            this.dtgProveedor.Columns["Categoria"].Visible = false;
            this.dtgProveedor.Columns["Precio"].Visible = false;
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dtgProveedor.CurrentRow is not null)
                {

                    Producto producto = (Producto)this.dtgProveedor.CurrentRow.DataBoundItem;

                    if (!formPrincipalPadre.supermercado.ExisteProducto(producto))
                    {
                        if (producto is ProductoCongelado<ECarnes>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoCongelado<ECarnes>)producto).Categoria));
                        }
                        else if (producto is ProductoCongelado<ELacteos>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoCongelado<ELacteos>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoCongelado<ELacteos>)producto).Categoria));

                        }
                        else if (producto is ProductoNoCongelado<EFrutas>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoNoCongelado<EFrutas>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoNoCongelado<EFrutas>)producto).Categoria));

                        }
                        else if (producto is ProductoNoCongelado<EGolocinas>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoNoCongelado<EGolocinas>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoNoCongelado<EGolocinas>)producto).Categoria));

                        }
                        else if (producto is ProductoNoCongelado<EHigiene>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoNoCongelado<EHigiene>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoNoCongelado<EHigiene>)producto).Categoria));

                        }
                        else if (producto is ProductoNoCongelado<ELimpieza>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoNoCongelado<ELimpieza>)producto).Categoria));

                        }
                        else if (producto is ProductoNoCongelado<EVerduras>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoNoCongelado<EVerduras>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoNoCongelado<EVerduras>)producto).Categoria));
                        }
                        else if (producto is ProductoNoCongelado<EOtros>)
                        {
                            formPrincipalPadre.supermercado.MiInventario.Add(new ProductoNoCongelado<EOtros>(producto.Nombre, (int)this.nudColocarPrecio.Value, producto.Codigo, (int)this.nudCantidadAComprar.Value, true, ((ProductoNoCongelado<EOtros>)producto).Categoria));
                        }
                    }
                    else
                    {
                        foreach (Producto item in formPrincipalPadre.supermercado.MiInventario)
                        {
                            if (item == producto)
                            {
                                item.Stock += ((int)this.nudCantidadAComprar.Value);
                            }
                        }
                    }
                    this.refrescar(formPrincipalPadre.supermercado.MiInventario);
                }
            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }


        private void dtgProveedor_Click(object sender, EventArgs e)
        {
            if (this.dtgProveedor.CurrentRow is null)
            {
                this.btnComprar.Enabled = false;
            }
            else
            {
                this.btnComprar.Enabled = true;

                if (formPrincipalPadre.supermercado.ExisteProducto((Producto)this.dtgProveedor.CurrentRow.DataBoundItem))
                {
                    this.nudColocarPrecio.Visible = false;
                    this.lblPrecio.Visible = false;
                }
                else
                {
                    this.nudColocarPrecio.Visible = true;
                    this.lblPrecio.Visible = true;
                }
            }
        }


        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                FormEditarProducto formEditarProducto = new FormEditarProducto(formPrincipalPadre, ((Producto)this.dtgMiInventaro.CurrentRow.DataBoundItem).Codigo);

                formEditarProducto.ShowDialog();

                this.refrescar(formPrincipalPadre.supermercado.MiInventario);

            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dtgMiInventaro.CurrentCell is not null)
                {
                    MessageBox.Show($"Produco {((Producto)this.dtgMiInventaro.CurrentRow.DataBoundItem).Nombre} ha sido eliminado");
                    formPrincipalPadre.supermercado.MiInventario -= (Producto)this.dtgMiInventaro.CurrentRow.DataBoundItem;
                    this.refrescar(formPrincipalPadre.supermercado.MiInventario);
                }

            }
            catch (Exception ex)
            {
                Archivos<Exception>.SerializarExceptionATexto(ex);
            }

        }

        public void Actualizar(List<Producto> listaProductos)
        {
            if (this.dtgMiInventaro.DataSource is not null)
            {
                this.dtgMiInventaro.DataSource = null;
            }

            this.dtgMiInventaro.DataSource = listaProductos;

        }

        private void dtgMiInventaro_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dtgMiInventaro.Columns["Stock_SI_NO"].Visible = false;
        }
    }
}