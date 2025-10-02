internal class Program
{
    private static void Main(string[] args)
    {

        for (int i=0; i<100; i++)
        {
            if (i%2==0)
            {
                Console.WriteLine(i);
            }
            else if (i%3==0)
            {
                Console.WriteLine(i);
            }

        }
    }
}