#define IN_LINE1

using System;

namespace DI_T1_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg1, msg2;
            Console.WriteLine("Frase1: ");
            msg1 = Console.ReadLine();
            Console.WriteLine("Frase2: ");
            msg2 = Console.ReadLine();
            Console.WriteLine();
#if IN_LINE
            Console.WriteLine("\"{0}\" \\{1}\\",msg1,msg2);
#elif !IN_LINE
            Console.WriteLine("{0}\t{1}" +
                "\r\n{0}" +
                "\r\n{1}",msg1,msg2);
#endif
        }
    }
}
