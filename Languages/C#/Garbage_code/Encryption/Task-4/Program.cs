﻿using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Боится,какчертладана";
            char[] m1 = s.ToCharArray();
            int n = 4;
            int m = 5;
            char[,] m2 = new char[n, m];
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (k < m1.Length)
                        m2[j, i] = m1[k];
                    k = k + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(m2[i, j] + " ");
                }
                Console.WriteLine();
            }
            char[,] m6 = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                m6[i, 0] = m2[i, 2];
                m6[i, 1] = m2[i, 0];
                m6[i, 2] = m2[i, 3];
                m6[i, 3] = m2[i, 1];
                m6[i, 4] = m2[i, 4];
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(m6[i, j] + " ");
                }
                Console.WriteLine();
            }
        }       
    }
}
