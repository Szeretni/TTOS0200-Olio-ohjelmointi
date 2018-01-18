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

            //size of the game map
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
            for (int i = 0; i < (fieldSize * fieldSize); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Player 0 turn. Type coordinates of your choice in xy-format: ");
                }
                
                else
                {
                    //at this point game field is full
                    if (i == (fieldSize * 2 - 1))
                    {
                        Console.WriteLine("Game over, neither won.");
                        break;
                    }
                    Console.Write("Player X turn. Type coordinates of your choice in xy-format: ");
                }
                Console.WriteLine();
                int[] playerInput = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    playerInput[j] = Console.Read();
                }
                Console.ReadLine();
                Console.Clear();
                printField(playerInput, fieldSize, ref gameField, i);

                //checking if win
                char winFlag = winCheck(fieldSize, gameField);
                if (winFlag == '0')
                {
                    winPrint(winFlag);
                    break;
                }
                if (winFlag == 'X')
                {
                    winPrint(winFlag);
                    break;
                }
                
            }
        }

        //prints the current game state
        static void printField(int[] playerInput, int fieldSize, ref char[,] gameField, int i)
        {
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {
                    //unelegant! Ie. playerInput[0] == 1 (ASCII-Dec == 49) - 0 (ASCII-Dec == 48) equals to Dec 1 
                    if (playerInput[0] - '0'  == k && (playerInput[1] - '@' == j || playerInput[1] - '`' == j))
                    {
                        if (i % 2 == 0) gameField[j, k] = '0';
                        else gameField[j, k] = 'X';
                    }
                    Console.Write(gameField[j, k]);
                }
                Console.WriteLine();
            }
        }

        //checks the win condition
        static char winCheck(int fieldSize, char[,] gameField)
        {
            char winFlag = ' ';
            char x0;
            string rowAdd, colAdd;

            char[] possibilities = { 'X', '0' };

            for (int i = 0; i < 2; i++)
            {
                x0 = possibilities[i];
                //row check
                rowAdd = "0";
                colAdd = "+";
                winFlag = winCondition(fieldSize, gameField, rowAdd, colAdd, x0);
                if (winFlag != ' ') return winFlag;

                //column check
                rowAdd = "+";
                colAdd = "0";
                winFlag = winCondition(fieldSize, gameField, rowAdd, colAdd, x0);
                if (winFlag != ' ') return winFlag;

                //X diagonal top left to bottom right
                rowAdd = "+";
                colAdd = "+";
                winFlag = winCondition(fieldSize, gameField, rowAdd, colAdd, x0);
                if (winFlag != ' ') return winFlag;

                //X diagonal top right to bottom left
                rowAdd = "+";
                colAdd = "-";
                winFlag = winCondition(fieldSize, gameField, rowAdd, colAdd, x0);
                if (winFlag != ' ') return winFlag;
            }
            
            return winFlag;
        }

        //prints win text
        static void winPrint(char winFlag)
        {
            if (winFlag == 'X') Console.WriteLine("Player X won!");
            if (winFlag == '0') Console.WriteLine("Player 0 won!");
        }

        //checks how many same chars are in row/column/diagonal
        static char winCondition(int fieldSize, char[,] gameField, string rowAdd, string colAdd, char x0)
        {
            char winFlag = ' ';
            int a = 0, b = 0;
            for (int j = 0; j < fieldSize; j++)
            {
                for (int k = 0; k < fieldSize; k++)
                {

                    //own char found
                    if (gameField[j, k] == x0)
                    {
                        //checks if next is also own
                        for (int l = 0; l < fieldSize; l++)
                        {
                            //checks next char
                            if (rowAdd == "+") a++;
                            if (rowAdd == "-") a--;
                            if (colAdd == "+") b++;
                            if (colAdd == "-") b--;

                            //own char (X/0) lenght to win is fieldsize -2 (bc borders)
                            if (a == fieldSize - 2 || b == fieldSize - 2)
                            {
                                winFlag = x0;
                                return winFlag;
                            }

                            //keeps index in bounds
                            if ((j + a >= fieldSize) || (k + b >= fieldSize)) break;

                            //checks next char
                            else
                            {
                                if (gameField[j + a, k + b] != x0) return winFlag;
                            }
                        }
                    }
                }
            }
            return winFlag;
        }
    }
}