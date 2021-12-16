using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Funcionario
    {
        public int _id { get; set; }
        public string _nome { get; set; }
        public double _sal { get; set; }

        public void aumentaSal(double aumenta)
        {
            _sal += (aumenta/100)*_sal;
        }

    }
}
