namespace problem_solving
{
    // do not put solution and project into the same folder

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            const int quit = -999;
            int totalHours = 0;
            int user = 0;
            double Total = 0;
            do
            {
                Console.Write($"Enter number of hours (-999 to quit) : ");
                user = int.Parse(Console.ReadLine());
                if (user == -999)
                    break;
                else
                {
                    totalHours = totalHours + user;
                    double customerCharge = CalculateCharge(user, Total);
                    Total = Total + customerCharge;
                    Console.WriteLine($"{$"Customer charge : {customerCharge}",-40} Total receipt {Total}");
                }
            }
            while (true);

            Console.WriteLine($"Total receipt is {Total:C2}");

        }
        static double CalculateCharge(int hours, double total)
        {
            double customerCharge = 0;

            if (hours <= 2 && hours>0)
                customerCharge = 2;
            else if (hours > 2 && hours <= 19)
                customerCharge = 0.5 * hours + 0.5;
            else if (hours <= 0)
                customerCharge = 0;
            else
                customerCharge = 10;

            return customerCharge;
        }
    }
}