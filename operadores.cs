using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora1
{
    class operadores
    {
        private int xnum1; //crea una variable privada de tipo int.
        private int ynum2;

        public operadores(string xvalor1, string xvalor2) //se crea un constructor.
        {
            xnum1 = int.Parse(xvalor1);
            ynum2 = int.Parse(xvalor2);
        }

        public double getsuma() //se crea metodo para sumar.
        {
            double zresult;
            zresult = xnum1 + ynum2;
            return zresult;
        }

    }
}
