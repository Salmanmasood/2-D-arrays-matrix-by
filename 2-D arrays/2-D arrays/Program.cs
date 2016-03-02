using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_arrays
{
    class Program
    {
        public static int[,] a = new int[100,100];
        public static int[,] b = new int[100, 100];
        public static int[,] c = new int[200, 200];

        static void Main(string[] args)
        {
            int flaga = 0, flagb = 0, rowa,rowb,columa,columb;
            int maininput;

            main:
            mainclass ob = new mainclass();
            try
            {
                ob.mainmenu(flaga, flagb);
                maininput = int.Parse(Console.ReadLine());
                switch (maininput)
                {
                    case 1:
                        mainclass c1 = new mainclass();
                        int case1=c1.creatematrix();
                        if (case1==1) //matrix A CREATION
                        {
                            if (a[0, 0] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have Created the Matrix A\nYou cannot re-create it again...");
                                Console.ForegroundColor = ConsoleColor.White;
                               
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("============================CREATING AN MATRIX A============================");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter the no. of Rows: ");
                                rowa = int.Parse(Console.ReadLine());
                                Console.Write("\nEnter the no. of columns: ");
                                columa = int.Parse(Console.ReadLine());
                                matrixoperation matrixa = new matrixoperation();
                                matrixa.createarray(a, rowa, columa);
                                flaga = 1;
                                a[0, 0] = 1; //setting a flag that it will not recreate the matrix.
                                matrixoperation M = new matrixoperation();
                                M.ismatrixsquare(a, rowa, columa);
                                goto main;
                            }
                        }
                        else if (case1 == 2) //matrix C CREATION
                        {
                            if (b[0, 0] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have Created the Matrix B\nYou cannot re-create it again...");
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("============================CREATING AN MATRIX A============================");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter the no. of Rows: ");
                                rowb = int.Parse(Console.ReadLine());
                                Console.Write("\nEnter the no. of columns: ");
                                columb = int.Parse(Console.ReadLine());
                                matrixoperation matrixa = new matrixoperation();
                                matrixa.createarray(b, rowb, columb);
                                flagb = 1;
                                b[0, 0] = 1; //setting a flag that it will not recreate the matrix.
                                matrixoperation M = new matrixoperation();
                                M.ismatrixsquare(b, rowb, columb);
                                goto main;
                            }

                        }
                        else //DEFAULT ERROR
                        {
                            mainclass ex = new mainclass();
                            ex.invalidinput();
                            goto main;
                        }
                        break;  //end of case 1.

                    case 2:
                        mainclass c2 = new mainclass();
                       int c2selection=c2.replaceelementinmatrix();
                       if (c2selection==1)
                       {
                           
                       }
                       else if (c2selection==2)
                       {
                           
                       }
                       else
                       {
                           mainclass ex = new mainclass();
                           ex.invalidinput();
                           goto main;
                       }
                       break; //end of case2

                    default:
                        break;
                }

                mainclass last = new mainclass();
                last.clearscreen();
                goto main;
            
            
            }
            catch(Exception)
            {
                mainclass ex = new mainclass();
                ex.invalidinput();
                goto main;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadLine();


        }
    }
}
