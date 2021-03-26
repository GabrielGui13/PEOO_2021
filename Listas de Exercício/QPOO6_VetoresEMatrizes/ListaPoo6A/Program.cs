using System;

namespace lista1teste
{
    class Program
    {
        static void Main(string[] args){
            /* int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] w = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < v.Length; i++) Console.WriteLine(v[i] + w[w.Length-1-i]); */

            /* int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] w = new int[10];
            Array.Copy(v, w, 5);
            foreach (int i in w) Console.WriteLine(i);
            } */

            /* int[] v = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
            Array.Sort(v);
            foreach (int i in v) Console.WriteLine(i);
            */

            /* int[] v = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
            Array.Reverse(v);
            foreach (int i in v)
            Console.WriteLine(i);
            */

            /* int[] v = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
            int p1 = Array.IndexOf(v, 5);
            int p2 = Array.IndexOf(v, 10);
            int p3 = Array.IndexOf(v, 15);
            Console.WriteLine(p1); //volta o indice do numero
            Console.WriteLine(p2); //primeiro
            Console.WriteLine(p3); //-1 out of range
            */
            
            /* int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.ForEach(v, i => Console.WriteLine(i * i)); */

            /* int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
            { 9, 10, 11, 12 } };
            Console.WriteLine(m.Length);
            Console.WriteLine(m.GetLength(0));
            Console.WriteLine(m.GetLength(1)); */

            /* int[,] m = new int[4, 5]; [linha, coluna]
            Console.WriteLine(m.Length);
            Console.WriteLine(m.GetLength(0)); linha
            Console.WriteLine(m.GetLength(1)); coluna */

            /* int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
            for (int i = 0; i < m.GetLength(0); i++) {
                for (int j = 0; j < m.GetLength(1); j++) {
                    Console.Write("{0,5}", m[i, j]);
                    Console.WriteLine();
                }
            } */

            /* int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
            foreach (int i in m) Console.WriteLine(i); */

            /* int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }, {13, 14, 15, 16 } };
            int x = 0;
            for (int i = 0; i < m.GetLength(0); i++) {
                for (int j = 0; j < m.GetLength(1); j++) if (i == j) x += m[i, j];
            }
            Console.WriteLine(x); */

            /* int[,] m = {{ 1, 2, 3, 4 }, { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }, {13, 14, 15, 16 }};
            int x = 0;
            for (int i = 0; i < m.GetLength(0); i++) x += m[i, i];
            Console.WriteLine(x); */
        }
    }
}
