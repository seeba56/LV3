using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2LV3
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random generator;
        private RandomGenerator()
        {
            this.generator = new Random();
        }
        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        }


        public double[][] NextMatrix(int m, int n)
        {

            double[][] matrix = new double[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new double[n];
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = generator.NextDouble();
                }
            }
            return matrix;
        }
    }
}

