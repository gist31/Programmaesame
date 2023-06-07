using System.Numerics;
using System.Collections.Generic;


namespace prova_atom
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Geben sie eine Nummer ein:");
            
            long num = System.Convert.ToInt32(System.Console.ReadLine());

            List<long> CalcoliInArray = new List<long>();

            while (num != 0)
            {
                CalcoliInArray.Add(num);
                num--;
            } 

            BigInteger factorial = 1;

            foreach (var CalcoloInArray in CalcoliInArray)
            {
                factorial *= CalcoloInArray;
            }
            
            System.Console.WriteLine(factorial);
        }
    }

}
