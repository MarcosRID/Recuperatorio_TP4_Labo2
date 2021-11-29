using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {

        #region Atributos / Propiedades

        List<ProductoSeleccionado> listaProducto;
        private string usuario;

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public List<ProductoSeleccionado> ListaProducto
        {
            get { return this.listaProducto; }
        }

        #endregion
        

        public Cliente(List<ProductoSeleccionado> lp,string usuario)
        {
            this.usuario = usuario;
            this.listaProducto = lp;
        }
    
        
    }
}
