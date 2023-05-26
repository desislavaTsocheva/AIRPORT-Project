using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AirportProject
{
    public class Pasanger:AirPort,IPrice
    {
        private string nameP;
        private string age;
        private int data;
        private int flighCode;

        public Pasanger(string nameP, string age, int data, int flighCode, string airPortname, string adress):base(airPortname,adress)
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
        public string Age
        {
            get { return age; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("EGN cannot be an empty string!");
                }
                this.age = value;
            }
        }
        public int Data
        {
            get { return data; }
            set
            {
                if (data>31)
                {
                    throw new ArgumentException("Data cannot be higher that 31");
                }
                this.data = value;
            }
        }
        public int FlighCode
        {
            get { return flighCode; }
            set
            {
                if (flighCode>100000)
                {
                    throw new ArgumentException("Enter valid code!");
                }
                this.flighCode = value;
            }
        }

        public void ISumPrice()
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            return $"Passenger: {this.NameP}, egn: {this.Age}, will fly on {this.Data}. Code: {this.FlighCode}";
           // return base.PrintInfo();
        }
        //public override void ISumPrice()
        //{
           
        //} 
    }
}
