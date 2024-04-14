namespace pmejiaT1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalculo_Clicked(object sender, EventArgs e)
        {
            string nombre=txtNombre.Text;
            string apellido=txtApellido.Text;
            int edad= Convert.ToInt32(txtEdad.Text);
            double salario = Convert.ToDouble(txtSalario.Text);
            double aporte = 9.45 * salario/100;


            DisplayAlert("Alerta", " Bienvenido: " +nombre +" "+ apellido+ "\n Tienes: " +edad+ " años " + "\n Tu aporte mensual es: " +aporte+ " Dolares ", "Cerrar");

        }
    }

}
