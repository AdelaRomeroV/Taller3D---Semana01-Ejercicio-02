using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_perimetro
{
    internal class Circulo
    {
        private float cRadio;
        private float pi;

        public Circulo(float cRadio, float pi)
        {
            this.cRadio = cRadio;
            this.pi = pi;
        }

        public float Area()
        {
            return pi * (cRadio * cRadio);
        }

        public float Perimetro()
        {
            return 2 * pi * cRadio;
        }
    }
}
