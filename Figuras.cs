using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_perimetro
{
    internal class Figuras
    {
        public void Start()
        {
            figuras();
        }

        bool continueflag = true;

        public void figuras()
        {
            while(continueflag) 
            {
                Console.WriteLine("Elige una figura: \n");

                Console.WriteLine("Rectangulo");
                Console.WriteLine("Triangulo");
                Console.WriteLine("Circulo");

                string Option = Console.ReadLine();

                switch (Option) 
                {
                    case "Rectangulo":

                        float rBase, rAltura;

                        Console.WriteLine("Ingresa la altura del rectangulo \n ");
                        rAltura = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la base del rectangulo \n ");
                        rBase = float.Parse(Console.ReadLine());

                        Rectangulo rectangulo = new Rectangulo(rBase, rAltura);
                        Console.WriteLine($"El area del rectangulo es {rectangulo.Area()} y el perimetro es {rectangulo.Perimetro()}");
                        break;

                    case "Triangulo":

                        float tBase, tAltura;

                        Console.WriteLine("Ingresa la altura del triangulo \n");
                        tAltura = float.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa la base del triangulo \n");
                        tBase = float.Parse(Console.ReadLine());

                        Triangulo triangulo = new Triangulo(tBase, tAltura);
                        Console.WriteLine($"El area del triangulo es {triangulo.Area()} y el perimetro es {triangulo.Perimetro()}");
                        break;

                    case "Circulo":

                        float cRadio, pi = 3.14f;

                        Console.WriteLine("Ingresa el radio del circulo \n");
                        cRadio = float.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo(cRadio, pi);
                        Console.WriteLine($"El area del circulo es {circulo.Area()} y el perimetro es {circulo.Perimetro()}");
                        break;

                }

                Console.WriteLine("Desea continuar, SI/NO \n");
                if (Console.ReadLine() == "NO")
                {
                    continueflag = false;
                }
            }

            Console.WriteLine();

        }
    }
}
