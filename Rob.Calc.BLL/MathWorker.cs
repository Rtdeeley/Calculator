using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rob.Calc.BLL
{
    public class MathWorker
    {
        public double AddResult(double num1, double num2)
        {
            return (num1 + num2);
        }

        public double SubResult(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double MultResult(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double DivResult(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}
