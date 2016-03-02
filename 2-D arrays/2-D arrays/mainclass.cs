using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_arrays
{
    class mainclass
    {

        public void mainmenu(int flag1, int flagb)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("===================================MAIN MENU===================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress 1 to Create a Matrix");
            if (flag1 == 1 || flagb == 1)
            {
                Console.WriteLine("\nPress 2 to Insert element in Matrix");
                Console.WriteLine("\nPress 3 to Replace element in Matrix");
                Console.WriteLine("\nPress 5 to Search element in Matrix");                
                Console.WriteLine("\nPress 7 to Display the Matrix");
                Console.WriteLine("\nPress 8 to Switiching  Matrix");
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








    }
}
