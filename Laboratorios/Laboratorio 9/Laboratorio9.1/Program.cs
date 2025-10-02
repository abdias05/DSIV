internal class Program
{
    private static void Main(string[] args)
    {
        double precio=0;
        bool efectivo = false, valido=false, validoF= false;
        string NumeroTarjeta= null;
        string LeerPrecio, LeerPago;
        short TipoPago = 0;
        

        do
        {
            Console.WriteLine("ingrese el valor del producto");
            LeerPrecio = Console.ReadLine();

            try
            {
                precio = double.Parse(LeerPrecio);

               
                if (precio > 0)
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Error: El precio debe ser un valor positivo.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: El valor ingresado no es un número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: El número ingresado es demasiado grande o pequeño.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error: No se ingresó ningún valor.");
            }

        } while (!valido);

        do
        {
            Console.Write("¿Forma de pago, para efectivo (presione 1) o tarjeta (presione 2?): ");
             LeerPago= Console.ReadLine();

            TipoPago=short.Parse(LeerPago);
            if(TipoPago == 1 || TipoPago == 2)
            {
                validoF=true;
            }
            else
            {
                Console.WriteLine("debe selecionar una forma de pago valida");
            }
        } while (!validoF);

        if (TipoPago == 2)
        {
            valido = false;

            do
            {
                Console.WriteLine("ingrese el numero de cuenta (16 digitos):");
                NumeroTarjeta = Console.ReadLine();

                if (NumeroTarjeta.Length == 16)
                {
                    valido=true;
                    Console.WriteLine($"\n Pago de ${precio:N2} procesado con tarjeta (Cuenta: {NumeroTarjeta}).");
                }
                else
                {
                    Console.WriteLine($"Error: El número de cuenta debe tener exactamente 16 dígitos. Usted ingresó {NumeroTarjeta.Length}.");
                }
            } while (!valido);
        }

        else
        {
            Console.WriteLine($"\n Pago de ${precio:N2} procesado en efectivo.");
        }


        

    }
}