using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SokolovaAA.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int s = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        s += matrix[i, j];
                    }
                }
            }

            return s;
        }
    }
}
