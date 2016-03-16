using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject.RungeKutt
{
    internal class RungeKutt
    {
        private double x0, y0;
        private double[] solution = new double[4];
        private static double H = 0.1;

        public double[] Solution
        {
            get { return solution; }
        }

        internal RungeKutt(double x0, double y0)
        {
            this.x0 = x0;
            this.y0 = y0;
        }

        private double f(double x, double y)
        {
            return 0.7 * (x + y) - (1 + x * y);
        }

        public void RungeKuttThird()
        {
            double x = x0;
            double y = y0;
            double deltaY;
            double FI0;
            double FI1;
            double FI2;
            solution[0] = y0;

            for (int i = 1; i < solution.Length; i++)
            {
                FI0 = H * f(x, y);
                FI1 = H * f(x + H / 2, y + FI0 / 2);
                FI2 = H * f(x + H, y - FI0 + 2 * FI1);
                deltaY = (FI0 + 4 * FI1 + FI2) / 6;
                solution[i] = solution[i - 1] + deltaY;
                x += H;
                y += deltaY;
            }

            for (int i = 0; i < solution.Length; i++)
            {
                Console.WriteLine("y[" + i + "] = " + solution[i]);
            }
        }
    }

    public class RungeKuttSingleton
    {
        private static RungeKutt instance;

        static RungeKutt Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Лабораторная работа №1");
                    Console.WriteLine("Метод Рунге-Кутта третьего порядка.");
                    Console.WriteLine("Находим значения y1, y2, y3 приближенного решения уравнения первого порядка y' = 0.7 * (x + y) - (1 + x * y)");
                    Console.WriteLine("Введите х0 и у0.");
                    Console.Write("x0 = ");
                    double x0 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("y0 = ");
                    double y0 = Convert.ToDouble(Console.ReadLine());
                    instance = new RungeKutt(x0, y0);
                }
                return instance;
            }
        }

        public static void Main()
        {
            RungeKutt r = Instance;
            r.RungeKuttThird();
            Console.WriteLine("Нажмите Enter для завершения работы программы.");
            Console.ReadLine();
        }
    }
}
