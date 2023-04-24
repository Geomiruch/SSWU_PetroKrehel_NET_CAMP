using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    internal class Apartment
    {
        public int ApartmentNumber { get; set; }
        public string Address { get; set; }
        public string Owner { get; set; }
        public int StartData { get; set; }
        public int EndData { get; set; }
        public DateTime LastReadingDate { get; set; }

        public decimal CalculateElectricityBill(decimal price)
        {
            int usedEnergy = EndData - StartData;
            return price * usedEnergy;
        }

        public int GetDaysSinceLastMeterReading()
        {
            return (DateTime.Today - LastReadingDate).Days;
        }

        public override string ToString()
        {// Шириною полів бажано,щоб користувач міг керувати
            return $"{ApartmentNumber,-5} {Owner,-15} {StartData,-10} {EndData,-10} {LastReadingDate:dd.MM.yy}";
        }
    }
}
