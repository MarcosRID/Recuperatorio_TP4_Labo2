using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestProductoCongelado
    {
        [TestMethod]
        public void Test_FiltrarLista1()
        {
            Supermercado supermercado = new Supermercado();
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            supermercado.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Leche.ToString(), 75, 10012, 100, true, ELacteos.Leche));
            supermercado.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Manteca.ToString(), 110, 10013, 100, true, ELacteos.Manteca));
            supermercado.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Queso_cremoso.ToString(), 150, 10014, 0, false, ELacteos.Queso_cremoso));
            supermercado.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Achicoria.ToString(), 30, 200210, 100, true, EVerduras.Achicoria));
            supermercado.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Acelga.ToString(), 50, 200211, 100, true, EVerduras.Acelga));

            List<ProductoCongelado<ECarnes>> lista = new List<ProductoCongelado<ECarnes>>();
            lista.Add((ProductoCongelado<ECarnes>)supermercado.MiInventario[0]);
            List<ProductoCongelado<ELacteos>> listaRespuesta;


            // ACT
            listaRespuesta = ProductoCongelado<ELacteos>.FiltrarLista(supermercado.MiInventario);

            for (int i = 0; i < lista.Count; i++)
            {
                Assert.AreNotEqual(lista[i], listaRespuesta[i]);
            }

        }

        [TestMethod]
        public void Test_FiltrarLista2()
        {
            List<ProductoCongelado<ELacteos>> listaRespuesta;


            // ACT
            listaRespuesta = ProductoCongelado<ELacteos>.FiltrarLista(null);


            Assert.IsNotNull(listaRespuesta);
        }  
        
     

        public void Test_FiltrarLista3()
        {
            Supermercado supermercado = new Supermercado();
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            supermercado.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Leche.ToString(), 75, 10012, 100, true, ELacteos.Leche));
            supermercado.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Manteca.ToString(), 110, 10013, 100, true, ELacteos.Manteca));
            supermercado.MiInventario.Add(new ProductoCongelado<ELacteos>(ELacteos.Queso_cremoso.ToString(), 150, 10014, 0, false, ELacteos.Queso_cremoso));
            supermercado.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Achicoria.ToString(), 30, 200210, 100, true, EVerduras.Achicoria));
            supermercado.MiInventario.Add(new ProductoNoCongelado<EVerduras>(EVerduras.Acelga.ToString(), 50, 200211, 100, true, EVerduras.Acelga));

            List<ProductoCongelado<ECarnes>> lista = new List<ProductoCongelado<ECarnes>>();
            lista.Add((ProductoCongelado<ECarnes>)supermercado.MiInventario[0]);
            List<ProductoCongelado<ECarnes>> listaRespuesta;


            // ACT
            listaRespuesta = ProductoCongelado<ECarnes>.FiltrarLista(supermercado.MiInventario);

            for (int i = 0; i < lista.Count; i++)
            {
                Assert.AreNotEqual(lista[i], listaRespuesta[i]);
            }

        }
    }
}
