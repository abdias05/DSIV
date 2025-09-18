internal class Program
{
    private static void Main(string[] args)
    {
        int ase, altura;

        CalculosMatematicos calculosMatematicos = new CalculosMatematicos();

        Console.Write("Ingrese la base del rectangulo: ");
        ase = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la altura del rectangulo: ");
        altura = Convert.ToInt32(Console.ReadLine());

        calculosMatematicos.ase = ase;
        calculosMatematicos.altura = altura;    


        Console.WriteLine(calculosMatematicos.calcularPerimetro());
    }
    public class CalculosMatematicos
    {
        public int a { get; set; }
        public int b { get; set; }

        public int ase { get; set; }
        public int altura { get; set; } 

 

    public int calcularPerimetro()
        {
            return 2 * (ase + altura);
        }
       
}

}