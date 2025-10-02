using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
       int lado1, lado2, lado3;

        lado1 = ValidarLado("ingrese el primer lado del triangulo");
        lado2 = ValidarLado("ingrese el segundo lado del triangulo");
        lado3 = ValidarLado("ingrese el tercer lado del triangulo");

     if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 &&lado2 + lado3 > lado1)
     {
            // Clasificación del triángulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es EQUILÁTERO.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es ISÓSCELES.");
            }
            else
            {
                Console.WriteLine("El triángulo es ESCALENO.");
            }
     }
        else
        {
            Console.WriteLine("Los lados ingresados NO forman un triángulo válido.");
        }
    }


    private static int ValidarLado(string lado)
    {
        int lados;
        do
        {
            Console.Write(lado);
            try
            {
                lados = Int32.Parse(Console.ReadLine());
                if (lados > 0)
                    return lados;
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