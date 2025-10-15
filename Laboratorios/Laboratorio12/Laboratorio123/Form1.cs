namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtLadoA.Text, out double ladoA) &&
               Double.TryParse(txtLadoB.Text, out double ladoB) &&
               Double.TryParse(txtLadoC.Text, out double ladoC))
            {
                try
                {
                    Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
                    double semiperimetro = triangulo.CalcularSemiperimetro();
                    txtSemiPerimetro.Text = $"{semiperimetro:F2}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.");
            }

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtLadoA.Text, out double ladoA) &&
               Double.TryParse(txtLadoB.Text, out double ladoB) &&
               Double.TryParse(txtLadoC.Text, out double ladoC))
            {
                try
                {
                    Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
                    double area = triangulo.CalcularArea();
                    txtArea.Text = $"{area:F2}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }


            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtSemiPerimetro.Clear();
            txtArea.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLadoA_Click(object sender, EventArgs e)
        {

        }
    }

    public class Triangulo
    {
        // Atributos
        private double ladoA;
        private double ladoB;
        private double ladoC;
        // Constructor
        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            if (ladoA > 0 && ladoB > 0 && ladoC > 0 &&
                (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA))
            {
                this.ladoA = ladoA;
                this.ladoB = ladoB;
                this.ladoC = ladoC;

            }
            else
            {
                throw new Exception("Los lados deben ser positivos y cumplir con la regla de los triangulos (que la suma de dos lados debe ser mayor al lado restante)");
            }

        }
        // Método para calcular el semiperímetro
        public double CalcularSemiperimetro()
        {
            return (ladoA + ladoB + ladoC) / 2;
        }
        // Método para calcular el área usando la fórmula de Herón
        public double CalcularArea()
        {
            double s = CalcularSemiperimetro();
            return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
        }
    }
}
