namespace Github_Test
{
    /* Name: Dominik Skala
     * Date: 27/01/2023
     * Desc: Worksheet1 - Q1
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Q1-A \n");
            PrintIntegersFor();
            Console.WriteLine("\n Q1-B \n");
            PrintIntegersWhile();
            Console.WriteLine("\n Q1-C \n");
            PrintIntegersDo();
            Console.WriteLine("\n Q1-D \n");
            PrintExcludingFor();
            Console.WriteLine("\n Q1-E \n");
            PrintDescendingFor();
        }

        static void PrintIntegersFor()
        {

            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);

            }

        }
        static void PrintIntegersWhile()
        {
            int integer = 40;
            while (integer<=60)
            {
                Console.WriteLine(integer);
                integer++;
            }
        }
        static void PrintIntegersDo()
        {
            int integer = 40;
            do
            {
                Console.WriteLine(integer);
                integer++;
            }
            while (integer<=60);
        }
        static void PrintExcludingFor()
        {
            for (int i = 40; i <= 60; i++)
            {
                if (i!=46 && i!= 48)
                Console.WriteLine(i);

            }

        }
        static void PrintDescendingFor()
        {

            for (int i = 60; i >= 40; i--)
            {
                Console.WriteLine(i);

            }


        }

    }
}