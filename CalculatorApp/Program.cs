using System;

namespace CalculatorApp
{
    class Calculator
    {
        public double Topla(double a, double b)
        {
            return a + b;
        }

        public double Cix(double a, double b)
        {
            return a - b;
        }

        public double Vur(double a, double b)
        {
            return a * b;
        }

        public double Bol(double a, double b)
        {
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

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
                    netice = calc.Topla(eded1, eded2);
                    break;

                case '-':
                    netice = calc.Cix(eded1, eded2);
                    break;

                case '*':
                    netice = calc.Vur(eded1, eded2);
                    break;

                case '/':
                    // Sıfıra bölmə yoxlanışını adi if ilə edirik
                    if (eded2 == 0)
                    {
                        Console.WriteLine("Xəta: Sıfıra bölmək olmaz.");
                        duzgundur = false;
                    }
                    else
                    {
                        netice = calc.Bol(eded1, eded2);
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