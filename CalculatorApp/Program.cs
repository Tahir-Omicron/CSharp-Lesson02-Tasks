using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci ədədi daxil edin: ");
            double eded1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Əməliyyatı daxil edin (+, -, *, /): ");
            char emeliyyat = Convert.ToChar(Console.ReadLine());

            Console.Write("İkinci ədədi daxil edin: ");
            double eded2 = Convert.ToDouble(Console.ReadLine());

            double netice = 0;
            bool duzgundur = true;

            switch (emeliyyat)
            {
                case '+':
                    netice = eded1 + eded2;
                    break;

                case '-':
                    netice = eded1 - eded2;
                    break;

                case '*':
                    netice = eded1 * eded2;
                    break;

                case '/':
                    if (eded2 == 0)
                    {
                        Console.WriteLine("Xəta: Sıfıra bölmək olmaz.");
                        duzgundur = false;
                    }
                    else
                    {
                        netice = eded1 / eded2;
                    }
                    break;

                default:
                    Console.WriteLine("Xəta: Yanlış əməliyyat daxil edildi.");
                    duzgundur = false;
                    break;
            }

            if (duzgundur)
            {
                Console.WriteLine($"Nəticə: {eded1} {emeliyyat} {eded2} = {netice}");
            }
        }
    }
}