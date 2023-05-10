using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public class Employees:AirPort,IEnumerable<Employees>
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
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.name = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fatal");
                }
            }
        }
        public string Positon
        {
            get { return position; }
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        this.Positon = value;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Fatal");
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                try
                {
                    if (age < 0 || age > 120)
                    {
                        this.Age = value;
                        //throw new ArgumentOutOfRangeException("Enter valid number for age!");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Fatal");
                }
                //this.Age = value;
            }
        }

        public IEnumerator<Employees> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            return $"Employee {this.Name} is on {this.Positon} position and is {this.Age} years old.";
           // return base.PrintInfo();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
