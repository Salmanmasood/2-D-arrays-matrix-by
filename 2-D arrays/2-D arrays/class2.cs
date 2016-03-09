using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_D_arrays
{
    class class2
    {
        public void adddisplay(float[,] a, float[,] b, float[,] c, int ra, int ca, int rb, int cb)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================ADDING MATRICES============================");
            Console.ForegroundColor = ConsoleColor.White;
            class2 ob = new class2();
           bool x= ob.cmpforadd(ra, ca, rb, cb);
           if (x==true)
           {
               for (int i = 1; i <= ra; i++)
               {
                   for (int j =1 ; j <= ca; j++)
                   {
                       c[i, j] = a[i, j] + b[i, j];
                       
                   }

               }
           L1:
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("Press 'd' or 'D' to diplay the matrix A\nPress 'm' or 'M' to go in the main menu... ");
               char d = char.Parse(Console.ReadLine());
               Console.ForegroundColor = ConsoleColor.White;
               if (d == 'd' || d == 'D')
               {
                   matrixoperation displayobj = new matrixoperation();
                   char m = 'C';
                   displayobj.display(c, ra, ca, m);
                   mainclass ob2 = new mainclass();
                   ob2.goback();
               }
               else if (d == 'm' || d == 'M')
               {
                   mainclass ob2 = new mainclass();
                   ob2.goback();
               }
               else
               {
                   mainclass ob2 = new mainclass();
                   ob2.invalidinput();
                   goto L1;
               }

           
           }
           
           else
               {
                     Console.ForegroundColor = ConsoleColor.Magenta;
                   Console.WriteLine("Matrices cannot be added....");
                     Console.ForegroundColor = ConsoleColor.White;

               }



        }

        public void subdisplay(float[,] a, float[,] b, float[,] c, int ra, int ca, int rb, int cb)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================SUBTRACTING MATRICES============================");
            Console.ForegroundColor = ConsoleColor.White;
            class2 ob = new class2();
            bool x = ob.cmpforadd(ra, ca, rb, cb);
            if (x == true)
            {
                for (int i = 1; i <= ra; i++)
                {
                    for (int j = 1; j <= ca; j++)
                    {
                        c[i, j] = a[i, j] - b[i, j];

                    }

                }
            L1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press 'd' or 'D' to diplay the matrix A\nPress 'm' or 'M' to go in the main menu... ");
                char d = char.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                if (d == 'd' || d == 'D')
                {
                    matrixoperation displayobj = new matrixoperation();
                    char m = 'C';
                    displayobj.display(c, ra, ca, m);
                    mainclass ob2 = new mainclass();
                    ob2.goback();
                }
                else if (d == 'm' || d == 'M')
                {
                    mainclass ob2 = new mainclass();
                    ob2.goback();
                }
                else
                {
                    mainclass ob2 = new mainclass();
                    ob2.invalidinput();
                    goto L1;
                }

         
         
            
            
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Matrices cannot be Subtracted....");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }




        public bool cmpforadd(int ra,int ca,int rb,int cb)
        {
            bool x = false;
            if (ra==rb && ca==cb)
            {
                x = true;
            }
            return x;

        }
        public bool cmpformul(int ra,int ca,int rb,int cb)
        {
            bool x = false;
            if (ca == rb )
            {
                x = true;
            }
            return x;

        }

        public void multiplymat(float[,] a, float[,] b, float[,] c, int ra, int ca, int rb, int cb)
        {
            class2 v2 = new class2();
         bool x=   v2.cmpformul(ra, ca, rb, cb);
         if (x == false)
         {
             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.WriteLine("Matrices cannot be Multpilied....");
             Console.ForegroundColor = ConsoleColor.White;
         }
         else
         {
             for (int i = 1; i <= ra; i++)
             {
                 for (int j = 1; j <= ca; j++)
                 {
                     for (int k = 1; k <= ca; k++)
                     {
                         c[i, j] += a[i, k] * b[k, j];
                     }
                 }
             }
         }
        } //end of method....




        public void displayrowslice(float[,]a,int r,int c)
        {
            Console.Write("Enter the row # that you want to see: ");
            int ri = int.Parse(Console.ReadLine());
            if (ri > r)
            {
                Console.WriteLine("The row {0} doesnot exist....", ri);
            }
            else
            {

                for (int j = 1; j <= c; j++)
                {
                    Console.Write(a[ri, j] + "\t");
                }
                Console.WriteLine();


            }


        } //end of method.....
        public void diplaycolumnslice(float[,] a, int r, int c)
        {
            Console.Write("Enter the column # that you want to see: ");
            int ri = int.Parse(Console.ReadLine());
            if (ri > c)
            {
                Console.WriteLine("The row {0} doesnot exist....", ri);
            }
            else
            {

                for (int j = 1; j <= r; j++)
                {
                    Console.WriteLine(a[j, ri]);
                }



            }

        } //end of method.....


        public float determinant(float[,] a, int rowa, int colmuna)
        {
            int counter = 0;
            int n = rowa;
            float temp = 0;
            float det = 0;
            int p = 2, q = 1, r = 1, x = 1;
        l1:
            for (int k = r; k <= rowa; k++)
            {
                a[x, k] = a[x, k] / a[x, x];

            }
            for (int i = p; i <= rowa; i++)
            {
                counter++;
                temp = a[x, p];
                if (temp < 0)
                {
                    temp = temp * (-1);
                }

                for (int j = q; j <= colmuna; j++)
                {
                    a[j, i] = a[j, i] - (a[j, x] * temp);
                }
                p++;
            }
            for (int i = 1; i < counter; i++)
            {
                p--;
            }
            if (n > 3)
            {
                p++; q++; r++; x++;
                n--;
                goto l1;
            }
            //    Program.display(a, rowa, colmuna);

            det = (a[rowa - 1, colmuna - 1] * a[rowa, colmuna]) - (a[rowa - 1, colmuna] * a[rowa, colmuna - 1]);

            return det;

        } //end of method.....

        public int determinantoption()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================DETERMINANT OF A MATRIX============================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Determinant of MATRIX A:");
            Console.WriteLine("\n2-Determinant of MATRIX B:");
            Console.Write("\nSelect a Number to Create the respective MATRIX: ");
            int arrayselection = int.Parse(Console.ReadLine());


            return arrayselection;

        }


        public int transposedisplay()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================TRANSPOSE OF A MATRIX============================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1-Transpose of MATRIX A:");
            Console.WriteLine("\n2-Transpose of MATRIX B:");
            Console.Write("\nSelect a Number to Create the respective MATRIX: ");
            int arrayselection = int.Parse(Console.ReadLine());


            return arrayselection;

        }
        public static void transpose(float[,] a, int r, int c)
        {
            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    Console.Write(a[j, i] + "\t");
                }
                Console.WriteLine();
            }


        }

    }
}
