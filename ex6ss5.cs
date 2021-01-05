using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnipet6
{

    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int i;
            int[,] dimension = new int[4,5];
            int numOne = 0;
            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 5; j++)
                {
                    dimension[i,j] = numOne;
                    numOne++;
                }
            }
            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 5; j++)
                {
                    Console.Write(dimension[i,j] + "");
                }
                Console.Write(dimension[i,j] + "");
            }
            Console.WriteLine();
        }
    }
 }

