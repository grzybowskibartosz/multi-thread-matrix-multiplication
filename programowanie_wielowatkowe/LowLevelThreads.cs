using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_wielowatkowe
{
    internal class LowLevelThreads
    {
        public double[,] Multiply(double[,] MA, double[,] MB, int threadCount)
        {
            int size = MA.GetLength(0);
            double[,] result = new double[size, size];
            Thread[] threads = new Thread[threadCount];
            int elementsPerThread = (size * size) / threadCount;

            for (int t = 0; t < threadCount; t++)
            {
                int threadIndex = t;
                threads[t] = new Thread(() =>
                {
                    int start = threadIndex * elementsPerThread;
                    int end = (threadIndex == threadCount - 1) ? size * size : start + elementsPerThread;

                    for (int index = start; index < end; index++)
                    {
                        int i = index / size;
                        int j = index % size;
                        double sum = 0;
                        for (int k = 0; k < size; k++)
                        {
                            sum += MA[i, k] * MB[k, j];
                        }
                        result[i, j] = sum;
                    }
                });
                threads[t].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            return result;
        }
    }
}