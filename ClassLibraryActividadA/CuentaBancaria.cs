using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryActividadA
{
    public class CuentaBancaria
    {
        public int NumeroCuenta {  get; set; }
        public string Cliente { get; set; }
        public List<Transaccion> Transacciones { get; set; }
        public CuentaBancaria()
        {
            // Constructor sin parametros para serializar
        }
        public CuentaBancaria(int numeroCuenta, string cliente)
        {
            NumeroCuenta = numeroCuenta;
            Cliente = cliente;
            Transacciones = new List<Transaccion>();
        }
        public decimal CalcularSaldo()
        {
                return Transacciones.Sum(t => t.Monto);
        }
        public void AgregarTransaccion(Transaccion transaccion)
        {
                Transacciones.Add(transaccion);
        }
        public bool EsDeudor()
        {
            if (CalcularSaldo() < 0)
            {
                return true;
            }
            return false;
        }
    }
    public class Transaccion
    {
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }

        public Transaccion(string fecha, string descripcion, decimal monto)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Monto = monto;
        }
        public Transaccion()
        {
            // Constructor sin parametros para serializar
        }
    }

}
