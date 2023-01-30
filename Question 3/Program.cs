namespace Question_3
{
    /* Name: Dominik Skala
         * Date: 27/01/2023
         * Desc: Worksheet1 - Q3
         */
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintTriangle();
            Console.WriteLine("\n");
            PrintTriangleUpsideDown();
            Console.WriteLine("\n");
            PrintTriangleGeneral();
            Console.WriteLine("\n");
            PrintTriangleGeneralCharacter();
        }
        static void PrintTriangle()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

        }
        static void PrintTriangleUpsideDown()
        {

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");

                }
                Console.WriteLine();
            }

        }
        static void PrintTriangleGeneral()
        {
            Console.Write("enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();

            }



        }
        static void PrintTriangleGeneralCharacter()
        {


            Console.Write("enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("enter the symbol u want to see: ");
            string symbol = Console.ReadLine();
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{symbol} ");
                }
                Console.WriteLine();

            }




        }
    }
}