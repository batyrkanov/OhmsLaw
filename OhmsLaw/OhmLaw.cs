using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw
{
    class OhmLaw
    {
       

        public double answer { get; set; }

        public double Amper(double u, double r)
        {
            return answer = u/r;
        }

        public double Volt(double i, double r)
        {
            return answer = i * r;
        }
        public double Ohms(double u, double i)
        {
            return answer = u / i;
        }
        public double OhmPos(double r1, double r2)
        {
            return answer = r1 + r2;
        }

        public double OhmsParralel(double r1, double r2)
        {
            return answer = (r1*r2)/(r1+r2);
        }
        //if(a == true && v == false && o == false && op == false)



    }
}
