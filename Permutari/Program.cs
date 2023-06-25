using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Permutari
{
    internal class Program
    {
        static void Permutari(int k, int n, int[] S, bool[] B)
        {
            if (k >= n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(S[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!B[i])
                    {
                        B[i] = true;
                        S[k] = i;
                        Permutari(k + 1, n, S, B);
                        B[i] = false;
                    }
                }
            }
        }
        static void Aranjamente(int k, int n, int[] S, bool[] B, int p)
        {
            if (k >= p)
            {
                for (int i = 0; i < p; i++)
                {
                    Console.Write(S[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!B[i])
                    {
                        B[i] = true;
                        S[k] = i;
                        Aranjamente(k + 1, n, S, B, p);
                        B[i] = false;
                    }
                }
            }
        }
        static void Combinari(int k, int n, int[] S, bool[] B, int p)
        {
            if (k >= p)
            {
                bool ok = true;
                for (int i = 0; i < p - 1; i++)
                {
                    if (S[i] > S[i + 1])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    for (int j = 0; j < p; j++)
                    {
                        Console.Write(S[j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!B[i])
                    {
                        B[i] = true;
                        S[k] = i;
                        Combinari(k + 1, n, S, B, p);
                        B[i] = false;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            int[] S = new int[n];
            bool[] B = new bool[n];
            int k = 0;
            int p = 3;
            //Permutari(k, n, S, B);
            //Aranjamente(k, n, S, B, p);
            Combinari(k, n, S, B, p);
            Console.ReadKey();
        }
    }
}
