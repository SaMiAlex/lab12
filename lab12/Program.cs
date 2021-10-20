using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{

    class Program
    {
        static void Main(string[] args)
        {
            Circle.calcP();
            Circle.calcS();
            Circle.checkPos();
            Console.ReadKey();
        }
    }
    static class Circle
    {
        static int r;
        static int x0;
        static int y0;

        static Circle()
        {
            try
            {
                Console.WriteLine("Введите радиус окружности r");
                r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координаты центра окружности x0 и y0");
                x0 = Convert.ToInt32(Console.ReadLine());
                y0 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void calcP()
        {
            double P = (double)2 * Math.PI * r;
            Console.WriteLine("Длина окружности радиусом {0} равна {1:f2}", r, P);
        }
        public static void calcS()
        {
            double S = (double)Math.PI * r * r;
            Console.WriteLine("Площадь круга радиусом {0} равна {1:f2}", r, S);
        }
        public static void checkPos()
        {
            Console.WriteLine("Введите координаты точки x и y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > x0 + r || y > y0 + r)
            {
                Console.WriteLine("Точка с координатами х={0} и у={1} лежит вне заданного контура", x, y);
            }
            else
            {
                Console.WriteLine("Точка с координатами х={0} и у={1} лежит внутри заданного контура", x, y);
            }
        }
    }
}
