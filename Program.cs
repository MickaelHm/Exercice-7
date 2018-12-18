using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle ABC rectangle en C
            double AB;
            int BC;
            int CA;

            Console.WriteLine("Donnez la longueur de BC");
            BC = int.Parse(Console.ReadLine());
            Console.WriteLine("Donnez la longueur de CA");
            CA = int.Parse(Console.ReadLine());

            AB = Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(CA, 2)); // Math.Sqrt = racine carrée // Math.Pow(X,puissance2) chiffre avec puissance x^2
            //sauter des lignes que si c'est vraiment nécessaire, chaque ligne est traité et alourdi le programme
            Console.WriteLine("La longueur de AB est donc de " + AB);

            //int BC = int.Parse(Console.ReadLine())


        }
    }
}
