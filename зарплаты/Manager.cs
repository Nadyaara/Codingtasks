using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зарплаты
{
    class Class_manager : IPosition
    {
        private double Base;
        private double Margin;


        public void SetBasicSalary(double salary)
        {
            Base = salary;
        }
        public void P(double prib_mes)
        {
            Margin = prib_mes;
        }
        public double GetSalary(double shifts)
        {
            return shifts * (Base * Base * 0.25 * Math.Pow(10, -4) + Margin * 0.5 * Math.Pow(10, -2) / 24);
        }
    }
}
