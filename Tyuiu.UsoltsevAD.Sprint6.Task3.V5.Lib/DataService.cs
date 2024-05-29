using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.UsoltsevAD.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] array = new int[rows, columns];
            int[] sortedColumn = new int[] { matrix[0, 2], matrix[1, 2], matrix[2, 2], matrix[3, 2], matrix[4, 2]};
            Array.Sort(sortedColumn);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 2)
                    {
                        array[i, j] = sortedColumn[i];
                    }
                    else
                    {
                        array[i, j] = matrix[i, j];
                    }
                }
            }
            return array;
        }
    }
}
