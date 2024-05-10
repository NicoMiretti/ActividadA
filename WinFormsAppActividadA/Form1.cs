using ServiceReference1;

namespace WinFormsAppActividadA
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient aCli = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);
            int numCuenta = 0;
            string nombre = txtNombreApellido.Text;
            int.TryParse(txtNum.Text, out numCuenta);
            aCli.CrearCuentaBancaria(numCuenta, nombre);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient aCli = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);
            CuentaBancaria[] cuentas = aCli.ConsultarCuentas();
            txtCuentas.Clear();
            foreach (CuentaBancaria cuenta in cuentas)
            {
                string infoCuenta = aCli.CalcularSaldo(cuenta.NumeroCuenta);
                txtCuentas.AppendText(infoCuenta + Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient aCli = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);
            int numCuenta = 0;
            string fecha = txtFecha.Text;
            string descripcion = txtDescripcion.Text;
            int monto = 0;
            int.TryParse(txtNum2.Text, out numCuenta);
            int.TryParse(txtMonto.Text, out monto);
            aCli.AgregarTransaccion(numCuenta, fecha, descripcion, monto);
            MessageBox.Show("La transacción se agregó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeudor_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient aCli = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);
            int numCuenta = 0;
            int.TryParse(txtDeudor.Text, out numCuenta);            
            lblDeudor.Text = aCli.EsDeudor(numCuenta);
        }
    }
}
