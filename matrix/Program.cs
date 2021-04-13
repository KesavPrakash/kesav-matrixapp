using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 4;
            int[,] a = { { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 },
                         { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 } };
            Console.WriteLine("Exercise 2 : Given matrix is \n");
            printMatrix(a);

            printPrincipalDiagonal(a, n);
            printASCIIDiagonal(a, n);
            printSecondaryDiagonal(a, n);
            Console.ReadLine();
        }


        #region privatemethods

        // Function to print the main Diagonal with binarycode
        static void printPrincipalDiagonal(int[,] mat, int n)
        {
            Console.Write("Exercise 2 (a): Diagonal value with 8bit binary code ");
            string maindiagonal = string.Empty;
            string binconverteddiagonal = string.Empty;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Condition for principal diagonal
                    if (i == j)
                    {
                        maindiagonal += mat[i, j] + ", ";

                        string binaryconverted = DecimalToBinary(mat[i, j]);
                        binconverteddiagonal += "\n" + "value:" + mat[i, j] + " Binary code:" + binaryconverted;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Diagonal value : " + maindiagonal);
            Console.WriteLine(binconverteddiagonal);
        }

        // Function to print the main Diagonal with asciicode
        static void printASCIIDiagonal(int[,] mat, int n)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Exercise 2 (b): Diagonal value with ASCII code: ");
            string maindiagonal = string.Empty;
            string asciiconverteddiagonal = string.Empty;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Condition for principal diagonal with ASCII
                    if (i == j)
                    {
                        maindiagonal += mat[i, j] + ", ";

                        byte[] dec_ascii = DecimalToASCII(Convert.ToString(mat[i, j]));
                        asciiconverteddiagonal += "\n" + "value:" + mat[i, j] + " ASCII code:" + dec_ascii[0];
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Diagonal value : " + maindiagonal);
            Console.WriteLine(asciiconverteddiagonal);
        }

        // Function to print the Other Diagonal
        static void printSecondaryDiagonal(int[,] mat, int n)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Exercise 2 (c): Other MatrixDimensions: ");
            Console.WriteLine("");

            string maindiagonal = string.Empty;
            string otherdiagonal = string.Empty;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Condition for principal diagonal with ASCII
                    if (i == j)
                    {
                        maindiagonal += mat[i, j] + ", ";
                    }

                    // Condition for secondary diagonal
                    if ((i + j) == (n - 1))
                    {
                        otherdiagonal += mat[i, j] + ", ";
                    }
                }
            }
            Console.WriteLine("");
            Console.Write("Main diagonal :" + maindiagonal);
            Console.WriteLine("");
            Console.Write("Other diagonal :" + otherdiagonal);
        }

        public static byte[] DecimalToASCII(string dec)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(dec);
            return asciiBytes;
        }

        static string DecimalToBinary(int n)
        {
            string binval = "";
            int i;
            int[] a = new int[10];
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            for (i = i - 1; i >= 0; i--)
            {
                binval += a[i];
            }

            return Convert.ToString(binval).PadLeft(8, '0');
        }
        static int ROW = 4;
        static int COL = 4;
        static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                    Console.Write(matrix[i, j] + " ");

                Console.WriteLine("\n");
            }
        }

        #endregion


     
    }

}
