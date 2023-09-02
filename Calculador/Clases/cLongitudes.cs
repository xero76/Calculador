using System;
using System.Collections.Generic;
using System.Text;

namespace Calculador.Clases
{
    internal class cLongitudes
    {
        public double mts_cms(double valor)
        {
            return valor * 100;
        }
        public double mts_mili(double valor)
        {
            return valor * 1000;
        }
        public double cms_mts(double valor)
        {
            return valor / 100;
        }
        public double cms_mili(double valor)
        {
            return valor * 10;
        }
        public double mili_cms(double valor)
        {
            return valor / 10;
        }
        public double mili_mts(double valor)
        {
            return valor / 1000;
        }
    }
}
