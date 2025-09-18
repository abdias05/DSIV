internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;

        CalculosMatematicos calculosMatematicos = new CalculosMatematicos();
        Console.Write("Ingrese el primer numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        b = Convert.ToInt32(Console.ReadLine());

        calculosMatematicos.a = a;
        calculosMatematicos.b = b;


        Console.WriteLine(calculosMatematicos.Calcular());
    }
    public class CalculosMatematicos
    { 
        public  int a { get; set; }
        public int b { get; set; }

        public int Calcular()
        {
            return (a+b) * (a-b);
        }


    }

}