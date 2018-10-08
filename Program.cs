using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soluciomillorada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dona'm la base: ");
            double baseNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Dona'm el num a convertir: ");
            string num = Console.ReadLine();
            string[] llista = num.Split(',');
            
            int numLen = llista[0].Length -1;
            Console.WriteLine(numLen);
            double suma = 0;
            foreach (char a in llista[0])
            {
                Console.WriteLine(a.ToString());
                int b = int.Parse(a.ToString());
                
                Console.WriteLine(b+ "HOLA");
                suma += b * Math.Pow(baseNum, numLen);
                numLen -= 1;
            }
            numLen = llista[1].Length;
            
            foreach (char a in llista[1])
            {
                Console.WriteLine(a.ToString());
                int b = int.Parse(a.ToString());

                Console.WriteLine(b + "HOLA");
                suma += b * Math.Pow(baseNum, -numLen);
                numLen -= 1;
            }
            Console.WriteLine(suma);

           }
    }
}
