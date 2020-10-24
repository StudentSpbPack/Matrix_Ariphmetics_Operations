using System;
using static System.Console;
using System.Threading;

namespace Matrixs_arithmetic_operations
{
    class Program
    {
        /// <summary>
        /// Method that multiplicate two matrixs
        /// </summary>
        /// <param name="CursorWidth"> Width for place parametrs of matrix </param>
        /// <param name="CursorHeight"> Height for place parametrs of matrix </param>
        /// <param name="MatrixGot1"> Matrix that will multiplicate and will write on console </param>
        /// <param name="MatrixGot2"> Matrix that will multiplicate MatrixGot1 </param>
        private static void Matrix_Multiplication_And_Write(int CursorWidth, int CursorHeight, int[,] MatrixGot1, int[,] MatrixGot2)
        {
            int widthSave = CursorWidth;
            for (int i = 0; i < MatrixGot1.GetLength(0); i++)
            {
                for (int k = 0; k < MatrixGot1.GetLength(1); k++)
                {
                    for (int j = 0; j < MatrixGot1.GetLength(1); j++)
                    {
                        MatrixGot1[i, k] += MatrixGot1[i, j] * MatrixGot2[j, k];
                    }
                    SetCursorPosition(CursorWidth, CursorHeight);
                    if (k == 0)
                        Write($"|{MatrixGot1[i, k]}");
                    else if (k == MatrixGot1.GetLength(1) - 1)
                        Write($"{MatrixGot1[i, k]}|");
                    else
                        Write($"{MatrixGot1[i, k]}");
                    MatrixGot1[i, k] = 0;
                    CursorWidth += 5;
                }
                CursorHeight += 1;
                CursorWidth = widthSave;
            }
        }

        /// <summary>
        /// Method that substraction matrixs
        /// </summary>
        /// <param name="CursorWidth"> Width for place parametrs of matrix </param>
        /// <param name="CursorHeight"> Height for place parametrs of matrix </param>
        /// <param name="MatrixGot1"> Matrix that will substraction and will write on console </param>
        /// <param name="MatrixGot2"> Matrix that will substration MatrixGot1 </param>
        private static void Matrix_Substraction_And_Write(int CursorWidth, int CursorHeight, int[,] MatrixGot1, int[,] MatrixGot2)
        {
            int widthSave = CursorWidth;
            for (int i = 0; i < MatrixGot1.GetLength(0); i++)
            {
                for (int k = 0; k < MatrixGot1.GetLength(1); k++)
                {
                    MatrixGot1[i, k] = MatrixGot1[i, k] - MatrixGot2[i, k];
                    SetCursorPosition(CursorWidth, CursorHeight);
                    if (k == 0)
                        Write($"|{MatrixGot1[i, k]}");
                    else if (k == MatrixGot1.GetLength(1) - 1)
                        Write($"{MatrixGot1[i, k]}|");
                    else
                        Write($"{MatrixGot1[i, k]}");

                    CursorWidth += 5;
                }
                CursorHeight += 1;
                CursorWidth = widthSave;
            }
        }

        /// <summary>
        /// Method that addition matrixs
        /// </summary>
        /// <param name="CursorWidth"> Width for place parametrs of matrix </param>
        /// <param name="CursorHeight"> Height for place parametrs of matrix </param>
        /// <param name="MatrixGot1"> Matrix that will addition and will write on console </param>
        /// <param name="MatrixGot2"> Matrix that will addition MatrixGot1 </param>
        private static void Matrix_Addition_And_Write(int CursorWidth, int CursorHeight, int[,] MatrixGot1, int[,] MatrixGot2)
        {
            int widthSave = CursorWidth;
            for (int i = 0; i < MatrixGot1.GetLength(0); i++)
            {
                for (int k = 0; k < MatrixGot1.GetLength(1); k++)
                {
                    MatrixGot1[i, k] = MatrixGot1[i, k] + MatrixGot2[i, k];
                    SetCursorPosition(CursorWidth, CursorHeight);
                    if (k == 0)
                        Write($"|{MatrixGot1[i, k]}");
                    else if (k == MatrixGot1.GetLength(1) - 1)
                        Write($"{MatrixGot1[i, k]}|");
                    else
                        Write($"{MatrixGot1[i, k]}");

                    CursorWidth += 5;
                }
                CursorHeight += 1;
                CursorWidth = widthSave;
            }

        }

        /// <summary>
        /// Method that multiplicate and write matrix
        /// </summary>
        /// <param name="CursorWidth"> Width for place parametrs of matrix </param>
        /// <param name="CursorHeight"> Height for place parametrs of matrix </param>
        /// <param name="NumberMultiplicate"> Number that will multiplicate on each numbers in matrixs</param>
        /// <param name="MatrixGot"> Matrix that will multiplicate on number and will write on console </param>
        private static void MatrixMultiplicationOnNumberAndWrite(int CursorWidth, int CursorHeight, int NumberMultiplicate, int[,] MatrixGot)
        {           
            SetCursorPosition(CursorWidth, MatrixGot.GetLength(1)/2);
            Write("=");
            CursorWidth += 5;
            int widthSave = CursorWidth;

            for (int i = 0; i < MatrixGot.GetLength(0); i++)
            {
                for (int k = 0; k < MatrixGot.GetLength(1); k++)
                {
                    MatrixGot[i, k] *= NumberMultiplicate;
                    SetCursorPosition(CursorWidth, CursorHeight);
                    if (k == 0)
                        Write($"|{MatrixGot[i, k]}");
                    else if (k == MatrixGot.GetLength(1) - 1)
                        Write($"{MatrixGot[i, k]}|");
                    else
                        Write($"{MatrixGot[i, k]}");

                    CursorWidth += 5;
                }
                CursorHeight += 1;
                CursorWidth = widthSave;
            }
            
        }

        /// <summary>
        /// Method that fill matrix
        /// </summary>
        /// <param name="MatrixGot"> Matrix that will be fill and return </param>
        /// <returns></returns>
        private static int[, ] MatrixFill(int[,] MatrixGot)
        {
            Random NumberForMatrix = new Random();
            for (int i = 0; i < MatrixGot.GetLength(0); i++)
            {
                for (int k = 0; k < MatrixGot.GetLength(1); k++)
                {
                    MatrixGot[i, k] = NumberForMatrix.Next(0, 4);
                }
            }
            return MatrixGot;
        }

        /// <summary>
        /// Method that write matrix
        /// </summary>
        /// <param name="CursorWidth"> Width for place parametrs of matrixs </param>
        /// <param name="CursorHeight"> Height for place parametrs of matrixs </param>
        /// <param name="MatrixMultplicationText"> Matrix that will be write on console </param>
        private static void MatrixWrite(int CursorWidth, int CursorHeight, int[, ] MatrixMultplicationText)
        {
            int WidthSave = CursorWidth;
            Random NumberForMatrix = new Random();
            for (int i = 0; i < MatrixMultplicationText.GetLength(0); i++)
            {
                for (int k = 0;  k < MatrixMultplicationText.GetLength(1); k++)
                {
                    SetCursorPosition(CursorWidth, CursorHeight);
                    if (k == 0)
                        Write($"|{MatrixMultplicationText[i, k]}");
                    else if (k == MatrixMultplicationText.GetLength(1) - 1)
                        Write($"{MatrixMultplicationText[i, k]}|");
                    else
                        Write($"{MatrixMultplicationText[i, k]}");

                    CursorWidth += 5;
                }
                CursorHeight += 1;
                CursorWidth = WidthSave;
            }
        }

        /// <summary>
        /// Method that run program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetWindowSize(150, 30);
            while (true)
            {
                #region Method that take number of columns, raws and number choose operation with matrix
                Write("Write amount of columns matrix: ");
                byte columns = byte.Parse(Console.ReadLine());
                Write("Should be less, than 10! Write amount of raws matrix: ");
                byte raws = byte.Parse(Console.ReadLine());
                Clear();

                WriteLine("\n1 - Multiplication matrix by number " +
                    "\n2 - Addition/substraction matrix from matrix" +
                    "\n3 - Multiplication matrix on matrix. Columns should be equally Raws and less than 10.");
                Write("Choose operation with matrix: ");
                byte NumberOfOperation = byte.Parse(ReadLine());
                #endregion
                if (NumberOfOperation == 1 && raws < 10)
                {
                    #region Method that take and write multiplication number
                    Clear();
                    Write("Write number that will multiplication on matrix: ");
                    short MultiplicationNumber = short.Parse(ReadLine());
                    Clear();
                    SetCursorPosition(0, columns / 2);
                    WriteLine($"{MultiplicationNumber}  x");
                    #endregion
                    #region Method that write matrix that will multiplicate on number
                    Thread.Sleep(1000);
                    int[,] matrix = new int[columns, raws];
                    MatrixFill(matrix);
                    MatrixWrite(5, 0, matrix);
                    #endregion
                    #region Method that write matrix have already multiplicated
                    Thread.Sleep(1000);
                    MatrixMultiplicationOnNumberAndWrite(raws * 5 + 3, 0, MultiplicationNumber, matrix);
                    Console.ReadKey();
                    #endregion
                }  // Multiplication on number
                else if (NumberOfOperation == 2 && raws < 10)
                {
                    #region Method that choose addition or substraction
                    Clear();
                    WriteLine("+ = Addition \n- = Substraction");
                    Write("Write char that will show what do with matrix: ");
                    char ChooseAriphmeticOperations = char.Parse(ReadLine());
                    Clear();
                    #endregion

                    #region Method that create and write two matrixs that will addition/substraction
                    Clear();
                    int[,] matrix1 = new int[columns, raws];
                    MatrixFill(matrix1);
                    MatrixWrite(0, 0, matrix1);

                    Thread.Sleep(1000);
                    SetCursorPosition(raws * 5, columns / 2);
                    Write(ChooseAriphmeticOperations);

                    Thread.Sleep(1000);
                    int[,] matrix2 = new int[columns, raws];
                    MatrixFill(matrix2);
                    MatrixWrite(raws * 5 + 2, 0, matrix2);
                    #endregion
                    // Operator that check choose addition of matrixs
                    if (ChooseAriphmeticOperations == '+')
                    {
                        Thread.Sleep(1000);
                        SetCursorPosition((raws * 5) * 2 + 4, columns / 2);
                        Write('=');
                        Matrix_Addition_And_Write((raws * 5) * 2 + 6, 0, matrix1, matrix2);
                        ReadKey();
                    } // Addition Matrixs
                    else if (ChooseAriphmeticOperations == '-')
                    {
                        Thread.Sleep(1000);
                        SetCursorPosition((raws * 5) * 2 + 4, columns / 2);
                        Write('=');
                        Matrix_Substraction_And_Write((raws * 5) * 2 + 8, 0, matrix1, matrix2);
                        ReadKey();
                    } // Substration Matrixs
                    else
                    {
                        Clear();
                        Write("Error you choose wrong arithmetic operations with matrixs");
                    } // Program error
                } // Addition/Substraction matrixs
                else if (NumberOfOperation == 3 && raws < 10)
                {
                    #region Method that create and write two matrixs that will multiplicate
                    Clear();
                    int[,] matrix1 = new int[columns, raws];
                    MatrixFill(matrix1);
                    MatrixWrite(0, 0, matrix1);

                    Thread.Sleep(1000);
                    SetCursorPosition(raws * 5, columns / 2);
                    Write('*');

                    Thread.Sleep(1000);
                    int[,] matrix2 = new int[columns, raws];
                    MatrixFill(matrix2);
                    MatrixWrite(raws * 5 + 2, 0, matrix2);
                    #endregion
                    if (columns == raws && columns < 10)
                    {
                        #region Method that multiplicate two matrixs
                        Thread.Sleep(1000);
                        SetCursorPosition((raws * 5) * 2 + 4, columns / 2);
                        Write('=');
                        Matrix_Multiplication_And_Write((raws * 5) * 2 + 6, 0, matrix1, matrix2);
                        ReadKey();
                        #endregion
                    } // Operator that check columns and raws for multiplicate
                    else
                    {
                        Console.Clear();
                        Write("Error. Columns != raws");
                        ReadKey();
                    } // Program error
                } // Multiplication matrixs
                else
                {
                    Clear();
                    Write("Error Raws > 10 or you choose nonexistent operation");
                    ReadKey();
                } // Programm error
                Clear();

                #region Method that reload or stop program
                WriteLine("Want to reload? \n1 - yes \n2 - no");
                byte ChooseContinue = byte.Parse(ReadLine());
                if (ChooseContinue == 1)
                {
                    Clear();
                    Write("Ok, wait 1 second");
                    Thread.Sleep(1000);
                    Console.Clear();
                }    
                else if (ChooseContinue == 2)
                {
                    Clear();
                    Write("Ok, wait 2 second");
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    while(true)
                    {
                        WriteLine("Error");
                    }
                }
                #endregion
            }
        }
    }
}
