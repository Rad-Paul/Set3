using System;
using System.Dynamic;

namespace set3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            //Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
            //int[] numbers = { 2, 7, 23, 48, 51, 20, 78, 101, 66, 231, 22, 6, 0 };

           // Console.WriteLine(SumaPrimi(360));
            int a = 50;
            // Console.WriteLine(a /= 5);
            // Console.WriteLine(a);
            // Console.WriteLine(cifreComuneMax(2034932, 3253923));
            Console.WriteLine(generareSir(10));
        }

        static int SumaPrimi(int n) // EX2
        {
            int aux = n;
            int sum = 0;
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
                while (n % i == 0)
                {
                    n /= i;
                }
                if (i == 2)
                {
                    i++;
                }
                else i += 2;
                if (i > aux / 2)
                {
                    sum += aux;
                    break;
                }
            }
            return sum;
        }
        static int cifreComuneMax(int x, int y) // EX1
        {
            int[] frx = new int[10];
            int[] fry = new int[10];
            int toreturn = 0;

            while (x > 0) // vectori de frecventa pt x si y
            {
                frx[x % 10] += 1;
                x /= 10;
            }
            while (y > 0)
            {
                fry[y % 10] += 1;
                y /= 10;
            }

            for (int i = 9; i >= 0; i--) // cel mai mare nr natural din cifre distincte comune
            {
                if (frx[i] > 0 && fry[i] > 0) // parcurgem vectorii de frecventa de la 9 la 0, verificam daca au cifre comune si formam numarul de returnat
                {
                    toreturn *= 10;
                    toreturn += i;
                }
            }
            return toreturn;
        }
        static void generareSir(int n)  // EX2
        {
            int contor = 0;
            int i = 1;
            while (contor < n)
            {
                for (int j = 1; j <= i; j++)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(j + " ");
                        contor++;
                        if (contor == n)
                        {
                            return;
                        }
                    }
                }
                i++;
            }
        }
    }

}