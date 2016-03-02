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
                          
                       
                           
                       
                       break; //end of case2
                    case 3:
                        //search element in matrix.

                       mainclass c3 = new mainclass();
                       c3.searchelement(a, b, rowa, columa, rowb, columb, a[0, 0], b[0, 0]);
                       break;//end of case3

                    case 4:
                         Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================Displaying A MATRIX============================");
            char selectionofmatrix2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Display MATRIX A:");
            Console.WriteLine("\n2-Display MATRIX B:");
            Console.Write("\nSelect a Number to Create the respective MATRIX: ");
            int dselection = int.Parse(Console.ReadLine());
            if (dselection==1)
            {
                selectionofmatrix2 = 'A';
                matrixoperation d11 = new matrixoperation();
                d11.display(a, rowa, columa, selectionofmatrix2);
            }
            else if (dselection==2)
            {
                selectionofmatrix2 = 'B';
                matrixoperation d11 = new matrixoperation();
                d11.display(b, rowb, columb, selectionofmatrix2);
            }
            else
            {
                mainclass obi = new mainclass();
                obi.invalidinput();

            }
                       break;
                    //end of case4
                    case 5:
                       mainclass c5 = new mainclass();
                       try
                       {
                           int c5s = c5.switchingmatrix();
                           if (c5s == 1)
                           {
                               if (flaga == 0)
                               {
                                   Console.ForegroundColor = ConsoleColor.Red;
                                   Console.WriteLine("You Have not created Matrix A yet....");
                                   Console.ForegroundColor = ConsoleColor.White;
                               }
                               else
                               {
                                   selectionofmatrix = 'A';
                                   Console.WriteLine("You have been swtiched to Matrix A");

                               }


                           }
                           else if (c5s == 2)
                           {
                               if (flagb == 0)
                               {
                                   Console.ForegroundColor = ConsoleColor.Red;
                                   Console.WriteLine("You Have not created Matrix B yet....");
                                   Console.ForegroundColor = ConsoleColor.White;
                               }
                               else
                               {
                                   selectionofmatrix = 'B';
                                   Console.WriteLine("You have been swtiched to Matrix B");

                               }

                           }
                           else
                           {

                               mainclass c5e = new mainclass();
                               c5e.invalidinput();

                           }
                       }
                        catch(Exception)
                       {
                           mainclass c5e = new mainclass();
                           c5e.invalidinput();
                           goto main;
                       }

                       break;
                    case 6:
                       try
                       {










                       }

                       catch (Exception)
                       {
                           mainclass c5e = new mainclass();
                           c5e.invalidinput();
                           goto main;
                       }

                       break;

                    case 7:

                       try
                       {
                           class2 c7 = new class2();
                           c7.adddisplay(a, b, c, rowa, columa, rowb, columb);

                       }

                        catch(Exception)
                       {
                           mainclass c5e = new mainclass();
                           c5e.invalidinput();
                           goto main;

                       }

                       break;





                    default:
                       mainclass d = new mainclass();
                       d.invalidinput();
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
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            


        }
    }
}
