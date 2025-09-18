internal class Program
{
    private static void Main(string[] args)
    {
        double radio;

        CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

        Console.Write("Ingrese el radio del circulo ");
        radio = Convert.ToDouble(Console.ReadLine());

        calculosMatematicos.radio = radio;


        Console.WriteLine(calculosMatematicos.calcularArea());
    }
    public class CalculosMatematicos
    {
        public int a { get; set; }
        public int b { get; set; }

        public double radio { get; set; }
        public int Calcular()
        {
            return (a + b) * (a - b);
        }

        public double calcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

    }

}