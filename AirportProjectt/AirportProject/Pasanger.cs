using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AirportProject
{
    public class Pasanger:AirPort,IPrice
    {
        private string nameP;
        private int age;
       private int data;
        private int flighCode;

        public Pasanger(string nameP, int age, int data, int flighCode, string airPortname, string adress):base(airPortname,adress)
        {
            NameP = nameP;
            Age = age;
            Data = data;
            FlighCode = flighCode;
        }
    
        public string NameP
        {
            get { return nameP; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be an empty string!");
                }
                this.nameP = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                try
                {
                    if (age > 0 || age < 120)
                    {
                        this.age = value;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Fatal");
                }
            }
        }
        public int Data
        {
            get { return this.data; }
            set
            {
                try
                {
                    if (data > 31)
                    {
                        this.Data = value;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Fatal");
                }
                //this.Data = value;
            }
        }
        public int FlighCode
        {
            get { return flighCode; }
            set
            {
                try
                {

                    if (flighCode < 100000)
                    {
                        this.flighCode = value;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Fatal!");
                }
            }
        }
        public override string PrintInfo()
        {
            return $"Passenger: {this.NameP}, age: {this.Age}. Code: {this.FlighCode}";
           // return base.PrintInfo();
        }
        public virtual double ISumPrice()
        {
            double price;
            if (Age <= 18)
            {
                price = 50 * 0.63;
            }
            else if (Age>19&&Age<60)
            {
                price = 120 * 0.63;
            }
            else
            {
                price=30 * 0.63;
            }
            return price;
        }
    }
}
