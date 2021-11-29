using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace Test
{
    [TestClass]
    public class TestSupermercado
    {
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void Test_existeProducto1()
        {
            Supermercado supermercado = new Supermercado();
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Asado_de_ternera.ToString(), 120, 70001, 100, true, ECarnes.Asado_de_ternera));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_angosto.ToString(), 160, 70003, 100, true, ECarnes.Bife_angosto));
            bool respuesta;

            respuesta = supermercado.ExisteProducto(supermercado.MiInventario[4]);

        }


        [TestMethod]
        public void Test_existeProducto2()
        {
            Supermercado supermercado = new Supermercado();
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Asado_de_ternera.ToString(), 120, 70001, 100, true, ECarnes.Asado_de_ternera));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_ancho.ToString(), 150, 70002, 100, true, ECarnes.Bife_ancho));
            supermercado.MiInventario.Add(new ProductoCongelado<ECarnes>(ECarnes.Bife_angosto.ToString(), 160, 70003, 100, true, ECarnes.Bife_angosto));
            bool respuesta;

            respuesta = supermercado.ExisteProducto(supermercado.MiInventario[0]);


            Assert.IsTrue(respuesta);
        }     
        
        [TestMethod]
        public void Test_existeProducto3()
        {
            Supermercado supermercado = new Supermercado();
            bool respuesta;


            respuesta = supermercado.ExisteProducto(null);


            Assert.IsFalse(respuesta);
        }   
        

        [TestMethod]
        public void Test_existeProducto4()
        {
            Supermercado supermercado = new Supermercado();
            bool respuesta;



            respuesta = supermercado.ExisteProducto(null);


            Assert.IsFalse(respuesta);
        }
    }
}
