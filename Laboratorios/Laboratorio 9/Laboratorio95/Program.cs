using Laboratorio95;

internal class Program
{
    private static void Main(string[] args)
    {
        int tamaño = leerEntero("Ingrese el tamaño del arreglo: ");
        int min = leerEntero("Ingrese el valor minimo del rango: ");
        int max = leerEntero("Ingrese el valor maximo del rango: ");
        int[] arreglo = Aleatorios.arreglo(tamaño, min, max);

        Console.Write("\nEl arreglo generado es: ");
        Console.Write("[ ");
        foreach (int numero in arreglo)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine("]");
    }

    private static int leerEntero(string mensaje)
    {
        int numero;
        do
        {
            Console.Write(mensaje);
            try
            {
                numero = Int32.Parse(Console.ReadLine());
                if (numero > 0)
                    return numero;
                else
                    Console.WriteLine("El número debe ser mayor a cero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        } while (true);

    }
}