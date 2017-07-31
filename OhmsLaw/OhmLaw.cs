using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmsLaw
{
    class OhmLaw
    {
       // класс Закона Ома

        public double answer { get; set; } 

        public double Amper(double u, double r) 
        {
            // метод для расчёта тока
            return answer = u/r;
        }

        public double Volt(double i, double r)
        {
            // метод для расчёта напряжения
            return answer = i * r;
        }
        public double Ohms(double u, double i)
        {
            // метод для расчёта сопротивления
            return answer = u / i;
        }
        public double OhmPos(double r1, double r2)
        {
            // метод для расчёта сопротивления которые подключены последовательно
            return answer = r1 + r2;
        }

        public double OhmsParralel(double r1, double r2)
        {
            // метод для расчёта сопротивления которые подключены параллельно
            return answer = (r1*r2)/(r1+r2);
        }



    }
}
