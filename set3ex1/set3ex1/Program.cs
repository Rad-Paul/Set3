using System;
namespace set3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
            int n;
            Console.WriteLine("Introduceti marimea vectorului: ");
            n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Introduceti numarul " + (i + 1) + ":");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < numbers.Length;i++) 
            {
               // Console.Write(numbers[i] + " ");
            }

            foreach(int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Suma numerelor este: " + sum);

            
        }
    }
}