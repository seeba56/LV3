using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2LV3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] matrix = new double[5][];
            for (int i = 0; i < 5; i++)
            {
                matrix[i] = new double[3];
            }
            RandomGenerator matrixgen = RandomGenerator.GetInstance();
            matrix = matrixgen.NextMatrix(5, 5);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i][j].ToString() + '\t');
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
