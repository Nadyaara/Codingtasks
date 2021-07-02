using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace зарплаты
{
    interface IPosition
    {
        double GetSalary(double shifts);
        void SetBasicSalary(double salary);
    }
}
