using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Not_Static
{
    class Calculadora
    {
        public double Pi = 3.14;
        public double AreaCircunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public double VolumeCircunferencia(double r)
        {
            return 4.0 / 3 * Pi * (r * r * r);
        }
    }
}
