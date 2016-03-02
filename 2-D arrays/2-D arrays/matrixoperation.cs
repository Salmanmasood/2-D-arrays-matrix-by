using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_arrays
{
    class matrixoperation
    {
        public int[,] createarray(int[,]a,int rows,int columns)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write("\nEnter the value at index A[{0},{1}] :", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            return a;
        } //end of method......
    
        public void ismatrixsquare(int[,]a,int rows,int columns)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (rows==columns)
            {
                Console.WriteLine("The matrix is An Square Matrix");
     
            }
            else
            {
                Console.WriteLine("The matrix is A Rectangular Matrix");
            }
            L1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press 'd' or 'D' to diplay the matrix A\nPress 'm' or 'M' to go in the main menu... ");
            char d = char.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            if (d=='d' ||d=='D')
            {
                matrixoperation displayobj = new matrixoperation();
                displayobj.display(a, rows, columns);
                mainclass ob = new mainclass();
                ob.goback();
            }
            else if (d=='m' || d=='M')
            {
                mainclass ob = new mainclass();
                ob.goback();
            }
            else
            {
                mainclass ob = new mainclass();
                ob.invalidinput();
                goto L1;
            }

            
        }

        public void display(int[,]a,int rows,int columns)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();

            }

        }

    }
}
