using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErglonExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.");
            Console.WriteLine("Please enter a word or a sentence.");

            string example = Console.ReadLine();

            ProblemOne.Reverse(example);

            Console.WriteLine();
            Console.WriteLine("Problem 2");

            //Input for the problem 2 (image)
            int[,] mirror = new int[8, 8];
            for(int r=0; r<8;r++)
            {
                for(int c=0; c < 8; c++)
                {
                    mirror[r, c] = c;
                }
            }

            Console.WriteLine("The matrix for mirroring is:");
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(mirror[r, c]);
                }
                Console.WriteLine();
            }

            try
            {
               ProblemTwo.VMirror(mirror);
            }
            catch(TypeInitializationException)
            {
                Console.WriteLine("Something's wrong with the input! Please check input!");
            }

            Console.ReadKey();
        }   
    }
}
