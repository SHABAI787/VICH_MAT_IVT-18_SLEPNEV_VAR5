//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace VICH_MAT_IVT_18_SLEPNEV_VAR5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VICH_MAT_IVT_18_SLEPNEV_VAR5;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод базовых значений
            Console.WriteLine(
            "                                 Вариант №5\n"+
            "Вычислить приближенные значения интеграла методом трапеций и методом Симпсона в соот-\n" +
            "ветствии с вариантом. Результаты сравнить с точным значением интеграла и между собой.\n" +
            "-------------------------------------------------------------------------------------\n" +
            "                       1\n" +
            "Функция   y(x) = -------------\n" +
            "                  ln(1 + x^2)\n" +
            "Введите a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double h = (b - a) / n;
            double[] y = new double[n + 1];
            double[] x = new double[n + 1];
            x[0] = a;

            // Вычислениие функция
            y[0] = 1 / (Math.Log(1 + Math.Pow(x[0], 2)));
            for (int i = 1; i <= n; i++)
            {
                x[i] = x[i - 1] + h;
                y[i] = y[0] = 1 / (Math.Log(1 + Math.Pow(x[i], 2)));
            }
            
            // Формирование таблицы
            Console.WriteLine(
                "\n-----------------------------------------------------------------\n" +
                "|\ti\t|\t x \t|\t        y        \t|");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(
                    "-----------------------------------------------------------------\n" +
                    "|\t" + i + "\t|\t" + x[i] + "\t|\t" + y[i] + "\t|");
            }
            Console.WriteLine("----------------------------------------------------------------- \n");

            // Вычисление методом трапеции
            double tapeziumMethod = СalculationProcess.TapeziumMethod(y, h);
            Console.WriteLine($"Метод трапеции = {tapeziumMethod}");

            // Вычисление методом Симпсона
            double simpsonsMethod = СalculationProcess.SimpsonsMethod(y, h);
            Console.WriteLine($"Метод Симпсона = {simpsonsMethod}");

            Console.Read();
        }
    }
}

