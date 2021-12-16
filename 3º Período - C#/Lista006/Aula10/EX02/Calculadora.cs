using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double AreaCircunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double VolumeCircunferencia(double r)
        {
            return 4.0 / 3 * Pi * (r * r * r);

        }
    }
}
