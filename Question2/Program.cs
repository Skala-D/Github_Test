namespace Question2
{
    /* Name: Dominik Skala
     * Date: 27/01/2023
     * Desc: Worksheet1 - Q2
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int count = CountOddNumbers();
            Console.WriteLine($"{count} total count of odd numbers");
            AverageMinMax();

        }
        static int CountOddNumbers()
        {
            int[] integers = new int[5];

            int count = 0;
            

     

            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine($"Enter value number {i + 1}");
                integers[i]= int.Parse(Console.ReadLine());
                if (integers[i] % 2 == 1 || integers[i]%2==-1)
                {
                    count++;
                }
            
            }
            return count;
           
        }
        static void AverageMinMax()
        {
            int average=0;
            int number = 0;
            int min = 0;


            int[] integers = new int[5];
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine($"Enter value number {i + 1} : ");
                integers[i] = int.Parse(Console.ReadLine());
                number=integers[i];

                average = average + integers[i];

            }
            average = average / integers.Length;
            int min= integers.Min();
            int max= integers.Max();
            Console.WriteLine($"The lowest value: {min} The highest value: {max} The average: {average}");

            }
    }
}