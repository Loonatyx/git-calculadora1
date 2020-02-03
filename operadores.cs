using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora1
{
    class operadores
    {
        private double xnum1; //crea una variable privada de tipo int.
        private double ynum2;

        private double xnum3;

        public operadores(string xvalor1, string xvalor2) //se crea un constructor.
        {
            xnum1 = Convert.ToDouble((xvalor1));
            ynum2 = Convert.ToDouble((xvalor2));
        }

        public double getsuma() //se crea metodo para sumar.
        {
            double zresult;
            zresult = xnum1 + ynum2;
            return zresult;
        }

      public double getresta()
        {
            double zresult;
            zresult = xnum1 - ynum2;
            return zresult;
        }
        public double getmultiplo()
        {
            double zresult;
            zresult = xnum1 * ynum2;
            return zresult;
        }
        public double getdivisor()
        {
            double zresult;
            zresult = xnum1 / ynum2;
            return zresult;
        }
        public double getpotencia()
        {
            double zresult;
            zresult = Math.Pow(xnum1, ynum2);
            return zresult;
        }
        public double getpromedio()
        {
            double zresult;
            zresult = 100 * ynum2 / xnum1;
            return zresult;
        }

        public operadores(string valor3)
        {
            xnum3 = Convert.ToDouble(valor3);
        }

        public double getraiz()
        {
            double zresult;
            zresult = Math.Sqrt(xnum3);
            return zresult;
        }
    }

}
