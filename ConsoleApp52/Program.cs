using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class AltinOranArama
        {
            public static void Main(string[] args)
            {
                double a = 0.0;
                double b = 10.0;
                double epsilon = 0.001;

                while (Math.Abs(b - a) > epsilon)
                {
                    double x1 = b - (b - a) / epsilon;
                    double x2 = a + (b - a) / epsilon;
                    double f1 = Fonksiyon(x1);
                    double f2 = Fonksiyon(x2);

                    if (f1 < f2)
                    {
                        a = x1;
                    }
                    else
                    {
                        b = x2;
                    }
                }

                double optimumNokta = (a + b) / 2;
                double optimumDeger = Fonksiyon(optimumNokta);

                Console.WriteLine("Optimum Nokta: " + optimumNokta);
                Console.WriteLine("Optimum Değer: " + optimumDeger);
            }

            static double Fonksiyon(double x)
            {
                return Math.Pow(x, 2) - 4 * x + 3;
            }
        }
    }
}
