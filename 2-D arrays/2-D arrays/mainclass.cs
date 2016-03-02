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
                Console.WriteLine("\nPress 5 to Switiching  Matrix");
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




    }
}
