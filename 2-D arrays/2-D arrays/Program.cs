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
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("============================CREATING AN MATRIX A============================");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Enter the no. of Rows: ");
                            rowa = int.Parse(Console.ReadLine());
                            Console.Write("\nEnter the no. of columns: ");
                            columa = int.Parse(Console.ReadLine());
                            matrixoperation matrixa = new matrixoperation();
                            matrixa.createarray(a, rowa, columa);
                            matrixoperation M = new matrixoperation();
                            M.ismatrixsquare(a, rowa, columa);
                            goto main;

                        }
                        else if (case1 == 2) //matrix C CREATION
                        {
                            
                        }
                        else //DEFAULT ERROR
                        {
                            mainclass ex = new mainclass();
                            ex.invalidinput();
                            goto main;
                        }




                        break;



                    default:
                        break;
                }
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
