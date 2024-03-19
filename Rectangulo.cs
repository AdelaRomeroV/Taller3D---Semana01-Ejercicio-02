using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_perimetro
{
    internal class Rectangulo
    {
        private float rBase;
        private float rAltura;

        public Rectangulo( float rBase, float rAltura )
        {
            this.rBase = rBase;
            this.rAltura = rAltura;
        }

        public float Area()
        {
            return rBase * rAltura;
        }

        public float Perimetro()
        {
            return (rAltura + rBase) * 2;
        }
    }
}
