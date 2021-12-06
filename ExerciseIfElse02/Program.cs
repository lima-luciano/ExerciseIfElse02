using System;
using System.Globalization;

namespace ExerciseIfElse02
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculates income tax based on the salary entered

            string taxes0 = "Tax exempt";
            double taxes1 = 0.08, taxes2 = 0.18, taxes3 = 0.28, p1, p2, p3, p4, p5, total;


            Console.WriteLine("INCOME                              INCOME TAX");
            Console.WriteLine("from R$ 0.00      to R$ 2000.00     TAX EXEMPT");
            Console.WriteLine("from R$ 2000.01   to R$ 3000.00     8 %");
            Console.WriteLine("from R$ 3000.01   to R$ 4500.00     18%");
            Console.WriteLine("Over              R$ 4500.00        28%");
            Console.WriteLine();
            Console.WriteLine("Tap your salary:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 2000.00)
            {
                Console.WriteLine(taxes0);
            }
            else if (salary > 2000.00 && salary <= 3000.00)
            {
                total = (salary - 2000) * taxes1;
                Console.WriteLine("TOTAL TAXE R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salary > 3000.00 && salary < 4500.00)
            {
                p1 = (salary - 3000);
                p2 = (p1 * taxes2);
                p3 = (salary - p1 - 2000) * taxes1;
                total = (p2 + p3);
                Console.WriteLine("TOTAL TAXE R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                p1 = (salary - 4500.00);
                p2 = (p1 * taxes3);
                p3 = (salary - p1 - 3000.00);
                p4 = (p3 * taxes2);
                p5 = (salary - p1 - p3 - 2000) * taxes1;
                total = (p2 + p4 + p5);

                Console.WriteLine("TOTAL TAXE R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
//Solved by lima-luciano on 11/15/2021
