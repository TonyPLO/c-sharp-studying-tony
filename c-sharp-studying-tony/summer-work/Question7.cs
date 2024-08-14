using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class Question7
    {
        bool testQuestion7(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                int rowSum = 0;
                int columnSum = 0;

                for (int j = 0; j < n; j++)
                {
                    rowSum += matrix[i, j];
                    columnSum += matrix[j, i];
                }

                if (rowSum != columnSum)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
