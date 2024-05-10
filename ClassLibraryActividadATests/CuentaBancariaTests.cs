using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryActividadA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryActividadA.Tests
{
    [TestClass()]
    public class CuentaBancariaTests
    {
        [TestMethod()]
        public void CuentaBancariaTest()
        {
            int numeroCuenta = 123456;
            string cliente = "John Doe";

            CuentaBancaria cuenta = new CuentaBancaria(numeroCuenta, cliente);

            Assert.AreEqual(numeroCuenta, cuenta.NumeroCuenta);
            Assert.AreEqual(cliente, cuenta.Cliente);
            Assert.IsNotNull(cuenta.Transacciones);
            Assert.AreEqual(0, cuenta.Transacciones.Count);
        }

        [TestMethod()]
        public void CalcularSaldoTest()
        {
            List<CuentaBancaria> cuentas = new List<CuentaBancaria>();
            cuentas.Add(new CuentaBancaria(1, "Nicolas Miretti"));
            cuentas.Add(new CuentaBancaria(2, "Gabriel Jose"));

            cuentas[0].AgregarTransaccion(new Transaccion("10/05/2024", "Deposito", 1000));
            cuentas[0].AgregarTransaccion(new Transaccion("10/05/2024", "Deposito", 1000));
            cuentas[1].AgregarTransaccion(new Transaccion("11/05/2024", "Retiro", -500));

            decimal saldoCuenta1 = cuentas[0].CalcularSaldo();
            decimal saldoCuenta2 = cuentas[1].CalcularSaldo();

            Assert.AreEqual(2000, saldoCuenta1);
            Assert.AreEqual(-500, saldoCuenta2);
        }
        [TestMethod()]
        public void AgregarTransaccionTest()
        {
            CuentaBancaria cuenta1 = new CuentaBancaria(1, "Nicolas Miretti");
            CuentaBancaria cuenta2 = new CuentaBancaria(2, "Gabriel Jose");
            Transaccion transaccion1 = new Transaccion("10/05/2024", "Deposito", 1000);
            Transaccion transaccion11 = new Transaccion("10/05/2024", "Deposito", 2000);
            Transaccion transaccion2 = new Transaccion("11/05/2024", "Retiro", -500);

            cuenta1.AgregarTransaccion(transaccion1);
            cuenta1.AgregarTransaccion(transaccion11);
            cuenta2.AgregarTransaccion(transaccion2);

            Assert.AreEqual(transaccion1, cuenta1.Transacciones[0]);
            Assert.AreEqual(transaccion11, cuenta1.Transacciones[1]);
            Assert.AreEqual(transaccion2, cuenta2.Transacciones[0]);
        }
        [TestMethod()]
        public void EsDeudorTestTrue()
        {
            CuentaBancaria cuenta1 = new CuentaBancaria(1, "Nicolas Miretti");
            Transaccion transaccion1 = new Transaccion("11/05/2024", "Retiro", -500);
            cuenta1.AgregarTransaccion(transaccion1);

            Assert.IsTrue(cuenta1.EsDeudor());
        }
        [TestMethod()]
        public void EsDeudorTestFalse()
        {
            CuentaBancaria cuenta1 = new CuentaBancaria(1, "Nicolas Miretti");
            Transaccion transaccion1 = new Transaccion("11/05/2024", "Retiro", 500);
            cuenta1.AgregarTransaccion(transaccion1);

            Assert.IsFalse(cuenta1.EsDeudor());
        }
    }
}