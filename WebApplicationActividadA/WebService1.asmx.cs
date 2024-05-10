using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClassLibraryActividadA;

namespace WebApplicationActividadA

{

    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        // Creo mi lista de cuentas
        public static List<CuentaBancaria> cuentasBancarias = new List<CuentaBancaria>();

        [WebMethod]
        public CuentaBancaria CrearCuentaBancaria(int numeroCuenta, string cliente)
        {
            // Verifico que la cuenta no exista
            if (cuentasBancarias.Exists(c => c.NumeroCuenta == numeroCuenta))
            {
                throw new Exception("La cuenta bancaria ya existe.");
            }

            // Creo la nueva cuenta
            CuentaBancaria nuevaCuenta = new CuentaBancaria(numeroCuenta, cliente);

            // Agrego la cuenta a la lista
            cuentasBancarias.Add(nuevaCuenta);

            // Devuelvo la cuenta creada
            return nuevaCuenta;
        }

        [WebMethod]
        public string CalcularSaldo(int numeroCuenta)
        {
            // Busco la cuenta
            CuentaBancaria cuenta = cuentasBancarias.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta == null)
            {
                throw new Exception("La cuenta bancaria no existe.");
            }

            string cuentaSaldo = "Numero: " + cuenta.NumeroCuenta + " || " + "Cuenta de: " + cuenta.Cliente + " || " + "Saldo: " + cuenta.CalcularSaldo().ToString();
            // Devuelvo el saldo
            return cuentaSaldo;
        }

        [WebMethod]
        public string EsDeudor(int numeroCuenta)
        {
            // Busco la cuenta
            CuentaBancaria cuenta = cuentasBancarias.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta == null)
            {
                throw new Exception("La cuenta bancaria no existe.");
            }

            // Devolver si la cuenta es deudora o no
            if (cuenta.EsDeudor())
            {
                return $"El cliente {cuenta.Cliente}, es deudor.";
            }
            return $"El cliente {cuenta.Cliente}, no es deudor.";
        }

        [WebMethod]
        public void AgregarTransaccion(int numeroCuenta, string fecha, string descripcion, decimal monto)
        {
            // Busco la cuenta
            CuentaBancaria cuenta = cuentasBancarias.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta == null)
            {
                throw new Exception("La cuenta bancaria no existe.");
            }

            // Creo la nueva transaccion
            Transaccion transaccion = new Transaccion(fecha, descripcion, monto);
            cuenta.AgregarTransaccion(transaccion);
        }
        [WebMethod]
        public CuentaBancaria ConsultarCuenta(int numeroCuenta)
        {
            // Busco la cuenta
            CuentaBancaria cuenta = cuentasBancarias.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta == null)
            {
                throw new Exception("La cuenta bancaria no existe.");
            }

            // Devuelvo la cuenta
            return cuenta;
        }
        [WebMethod]
        public List<CuentaBancaria> ConsultarCuentas()
        {
            return cuentasBancarias;
        }
    }
}