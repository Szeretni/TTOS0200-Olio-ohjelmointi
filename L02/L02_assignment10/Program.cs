/*Hannu Oksman
Toteuta jokin oma villi-ideasi ja yllätä opettaja toteutuksellasi.

TODO: coordinate must be empty when submitting turn?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Checks and Zeroes Game");
            int fieldSize = 5;
            //multidimensional syntax
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
            char[,] gameField = new char[fieldSize,fieldSize];

            //initialising game screen
            char initRow = '1';
            char initCol = 'A';
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    //-1 in order to fit array
                    if (i == 0 || i == fieldSize - 1 || j == 0 || j == fieldSize - 1)
                    {
                        gameField[i, j] = '*';
                    }
                    if (i == 0 && (j > 0 && j < (fieldSize - 1)))
                    {
                        gameField[i, j] = initRow;
                        initRow++;
                    }
                    if (j == 0 && (i > 0 && i < (fieldSize - 1)))
                    {
                        gameField[i, j] = initCol;
                        initCol++;
                    }
                    Console.Write(gameField[i,j]);
                }
                Console.WriteLine();
            }

            //initialising playing
            for (int i = 0; ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Player 0 turn. Type coordinates of your choice in xy-format: ");
                }
                else
                {
                    Console.Write("Player X turn. Type coordinates of your choice in xy-format: ");
                }
                Console.WriteLine();
                int[] playerInput = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    playerInput[j] = Console.Read();
                }
                Console.ReadLine();
                printField(playerInput, fieldSize, ref gameField, i);

                //checking if win
                int winFlag = 0;
                winFlag = winCheck(winFlag, fieldSize, gameField);
                if (winFlag == 1)
                {
                    Console.WriteLine("Player X won!");
                    break;
                }
                if (winFlag == 2)
                {
                    Console.WriteLine("Player 0 won!");
                    break;
                }
            }
        }

        static void printField(int[] playerInput, int fieldSize, ref char[,] gameField, int i)
        {
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (playerInput[0] - '0' == k && playerInput[1] - '@' == j)
                    {
                        if (i % 2 == 0) gameField[j, k] = '0';
                        else gameField[j, k] = 'X';
                    }
                    Console.Write(gameField[j, k]);
                }
                Console.WriteLine();
            }
        }

        static int winCheck(int winFlag, int fieldSize, char[,] gameField)
        {
            //X row check
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j,k] == 'X')
                    {
                        if (gameField[j,k+1] == 'X')
                        {
                            if (gameField[j,k+2] == 'X')
                            {
                                winFlag = 1;
                            }
                        }
                    }
                }
            }
            //X column check
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j,k] == 'X')
                    {
                        if (gameField[j+1,k] == 'X')
                        {
                            if (gameField[j+2,k] == 'X')
                            {
                                winFlag = 1;
                            }
                        }
                    }
                }
            }
            //X diagonal top left
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j,k] == 'X')
                    {
                        if (gameField[j+1,k+1] == 'X')
                        {
                            if (gameField[j+2,k+2] == 'X')
                            {
                                winFlag = 1;
                            }
                        }
                    }
                }
            }
            //X diagonal top right
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j, k] == 'X')
                    {
                        if (gameField[j + 1, k - 1] == 'X')
                        {
                            if (gameField[j + 2, k - 2] == 'X')
                            {
                                winFlag = 1;
                            }
                        }
                    }
                }
            }
            //0 row check
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j,k] == '0')
                    {
                        if (gameField[j,k+1] == '0')
                        {
                            if (gameField[j,k+2] == '0')
                            {
                                winFlag = 2;
                            }
                        }
                    }
                }
            }
            //0 column check
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j,k] == '0')
                    {
                        if (gameField[j+1,k] == '0')
                        {
                            if (gameField[j+2,k] == '0')
                            {
                                winFlag = 2;
                            }
                        }
                    }
                }
            }
            //X diagonal top left
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j, k] == '0')
                    {
                        if (gameField[j + 1, k + 1] == '0')
                        {
                            if (gameField[j + 2, k + 2] == '0')
                            {
                                winFlag = 2;
                            }
                        }
                    }
                }
            }
            //X diagonal top right
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    if (gameField[j, k] == '0')
                    {
                        if (gameField[j + 1, k - 1] == '0')
                        {
                            if (gameField[j + 2, k - 2] == '0')
                            {
                                winFlag = 2;
                            }
                        }
                    }
                }
            }
            return winFlag;
        }
    }
}
