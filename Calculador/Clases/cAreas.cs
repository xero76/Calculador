using System;
using System.Collections.Generic;
using System.Text;

namespace Calculador.Clases
{
    internal class cAreas
    {
        public double rectangulo(double b, double h)
        {
            return b * h;
        }
        public double triangulo(double b, double h)
        {
            double area;
            area =  (b * h)/2;
            return area;
        }

        public double circulo(double r)
        {
            return  Math.PI * Math.Pow(r, 2 );
        }
    }
}
