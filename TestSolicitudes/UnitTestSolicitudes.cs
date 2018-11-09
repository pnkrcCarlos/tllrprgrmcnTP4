using System;
using EJ5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolicitudes
{
    [TestClass]
    public class UnitTestSolicitudes
    {
        [TestMethod]
        public void TestMenorEdad1()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(2000, 11, 10); // 1 dia más
            DateTime fechaIngreso =  new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestMenorEdad2()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(2000, 11, 9); // día igual
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestMenorEdad3()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(2000, 11, 8); // 1 día menos
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestMayorEdad1()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1943, 11, 10); // 1 día más
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestMayorEdad2()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1943, 11, 9); // día igual
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestMayorEdad3()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1943, 11, 8); // 1 día menos
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestAntiguedadLaboral1()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14); 
            DateTime fechaIngreso = new DateTime(2018, 5, 10); // 1 día más
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestAntiguedadLaboral2()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2018, 5, 9); // día igual
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestAntiguedadLaboral3()
        {
            //hoy es 9-11-18
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2018, 5, 8); // 1 día menos
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestSueldoMinimo1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(5000, fechaIngreso); // ==
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestSueldoMinimo2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(5001, fechaIngreso); // ++
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestSueldoMinimo3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(4999, fechaIngreso); // --
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 6);
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestNoClienteMonto1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 20000, 6); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestNoClienteMonto2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 20001, 6); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestNoClienteMonto3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 19999, 6); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestNoClienteCuotas1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 12); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestNoClienteCuotas2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 13); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestNoClienteCuotas3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 11); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }

        [TestMethod]
        public void TestClienteMonto1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 100000, 6); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteMonto2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 100001, 6); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteMonto3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 99999, 6); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteCuotas1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 32); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteCuotas2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 33); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteCuotas3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.Cliente;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 31); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }

        [TestMethod]
        public void TestClienteGoldMonto1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 150000, 6); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteGoldMonto2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 150001, 6); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteGoldMonto3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 149999, 6); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteGoldCuotas1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 60); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteGoldCuotas2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 61); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClienteGoldCuotas3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClienteGold;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 59); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }

        [TestMethod]
        public void TestClientePlatinumMonto1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClientePlatinum;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 200000, 6); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClientePlatinumMonto2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClientePlatinum;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 200001, 6); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClientePlatinumMonto3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClientePlatinum;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 199999, 6); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClientePlatinumCuotas1()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClientePlatinum;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 60); // ==
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClientePlatinumCuotas2()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClientePlatinum;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 61); // ++
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(false, validador.Validar(gestor, solicitud));
        }
        [TestMethod]
        public void TestClientePlatinumCuotas3()
        {
            GestorPrestamos gestor = GestorPrestamos.Instancia;
            DateTime fechaNacimiento = new DateTime(1996, 5, 14);
            DateTime fechaIngreso = new DateTime(2000, 5, 14);
            Empleo empleo = new Empleo(10000, fechaIngreso);
            Cliente cliente = new Cliente("Carlos", "Pankrac", fechaNacimiento, empleo);
            cliente.TipoCliente = TipoCliente.ClientePlatinum;
            SolicitudPrestamo solicitud = new SolicitudPrestamo(cliente, 15000, 59); // --
            ValidadorSolicitudes validador = new ValidadorSolicitudes();
            Assert.AreEqual(true, validador.Validar(gestor, solicitud));
        }
    }
}
