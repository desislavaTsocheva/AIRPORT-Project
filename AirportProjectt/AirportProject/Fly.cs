using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public class Fly:AirPort,IComparable<Fly>   
    {
        private int freeSeats;
        private int notFreeSeats;
        public Fly(int freeSeats, int notFreeSeats, string airPortName, string adress):base(airPortName,adress)
        {
            this.freeSeats = freeSeats;
            this.notFreeSeats = notFreeSeats;
        }
    
        public int FreeSeats
        {
            get { return this.FreeSeats; }
            set 
            {
                try
                {
                    if (freeSeats < 500)
                    {
                        this.FreeSeats = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fatal");
                }
            }
        }
        public int NotFreeSeats
        {
            get { return this.NotFreeSeats; }
            set
            {
                try
                {
                    if (notFreeSeats < 500)
                    {
                        this.notFreeSeats = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fatal");
                }
            }
        }

        public int CompareTo(Fly other)
        {
            int result = FreeSeats.CompareTo(other.FreeSeats);
            if(result == 0)
            {
                result=NotFreeSeats.CompareTo(other.FreeSeats); 
            }
            return result;
        }
    }
}
