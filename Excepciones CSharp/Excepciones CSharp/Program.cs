using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            int r;
            try
            {
                Console.Write(" Ingrese el primer numero: ");
                Num1 = int.Parse(Console.ReadLine());
                Console.Write(" Ingrese el segundo numero: ");
                Num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                r = Num1 / Num2;
                Console.WriteLine(r);
                Console.ReadKey();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
