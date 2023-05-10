using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public abstract class AirPort : IPrice
    {
        protected string airPortName;
        protected string adress;
        public AirPort(string airPortName, string adress)
        {
            this.airPortName = airPortName;
            this.adress = adress;
        }

        public virtual string PrintInfo()
        {
            return $"Airport {this.airPortName} is placed in {this.adress}";
        }
        public virtual double ISumPrice()
        {
            return 0;
        }

    }
}
