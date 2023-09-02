using System;
using System.Collections.Generic;
using System.Text;

namespace Calculador.Clases
{
    internal class cVolumenes
    {
        public double Cubo(double l)
        {
            double volumen;
            volumen = l * l * l;
            return volumen;
        }
        public double Cilindro(double r,double h)
        {
            double volumen;
            volumen = Math.PI*Math.Pow(r,2) * h;
            return volumen;
        }
        public double Esfera(double r)
        {
            double volumen; 
            volumen = (4*Math.PI * Math.Pow(r, 3))/3;
            return volumen;
        }
        public double Cono(double r, double h)
        {
            double volumen;
            volumen = (Math.PI * Math.Pow(r, 2) * h)/3;
            return volumen;
        }
    }
}
