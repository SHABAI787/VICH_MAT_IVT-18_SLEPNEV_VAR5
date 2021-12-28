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
    }
}
