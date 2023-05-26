using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public class Fly:AirPort
    {
        private int freeSeats;
        private int notFreeSeats;
        public Fly(int freeSeats, int notFreeSeats, string airPortName, string adress):base(airPortName,adress)
        {
            FreeSeats = freeSeats;
            NotFreeSeats = notFreeSeats;
        }
    
        public int FreeSeats
        {
            get { return this.FreeSeats; }
            set 
            {
                if (freeSeats>500)
                {
                    throw new OutOfMemoryException("Enter valid number");
                }
                this.FreeSeats = value; 
            }
        }
        public int NotFreeSeats
        {
            get { return this.NotFreeSeats; }
            set
            {
                if (notFreeSeats > 500)
                {
                    throw new OutOfMemoryException("Enter valid number");
                }
                this.NotFreeSeats = value;
            }
        }
    }
}
