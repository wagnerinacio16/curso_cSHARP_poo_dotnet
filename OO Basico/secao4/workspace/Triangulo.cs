
using System;

namespace workspace
{
    class Triangulo{
        //pragma warning disable 0649
        public double A;
        public double B;
        public double C;

        public double Area(){
            //Fórmula de Aron;
            double p = (A + B + C)/2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }

    }
}
