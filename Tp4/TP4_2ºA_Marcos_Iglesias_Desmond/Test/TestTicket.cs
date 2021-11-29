using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestTicket
    {
        [TestMethod]
        public void Test_CalcularMontoTotal1()
        {
            Supermercado supermercado = new Supermercado();
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Asado_de_ternera.ToString(), 120, 70001, 100, true, ECarnes.Asado_de_ternera));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_angosto.ToString(), 160, 70003, 100, true, ECarnes.Bife_angosto));

            List<ProductoSeleccionado> listaProductoSeleccionados1 = new List<ProductoSeleccionado>();
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[0], 1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[1], 1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[2], 1));
            double respuesta;
            double respuestaEsperada = 430;

            respuesta = Ticket.CalcularMontoTotal(listaProductoSeleccionados1);


            Assert.AreEqual(respuestaEsperada,respuesta);
        }
        
        [TestMethod]
        public void Test_CalcularMontoTotal2()
        {
            Supermercado supermercado = new Supermercado();
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Asado_de_ternera.ToString(), 120, 70001, 100, true, ECarnes.Asado_de_ternera));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_angosto.ToString(), 160, 70003, 100, true, ECarnes.Bife_angosto));

            List<ProductoSeleccionado> listaProductoSeleccionados1 = new List<ProductoSeleccionado>();
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[0], 1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[1], 1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[2], 1));
            double respuesta;
            double respuestaEsperada = 40;

            respuesta = Ticket.CalcularMontoTotal(listaProductoSeleccionados1);


            Assert.AreNotEqual(respuestaEsperada,respuesta);
        }  
        

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void Test_CalcularMontoTotal3()
        {
            Supermercado supermercado = new Supermercado();
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Asado_de_ternera.ToString(), 120, 70001, 100, true, ECarnes.Asado_de_ternera));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_angosto.ToString(), 160, 70003, 100, true, ECarnes.Bife_angosto));

            List<ProductoSeleccionado> listaProductoSeleccionados1 = new List<ProductoSeleccionado>();
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[0], 1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[1], 1));
            listaProductoSeleccionados1.Add(new ProductoSeleccionado((Producto)supermercado.MiInventario[2], 1));
            double respuesta;

            respuesta = Ticket.CalcularMontoTotal(null);

        }   


      
    }
}
