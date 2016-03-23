using System;

namespace LabProject.RungeKutt
{
    internal class MethodRungeKutt
    {
        private double x0, y0;
        private double[] solution = new double[4];
        private static double H = 0.1;

        public double[] Solution
        {
            get { return solution; }
        }

        protected internal MethodRungeKutt(double x0, double y0)
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
}
