namespace Laboratorio95
{
    class Aleatorios
    {
        private static Random random = new Random();
        public static int generar(int min, int max)
        {
            return random.Next(min, max);
        }

        public static int[] arreglo(int n, int min, int max)
        {
            int[] arreglo = new int[n];
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = generar(min, max);
            }
            return arreglo;
        }
    }
}
