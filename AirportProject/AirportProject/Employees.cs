using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public class Employees:AirPort
    {
        private string name;
        private string position;
        private int age;

        public Employees(string name, string position, int age, string airPortName,string adress):base(airPortName,adress)
        {
            this.name = name;
            this.position = position;
            this.age = age; 
        }
        public string Name
        {
            get { return name; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be an empty string!");
                }
                this.name= value;   
            }
        }
        public string Positon
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Position cannot be an empty string!");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.Age; }
            set
            {
                if (Age < 0 || Age > 120)
                {
                    throw new ArgumentOutOfRangeException("Enter valid number for age!");
                }
                this.Age = value;
            }
        }
        public override string PrintInfo()
        {
            return $"Employee {this.Name} is on {this.Positon} position and is {this.Age} years old.";
           // return base.PrintInfo();
        }
    }
}
