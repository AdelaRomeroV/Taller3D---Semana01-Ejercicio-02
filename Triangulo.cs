using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_perimetro
{
    internal class Triangulo
    {
        private float tBase;
        private float tAltura;

        public Triangulo(float tBase, float tAltura)
        {
            this.tBase = tBase;
            this.tAltura = tAltura;
        }

        public float Area()
        {
            return tBase * tAltura / 2;
        }

        public float Perimetro()
        {
            return (tAltura * 2) + tBase;
        }
    }
}

