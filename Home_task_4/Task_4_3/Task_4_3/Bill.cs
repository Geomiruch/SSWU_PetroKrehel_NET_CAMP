using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    internal class Bill
    {
        public List<Quarter> Quarters { get; set; }
        public decimal PricePerKw { get; set; }

        public Bill()
        {
            Quarters = new List<Quarter>();
        }

        public void ReadData(string file)
        {
            string[] lines = File.ReadAllLines(file);
            int numberOfApartments = int.Parse(lines[0].Split(' ')[0]);
            int quarterNumber = int.Parse(lines[0].Split(' ')[1]);
            List<Apartment> apartments = new List<Apartment>();
            for (int i = 1; i <= numberOfApartments; i++)
            {
                string[] apartmentData = lines[i].Split('\t');
                Apartment apartment = new Apartment
                {
                    ApartmentNumber = int.Parse(apartmentData[0]),
                    Address = apartmentData[1],
                    Owner = apartmentData[2],
                    StartData = int.Parse(apartmentData[3]),
                    EndData = int.Parse(apartmentData[4]),
                    LastReadingDate = DateTime.ParseExact(apartmentData[5], "dd.MM.yy", CultureInfo.InvariantCulture),
                };
                apartments.Add(apartment);
            }
            Quarter quarter = new Quarter
            {
                Number = quarterNumber,
                Apartments = apartments
            };
            Quarters.Add(quarter);
        }

        
        public string GetOwnerWithLargestDebt()
        {
            string ownerSurname = "";
            decimal largestDebt = 0;
            foreach (Quarter quarter in Quarters)
            {
                foreach (Apartment apartment in quarter.Apartments)
                {
                    decimal debt = (apartment.EndData - apartment.StartData) * PricePerKw;
                    if (debt > largestDebt)
                    {
                        largestDebt = debt;
                        ownerSurname = apartment.Owner;
                    }
                }
            }
            return ownerSurname;
        }

        public List<int> GetApartmentsWithNoElectricityUsage()
        {
            List<int> apartmentsWithNoUsage = new List<int>();
            foreach (Quarter quarter in Quarters)
            {
                foreach (Apartment apartment in quarter.Apartments)
                {
                    int consumption = apartment.EndData - apartment.StartData;
                    if (consumption == 0)
                    {
                        apartmentsWithNoUsage.Add(apartment.ApartmentNumber);
                    }
                }
            }
            return apartmentsWithNoUsage;
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            foreach (Quarter quarter in Quarters)
            {
                report.AppendLine($"Quarter {quarter.Number}");
                report.AppendLine("----------------------------------------------------");
                report.AppendLine("| Apartment |    Owner Last Name   |" +
                    $" Consumption |   Cost    |  Days Since Last Reading |");
                foreach (Apartment apartment in quarter.Apartments)
                {
                    int consumption = apartment.EndData - apartment.StartData;
                    decimal cost = consumption * PricePerKw;
                    int daysSinceLastReading = (DateTime.Today - apartment.LastReadingDate).Days;
                    report.AppendLine($"| {apartment.ApartmentNumber,-10} | {apartment.Owner,-20}" +
                        $" | {consumption,-11} | {cost,-8:F2} | {daysSinceLastReading,-24} |");
                }
                report.AppendLine("----------------------------------------------------");
                decimal totalConsumption = quarter.Apartments.Sum(a => a.EndData - a.StartData);
                decimal totalCost = totalConsumption * PricePerKw;
                int daysSinceLastReadingForQuarter = quarter.Apartments.Select(a => (DateTime.Today - a.LastReadingDate).Days).Max();
                report.AppendLine($"Total consumption: {totalConsumption:F2}");
                report.AppendLine($"Total cost: {totalCost:F2}");
                report.AppendLine($"Days since last reading: {daysSinceLastReadingForQuarter}");
            }
            return report.ToString();
        }
    }
}
