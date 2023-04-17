using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    internal class Quarter
    {
        public int Number { get; set; }
        public List<Apartment> Apartments { get; set; }

        public decimal CalculateTotalElectricityBill(decimal electricityPrice)
        {
            decimal totalBill = 0;
            foreach (Apartment apartment in Apartments)
            {
                totalBill += apartment.CalculateElectricityBill(electricityPrice);
            }
            return totalBill;
        }

        public Apartment FindApartment(int apartmentNumber)
        {
            return Apartments.Find(a => a.ApartmentNumber == apartmentNumber);
        }

        public Apartment FindApartmentWithNoElectricityUsage()
        {
            return Apartments.Find(a => a.StartData == a.EndData);
        }

        public string FindOwnerWithLargestDebt(decimal electricityPrice)
        {
            string ownerWithLargestDebt = "";
            decimal largestDebt = 0;
            foreach (Apartment apartment in Apartments)
            {
                decimal debt = apartment.CalculateElectricityBill(electricityPrice) - (apartment.EndData - apartment.StartData) * electricityPrice;
                if (debt > largestDebt)
                {
                    largestDebt = debt;
                    ownerWithLargestDebt = apartment.Owner;
                }
            }
            return ownerWithLargestDebt;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{"Apartment number",-5} {"Owner",-15} {"Start data",-10} {"End data",-10} {"Date",-10}");
            foreach (Apartment apartment in Apartments)
            {
                sb.AppendLine(apartment.ToString());
            }
            return sb.ToString();
        }
    }
}
