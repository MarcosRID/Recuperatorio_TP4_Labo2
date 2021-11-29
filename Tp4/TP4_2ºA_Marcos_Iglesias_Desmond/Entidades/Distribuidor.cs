using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Distribuidor
    {

        private List<Producto> lista_de_productos;


        #region Constructores
        public List<Producto> Lista_de_productos
        {
            get { return this.lista_de_productos; }
            set { this.lista_de_productos = value; }
        }


        public Distribuidor()
        {
            lista_de_productos = new List<Producto>();
        }
        #endregion



        #region Metodods
        /// <summary>
        /// Lista los productos congelados PreCargados
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listaProductos"></param>
        /// <returns></returns>
        public static List<ProductoCongelado<T>> listarProductosCongelado<T>(List<Producto> listaProductos) where T : Enum
        {
            try
            {
                List<ProductoCongelado<T>> lista1 = ProductoCongelado<T>.FiltrarLista(listaProductos);

                return lista1;
            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e);
            }

            return null;
        }

        /// <summary>
        /// Lista los productos NO congelados PreCargados
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listaProductos"></param>
        /// <returns></returns>
        public static List<ProductoNoCongelado<T>> listarProductosNoCongelado<T>(List<Producto> listaProductos) where T : Enum
        {
            try
            {
                List<ProductoNoCongelado<T>> lista2 = ProductoNoCongelado<T>.FiltrarLista(listaProductos);

                return lista2;
            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e);
            }

            return null;
        }
        #endregion



        #region metodo harcodeado
        public void harcodearDatos()
        {
            //Productos Congelados
            #region ECarnes
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Asado_de_ternera.ToString(), 70001));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 70002));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_angosto.ToString(), 70003));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Cuadril.ToString(), 70004));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Falda.ToString(), 70005));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Lomo.ToString(), 70006));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Nalga.ToString(), 70007));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Paleta.ToString(), 70008));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Picada_comun.ToString(), 70009));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Picada_especial.ToString(), 70010));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Roast_beef.ToString(), 70011));
            this.lista_de_productos.Add(new ProductoCongelado<ECarnes>(ECarnes.Vacio_de_ternera.ToString(), 70012));
            #endregion

            #region ELacteos
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Dulce_de_leche.ToString(), 10010));
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Leber_wurst.ToString(), 10011));
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Leche.ToString(), 10012));
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Manteca.ToString(), 10013));
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Queso_cremoso.ToString(), 10014));
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Queso_rallado.ToString(), 10015));
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Queso_Untable.ToString(), 10016));
            this.lista_de_productos.Add(new ProductoCongelado<ELacteos>(ELacteos.Yoghurt.ToString(), 10017));
            #endregion


            // Productos NO Congelados
            #region EVerduras
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Achicoria.ToString(), 200210));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Acelga.ToString(), 200211));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Apio.ToString(), 200212));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Batata.ToString(), 200213));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Berenjena.ToString(), 200214));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Brocoli.ToString(), 200215));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Calabaza.ToString(), 200216));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Cebolla.ToString(), 200217));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Chaucha_chata.ToString(), 200218));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Chaucha_rolito.ToString(), 200219));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Choclo.ToString(), 200220));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Coliflor.ToString(), 200321));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Espinaca.ToString(), 200322));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Crespa.ToString(), 200324));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Mantecosa.ToString(), 200325));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Morada.ToString(), 200326));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Lechuga_Repollada.ToString(), 70, 200327, 100, true, EVerduras.Lechuga_Repollada));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Pepino.ToString(), 200328));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Perejil.ToString(), 200329));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Pimiento_rojo.ToString(), 200420));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Pimiento_verde.ToString(), 200421));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Puerro.ToString(), 200422));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Rabanito.ToString(), 200423));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Remolacha.ToString(), 200424));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Repollo_blanco.ToString(), 200425));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Repollo_morado.ToString(), 200426));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Rucula.ToString(), 200427));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.tomate_perita.ToString(), 200428));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Tomate_redondo.ToString(), 200439));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Verdeo.ToString(), 200540));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Zanahoria.ToString(), 200541));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Zapallito_verde.ToString(), 200542));
            this.lista_de_productos.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Zapallo.ToString(), 200543));
            #endregion

            #region EFruta
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Banana.ToString(), 30010));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Ciruela.ToString(), 30011));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Ciruela_amarilla.ToString(), 30012));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Durazno.ToString(), 30013));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Frutilla.ToString(), 30014));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Higo.ToString(), 30015));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Kaki.ToString(), 30016));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Limon.ToString(), 30017));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Mandarina.ToString(), 30018));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Mango.ToString(), 30019));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Manzana.ToString(), 30020));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Manzana_verde.ToString(), 30021));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Melon.ToString(), 30022));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Naranja.ToString(), 30023));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Papa_blanca.ToString(), 30024));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Papa_negra.ToString(), 30025));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Pelon.ToString(), 30026));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Peras.ToString(), 30027));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Sandia.ToString(), 30028));
            this.lista_de_productos.Add(new ProductoNoCongelado<EFrutas>(EFrutas.Uva.ToString(), 30029));
            #endregion

            #region EHigiene
            this.lista_de_productos.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Acondicionador.ToString(), 40001));
            this.lista_de_productos.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Cepillo_dental.ToString(), 40002));
            this.lista_de_productos.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Dentrifico.ToString(), 40003));
            this.lista_de_productos.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Hilo_dental.ToString(), 40004));
            this.lista_de_productos.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Javon_Dave.ToString(), 40005));
            this.lista_de_productos.Add(new ProductoNoCongelado<EHigiene>(EHigiene.Shampo.ToString(), 40006));
            #endregion

            #region ELimpieza
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Acaroina.ToString(), 50010));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Cera.ToString(), 50011));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Cloro.ToString(), 50012));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Desengrasante_multiuso.ToString(), 50013));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Detergente_magistral.ToString(), 50014));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Escobillon.ToString(), 50015));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Escobillon_economico.ToString(), 50016));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Escobillon_esquinero.ToString(), 50017));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Esponja.ToString(), 50018));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Esponja_viruta.ToString(), 50029));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Franela.ToString(), 50020));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Jabon_liquido_Ariel.ToString(), 50021));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Jabon_liquido_Skip.ToString(), 50022));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Javon_blanco.ToString(), 50023));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Javon_en_polvo_ala.ToString(), 50024));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Javon_en_polvo_querivin.ToString(), 50025));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Lavandina_ropa_blanca.ToString(), 50026));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Paño_amarillo.ToString(), 50027));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Perfuminas.ToString(), 50028));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Repasador.ToString(), 50039));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Secador.ToString(), 50030));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Suavizante_vivere.ToString(), 50031));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Trapo_de_piso_blanco.ToString(), 50032));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Trapo_de_piso_gris.ToString(), 50033));
            this.lista_de_productos.Add(new ProductoNoCongelado<ELimpieza>(ELimpieza.Trapo_rejilla.ToString(), 50034));
            #endregion

            #region EGolocina 
            this.lista_de_productos.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Bombon.ToString(), 60011));
            this.lista_de_productos.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Caramelo.ToString(), 60012));
            this.lista_de_productos.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Chicle.ToString(), 60013));
            this.lista_de_productos.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Chocolate.ToString(), 60014));
            this.lista_de_productos.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Chupetin.ToString(), 60015));
            this.lista_de_productos.Add(new ProductoNoCongelado<EGolocinas>(EGolocinas.Paleta.ToString(), 60016));
            #endregion

        }
        #endregion
    }
}
