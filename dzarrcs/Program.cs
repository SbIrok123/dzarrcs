using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzarrcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] rainbowColors = 
            {
                ConsoleColor.Red,
                ConsoleColor.DarkYellow,
                ConsoleColor.Yellow,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Blue,
                ConsoleColor.Magenta
            };
            string str = "                                                  ";

            foreach (var color in rainbowColors)
            {
                Console.BackgroundColor = color;
                Console.WriteLine(str);
            }
            Console.BackgroundColor= ConsoleColor.Black;
            string[,] chess =
            new string[8, 8]{
                { "0","0","0","0","0","0","0","0" },
                { "0","0","0","0","0","0","0","0" },
                { "0","0","0","0","0","0","0","0" },
                { "0","0","0","0","0","0","0","0" },
                { "0","0","0","0","0","0","0","0" },
                { "0","0","0","0","0","0","0","0" },
                { "0","0","0","0","0","0","0","0" },
                { "0","0","0","0","0","0","0","0" }


            };
            for (int i = 0; i < chess.GetLength(0); i++)
            {
                for (int j = 0; j < chess.GetLength(1);j++)
                {
                    Console.Write(chess[i, j]+" ");
                    if (i ==7 && j ==3)
                    {
                        chess[i, j] = "Q";
                    }
                    else
                    {
                        if ((i==7 || j==3) )
                        {
                            chess[i,j] = "+";
                        }
                        else if((i-j==4) || i+j==10)
                        {
                            chess[i, j] = "+";
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < chess.GetLength(0); i++)
            {
                for (int j = 0; j < chess.GetLength(1); j++)
                {
                    Console.Write(chess[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
