using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_arrays
{
    class mainclass
    {
        public void clearscreen()
        {
            Console.WriteLine("Press any key to go back.....");
            Console.ReadKey();
            Console.Clear();
        }
        public void mainmenu(int flaga, int flagb)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("===================================MAIN MENU===================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress 1 to Create a Matrix");
            if (flaga == 1 || flagb == 1)
            {
                Console.WriteLine("\nPress 2 to Replace element in Matrix");
                Console.WriteLine("\nPress 3 to Search element in Matrix");                
                Console.WriteLine("\nPress 4 to Display the Matrix");
                Console.WriteLine("\nPress 5 to Switching  Matrix");
                Console.WriteLine("\nPress 6 to Find Determinant  of Matrix");
                
            }
            if (flaga==1 && flagb==1)
            {
                Console.WriteLine("\nPress 7 to Add Matrices");
                Console.WriteLine("\nPress 8 to Subtract Matrices");
                Console.WriteLine("\nPress 9 to Multiply Matrices");
                Console.WriteLine("\nPress 10 to Find Inverse Matrices");
                
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("select a no. to perform the following the funtion: ");
            Console.ForegroundColor = ConsoleColor.Magenta;

        } //1st display method

        public void invalidinput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input!!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("press any key to go back......");
            Console.ReadKey();
            Console.Clear();
        } //exception method

        public int creatematrix()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================CREATING A MATRIX============================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Create MATRIX A:");
            Console.WriteLine("\n2-Create MATRIX B:");
            Console.Write("\nSelect a Number to Create the respective MATRIX: ");
            int arrayselection = int.Parse(Console.ReadLine());


            return arrayselection;

        }
        public int replaceelementinmatrix()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=====================REPLACEMENT AN ELEMENT IN MATRIX=====================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Replace Element in MATRIX A:");
            Console.WriteLine("\n2-Replace Element in MATRIX B:");
            Console.Write("\nSelect a Number to chose the respective MATRIX: ");
            int arrayselection = int.Parse(Console.ReadLine());


            return arrayselection;

        } //end of method

        public void searchelement(int[,] a, int[,] b, int rowa, int colmna, int rowb, int colmnb,int flaga,int flagb)
        { l1:
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=====================SEARCH AN ELEMENT IN MATRIX=====================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Search Element in MATRIX A:");
            Console.WriteLine("\n2-Search Element in MATRIX B:");
            Console.Write("\nSelect a Number to chose the respective MATRIX: ");
            int arrayselection = int.Parse(Console.ReadLine());
            if (arrayselection==1)
            {
                mainclass a1 = new mainclass();
               int x= a1.searchinterface();
               if (x==1)
               {
                   mainclass x1 = new mainclass();
                   x1.searchingelementmethod(a, rowa, colmna,flaga);
                   
               }
               else if (x==2)
               {

                   mainclass x2 = new mainclass();
                   x2.searchbyindex(a, rowa, colmna,flaga);
      
               }
               else
               {
                   mainclass e1 = new mainclass();
                   e1.invalidinput();
                   goto l1;

               }


            }
            else if (arrayselection ==2)   
            {
                mainclass b1 = new mainclass();
                int x = b1.searchinterface();
                if (x == 1)
                {
                    mainclass x1 = new mainclass();
                    x1.searchingelementmethod(b, rowb, colmnb,flagb);

                }
                else if (x == 2)
                {
                    mainclass x2 = new mainclass();
                    x2.searchbyindex(b, rowb, colmnb,flagb);
                }
                else
                {
                    mainclass e1 = new mainclass();
                    e1.invalidinput();
                    goto l1;

                }


            }
            else
            {
                mainclass ob = new mainclass();
                ob.invalidinput();
                goto l1;
            }

        } //end of method

        public int searchinterface()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=====================SEARCH AN ELEMENT IN MATRIX=====================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Search by Element ");
            Console.WriteLine("\n2-Search by index");
            Console.Write("\nSelect a Number to chose the respective MATRIX: ");
            int s = int.Parse(Console.ReadLine());
            return s;

        }




        public void goback()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press any key to go back....");
            Console.ReadKey();
            Console.Clear();

        }
        public int replaceinterface()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=====================REPLACEMENT AN ELEMENT IN MATRIX=====================");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\n1-Replace Element By Position");
            Console.WriteLine("\n2-Replace By Element ");
            Console.Write("\nSelect a Number to chose the respective MATRIX: ");
            int arrayselection = int.Parse(Console.ReadLine());


            return arrayselection;



        }

        public void logicalerror()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Logical Error!!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("press any key to go back......");
            Console.ReadKey();
            Console.Clear();


        }

        public void searchingelementmethod(int[,]a,int row,int col,int flag)
        {
            if (flag == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You not have Created the Matrix ..");
                Console.ForegroundColor = ConsoleColor.White;


            }
            else
            {
                Console.WriteLine("Enter the element that you want to search: ");
                int s = int.Parse(Console.ReadLine());
                int xi = 0, yi = 0;
                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= col; j++)
                    {
                        if (a[i, j] == s)
                        {
                            xi = i;
                            yi = j;
                        }

                    }


                }

                if (xi == 0 && yi == 0)
                {
                    Console.WriteLine("element {0} has not found !!", s);
                }
                else
                {
                    Console.WriteLine("element {0} is found at M[{1},{2}]", s, xi, yi);
                }
            }
        }


        public void searchbyindex(int[,]a,int row,int col,int flaga)
        {

            if (flaga== 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You not have Created the Matrix ..");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.Write("\nenter the row#:");
                int ri = int.Parse(Console.ReadLine());
                Console.Write("\nenter the column#:");
                int ci = int.Parse(Console.ReadLine());
                int temp = -3232323;
                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= col; j++)
                    {
                        if (i == ri && j == ci)
                        {
                            temp = a[i, j];
                        }

                    }


                }
                if (temp == -3232323)
                {
                    Console.WriteLine("no such index exist....");
                }
                else
                {
                    Console.WriteLine("On M[{0},{1}] index we have elemnt {2}", ri, ci, temp);
                }
            }

        } //end of method.....
        public int switchingmatrix()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=======================SWITCHING ARRAY=======================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Switch to matrix A");
            Console.WriteLine("\n2-Switch to matrix B");
            Console.Write("\n select a number to perform the following funtions: ");
            int sortoption = int.Parse(Console.ReadLine());

            return sortoption;
        }//end of method.....




    }
}
