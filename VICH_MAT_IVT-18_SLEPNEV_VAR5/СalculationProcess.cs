using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VICH_MAT_IVT_18_SLEPNEV_VAR5
{
    /// <summary>
    /// Процесс вычисления разными методами
    /// </summary>
    public static class СalculationProcess
    {
        /// <summary>
        /// Вычисление методом трапеций
        /// </summary>
        public static double TapeziumMethod(double[] y, double h)
        {
            double result = 0;

            double mt1 = (y[0] + y[y.Length - 1]) / 2;
            double mt2 = 0;
            for (int i = 1; i < y.Length - 1; i++)
            {
                mt2 = mt2 + y[i];
            }
            result = h * (mt1 + mt2);

            return result;
        }

        /// <summary>
        /// Вычисление методом Симпсона
        /// </summary>
        public static double SimpsonsMethod(double[] y, double h)
        {
            double result = 0;

            double ms1 = 0;
            for (int i = 1; i < y.Length - 1; i = i + 2)
            {
                ms1 = ms1 + y[i];
            }
            double ms2 = 0;
            for (int i = 2; i < y.Length - 1; i = i + 2)
            {
                ms2 = ms2 + y[i];
            }
            result = h / 3 * (y[0] + 4 * ms1 + 2 * ms2 + y[y.Length - 1]);
            return result;
        }

        /// <summary>
        /// Вычисление методом среднего прямоугольника
        /// </summary>
        public static double MiddleRectangleMethod(double[] y, double h, int n)
        {
            double result = 0;

            double mp = 0;
            for (int i = 0; i < n; i++)
            {
                mp = mp + y[i];
            }
            result = mp * h;

            return result;
        }
    }
}
