namespace WinFormsAppActividadA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ServiceReference1.WebService1SoapClient aCli = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap);

            InitializeComponent();
        }
    }
}
