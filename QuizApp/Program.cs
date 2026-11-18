using System;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int duzgun = 0;
            int sehv = 0;

            Console.WriteLine("1. int, double, bool tipləri yaddaşın hansı hissəsində saxlanılır?");
            Console.WriteLine("a) Heap");
            Console.WriteLine("b) Stack");
            Console.WriteLine("c) Disk");
            Console.Write("Cavabınız: ");
            string c1 = Console.ReadLine().ToLower().Trim();

            if (c1 == "b")
            {
                Console.WriteLine("Doğrudur.\n");
                duzgun++;
            }
            else
            {
                Console.WriteLine("Səhvdir. Düzgün cavab: b\n");
                sehv++;
            }

            Console.WriteLine("2. Console.ReadLine() daxil edilən məlumatı hansı tipdə qaytarır?");
            Console.WriteLine("a) int");
            Console.WriteLine("b) object");
            Console.WriteLine("c) string");
            Console.Write("Cavabınız: ");
            string c2 = Console.ReadLine().ToLower().Trim();

            if (c2 == "c")
            {
                Console.WriteLine("Doğrudur.\n");
                duzgun++;
            }
            else
            {
                Console.WriteLine("Səhvdir. Düzgün cavab: c\n");
                sehv++;
            }

            Console.WriteLine("3. Reference Type-lar default olaraq hansı dəyəri alır?");
            Console.WriteLine("a) 0");
            Console.WriteLine("b) false");
            Console.WriteLine("c) null");
            Console.Write("Cavabınız: ");
            string c3 = Console.ReadLine().ToLower().Trim();

            if (c3 == "c")
            {
                Console.WriteLine("Doğrudur.\n");
                duzgun++;
            }
            else
            {
                Console.WriteLine("Səhvdir. Düzgün cavab: c\n");
                sehv++;
            }

            Console.WriteLine("4. Parse ilə TryParse arasındakı əsas fərq nədir?");
            Console.WriteLine("a) Parse xəta olanda exception atır, TryParse isə false qaytarır");
            Console.WriteLine("b) Fərqləri yoxdur");
            Console.WriteLine("c) TryParse yalnız string üçündür");
            Console.Write("Cavabınız: ");
            string c4 = Console.ReadLine().ToLower().Trim();

            if (c4 == "a")
            {
                Console.WriteLine("Doğrudur.\n");
                duzgun++;
            }
            else
            {
                Console.WriteLine("Səhvdir. Düzgün cavab: a\n");
                sehv++;
            }

            Console.WriteLine("5. Məlumatı ekrana çıxarıb yeni sətrə keçən metod hansıdır?");
            Console.WriteLine("a) Console.Write()");
            Console.WriteLine("b) Console.WriteLine()");
            Console.WriteLine("c) Console.ReadLine()");
            Console.Write("Cavabınız: ");
            string c5 = Console.ReadLine().ToLower().Trim();

            if (c5 == "b")
            {
                Console.WriteLine("Doğrudur.\n");
                duzgun++;
            }
            else
            {
                Console.WriteLine("Səhvdir. Düzgün cavab: b\n");
                sehv++;
            }

            Console.WriteLine($"Nəticə -> Düzgün: {duzgun}, Səhv: {sehv}");
        }
    }
}