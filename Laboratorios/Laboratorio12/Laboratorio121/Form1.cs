namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtVelocidad.Text, out double velocidad) && double.TryParse(txtTiempo.Text, out double tiempo))
            {
                double distancia = Formulario.calcularDistancia(velocidad, tiempo);
                txtDistanciaTotal.Text = $"{distancia}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para velocidad y tiempo.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVelocidad.Clear();
            txtTiempo.Clear();
            txtDistanciaTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Formulario
    {
        public static double calcularDistancia(double velocidad, double tiempo)
        {
            return velocidad * tiempo;
        }
    }
}
