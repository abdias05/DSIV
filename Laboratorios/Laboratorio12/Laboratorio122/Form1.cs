namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "")
            {
                MessageBox.Show("Por favor, ingrese las tres notas.");
                return;
            }
            if (double.TryParse(txtNota1.Text, out double nota1) &&
                double.TryParse(txtNota2.Text, out double nota2) &&
                double.TryParse(txtNota3.Text, out double nota3))
            {
                if (nota1 < 0 || nota2 < 0 || nota3 < 0)
                {
                    MessageBox.Show("Las notas deben ser iguales o mayores a 0.");
                    return;
                }
                double promedio = Promedio.calcular(nota1, nota2, nota3);
                txtPromedio.Text = $"{promedio:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }

        public class Promedio
        {
            public static double calcular(double n1, double n2, double n3)
            {
                return (n1 + n2 + n3) / 3;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNota1_Click(object sender, EventArgs e)
        {

        }
    }
}
