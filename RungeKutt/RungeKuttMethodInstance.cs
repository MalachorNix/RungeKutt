using System;
using RungeKutt;

namespace LabProject.RungeKutt
{
    static class RungeKuttMethodInstance
    {
        private static RungeKuttMethod instance;

        public static RungeKuttMethod Instance
        {
            get
            {
                if (instance == null)
                {
                    //Console.WriteLine("Лабораторная работа №1");
                    //Console.WriteLine("Метод Рунге-Кутта третьего порядка.");
                    //Console.WriteLine("Находим значения y1, y2, y3 приближенного решения уравнения первого порядка y' = 0.7 * (x + y) - (1 + x * y)");
                    //Console.WriteLine("Введите х0 и у0.");

                link:
                    try
                    {
                        //Console.Write("x0 = ");
                        //double x0 = Convert.ToDouble(Console.ReadLine());
                        //Console.Write("y0 = ");
                        //double y0 = Convert.ToDouble(Console.ReadLine());
                        //instance = new RungeKuttMethod(x0, y0);
                        instance = new RungeKuttMethod(0, 0);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Ввод текста запрещен. Введите число. Повторите попытку.");
                        goto link;
                    }
                }
                return instance;
            }
        }


        public static void Main()
        {
            //RungeKutt_Methods r = new RungeKutt_Methods();


            System.Windows.Forms.Application.Run(new RungeKutt_Methods());


            //RungeKuttMethod r = Instance;
            //r.RungeKuttThird();
            //Console.WriteLine("Нажмите Enter для завершения работы программы.");
            //Console.ReadLine();
        }
    }
}
