using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            AirPort a1 = new Employees("Ivan Ivanov", "Sanitar", 34, "Sofiq Terminal 1","Ivanvazovsko");
            AirPort a2 = new Employees("Martin Marinov", "Pilot", 55, "Varna Terminal 2","Stambolisko");
            AirPort a3 = new Employees("Ivanka Stoyanova", "Stuardesa", 26, "Plovdiv Terminal 2","Lozovsko");

            AirPort a4 = new Pasanger("Mariyan",65,22, 45678, "Sofiq Terminal 1", "Ivanvazovsko");
            AirPort a5 = new Pasanger("Mariyana", 14,13, 87123, "Varna Terminal 2", "Stamboliisko");

            a4.ISumPrice();
            a5.ISumPrice();

            AirPort a6 = new Fly(89, 411, "Plovdiv Terminal 2", "Lozovsko");
            AirPort a7 = new Fly(67, 430, "Varna Terminal 2", "Stamboliisko");

            Console.WriteLine(a1.PrintInfo());
            Console.WriteLine(a2.PrintInfo());
            Console.WriteLine(a3.PrintInfo());
            Console.WriteLine(a4.PrintInfo());
            Console.WriteLine(a5.PrintInfo());
            Console.WriteLine(a6.PrintInfo());
            Console.WriteLine(a7.PrintInfo());
        }
    }
}
