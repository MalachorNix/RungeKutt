using System;

namespace LabProject.RungeKutt
{
    static class RungeKuttSingleton
    {
        private static MethodRungeKutt instance;

        public static MethodRungeKutt Instance
        {
            get
            {
                if (instance == null)
                {
                    Console.WriteLine("Лабораторная работа №1");
                    Console.WriteLine("Метод Рунге-Кутта третьего порядка.");
                    Console.WriteLine("Находим значения y1, y2, y3 приближенного решения уравнения первого порядка y' = 0.7 * (x + y) - (1 + x * y)");
                    Console.WriteLine("Введите х0 и у0.");

                link:
                    try
                    {
                        Console.Write("x0 = ");
                        double x0 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("y0 = ");
                        double y0 = Convert.ToDouble(Console.ReadLine());
                        instance = new MethodRungeKutt(x0, y0);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Ввод текста запрещен. Вводите только число. Повторите попытку.");
                        goto link;
                    }
                }
                return instance;
            }
        }


        public static void Main()
        {
            MethodRungeKutt r = Instance;
            r.RungeKuttThird();
            Console.WriteLine("Нажмите Enter для завершения работы программы.");
            Console.ReadLine();

        }
    }
}
