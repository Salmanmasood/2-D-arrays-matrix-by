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
            int flaga = 0, flagb = 0, rowa = 0, rowb = 0, columa = 0, columb = 0;
            int maininput;
            char selectionofmatrix = 'A';
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
                                M.ismatrixsquare(a, rowa, columa,selectionofmatrix);
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
                                selectionofmatrix = 'B';
                                matrixoperation M = new matrixoperation();
                                M.ismatrixsquare(b, rowb, columb,selectionofmatrix);
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

                           if (a[0,0]==1)
                           {
                               mainclass c22 = new mainclass();
                               int cs = c22.replaceinterface();
                               if (cs == 1)
                               {
                                   matrixoperation ob2 = new matrixoperation();
                                   ob2.replaceelement(a, rowa, columa);

                               }
                               else if (cs == 2)
                               {
                                   matrixoperation oc = new matrixoperation();
                                   oc.replacementbyanelement(a, rowa, columa);

                               }

                               else
                               {
                                   mainclass ex = new mainclass();
                                   ex.invalidinput();
                                   goto main;

                               }
     
                           }

                           else
                           {
                               Console.ForegroundColor = ConsoleColor.Red;
                               Console.WriteLine("you have not Created matrix A!!!!");
                               Console.ForegroundColor = ConsoleColor.White;
                               Console.WriteLine("press any key to go back......");
                               Console.ReadKey();
                               Console.Clear();
                           }


                       } //yhn ha
                       else if (c2selection==2)
                       {
                           if (b[0,0]==1)
                           {
                               mainclass c23 = new mainclass();
                               int cs2 = c23.replaceinterface();

                               if (cs2 == 1)
                               {
                                   matrixoperation ob2 = new matrixoperation();
                                   ob2.replaceelement(b, rowb, columb);

                               }
                               else if (cs2 == 2)
                               {
                                   matrixoperation oc = new matrixoperation();
                                   oc.replacementbyanelement(b, rowb, columb);

                               }

                               else
                               {
                                   mainclass ex = new mainclass();
                                   ex.invalidinput();
                                   goto main;

                               }


                           }
                           else
                           {
                               Console.ForegroundColor = ConsoleColor.Red;
                               Console.WriteLine("you have not Created matrix B!!!!");
                               Console.ForegroundColor = ConsoleColor.White;
                               Console.WriteLine("press any key to go back......");
                               Console.ReadKey();
                               Console.Clear();
                           }
                          
                       
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
