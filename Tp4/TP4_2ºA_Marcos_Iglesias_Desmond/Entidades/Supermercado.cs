using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Supermercado : Inventario
    {

        #region Atributos / Propiedades
        private int id_mercado;
        private string nombre;
        List<Producto> miInventario;
        List<Ticket> historial_de_venta;

        public int Id_mercado
        {
            get
            {
                return this.id_mercado;
            }
            set
            {
                this.id_mercado = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public override List<Producto> MiInventario
        {
            get
            {
                return this.miInventario;
            }
            set
            {
                this.miInventario = value;
            }
        }

        public override List<Ticket> Historial_de_venta
        {
            get
            {
                return this.historial_de_venta;
            }
            set
            {
                this.historial_de_venta = value;
            }
        }
        #endregion


        #region Constructores
        public Supermercado()
        {
            this.MiInventario = new List<Producto>();
            this.Historial_de_venta = new List<Ticket>();
        }

        public Supermercado(int id, string nombre) : this()
        {
            this.id_mercado = id;
            this.nombre = nombre;
        }
        #endregion


        #region Metodos


        /// <summary>
        /// Verefica que exista el produco
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public bool ExisteProducto(Producto producto)
        {
            bool rta = false;

            if (this.miInventario is not null)
            {
                foreach (Producto item in this.miInventario)
                {
                    if (item == producto)
                    {rta = true;}
                }
            }
            return rta;
        }


        /// <summary>
        /// Retorna lista con productos con Stock en Cero 
        /// </summary>
        /// <returns></returns>
        public List<Producto> ProductosNulos()
        {
            List<Producto> listaEscasos = new List<Producto>();

            if (this.MiInventario is not null)
            {

                foreach (Producto item in this.MiInventario)
                {
                    if (!item.Stock_SI_NO)
                    {
                        listaEscasos.Add(item);
                    }
                }

            }

            return listaEscasos;
        }


        /// <summary>
        /// Retorna lista de productos con Stock menor a 10.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ProductosEscasos()
        {
            List<Producto> listaEscasos = new List<Producto>();

            if (this.MiInventario is not null)
            {

                foreach (Producto item in this.MiInventario)
                {
                    if (item.Stock < 10 && item.Stock_SI_NO)
                    {
                        listaEscasos.Add(item);
                    }
                }

            }

            return listaEscasos;
        }



        public Producto ParceProducto(int codigo)
        {
            Producto producto = null;

            foreach (Producto item in miInventario)
            {
                if (item.Codigo == codigo)
                {
                    producto = item;
                }
            }

            return producto;
        }

        #endregion


        #region Productos Hardcodeados
        public void harcodearDatos()
        {
            //Productos Congelados
            #region ECarnes


            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Asado_de_ternera.ToString(), 120, 70001, 100, true, ECarnes.Asado_de_ternera));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_angosto.ToString(), 160, 70003, 100, true, ECarnes.Bife_angosto));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Cuadril.ToString(), 170, 70004, 100, true, ECarnes.Cuadril));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Falda.ToString(), 185, 70005, 100, true, ECarnes.Falda));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Lomo.ToString(), 200, 70006, 100, true, ECarnes.Lomo));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Nalga.ToString(), 90, 70007, 100, true, ECarnes.Nalga));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Paleta.ToString(), 100, 70008, 100, true, ECarnes.Paleta));
            this.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Picada_comun.ToString(), 110, 70009, 100, true, ECarnes.Picada_comun));
            #endregion

            #region ELacteos
            this.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Dulce_de_leche.ToString(), 70, 10010, 100, true, ELacteos.Dulce_de_leche));
            this.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Leber_wurst.ToString(), 50, 10011, 100, true, ELacteos.Leber_wurst));
            this.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Leche.ToString(), 75, 10012, 100, true, ELacteos.Leche));
            this.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Manteca.ToString(), 110, 10013, 100, true, ELacteos.Manteca));
            this.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Queso_cremoso.ToString(), 150, 10014, 0, false, ELacteos.Queso_cremoso));
            #endregion


            // Productos NO Congelados
            #region EVerduras
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Achicoria.ToString(), 30, 200210, 100, true, EVerduras.Achicoria));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Acelga.ToString(), 50, 200211, 100, true, EVerduras.Acelga));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Apio.ToString(), 60, 200212, 100, true, EVerduras.Apio));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Batata.ToString(), 90, 200213, 100, true, EVerduras.Batata));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Berenjena.ToString(), 90, 200214, 100, true, EVerduras.Berenjena));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Brocoli.ToString(), 120, 200215, 10, true, EVerduras.Brocoli));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Calabaza.ToString(), 140, 200216, 9, true, EVerduras.Calabaza));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Cebolla.ToString(), 80, 200217, 100, true, EVerduras.Cebolla));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Chaucha_chata.ToString(), 85, 200218, 100, true, EVerduras.Chaucha_chata));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Chaucha_rolito.ToString(), 50, 200219, 100, true, EVerduras.Chaucha_rolito));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Choclo.ToString(), 50, 200220, 100, true, EVerduras.Choclo));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Coliflor.ToString(), 90, 200321, 4, true, EVerduras.Coliflor));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Espinaca.ToString(), 80, 200322, 100, true, EVerduras.Espinaca));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Crespa.ToString(), 70, 200324, 15, true, EVerduras.Lechuga_Crespa));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Mantecosa.ToString(), 70, 200325, 100, true, EVerduras.Lechuga_Mantecosa));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Morada.ToString(), 70, 200326, 100, true, EVerduras.Lechuga_Morada));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Repollada.ToString(), 70, 200327, 100, true, EVerduras.Lechuga_Repollada));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Pepino.ToString(), 40, 200328, 100, true, EVerduras.Pepino));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Perejil.ToString(), 50, 200329, 100, true, EVerduras.Perejil));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Pimiento_rojo.ToString(), 65, 200420, 100, true, EVerduras.Pimiento_rojo));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Pimiento_verde.ToString(), 65, 200421, 100, true, EVerduras.Pimiento_verde));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Puerro.ToString(), 55, 200422, 100, true, EVerduras.Puerro));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Rabanito.ToString(), 46, 200423, 100, true, EVerduras.Rabanito));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Remolacha.ToString(), 75, 200424, 100, true, EVerduras.Remolacha));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Repollo_blanco.ToString(), 80, 200425, 100, true, EVerduras.Repollo_blanco));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Repollo_morado.ToString(), 164, 200426, 100, true, EVerduras.Repollo_morado));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Rucula.ToString(), 110, 200427, 100, true, EVerduras.Rucula));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.tomate_perita.ToString(), 90, 200428, 100, true, EVerduras.tomate_perita));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Tomate_redondo.ToString(), 16, 200439, 100, true, EVerduras.Tomate_redondo));
            this.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Verdeo.ToString(), 20, 200540, 100, true, EVerduras.Verdeo));
            #endregion

            #region EFruta
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Banana.ToString(), 120, 30010, 100, true, EFrutas.Banana));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Ciruela.ToString(), 110, 30011, 100, true, EFrutas.Ciruela));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Ciruela_amarilla.ToString(), 100, 30012, 100, true, EFrutas.Ciruela_amarilla));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Durazno.ToString(), 90, 30013, 100, true, EFrutas.Durazno));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Frutilla.ToString(), 95, 30014, 100, true, EFrutas.Frutilla));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Higo.ToString(), 110, 30015, 100, true, EFrutas.Higo));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Kaki.ToString(), 80, 30016, 100, true, EFrutas.Kaki));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Limon.ToString(), 95, 30017, 0, false, EFrutas.Limon));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Mandarina.ToString(), 46, 30018, 100, true, EFrutas.Mandarina));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Mango.ToString(), 45, 30019, 100, true, EFrutas.Mango));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Manzana.ToString(), 55, 30020, 100, true, EFrutas.Manzana));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Manzana_verde.ToString(), 50, 30021, 0, false, EFrutas.Manzana_verde));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Melon.ToString(), 100, 30022, 0, false, EFrutas.Melon));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Naranja.ToString(), 70, 30023, 100, true, EFrutas.Naranja));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Papa_blanca.ToString(), 80, 30024, 9, true, EFrutas.Papa_blanca));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Papa_negra.ToString(), 70, 30025, 10, true, EFrutas.Papa_negra));
            this.MiInventario.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Pelon.ToString(), 75, 30026, 100, true, EFrutas.Pelon));
            #endregion

            #region EHigiene
            this.MiInventario.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Acondicionador.ToString(), 200, 40001, 100, true, EHigiene.Acondicionador));
            this.MiInventario.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Cepillo_dental.ToString(), 150, 40002, 100, true, EHigiene.Cepillo_dental));
            this.MiInventario.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Dentrifico.ToString(), 110, 40003, 100, true, EHigiene.Dentrifico));
            this.MiInventario.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Hilo_dental.ToString(), 50, 40004, 100, true, EHigiene.Hilo_dental));
            #endregion

            #region ELimpieza
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Acaroina.ToString(), 170, 50010, 100, true, ELimpieza.Acaroina));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Cera.ToString(), 110, 50011, 100, true, ELimpieza.Cera));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Cloro.ToString(), 160, 50012, 100, true, ELimpieza.Cloro));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Desengrasante_multiuso.ToString(), 150, 50013, 100, true, ELimpieza.Desengrasante_multiuso));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Detergente_magistral.ToString(), 150, 50014, 100, true, ELimpieza.Detergente_magistral));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Escobillon.ToString(), 100, 50015, 100, true, ELimpieza.Escobillon));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Escobillon_economico.ToString(), 200, 50016, 100, true, ELimpieza.Escobillon_economico));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Escobillon_esquinero.ToString(), 200, 50017, 100, true, ELimpieza.Escobillon_esquinero));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Esponja.ToString(), 70, 50018, 100, true, ELimpieza.Esponja));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Esponja_viruta.ToString(), 75, 50029, 100, true, ELimpieza.Esponja_viruta));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Franela.ToString(), 60, 50020, 100, true, ELimpieza.Franela));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Jabon_liquido_Ariel.ToString(), 190, 50021, 100, true, ELimpieza.Jabon_liquido_Ariel));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Jabon_liquido_Skip.ToString(), 180, 50022, 100, true, ELimpieza.Jabon_liquido_Skip));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Javon_blanco.ToString(), 70, 50023, 100, true, ELimpieza.Javon_blanco));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Javon_en_polvo_ala.ToString(), 85, 50024, 100, true, ELimpieza.Javon_en_polvo_ala));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Javon_en_polvo_querivin.ToString(), 90, 50025, 100, true, ELimpieza.Javon_en_polvo_querivin));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Lavandina_ropa_blanca.ToString(), 250, 50026, 100, true, ELimpieza.Lavandina_ropa_blanca));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Paño_amarillo.ToString(), 75, 50027, 100, true, ELimpieza.Paño_amarillo));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Perfuminas.ToString(), 55, 50028, 100, true, ELimpieza.Perfuminas));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Repasador.ToString(), 50, 50039, 100, true, ELimpieza.Repasador));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Secador.ToString(), 200, 50030, 100, true, ELimpieza.Secador));
            this.MiInventario.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Suavizante_vivere.ToString(), 180, 50031, 100, true, ELimpieza.Suavizante_vivere));
            #endregion

            #region EGolocina 
            this.MiInventario.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Bombon.ToString(), 100, 60011, 100, true, EGolocinas.Bombon));
            this.MiInventario.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Caramelo.ToString(), 15, 60012, 100, true, EGolocinas.Caramelo));
            this.MiInventario.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Chicle.ToString(), 10, 60013, 100, true, EGolocinas.Chicle));
            this.MiInventario.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Chocolate.ToString(), 100, 60014, 100, true, EGolocinas.Chocolate));
            #endregion

        }


        public void harcodearDatosTickets()
        {
            List<ProductoSeleccionado> listaProductoSeleccionados1 = new List<ProductoSeleccionado>();

            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)miInventario[0],3));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)miInventario[3],3));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)miInventario[5],10));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)miInventario[7],1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)miInventario[8],2));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)miInventario[10],1));
            
            List<ProductoSeleccionado> listaProductoSeleccionados2 = new List<ProductoSeleccionado>();

            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)miInventario[11],13));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)miInventario[12],3));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)miInventario[13],1));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)miInventario[7],1));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)miInventario[16],2));
            listaProductoSeleccionados2.Add(new ProductoSeleccionado((Producto)miInventario[22],1));
            
            List<ProductoSeleccionado> listaProductoSeleccionados3 = new List<ProductoSeleccionado>();

            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)miInventario[0],3));
            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)miInventario[3],3));
            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)miInventario[5],11));
            listaProductoSeleccionados3.Add(new ProductoSeleccionado((Producto)miInventario[10],1));

            historial_de_venta.Add(new Ticket(listaProductoSeleccionados1, 'B'));
            historial_de_venta.Add(new Ticket(listaProductoSeleccionados2, 'B'));
            historial_de_venta.Add(new Ticket(listaProductoSeleccionados3, 'B'));
            
        }
        #endregion
    }
}
