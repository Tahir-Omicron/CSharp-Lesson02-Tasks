using System;

namespace QuizApp
{
    class Question
    {
        public string Metn { get; set; }
        public string VariantA { get; set; }
        public string VariantB { get; set; }
        public string VariantC { get; set; }
        public string DuzgunVariant { get; set; }

        public Question(string metn, string va, string vb, string vc, string duzgun)
        {
            Metn = metn;
            VariantA = va;
            VariantB = vb;
            VariantC = vc;
            DuzgunVariant = duzgun;
        }

        public void CapEt()
        {
            Console.WriteLine(Metn);
            Console.WriteLine(VariantA);
            Console.WriteLine(VariantB);
            Console.WriteLine(VariantC);
        }

        public bool Yoxla(string cavab)
        {
            return cavab.ToLower().Trim() == DuzgunVariant.ToLower().Trim();
        }
    }

    class Program
    {
        static void SualiVer(Question q, ref int duzgun, ref int sehv)
        {
            q.CapEt();
            Console.Write("Cavabınız: ");
            string cavab = Console.ReadLine();

            if (q.Yoxla(cavab))
            {
                Console.WriteLine("Doğrudur.\n");
                duzgun++;
            }
            else
            {
                Console.WriteLine($"Səhvdir. Düzgün cavab: {q.DuzgunVariant}\n");
                sehv++;
            }
        }

        static void Main(string[] args)
        {
            int duzgun = 0;
            int sehv = 0;

            Question q1 = new Question(
                "1. int, double, bool tipləri yaddaşın hansı hissəsində saxlanılır?",
                "a) Heap",
                "b) Stack",
                "c) Disk",
                "b"
            );

            Question q2 = new Question(
                "2. Console.ReadLine() daxil edilən məlumatı hansı tipdə qaytarır?",
                "a) int",
                "b) object",
                "c) string",
                "c"
            );

            Question q3 = new Question(
                "3. Reference Type-lar default olaraq hansı dəyəri alır?",
                "a) 0",
                "b) false",
                "c) null",
                "c"
            );

            Question q4 = new Question(
                "4. Parse ilə TryParse arasındakı əsas fərq nədir?",
                "a) Parse xəta olanda exception atır, TryParse isə false qaytarır",
                "b) Fərqləri yoxdur",
                "c) TryParse yalnız string üçündür",
                "a"
            );

            Question q5 = new Question(
                "5. Məlumatı ekrana çıxarıb yeni sətrə keçən metod hansıdır?",
                "a) Console.Write()",
                "b) Console.WriteLine()",
                "c) Console.ReadLine()",
                "b"
            );

            SualiVer(q1, ref duzgun, ref sehv);
            SualiVer(q2, ref duzgun, ref sehv);
            SualiVer(q3, ref duzgun, ref sehv);
            SualiVer(q4, ref duzgun, ref sehv);
            SualiVer(q5, ref duzgun, ref sehv);

            Console.WriteLine($"Nəticə -> Düzgün: {duzgun}, Səhv: {sehv}");
        }
    }
}