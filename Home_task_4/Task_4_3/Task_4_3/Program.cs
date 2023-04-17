using System.Globalization;
using System.Text;

namespace Task_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Bill.txt";

            Bill electricity = new Bill();
            electricity.ReadData(filePath);

            electricity.PricePerKw = 0.15m;

            Console.WriteLine("Electricity report:");
            Console.WriteLine(electricity);

            Console.WriteLine($"The owner with the largest debt is: {electricity.GetOwnerWithLargestDebt()}");

            Console.WriteLine("Apartments with no electricity usage:");
            var apartmentsWithNoUsage = electricity.GetApartmentsWithNoElectricityUsage();
            if (apartmentsWithNoUsage.Count == 0)
            {
                Console.WriteLine("No apartments found with no electricity usage.");
            }
            else
            {
                Console.WriteLine(string.Join(", ", apartmentsWithNoUsage));
            }
        }
    }
}