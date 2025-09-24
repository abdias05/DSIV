internal class PruebaVector1
{
    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[6];
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + f + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }

    public void Imprimir()
    {
        Console.Write("Los 5 sueldos de los operarios \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("[" + sueldos[f] + "]");
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}

