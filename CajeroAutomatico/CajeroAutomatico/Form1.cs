namespace CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarImagenes();
        }

        private void CargarImagenes()
        {
            string carpeta = Application.StartupPath + "\\Imagenes\\";

            pic20000.Image = Image.FromFile(carpeta + "Billete de 20000 arg.jpg");
            pic10000.Image = Image.FromFile(carpeta + "Billete de 10000 arg.jpg");
            pic2000.Image = Image.FromFile(carpeta + "Billete de 2000 arg.jpg");
            pic1000.Image = Image.FromFile(carpeta + "Billete de 1000 arg.jpg");
            pic500.Image = Image.FromFile(carpeta + "Billete de 500 arg.jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtMonto.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto");
                return;
            }

            int monto = Convert.ToInt32(txtMonto.Text);

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser positivo");
                return;
            }

            int resto = monto;

            int billetes20000 = resto / 20000;
            resto = resto % 20000;

            int billetes10000 = resto / 10000;
            resto = resto % 10000;

            int billetes2000 = resto / 2000;
            resto = resto % 2000;

            int billetes1000 = resto / 1000;
            resto = resto % 1000;

            int billetes500 = resto / 500;
            resto = resto % 500;

            lblCantidad20000.Text = billetes20000.ToString();
            lblCantidad10000.Text = billetes10000.ToString();
            lblCantidad2000.Text = billetes2000.ToString();
            lblCantidad1000.Text = billetes1000.ToString();
            lblCantidad500.Text = billetes500.ToString();

            if (resto > 0)
            {
                MessageBox.Show("Quedan $" + resto + " que no se entregaron");
            }
        }
    }
}
