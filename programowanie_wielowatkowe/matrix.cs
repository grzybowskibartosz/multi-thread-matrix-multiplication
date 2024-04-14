using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_wielowatkowe
{
    internal class matrix
    {
        int rank { get; set; }
        public double[,] GenerateRandomMatrix(int rank)
        {
            double[,] matrix = new double[rank, rank];
            Random random = new Random();
            for (int i = 0; i < rank; i++)
            {
                for (int j = 0; j < rank; j++)
                {
                    matrix[i, j] = random.NextDouble() * 100;
                }
            }
            return matrix;
        }
    }
}
