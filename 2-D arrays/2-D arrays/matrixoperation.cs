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
    
        public void ismatrixsquare(int[,]a,int rows,int columns,char m)
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
                displayobj.display(a, rows, columns,m);
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

        public void display(int[,]a,int rows,int columns,char m)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("==========matrix {0}==========", m);
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();

            }

        }
        

        public void replaceelement(int[,]a,int row,int col)
        {
            l1:
            Console.Write("\nEnter the row number :");
            int r = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the column number :");
            int c = int.Parse(Console.ReadLine());
            if (r>row || c>col)
            {
                mainclass ob = new mainclass();
                ob.logicalerror();
                goto l1;
            }
            else
            {

                Console.Write("\nEnter the element that you want to put on this index M[{0},{1}] ", r, c);
                int ele = int.Parse(Console.ReadLine());
                a[r, c] = ele;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("The element {0} has been replaced successfully on index M[{1},{2}]..",ele,r,c);
            }


        }

        public void replacementbyanelement(int[,] a, int row, int col)
        {
            Console.Write("\nEnter the element that you want to Replace: ");
            int rep = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the element that you want to put: ");
            int put = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (a[i, j] == rep)
                    {
                        a[i, j] = put;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The element {0} has been replaced by {1} successfully..",rep,put);
                    }

                }

            }


        }   //end of method.....


    }
}
