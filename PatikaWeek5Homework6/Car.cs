using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek5Homework6
{
    internal class Car
    {
        //Araba nesnesinin property'leri
        public DateTime ProductionDate { get; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public int NumberOfDoors { get; set; }

        public Car()
        {
            ProductionDate = DateTime.Now;//Araba nesnesi üretildiğinde üretim tarihini atar
        }

        public void CarInfo()
        {
           
            Console.WriteLine($"\nSeri Numarası..:{SerialNumber} \nMarka..:{Brand}");
        }

    }
}

