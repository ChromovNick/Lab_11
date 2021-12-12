using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution=new Solution();
            Console.WriteLine("Добро пожаловать в программу для решения уравнения прямой kx+b=0");
            Console.WriteLine("Введите целочисленное значение k:");
            solution.K = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите целочисленное значение b:{0}");
            solution.B = Convert.ToDouble(Console.ReadLine());
            solution.Root();
            Console.ReadKey();
        }
    }

    public struct Solution
    {
        double x;
        double k;
        double b;

        public double K
        {
            set
            {
                if (value % 1 == 0)
                {
                    k = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели нецелое значение k");
                }
            }
            get
            {
                return k;
            }
        }
        public double B
        {
            set
            {
                if (value % 1 == 0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели нецелое значение b");
                }
            }
            get
            {
                return b;
            }
        }

        public void Root()
        {
            Console.WriteLine("Решение:");
            double x = -b / k;
            Console.WriteLine("X={0}", x);
        }
    }
}
