using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErglonExam
{
    class ProblemTwo
    {
        //Problem 2
        public static void VMirror(int[,] input)
        {
            int[,] reversedMatrix = new int[input.GetLength(0), input.GetLength(1)];
            for (int r = 0; r < input.GetLength(0); r++)
            {
                for (int c = 0; c < input.GetLength(1); c++)
                {
                    reversedMatrix[r, c] = input[8 - r - 1, 8 - c - 1];
                }
            }
            Console.WriteLine("The reversed matrix is");
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(reversedMatrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
