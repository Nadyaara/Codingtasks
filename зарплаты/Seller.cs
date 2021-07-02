using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зарплаты
{
    class Class_seller : IPosition
    {
        private double Base;

        public double GetSalary(double shifts)
        {
            return shifts * Base / 24;
        }

        public void SetBasicSalary(double salary)
        {
            Base = salary;
        }
    }
}
