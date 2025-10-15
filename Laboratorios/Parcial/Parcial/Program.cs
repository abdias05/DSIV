internal class Program
{
    private static void Main(string[] args)
    {
        int N = 0;
        long multi=1;
        String Dimension;
        Boolean valido = false;
        Random rnd = new Random();
        do
        {
            Console.WriteLine("ingrese el valor del arreglo (debe ser par):");
            Dimension = Console.ReadLine();

            try
            {
                N = int.Parse(Dimension);
                if (N % 2 == 0 && N > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Error: El tamaño del arreglo debe ser un valor positivo y par.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor ingresado no es un número válido.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error: No se ingresó ningún valor.");
            }

        } while (!valido);

        int[,] arreglo = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i % 2 != 0)
                {
                    arreglo[i, j] = rnd.Next(101, 200);
                    multi *= arreglo[i, j];
                }
                else
                {
                    arreglo[i, j] = 0;
                }
            }

        }

        Console.WriteLine("El arreglo generado es:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(arreglo[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("El total de la multiplicacion es: " + multi);
    }


}



