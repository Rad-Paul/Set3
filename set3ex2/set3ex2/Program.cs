using System;
namespace set3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k.
            //Daca k nu apare in vector rezultatul va fi -1. 
            Console.Write("Introduceti numarul cautat in vector: ");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            int k = int.Parse(Console.ReadLine());
            int rez = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                // Console.WriteLine(numbers[i])
                if (numbers[i] == k)
                {
                    rez = i;
                    Console.WriteLine("Numarul se afla pe pozitia " + rez + ".");
                    break;
                }

                else if (numbers[i] != k) 
                {
                    rez = -1;
                }
            }
           
        }
    }
}
