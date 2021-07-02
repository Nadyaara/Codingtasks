using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зарплаты
{
    class Class_mainseller : IPosition
    {
        private double Base;
        private double Margin;


        public void SetBasicSalary(double salary)
        {
            Base = salary;
        }
        public void P(double margin_month)
        {
            Margin = margin_month;
        }
        public double GetSalary(double shifts)
        {
            return (shifts * (Base * Base) * 0.15 * Math.Pow(10, -4) + Margin * 0.1 * Math.Pow(10, -2) / 24);
        }
    }
}
